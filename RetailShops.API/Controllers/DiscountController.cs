using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RetailShops.Domain.Entities;
using RetailShops.Domain.Shared;
using RetailShops.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RetailShops.API.Controllers
{


    [ApiController]
    [Route("api/[controller]/[action]")]
    public class DiscountController : ControllerBase
    {

        private readonly IDiscountCountRepository _discountCountRepository;

        private readonly IMapper _mapper;
        public DiscountController(IDiscountCountRepository discountCountRepository, IMapper mapper)
        {
            _discountCountRepository = discountCountRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public Task<IActionResult> GetAllDiscountTypes()
        {
            var discountsTypeList = _discountCountRepository.GetAll();
            var discountsDto = _mapper.Map<IEnumerable<DiscountTypesResponse>>(discountsTypeList);
            return Task.FromResult<IActionResult>(Ok(discountsDto));
        }

        [HttpGet("{type}")]
        public async Task<IActionResult> GetDiscount(int discountTypeId)
        {
            var discount = await _discountCountRepository.GetDiscountTypeByTypeId(discountTypeId);
            if (discount == null) return NotFound();
            var discountPercentage = _discountCountRepository.GetDiscountPercentage(discount);
            if (discountPercentage != null) return Ok(discountPercentage);
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> CreateDiscount([FromBody] CreateDiscountTypeRequest discountDto)
        {
            var discountEntity = _mapper.Map<DiscountTypeEntity>(discountDto);
            await _discountCountRepository.Create(discountEntity);
            return Ok();
        }

    }
}
