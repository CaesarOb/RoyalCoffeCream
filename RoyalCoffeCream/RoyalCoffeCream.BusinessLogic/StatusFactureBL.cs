using RoyalCoffeCream.DataAccess;
using RoyalCoffeCream.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoyalCoffeCream.BusinessLogic
{
    public class StatusFactureBL
    {
        private static StatusFactureBL _instance;
        public static StatusFactureBL Instance
        {
            get
            {
                return _instance ?? (_instance = new StatusFactureBL());
            }
        }
        public List<StatusFacture> SelectAll()
        {
            List<StatusFacture> result = null;
            try
            {
                result = StatusFactureDAL.Instance.SelectAll();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }
    }
}
