using RoyalCoffeCream.DataAccess;
using RoyalCoffeCream.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoyalCoffeCream.BusinessLogic
{
    public class UserTypeBL
    {
        private static UserTypeBL _instance;
        public static UserTypeBL Instance
        {
            get
            {
                return _instance ?? (_instance = new UserTypeBL());
            }
        }
        public List<UserType> SelectAll()
        {
            List<UserType> result = null;
            try
            {
                result = UserTypeDAL.Instance.SelectAll();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }
    }
}
