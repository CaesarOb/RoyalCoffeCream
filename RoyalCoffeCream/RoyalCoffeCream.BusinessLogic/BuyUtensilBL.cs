using RoyalCoffeCream.DataAccess;
using RoyalCoffeCream.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoyalCoffeCream.BusinessLogic
{
    public class BuyUtensilBL
    {
        private static BuyUtensilBL _instance;
        public static BuyUtensilBL Instance
        {
            get
            {
                return _instance ?? (_instance = new BuyUtensilBL());
            }
        }
        public List<BuyUtensil> SelectAll()
        {
            List<BuyUtensil> result = null;
            try
            {
                result = BuyUtensilDAL.Instance.SelectAll();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }
    }
}
