using Consumer.Application.PokeApp.Interfaces;
using Consumer.Domain.Entities;
using Refit;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Consumer.Application.PokeApp.Integrations
{
    public class PokeApiService : IPokeApi
    {
        private readonly IPokeApiFactory _pokeApiFactory;

        public PokeApiService(IPokeApiFactory pokeApiFactory)
        {
            _pokeApiFactory = pokeApiFactory;
        }

        public async Task<PokeApiResponse> GetPokemonByName(string pokemonName)
        {
            if (pokemonName is null) throw new NullReferenceException("O Nome do pokemon não pode ser nulo");

            var response = await CreateApi().GetPokemonByName(pokemonName);

            return response;
        }

        private IPokeApi CreateApi() => _pokeApiFactory.CreateApi();
    }
}
