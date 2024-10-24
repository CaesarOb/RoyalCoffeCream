using RoyalCoffeCream.DataAccess;
using RoyalCoffeCream.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoyalCoffeCream.BusinessLogic
{
    public class SellDrinkBL
    {
        private static SellDrinkBL _instance;
        public static SellDrinkBL Instance
        {
            get
            {
                return _instance ?? (_instance = new SellDrinkBL());
            }
        }
        public List<SellDrink> SelectAll()
        {
            List<SellDrink> result = null;
            try
            {
                result = SellDrinkDAL.Instance.SelectAll();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }
    }
}
