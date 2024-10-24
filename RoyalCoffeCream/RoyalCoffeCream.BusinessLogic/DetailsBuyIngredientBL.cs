using RoyalCoffeCream.DataAccess;
using RoyalCoffeCream.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoyalCoffeCream.BusinessLogic
{
    public class DetailsBuyIngredientBL
    {
        private static DetailsBuyIngredientBL _instance;
        public static DetailsBuyIngredientBL Instance
        {
            get
            {
                return _instance ?? (_instance = new DetailsBuyIngredientBL());
            }
        }
        public List<DetailsBuyIngredient> SelectAll()
        {
            List<DetailsBuyIngredient> result = null;
            try
            {
                result = DetailsBuyIngredientDAL.Instance.SelectAll();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }
    }
}
