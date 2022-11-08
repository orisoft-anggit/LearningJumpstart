using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LearningJumpstart.Dtos.Character;
using LearningJumpstart.Service.WeaponService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LearningJumpstart.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class WeaponController : ControllerBase
    {
        private readonly IWeaponService _weaponService;

        public WeaponController (IWeaponService weaponService)
        {
            _weaponService = weaponService; 
        }

        [HttpPost]
        public async Task<ActionResult<ServiceResponse<GetCharacterDto>>> AddWeapon (AddWeaponDto newWeapon)
        {
            return Ok(await _weaponService.AddWeapon(newWeapon)); 
        }
    }
}

