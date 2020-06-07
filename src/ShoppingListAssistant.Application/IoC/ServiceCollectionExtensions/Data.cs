using Microsoft.Extensions.DependencyInjection;
using ShoppingListAssistant.Core.Interfaces;
using ShoppingListAssistant.Infrastructure.Repositories;

namespace ShoppingListAssistant.Application.IoC.ServiceCollectionExtensions
{
    public static class Data
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services
                .AddSingleton<IIngredientsRepository, IngredientsRepository>();

            return services;
        }
    }
}