using Microsoft.Extensions.DependencyInjection;
using AltaApi.Services;


namespace AltaApi.IoC
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddAltaApiDependencies(this IServiceCollection services)
        {
            services.AddServices()
                    .AddInfraestructure("Server = LAPTOP-TEH8DOAU; database = ALTA_APIDB; Integrated Security = True")
                    .AddMapper();

            return services;
        }
    }
}
