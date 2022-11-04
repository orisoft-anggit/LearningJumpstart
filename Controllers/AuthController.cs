using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LearningJumpstart.Data;
using LearningJumpstart.Dtos.Character;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LearningJumpstart.Controllers
{
    public class AuthController : ControllerBase
    {
        private readonly IAuthRepository _authRepo;

        public AuthController (IAuthRepository authRepo)
        {
            _authRepo = authRepo;
        }

        [HttpPost("auth/register")]
        public async Task<ActionResult<ServiceResponse<int>>> Register(UserRegisterDto request)
        {
            var response = await _authRepo.Register(
                new User{Username = request.Username}, request.Password
                );
            if(!response.Success)
            {
                return BadRequest(response);  
            }
            return Ok(response);
        }

        [HttpPost("auth/login")]
        public async Task<ActionResult<ServiceResponse<string>>> Login(UserLoginDto request)
        {
            var response = await _authRepo.Login(request.Username , request.Password);
            if (!response.Success)
            {
                return BadRequest(response);
            }
            return Ok(response);
        }
    }
}

