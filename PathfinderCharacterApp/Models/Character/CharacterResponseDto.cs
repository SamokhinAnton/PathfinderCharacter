using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PathfinderCharacterApp.Models.Character
{
    public class CharacterResponseDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string PlayerName { get; set; }
        public string Avatar { get; set; }
        public string Homeland { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }

        public RaceResponseDto Race { get; set; }
        public int RaceId { get; set; }
    }
}
