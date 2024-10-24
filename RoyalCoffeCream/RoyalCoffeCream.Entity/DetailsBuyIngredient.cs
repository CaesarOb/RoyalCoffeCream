using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoyalCoffeCream.Entity
{
    public class DetailsBuyIngredient
    {
        public int DetailsBuyIngredientId { get; set; }
        public int BuyIngredientId { get; set; }
        public int IngredientId { get; set; }
        public int Quantity { get; set; }
        public Decimal Total {  get; set; }
        public int StatusFactureId { get; set; }
        public Decimal Discount { get; set; }
    }
}
