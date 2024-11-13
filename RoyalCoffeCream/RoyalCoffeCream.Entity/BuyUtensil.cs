using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoyalCoffeCream.Entity
{
    public class BuyUtensil
    {
        public int BuyUtensilId { get; set; }
        public DateTime SupplyDate { get; set; }
        public Decimal Price { get; set; }
        public int SupplierId { get; set; }
        public int UserId { get; set; }
    }
}
