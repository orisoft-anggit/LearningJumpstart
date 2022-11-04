using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LearningJumpstart.Dtos.Character;

namespace LearningJumpstart.Service.CharacterService
{
    public interface ICharacterService
    {
        Task<ServiceResponse<List<GetCharacterDto>>>GetAllCharacters();
        Task<ServiceResponse<GetCharacterDto>> GetCharacterById(int id);
        Task<ServiceResponse<List<GetCharacterDto>>> AddCharacter(AddCharacterDto newCharacter);
        Task<ServiceResponse<GetCharacterDto>> UpdateCharacter(UpdateCharacterDto updateCharacter);
        Task<ServiceResponse<List<GetCharacterDto>>> DeleteCharacter(int id);
    }
}

