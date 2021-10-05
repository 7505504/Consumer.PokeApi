using Consumer.Application.PokeApp.Interfaces;
using Consumer.Application.Shared;
using Consumer.Domain.Entities;
using System;
using System.Threading.Tasks;

namespace Consumer.Application.PokeApp.Integrations
{
    public class PokeApiService : IPokeApiService
    {
        private readonly IPokeApiFactory _pokeApiFactory;

        public PokeApiService(IPokeApiFactory pokeApiFactory)
        {
            _pokeApiFactory = pokeApiFactory;
        }

        public Task<PokeApiResponse> GetPokemonByNameTest(string pokemonName)
        {
            if (pokemonName is null) throw new NullReferenceException("O Nome do pokemon não pode ser nulo");

            var response = AsyncUtil.RunSync(() => CreateApi().GetPokemonByName(pokemonName));

            return Task.FromResult(new PokeApiResponse
            {
                Id = response.Id,
                Name = response.Name,
                Types = response.Types
            });
        }

        private IPokeApi CreateApi() => _pokeApiFactory.CreateApi();

    }
}
