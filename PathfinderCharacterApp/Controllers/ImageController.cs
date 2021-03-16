using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PathfinderCharacterApp.Common;

namespace PathfinderCharacterApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImageController : ControllerBase
    {
        private readonly PathfinderCharacterContext _context;

        public ImageController(PathfinderCharacterContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Get(Guid characterId)
        {
            var character = await _context.Characters.FindAsync(characterId);
            var path = $"{Environment.CurrentDirectory}\\Images\\{character.Avatar}";
            var image = await System.IO.File.ReadAllBytesAsync(path);
            return File(image, "image/jpeg");
        }
    }
}