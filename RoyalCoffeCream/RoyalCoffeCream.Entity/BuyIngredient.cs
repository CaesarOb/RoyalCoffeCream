using System;

namespace RoyalCoffeCream.Entity
{
    public class BuyIngredient
    {
        public int BuyIngredientId { get; set; }
        public DateTime SupplyDate { get; set; }
        public Decimal Price { get; set; }
        public int SupplierId { get; set; }
        public int UserId { get; set; }
    }
}
