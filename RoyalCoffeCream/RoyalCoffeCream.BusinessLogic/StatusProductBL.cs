using RoyalCoffeCream.DataAccess;
using RoyalCoffeCream.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoyalCoffeCream.BusinessLogic
{
    public class StatusProductBL
    {
        private static StatusProductBL _instance;
        public static StatusProductBL Instance
        {
            get
            {
                return _instance ?? (_instance = new StatusProductBL());
            }
        }
        public List<StatusProduct> SelectAll()
        {
            List<StatusProduct> result = null;
            try
            {
                result = StatusProductDAL.Instance.SelectAll();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }
    }
}
