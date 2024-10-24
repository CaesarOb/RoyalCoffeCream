using RoyalCoffeCream.DataAccess;
using RoyalCoffeCream.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoyalCoffeCream.BusinessLogic
{
    public class DetailsBuyUtensiltBL
    {
        private static DetailsBuyUtensiltBL _instance;
        public static DetailsBuyUtensiltBL Instance
        {
            get
            {
                return _instance ?? (_instance = new DetailsBuyUtensiltBL());
            }
        }
        public List<DetailsBuyUtensilt> SelectAll()
        {
            List<DetailsBuyUtensilt> result = null;
            try
            {
                result = DetailsBuyUtensiltDAL.Instance.SelectAll();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }
    }
}
