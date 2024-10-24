using RoyalCoffeCream.DataAccess;
using RoyalCoffeCream.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoyalCoffeCream.BusinessLogic
{
    public class StockFoodBL
    {
        private static StockFoodBL _instance;
        public static StockFoodBL Instance
        {
            get
            {
                return _instance ?? (_instance = new StockFoodBL());
            }
        }
        public List<StockFood> SelectAll()
        {
            List<StockFood> result = null;
            try
            {
                result = StockFoodDAL.Instance.SelectAll();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }
    }
}
