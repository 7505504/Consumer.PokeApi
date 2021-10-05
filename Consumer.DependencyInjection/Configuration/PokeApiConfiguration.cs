using Consumer.Application.PokeApp.Integrations;
using Consumer.Application.PokeApp.Interfaces;
using Consumer.Domain.Constants;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Consumer.DependencyInjection.Configuration
{
    public static class PokeApiConfiguration
    {

        public static IServiceCollection AddPokeApiConfiguration(this IServiceCollection services)
        {

            services
                .AddScoped<IPokeApiFactory, PokeApiFactory>()
                .AddScoped<IPokeApi, PokeApiService>();

            var pokeApiUrl = "https://pokeapi.co/api/"; 

            services.AddHttpClient(PokeApiConstants.ApiClientName, c => c.BaseAddress = new Uri(pokeApiUrl));

            return services;
        }
    }
}
