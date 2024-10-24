using RoyalCoffeCream.DataAccess;
using RoyalCoffeCream.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoyalCoffeCream.BusinessLogic
{
    public class DrinkBillBL
    {
        private static DrinkBillBL _instance;
        public static DrinkBillBL Instance
        {
            get
            {
                return _instance ?? (_instance = new DrinkBillBL());
            }
        }
        public List<DrinkBill> SelectAll()
        {
            List<DrinkBill> result = null;
            try
            {
                result = DrinkBillDAL.Instance.SelectAll();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }
    }
}
