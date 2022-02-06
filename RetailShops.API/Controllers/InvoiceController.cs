using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RetailShops.Domain.Entities;
using RetailShops.Domain.Enums;
using RetailShops.Domain.Shared;
using RetailShops.Infrastructure.Utility;
using RetailShops.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RetailShops.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class InvoiceController : ControllerBase
    {

        private readonly IInvoiceRepository _invoiceRepository;
        private readonly IUserRepository _userRepository;
        private readonly IDiscountCountRepository _discountCountRepository;
        private readonly IMapper _mapper;

        public InvoiceController(IUserRepository userRepository, IInvoiceRepository invoiceRepository, IMapper mapper, IDiscountCountRepository discountRepository)
        {
            _invoiceRepository = invoiceRepository;
            _discountCountRepository = discountRepository;
            _userRepository = userRepository;
            _mapper = mapper;
        }


        [HttpGet("{serialNumber}")]
        public async Task<IActionResult> GetInvoiceTotal(string serialNumber)
        {
            var invoice = await _invoiceRepository.GetInvoiceTotal(serialNumber);
            if (invoice == null) return NotFound();
            var invoiceDto = _mapper.Map<InvoiceResponse>(invoice);
            return Ok(invoiceDto.Total);
        }

        [HttpPost]
        public async Task<IActionResult> CalculateInvoiceDiscountByUserId([FromBody] CreateInvoiceRequest invoiceRequest)
        {
            decimal subTotal = 0;
            var user = await _userRepository.GetById(invoiceRequest.UserId);
            if (user == null) return NotFound();
            var userResponse = _mapper.Map<UserResponse>(user);

            subTotal = CalculateDiscount(invoiceRequest, subTotal, userResponse);
            var invoiceEntity = _mapper.Map<InvoicesEntity>(invoiceRequest);
            invoiceEntity.Total = subTotal;
            invoiceEntity.UserId = user.Id;
            await _invoiceRepository.Create(invoiceEntity);
            return Ok(invoiceEntity);
        }

        public decimal CalculateDiscount(CreateInvoiceRequest invoiceRequest, decimal invoiceSubtotal, UserResponse user)
        {
            var discountsType = _discountCountRepository.GetAll();
            foreach (var discount in discountsType)
            {

                var userTypeEnumDesc = ((UserTypeEnum)user.UserType).GetDescription();
                if (discount.DiscountTypeName.Equals(userTypeEnumDesc) && discount.IsPercentage)
                {
                    var calculatedDiscountValue = (UserTypeEnum)user.UserType != UserTypeEnum.Customer || user.CreatedDate > DateTime.Now.AddYears(2);

                    if (calculatedDiscountValue)
                    {
                        var discountValue = invoiceRequest.OrderTotal * (discount.Rate / 100);
                        invoiceSubtotal = invoiceRequest.OrderTotal - discountValue;
                    }

                }

                if (discount.DiscountTypeName.Equals(DiscountTypeEnum.Price.GetDescription()))
                {
                    int dividedOneHundred = Convert.ToInt32(invoiceRequest.OrderTotal / 100);
                    if (dividedOneHundred > 0)
                        invoiceSubtotal -= (discount.Rate * dividedOneHundred);

                }
            }

            return invoiceSubtotal;
        }



    }
}
