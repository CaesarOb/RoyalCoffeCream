using RoyalCoffeCream.DataAccess;
using RoyalCoffeCream.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoyalCoffeCream.BusinessLogic
{
    public class SizeBL
    {
        private static SizeBL _instance;
        public static SizeBL Instance
        {
            get
            {
                return _instance ?? (_instance = new SizeBL());
            }
        }
        public List<Size> SelectAll()
        {
            List<Size> result = null;
            try
            {
                result = SizeDAL.Instance.SelectAll();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }
        public bool Insert(Size entity)
        {
            bool result = false;
            try
            {
                result = SizeDAL.Instance.Insert(entity);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }
    }
}
