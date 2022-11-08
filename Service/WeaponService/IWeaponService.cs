using System;
using LearningJumpstart.Dtos.Character;

namespace LearningJumpstart.Service.WeaponService
{
    public interface IWeaponService
    {
        Task<ServiceResponse<GetCharacterDto>> AddWeapon(AddWeaponDto newWeapon); 
    }
}

