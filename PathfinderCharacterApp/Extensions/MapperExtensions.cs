using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using PathfinderCharacterApp.Profiles;

namespace PathfinderCharacterApp.Extensions
{
    public static class MapperExtensions
    {
        public static IMapper GetMapper()
        {
            var myAssembly = typeof(CharacterProfile).Assembly;
            var config = new MapperConfiguration(cfg => { cfg.AddMaps(myAssembly); });

            return config.CreateMapper();
        }

        public static IServiceCollection AddAutoMapper(this IServiceCollection services)
        {
            return services.AddSingleton(GetMapper());
        }
    }
}
