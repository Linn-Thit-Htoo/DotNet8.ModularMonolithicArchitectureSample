using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modules.Blog.Application.Extensions
{
    public static class AddMediatR
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddMediatR(cf =>
                cf.RegisterServicesFromAssembly(typeof(AddMediatR).Assembly)
            );
            return services;
        }
    }
}
