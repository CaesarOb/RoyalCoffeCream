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

    public class VentaViewModel
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public decimal Subtotal { get; set; }
    }
}
