using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using RetailShops.Domain.Entities;
using RetailShops.Domain.Shared;
using RetailShops.Repositories.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RetailShops.API.Controllers
{


    [ApiController]
    [Route("api/[controller]/[action]")]
    public class UserController : ControllerBase
    {

        private readonly IUserRepository _userRepository;

        private readonly IMapper _mapper;
        public UserController(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetUsers()
        {
            var customers = _userRepository.GetAll();
            var customerDto = _mapper.Map<IEnumerable<UserResponse>>(customers);
            return Ok(customerDto);
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser([FromBody] CreateUserRequest userRequest)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var userEntity = _mapper.Map<UserEntity>(userRequest);
            await _userRepository.Create(userEntity);

            var customerToReturn = _mapper.Map<UserResponse>(userEntity);
            return CreatedAtRoute("CustomerId", new {   customerToReturn.Id }, customerToReturn);
        }

    }
}
