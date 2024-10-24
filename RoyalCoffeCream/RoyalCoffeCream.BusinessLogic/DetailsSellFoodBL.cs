using RoyalCoffeCream.DataAccess;
using RoyalCoffeCream.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoyalCoffeCream.BusinessLogic
{
    public class DetailsSellFoodBL
    {
        private static DetailsSellFoodBL _instance;
        public static DetailsSellFoodBL Instance
        {
            get
            {
                return _instance ?? (_instance = new DetailsSellFoodBL());
            }
        }
        public List<DetailsSellFood> SelectAll()
        {
            List<DetailsSellFood> result = null;
            try
            {
                result = DetailsSellFoodDAL.Instance.SelectAll();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }
    }
}
