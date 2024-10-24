using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoyalCoffeCream.Entity
{
    public class Ingredient
    {
        public int IngredientId { get; set; }
        public string Name { get; set; }
        public int SizeId { get; set; }
        public int StatusId { get; set; }
        public DateTime? ExpirationDate { get; set; }
    }
}
