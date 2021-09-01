using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BartenderApp.Models
{
    public class Drink
    {
        public int Id { get; set; }
        public string DrinkName { get; set; }

        public string PatronName { get; set; }

        public float Price { get; set; }

        public Drink()
        {

        }
    }
}
