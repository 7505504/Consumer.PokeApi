using Consumer.Application.PokeApp.Integrations;
using Consumer.Application.PokeApp.Interfaces;
using Consumer.Application.Shared;
using Consumer.Domain.Entities;
using Consumer.PokeApi.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Consumer.PokeApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ConsumerController : ControllerBase
    {
        private readonly IPokeApiService _pokeApiService;
        private List<TypeSlot> typesResults;

        public ConsumerController(IPokeApiService pokeApiService)
        {
            _pokeApiService = pokeApiService;
        }

        [HttpGet]
        [Route("pokemon/{name}")]
        public ConsumerResponse GetPokemonByName(string name)
        {

            var response = _pokeApiService.GetPokemonByNameTest(name);
            var result = response.Result.Types;

            ConsumerResponse consumerResponse = new ConsumerResponse()
            {
                Id = response.Result.Id,
                Name = response.Result.Name,
                Types = new List<TypesResult>()
            };

            foreach(var type in result)
            {
                consumerResponse.Types.Add(
                    new TypesResult(
                        type.Slot, 
                        new TypeResult(
                            type.Type.Name)
                        )
                    );

            }

            return consumerResponse;

        }
    }

}



