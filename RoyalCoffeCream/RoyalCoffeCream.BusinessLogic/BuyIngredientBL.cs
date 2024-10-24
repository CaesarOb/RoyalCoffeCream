using RoyalCoffeCream.DataAccess;
using RoyalCoffeCream.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoyalCoffeCream.BusinessLogic
{
    public class BuyIngredientBL
    {
        private static BuyIngredientBL _instance;
        public static BuyIngredientBL Instance
        {
            get
            {
                return _instance ?? (_instance = new BuyIngredientBL());
            }
        }
        public List<BuyIngredient> SelectAll()
        {
            List<BuyIngredient> result = null;
            try
            {
                result = BuyIngredientDAL.Instance.SelectAll();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }
    }
}
