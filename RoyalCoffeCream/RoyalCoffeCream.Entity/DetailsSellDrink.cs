using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoyalCoffeCream.Entity
{
    public class DetailsSellDrink
    {
        public int DetailsSellDrinkId { get; set; }
        public int SellDrinkId { get; set; }
        public int DrinkId { get; set; }
        public int Quantity { get; set; }
        public Decimal Total { get; set; }
        public int StatusFactureId { get; set; }
    }
}
