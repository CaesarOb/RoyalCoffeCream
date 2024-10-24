using RoyalCoffeCream.DataAccess;
using RoyalCoffeCream.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoyalCoffeCream.BusinessLogic
{
    public class CategoryBL
    {
        private static CategoryBL _instance;
        public static CategoryBL Instance
        {
            get
            {
                return _instance ?? (_instance = new CategoryBL());
            }
        }
        public List<Category> SelectAll()
        {
            List<Category> result = null;
            try
            {
                result = CategoryDAL.Instance.SelectAll();
            }
            catch (Exception ex) 
            {
                throw new Exception(ex.Message);
            }
            return result;
        }
        public bool Insert(Category entity)
        {
            bool result = false;
            try
            {
                result = CategoryDAL.Instance.Insert(entity);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }
    }
}
