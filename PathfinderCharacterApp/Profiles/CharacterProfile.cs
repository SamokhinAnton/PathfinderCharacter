using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using PathfinderCharacterApp.Models.Character;
using PathfinderCharacterApp.Models.Entities;

namespace PathfinderCharacterApp.Profiles
{
    public class CharacterProfile : Profile
    {
        public CharacterProfile()
        {
            CreateMap<CharacterEntity, CharactersResponseDto>();
            CreateMap<CharacterEntity, CharacterResponseDto>();
            CreateMap<RaceEntity, RaceResponseDto>();
        }
    }
}
