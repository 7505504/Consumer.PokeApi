using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Consumer.PokeApi.Models
{
    public class ConsumerResponse
    {
        public ConsumerResponse()
        {
        }

        public ConsumerResponse(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public List<TypesResult> Types { get; set; }
    }
    public class TypesResult
    {

        public TypesResult(int slot, TypeResult type)
        {
            Slot = slot;
            Type = type;
        }

        public int Slot { get; set; }

        public TypeResult Type { get; set; }
    }

    public class TypeResult
    {
        public TypeResult(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

    }
}
