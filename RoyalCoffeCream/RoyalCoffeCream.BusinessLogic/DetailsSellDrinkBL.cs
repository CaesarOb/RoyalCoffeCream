using RoyalCoffeCream.DataAccess;
using RoyalCoffeCream.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoyalCoffeCream.BusinessLogic
{
    public class DetailsSellDrinkBL
    {
        private static DetailsSellDrinkBL _instance;
        public static DetailsSellDrinkBL Instance
        {
            get
            {
                return _instance ?? (_instance = new DetailsSellDrinkBL());
            }
        }
        public List<DetailsSellDrink> SelectAll()
        {
            List<DetailsSellDrink> result = null;
            try
            {
                result = DetailsSellDrinkDAL.Instance.SelectAll();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }
        public bool Insert(DetailsSellDrink entity)
        {
            bool result = false;
            try
            {
                result = DetailsSellDrinkDAL.Instance.Insert(entity);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }
    }
}
