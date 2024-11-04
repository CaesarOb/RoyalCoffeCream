using RoyalCoffeCream.DataAccess;
using RoyalCoffeCream.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoyalCoffeCream.BusinessLogic
{
    public class RecordBL
    {
        private static RecordBL _instance;
        public static RecordBL Instance
        {
            get
            {
                return _instance ?? (_instance = new RecordBL());
            }
        }
        public List<Record> SelectAll()
        {
            List<Record> result = null;
            try
            {
                result = RecordDAL.Instance.SelectAll();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }
    }
}
