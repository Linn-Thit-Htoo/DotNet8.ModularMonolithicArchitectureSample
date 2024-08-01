using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Modules.Blog.Application.Services;
using Modules.Blog.Infrastructure.Db;

namespace Modules.Blog.API.Extensions
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddDependencyInjection(this IServiceCollection services, WebApplicationBuilder builder)
        {
            return services.AddDbContextService(builder)
                .AddBlogService();
        }

        private static IServiceCollection AddDbContextService(this  IServiceCollection services, WebApplicationBuilder builder)
        {
            builder.Services.AddDbContext<BlogDbContext>(opt =>
            {
                opt.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
                opt.UseSqlServer(builder.Configuration.GetConnectionString("DbConnection"));
            }, ServiceLifetime.Transient);

            return services;
        }

        private static IServiceCollection AddBlogService(this IServiceCollection services)
        {
            return services.AddScoped<IBlogService, BlogService>();
        }
    }
}
