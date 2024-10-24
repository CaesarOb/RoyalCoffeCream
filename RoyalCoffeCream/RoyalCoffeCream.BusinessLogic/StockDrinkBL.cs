using RoyalCoffeCream.DataAccess;
using RoyalCoffeCream.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoyalCoffeCream.BusinessLogic
{
    public class StockDrinkBL
    {
        private static StockDrinkBL _instance;
        public static StockDrinkBL Instance
        {
            get
            {
                return _instance ?? (_instance = new StockDrinkBL());
            }
        }
        public List<StockDrink> SelectAll()
        {
            List<StockDrink> result = null;
            try
            {
                result = StockDrinkDAL.Instance.SelectAll();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }
    }
}
