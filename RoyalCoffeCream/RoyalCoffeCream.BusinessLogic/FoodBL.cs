using RoyalCoffeCream.DataAccess;
using RoyalCoffeCream.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoyalCoffeCream.BusinessLogic
{
    public class FoodBL
    {
        private static FoodBL _instance;
        public static FoodBL Instance
        {
            get
            {
                return _instance ?? (_instance = new FoodBL());
            }
        }
        public List<Food> SelectAll()
        {
            List<Food> result = null;
            try
            {
                result = FoodDAL.Instance.SelectAll();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }
    }
}
