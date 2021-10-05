using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consumer.Domain.Entities
{
    public class PokeApiResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("types")]
        public List<TypeSlot> Types { get; set; }
    }
    public class TypeSlot
    {
        [JsonProperty("slot")]
        public int Slot { get; set; }

        [JsonProperty("type")]
        public Type Type { get; set; }
    }

    public class Type
    {
        [JsonProperty("name")]
        public string Name { get; set; }

    }

}

