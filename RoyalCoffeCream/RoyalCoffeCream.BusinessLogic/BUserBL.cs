using RoyalCoffeCream.DataAccess;
using RoyalCoffeCream.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoyalCoffeCream.BusinessLogic
{
    public class BUserBL
    {
        private static BUserBL _instance;
        public static BUserBL Instance
        {
            get
            {
                return _instance ?? (_instance = new BUserBL());
            }
        }
        public List<BUser> SelectAll()
        {
            List<BUser> result = null;
            try
            {
                result = BUserDAL.Instance.SelectAll();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }

        public BUser spBUserValidate(string password, string nick)
        {
            BUser result = null;
            try
            {
                result = BUserDAL.Instance.ValidateSession(password, nick);
            }
            catch (Exception ex)
            {
                throw;
            }
            return result;
        }
    }
}
