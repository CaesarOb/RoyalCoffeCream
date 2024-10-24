using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoyalCoffeCream.Entity
{
    public class DetailsBuyUtensilt
    {
        public int DetailsBuyUtensiltId { get; set; }
        public int BuyUtensilId { get; set; }
        public int UtensilId { get; set; }
        public int Quantity { get; set; }
        public Decimal Total { get; set; }
        public int StatusFactureId { get; set; }
        public Decimal Discount { get; set; }
    }
}
