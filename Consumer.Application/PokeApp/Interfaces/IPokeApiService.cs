using Consumer.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consumer.Application.PokeApp.Interfaces
{
    public interface IPokeApiService
    {
        Task<PokeApiResponse> GetPokemonByNameTest(string pokemonName);
    }
}
