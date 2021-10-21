using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PracticeProject.Api.Resources;
using PracticeProject.Api.Validations;
using PracticeProject.Core.Models;
using PracticeProject.Core.Services;

namespace PracticeProject.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IMapper _mapper;
        
        public UsersController(IUserService userService, IMapper mapper)
        {
            this._mapper = mapper;
            this._userService = userService;
        }

        [HttpGet("")]
        public async Task<ActionResult<IEnumerable<UserResource>>> GetAllUsers()
        {
            var users = await _userService.GetAllUsers();
            var userResources = _mapper.Map<IEnumerable<User>, IEnumerable<UserResource>>(users);

            return Ok(userResources);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<UserResource>> GetUserById(int id)
        {
            var user = await _userService.GetUserById(id);
            var userResource = _mapper.Map<User, UserResource>(user);

            return Ok(userResource);
        }
    }
}