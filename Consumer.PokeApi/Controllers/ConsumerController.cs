using Consumer.Application.PokeApp.Integrations;
using Consumer.Application.PokeApp.Interfaces;
using Consumer.Application.Shared;
using Consumer.PokeApi.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Consumer.PokeApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ConsumerController : ControllerBase
    {
        private readonly IPokeApiService _pokeApiService;

        public ConsumerController(IPokeApiService pokeApiService)
        {
            _pokeApiService = pokeApiService;
        }

        [HttpGet]
        [Route("pokemon/{name}")]
        public ConsumerResponse GetPokemonByName(string name)
        {

            var response = _pokeApiService.GetPokemonByNameTest(name);

            ConsumerResponse consumerResponse = null;

            foreach (var type in response.Result.Types)
            {
                consumerResponse.Types.AddRange((IEnumerable<TypesResult>)response.Result.Types);
            }

            return new ConsumerResponse()
            {
                Id = response.Result.Id,
                Name = response.Result.Name,
                Types = consumerResponse.Types

            };
        }
    }
}
