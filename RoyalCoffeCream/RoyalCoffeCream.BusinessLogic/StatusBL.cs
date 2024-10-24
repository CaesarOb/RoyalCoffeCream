using RoyalCoffeCream.DataAccess;
using RoyalCoffeCream.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoyalCoffeCream.BusinessLogic
{
    public class StatusBL
    {
        private static StatusBL _instance;
        public static StatusBL Instance
        {
            get
            {
                return _instance ?? (_instance = new StatusBL());
            }
        }
        public List<Status> SelectAll()
        {
            List<Status> result = null;
            try
            {
                result = StatusDAL.Instance.SelectAll();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }
    }
}
