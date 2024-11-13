using RoyalCoffeCream.DataAccess;
using RoyalCoffeCream.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoyalCoffeCream.BusinessLogic
{
    public class SellFoodBL
    {
        private static SellFoodBL _instance;
        public static SellFoodBL Instance
        {
            get
            {
                return _instance ?? (_instance = new SellFoodBL());
            }
        }
        public List<SellFood> SelectAll()
        {
            List<SellFood> result = null;
            try
            {
                result = SellFoodDAL.Instance.SelectAll();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }
        public int Insert(SellFood entity)
        {
            int result = 0;
            try
            {
                result = SellFoodDAL.Instance.Insert(entity);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }
    }
}
