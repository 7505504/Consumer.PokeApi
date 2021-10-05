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

        [JsonProperty("base_experience")]
        public int BaseExperience { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("is_default")]
        public bool IsDefault { get; set; }

        [JsonProperty("order")]
        public int Order { get; set; }

        [JsonProperty("weight")]
        public int Weight { get; set; }

        [JsonProperty("location_area_encounters")]
        public string LocationAreaEncounters { get; set; }

        [JsonProperty("species")]
        public Species Species { get; set; }

        [JsonProperty("types")]
        public List<Type> Types { get; set; }
    }


    public class Species
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class Icons
    {
    }

    public class Type2
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class Type
    {
        [JsonProperty("slot")]
        public int Slot { get; set; }

        [JsonProperty("type")]
        public Type Type1 { get; set; }
    }



}

