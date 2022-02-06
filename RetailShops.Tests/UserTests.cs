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
    public class UserTests
    {
        private readonly Mock<IUserRepository> _mockUserRepository;
        private readonly UserController _userController;

        public UserTests()
        {
            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MappingProfile());
            });
            var mapper = mappingConfig.CreateMapper();
            var mapper1 = mapper;
            _mockUserRepository = new Mock<IUserRepository>();
            _userController = new UserController(_mockUserRepository.Object, mapper1);
            
        }


        [Fact]
        public void GetUsers_ActionExucutes_ReturnTaskActionResult()
        {
            var actionResult = _userController.GetUsers();

             Assert.IsNotType<Task<IActionResult>>(actionResult);
        }

        /// <summary>
        /// User controller in GetUsers action called with Mock service
        /// </summary>
        [Fact]
        public  void User_ActionExecutesWithMock_ReturnsExactNumberOfUsers()
        {
            _mockUserRepository.Setup(repo => repo.GetAll())
                .Returns(new List<UserEntity>() { new UserEntity(), new UserEntity() });

            var actionResult = _userController.GetUsers();

            var viewResult  =Assert.IsType<OkObjectResult>(actionResult);

            var employees = Assert.IsType<List<UserResponse>>(viewResult.Value);
            Assert.Equal(2, employees.Count);
        }



        [Theory]
        [MemberData(nameof(TestDataGenerator.GetUserFromDataGenerator), MemberType = typeof(TestDataGenerator))]
        public void CreateUser_ActionExecutes_ReturnsActionResultForCreate(CreateUserRequest request)
        {
            var result = _userController.CreateUser(request);

            Assert.IsType<Task<IActionResult>>(result);
        }

        [Fact]
        
        public void CreateUser_InvalidModelState_ReturnsView()
        {
            _userController.ModelState.AddModelError("Name", "Name is required");

            var userRequest = new CreateUserRequest { Name ="Sezer",LastName="Test LasName" , Email="aa" };
            var result = _userController.CreateUser(userRequest);
            var viewResult = Assert.IsType<Task<IActionResult>>(result);


             Assert.IsType<BadRequestObjectResult> (viewResult.Result);
        }

    }

}
