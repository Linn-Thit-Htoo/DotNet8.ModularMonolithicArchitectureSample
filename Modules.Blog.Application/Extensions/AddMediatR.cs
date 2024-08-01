namespace Modules.Blog.Application.Extensions;

public static class AddMediatR
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddMediatR(cf => cf.RegisterServicesFromAssembly(typeof(AddMediatR).Assembly));
        return services;
    }
}
