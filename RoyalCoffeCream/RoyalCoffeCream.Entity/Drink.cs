using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoyalCoffeCream.Entity
{
    public class Drink
    {
        public int DrinkId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Decimal Price { get; set; }
        public int SizeId { get; set; }
        public int CategoryId { get; set; }
        public int StatusProductId { get; set; }
    }
}
