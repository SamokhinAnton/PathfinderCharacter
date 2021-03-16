using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PathfinderCharacterApp.Models.Entities;

namespace PathfinderCharacterApp.Common
{
    public class PathfinderCharacterContext : DbContext
    {
        public DbSet<CharacterEntity> Characters { get; set; }
        public DbSet<RaceEntity> Races { get; set; }

        public PathfinderCharacterContext(DbContextOptions<PathfinderCharacterContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
