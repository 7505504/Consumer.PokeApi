using Consumer.Domain.Entities;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consumer.Application.PokeApp.Interfaces
{
    public interface IPokeApi
    {
        [Get("v2/pokemon/")]
        Task<PokeApiResponse> GetPokemonByName(string pokemonName);
    }
}
