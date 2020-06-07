using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ShoppingListAssistant.Application.IoC.ServiceCollectionExtensions
{
    public static class Configuration
    {
        public static IServiceCollection AddConfiguration(this IServiceCollection services, IConfigurationRoot configurationRoot)
        {
            services
                .AddSingleton(configurationRoot);

            return services;
        }
    }
}