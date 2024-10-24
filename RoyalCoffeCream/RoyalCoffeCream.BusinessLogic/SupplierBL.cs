using RoyalCoffeCream.DataAccess;
using RoyalCoffeCream.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoyalCoffeCream.BusinessLogic
{
    public class SupplierBL
    {
        private static SupplierBL _instance;
        public static SupplierBL Instance
        {
            get
            {
                return _instance ?? (_instance = new SupplierBL());
            }
        }
        public List<Supplier> SelectAll()
        {
            List<Supplier> result = null;
            try
            {
                result = SupplierDAL.Instance.SelectAll();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }
    }
}
