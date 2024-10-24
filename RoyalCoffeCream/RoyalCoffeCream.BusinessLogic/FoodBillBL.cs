using RoyalCoffeCream.DataAccess;
using RoyalCoffeCream.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoyalCoffeCream.BusinessLogic
{
    public class FoodBillBL
    {
        private static FoodBillBL _instance;
        public static FoodBillBL Instance
        {
            get
            {
                return _instance ?? (_instance = new FoodBillBL());
            }
        }
        public List<FoodBill> SelectAll()
        {
            List<FoodBill> result = null;
            try
            {
                result = FoodBillDAL.Instance.SelectAll();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }
    }
}
