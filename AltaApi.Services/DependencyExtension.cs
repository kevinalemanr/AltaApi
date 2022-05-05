using AltaApi.EFCore.DataContext;
using AltaApi.EFCore.Repositories;
using AltaApi.Entities.Interfaces;
using AltaApi.UseCases;
using AltaApi.UseCasesPorts;
using AltaApi.WebClients;
using AltaApi.WebClients.Helpers;
using AltaApi.WebClients.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;


namespace AltaApi.Services
{
    public static class DependencyExtension
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<ICreateLineInventoryInputPort, CreateLineInventory>();
            services.AddScoped<IInventoryRepository, InventoryRespository>();
            services.AddScoped<ICreateHeartBeatInitiateInputPort, CreateHeartBeatInitiate>();
            services.AddScoped<IHeartBeatRepository, HeartBeatInitiateRespository>();
            services.AddScoped<ICreateRequestInitiateInputPort, CreateRequestInitiate>();
            services.AddScoped<IRequestInitiateRepository, RequestInitiateRepository>();
            services.AddScoped<ICreateMessageInputPort, CreateMessage>();
            services.AddScoped<IRequestInboxRepository, RequestInboxRepository>();
            services.AddScoped<ISendToPrime, SendToPrime>();
            services.AddScoped<IWebHelpers, WebHelpers>();

            return services;
        }


        public static IServiceCollection AddInfraestructure(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<ApplicationDataContext>(options => options.UseSqlServer(connectionString));

            return services;
        }

        public static IServiceCollection AddMapper(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.Load("AltaApi.EFCore"));
            return services;    
        }
    }
}
