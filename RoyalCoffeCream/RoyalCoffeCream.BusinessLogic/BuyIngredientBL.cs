using RoyalCoffeCream.DataAccess;
using RoyalCoffeCream.Entity;
using System;
using System.Collections.Generic;

namespace RoyalCoffeCream.BusinessLogic
{
    public class BuyIngredientBL
    {
        private static BuyIngredientBL _instance;
        public static BuyIngredientBL Instance
        {
            get
            {
                return _instance ?? (_instance = new BuyIngredientBL());
            }
        }
        public List<BuyIngredient> SelectAll()
        {
            List<BuyIngredient> result = null;
            try
            {
                result = BuyIngredientDAL.Instance.SelectAll();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }
        public int Insert(BuyIngredient entity)
        {
            int result = 0;
            try
            {
                result = BuyIngredientDAL.Instance.Insert(entity);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }
    }
}
