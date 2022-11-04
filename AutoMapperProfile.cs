using System;
using AutoMapper;
using LearningJumpstart.Dtos.Character;

namespace LearningJumpstart
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Character, GetCharacterDto>();
            CreateMap<AddCharacterDto, Character>();
            CreateMap<UpdateCharacterDto, Character>();
        }
    }
}

