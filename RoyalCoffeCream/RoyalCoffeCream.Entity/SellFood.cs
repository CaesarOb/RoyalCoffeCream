using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoyalCoffeCream.Entity
{
    public class SellFood
    {
        public int SellFoodId { get; set; }
        public DateTime SellDate { get; set; }
        public Decimal Price { get; set; }
        public int UserId { get; set; }
    }
}
