using RoyalCoffeCream.DataAccess;
using RoyalCoffeCream.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoyalCoffeCream.BusinessLogic
{
    public class IngredientBL
    {
        private static IngredientBL _instance;
        public static IngredientBL Instance
        {
            get
            {
                return _instance ?? (_instance = new IngredientBL());
            }
        }
        public List<Ingredient> SelectAll()
        {
            List<Ingredient> result = null;
            try
            {
                result = IngredientDAL.Instance.SelectAll();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }
        public bool Insert(Ingredient entity)
        {
            bool result = false;
            try
            {
                result = IngredientDAL.Instance.Insert(entity);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }
    }
}
