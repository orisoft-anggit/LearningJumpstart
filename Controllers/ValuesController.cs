using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LearningJumpstart.Models;
using LearningJumpstart.Service.CharacterService;
using Microsoft.AspNetCore.Mvc;
using LearningJumpstart.Dtos.Character;
using Microsoft.AspNetCore.Authorization;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LearningJumpstart.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class ValuesController : ControllerBase
    {
        private readonly ICharacterService _characterService;

        public ValuesController (ICharacterService characterService )
        {
            _characterService = characterService;
        }

        [HttpGet("GetAll")]
        public async Task<ActionResult<ServiceResponse<List<GetCharacterDto>>>> Get()
        {
            return Ok(await _characterService.GetAllCharacters());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceResponse<List<GetCharacterDto>>>> GetSingle(int id)
        {
            return Ok(await _characterService.GetCharacterById(id));
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<ServiceResponse<List<GetCharacterDto>>>> Delete(int id)
        {
            var response = await _characterService.DeleteCharacter(id);
            if (response.Data == null)
            {
                return NotFound(response);
            };

            return Ok(response);
        }

        [HttpPost]
        public async Task<ActionResult<ServiceResponse<List<GetCharacterDto>>>> AddCharacter (AddCharacterDto newCharacter)
        {
            return Ok(await _characterService.AddCharacter(newCharacter));
        }

        [HttpPut]
        public async Task<ActionResult<ServiceResponse<GetCharacterDto>>> UpdateCharacter(UpdateCharacterDto updateCharacter)
        {
            var response = await _characterService.UpdateCharacter(updateCharacter);
            if ( response.Data == null )
            {
                return NotFound(response);
            };

            return Ok(response);
        }
    }
}

