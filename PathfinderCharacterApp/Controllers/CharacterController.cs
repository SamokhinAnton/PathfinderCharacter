using System;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PathfinderCharacterApp.Common;
using PathfinderCharacterApp.Models.Character;
using PathfinderCharacterApp.Models.Entities;

namespace PathfinderCharacterApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CharacterController : ControllerBase
    {
        private readonly PathfinderCharacterContext _context;
        private readonly IMapper _mapper;

        public CharacterController(
            PathfinderCharacterContext context,
            IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var characters = _context.Characters.Select(_mapper.Map<CharacterEntity, CharactersResponseDto>).ToList();
            return Ok(characters);
        }

        public async Task<IActionResult> Get(Guid id)
        {
            var character = await _context.Characters.FindAsync(id);
            return Ok(character);
        }
    }
}