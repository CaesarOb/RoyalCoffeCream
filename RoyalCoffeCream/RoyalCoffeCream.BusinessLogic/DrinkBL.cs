using RoyalCoffeCream.DataAccess;
using RoyalCoffeCream.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoyalCoffeCream.BusinessLogic
{
    public class DrinkBL
    {
        private static DrinkBL _instance;
        public static DrinkBL Instance
        {
            get
            {
                return _instance ?? (_instance = new DrinkBL());
            }
        }
        public List<Drink> SelectAll()
        {
            List<Drink> result = null;
            try
            {
                result = DrinkDAL.Instance.SelectAll();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }
    }
}
