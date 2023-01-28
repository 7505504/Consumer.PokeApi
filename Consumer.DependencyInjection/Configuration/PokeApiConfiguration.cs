using Consumer.Application.PokeApp.Integrations;
using Consumer.Application.PokeApp.Interfaces;
using Consumer.Domain.Constants;
using Consumer.Infrastructure.Handlers;
using Consumer.Infrastructure.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Consumer.DependencyInjection.Configuration
{
    public static class PokeApiConfiguration
    {

        public static IServiceCollection AddPokeApiConfiguration(this IServiceCollection services)
        {

            services
                .AddScoped<IPokeApiFactory, PokeApiFactory>()
                .AddScoped<IPokeApiService, PokeApiService>();

            services.AddSingleton<ApiKeyAuthorizationFilter>();
            services.AddSingleton<IApiKeyValidator, ApiKeyValidator>();
            
            var pokeApiUrl = "https://pokeapi.co/api";

            services.AddHttpClient(PokeApiConstants.ApiClientName, c => c.BaseAddress = new Uri(pokeApiUrl));

            return services;
        }
    }
}
