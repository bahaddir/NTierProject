using Microsoft.Extensions.DependencyInjection;
using Project.Validation.MappingProfiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Validation.MapperResolvers
{
    public static class VmMapperResolver
    {
        public static void AddVmMapperService(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(VmMappingProfile));
        }
    }
}
