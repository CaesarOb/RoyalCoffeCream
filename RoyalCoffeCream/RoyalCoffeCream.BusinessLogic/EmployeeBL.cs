using RoyalCoffeCream.DataAccess;
using RoyalCoffeCream.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoyalCoffeCream.BusinessLogic
{
    public class EmployeeBL
    {
        private static EmployeeBL _instance;
        public static EmployeeBL Instance
        {
            get
            {
                return _instance ?? (_instance = new EmployeeBL());
            }
        }
        public List<Employee> SelectAll()
        {
            List<Employee> result = null;
            try
            {
                result = EmployeeDAL.Instance.SelectAll();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }
        public bool Insert(Employee entity)
        {
            bool result = false;
            try
            {
                result = EmployeeDAL.Instance.Insert(entity);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }
    }
}
