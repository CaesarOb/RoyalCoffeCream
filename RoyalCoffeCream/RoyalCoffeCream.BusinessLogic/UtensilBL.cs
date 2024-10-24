using RoyalCoffeCream.DataAccess;
using RoyalCoffeCream.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoyalCoffeCream.BusinessLogic
{
    public class UtensilBL
    {
        private static UtensilBL _instance;
        public static UtensilBL Instance
        {
            get
            {
                return _instance ?? (_instance = new UtensilBL());
            }
        }
        public List<Utensil> SelectAll()
        {
            List<Utensil> result = null;
            try
            {
                result = UtensilDAL.Instance.SelectAll();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }
    }
}
