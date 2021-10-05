using Consumer.Application.PokeApp.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Consumer.PokeApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ConsumerController : ControllerBase
    {
        private readonly IPokeApi _pokeApi;

        public ConsumerController(IPokeApi pokeApi)
        {
            _pokeApi = pokeApi;
        }

        [HttpGet]
        [Route("pokemon/{name}")]
        public Task GetPokemonByName(string name)
        {
            var result =  _pokeApi.GetPokemonByName(name);
            
            return Task.FromResult(JsonConvert.SerializeObject(result));
        }
    }
}
