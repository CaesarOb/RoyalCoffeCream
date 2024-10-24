using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoyalCoffeCream.Entity
{
    public class DetailsSellFood
    {
        public int DetailsSellFoodId { get; set; }
        public int SellFoodId { get; set; }
        public int FoodId { get; set; }
        public int Quantity { get; set; }
        public Decimal Total { get; set; }
        public int StatusFactureId { get; set; }
    }
}
