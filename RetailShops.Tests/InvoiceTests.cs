using AutoMapper;
using Moq;
using RetailShops.API.Controllers;
using RetailShops.Domain.Entities;
using RetailShops.Repositories.Interfaces;
using System.Collections.Generic;
using Xunit;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using RetailShops.Domain.Shared;
using RetailShops.Tests.SampleData;

namespace RetailShops.Tests
{
    public class InvoiceTests
    {
        private readonly Mock<IInvoiceRepository> _mockInvoiceRepository;
        private readonly Mock<IUserRepository> _mockUserRepository;
        private readonly Mock<IDiscountCountRepository> _mockDiscountRepository;
        private readonly InvoiceController _invoiceController;

        private readonly IMapper _mapper;
        public InvoiceTests()
        {
            if (_mapper == null)
            {
                var mappingConfig = new MapperConfiguration(mc =>
                {
                    mc.AddProfile(new MappingProfile());
                });
                IMapper mapper = mappingConfig.CreateMapper();
                _mapper = mapper;
            }
            _mockInvoiceRepository = new Mock<IInvoiceRepository>();
            _mockUserRepository = new Mock<IUserRepository>();
            _mockDiscountRepository = new Mock<IDiscountCountRepository>();
            _invoiceController = new InvoiceController(_mockUserRepository.Object, _mockInvoiceRepository.Object, _mapper, _mockDiscountRepository.Object);

        }


        [Theory]
        [MemberData(nameof(TestDataGenerator.GetInvoiceRequestFromDataGenerator), MemberType = typeof(TestDataGenerator))]
        public void GetInvoiceTotal_ActionExucutes_ReturnSubTotalValueCheck(InvoicesEntity invoicesEntity)
        {

            _mockInvoiceRepository.Setup(repo => repo.GetInvoiceTotal(invoicesEntity.InvoiceSerialNumber))
                .Returns(Task.FromResult(invoicesEntity));

            var actionResult = _invoiceController.GetInvoiceTotal(invoicesEntity.InvoiceSerialNumber);

            var actionResultValue = Assert.IsType<OkObjectResult>(actionResult.Result);
            Assert.IsType<decimal>(actionResultValue.Value);
            Assert.Equal(actionResultValue.Value.ToString(), invoicesEntity.Total.ToString());

        }

        /// <summary>
        ///  for Customer calcute discount
        /// </summary>
        /// <param name="invoiceRequest"></param>
        /// <param name="userEntity"></param>
        /// <param name="listDiscountTypes"></param>
        /// <param name="compareAmout"></param>
        [Theory]
        [MemberData(nameof(TestDataGenerator.GetCreateInvoiceRequestFromDataGeneratorForCustomer), MemberType = typeof(TestDataGenerator))]
        //[InlineData(UserTypeEnum.Customer)]
        public void CalculateInvoiceDiscountByUserIdForCustomer_ActionExucutes_ReturnDiscountCheck(CreateInvoiceRequest invoiceRequest, UserEntity userEntity, List<DiscountTypeEntity> listDiscountTypes, decimal compareAmout)
        {

            _mockUserRepository.Setup(repo => repo.GetById(userEntity.Id)).
                Returns(Task.FromResult(userEntity));

            _mockDiscountRepository.Setup(repo => repo.GetAll()).
              Returns(listDiscountTypes);

            var actionResult = _invoiceController.CalculateInvoiceDiscountByUserId(invoiceRequest);

            var actionResultValue = Assert.IsType<OkObjectResult>(actionResult.Result);
            var invoiceResponse = Assert.IsType<InvoicesEntity>(actionResultValue.Value);

            Assert.Equal(invoiceResponse.Total, compareAmout);

        }

        /// <summary>
        /// For Employe calcute discount
        /// </summary>
        /// <param name="invoiceRequest"></param>
        /// <param name="userEntity"></param>
        /// <param name="listDiscountTypes"></param>
        /// <param name="compareAmout"></param>

        [Theory]
        [MemberData(nameof(TestDataGenerator.GetCreateInvoiceRequestFromDataGeneratorForEmployee), MemberType = typeof(TestDataGenerator))]
        //[InlineData(UserTypeEnum.Customer)]
#pragma warning disable S4144 // Methods should not have identical implementations
        public void CalculateInvoiceDiscountByUserIdForEmployee_ActionExucutes_ReturnDiscount(CreateInvoiceRequest invoiceRequest, UserEntity userEntity, List<DiscountTypeEntity> listDiscountTypes, decimal compareAmout)
#pragma warning restore S4144 // Methods should not have identical implementations
        {

            _mockUserRepository.Setup(repo => repo.GetById(userEntity.Id)).
                Returns(Task.FromResult(userEntity));

            _mockDiscountRepository.Setup(repo => repo.GetAll()).
              Returns(listDiscountTypes);

            var actionResult = _invoiceController.CalculateInvoiceDiscountByUserId(invoiceRequest);

            var actionResultValue = Assert.IsType<OkObjectResult>(actionResult.Result);
            var invoiceResponse = Assert.IsType<InvoicesEntity>(actionResultValue.Value);

            Assert.Equal(invoiceResponse.Total, compareAmout);

        }



        /// <summary>
        /// For AffiliateStore
        /// </summary>
        /// <param name="invoiceRequest"></param>
        /// <param name="userEntity"></param>
        /// <param name="listDiscountTypes"></param>
        /// <param name="compareAmout"></param>

        [Theory]
        [MemberData(nameof(TestDataGenerator.GetCreateInvoiceRequestFromDataGeneratorForAffiliateStore), MemberType = typeof(TestDataGenerator))]
        //[InlineData(UserTypeEnum.Customer)]
#pragma warning disable S4144 // Methods should not have identical implementations
        public void CalculateInvoiceDiscountByUserIdForAffiliateStore_ActionExucutes_ReturnDiscountCheck(CreateInvoiceRequest invoiceRequest, UserEntity userEntity, List<DiscountTypeEntity> listDiscountTypes, decimal compareAmout)
#pragma warning restore S4144 // Methods should not have identical implementations
        {

            _mockUserRepository.Setup(repo => repo.GetById(userEntity.Id)).
                Returns(Task.FromResult(userEntity));

            _mockDiscountRepository.Setup(repo => repo.GetAll()).
              Returns(listDiscountTypes);

            var actionResult = _invoiceController.CalculateInvoiceDiscountByUserId(invoiceRequest);

            var actionResultValue = Assert.IsType<OkObjectResult>(actionResult.Result);
            var invoiceResponse = Assert.IsType<InvoicesEntity>(actionResultValue.Value);

            Assert.Equal(invoiceResponse.Total, compareAmout);

        }


    }

}
