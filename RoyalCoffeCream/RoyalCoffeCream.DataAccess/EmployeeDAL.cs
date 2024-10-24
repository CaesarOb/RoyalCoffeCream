using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using RoyalCoffeCream.Entity;

namespace RoyalCoffeCream.DataAccess
{
    public class EmployeeDAL : Connection
    {
        private static EmployeeDAL _instance;
        public static EmployeeDAL Instance
        {
            get
            {
                return _instance ?? (_instance = new EmployeeDAL());
            }
        }
        public List<Employee> SelectAll()
        {
            List<Employee> result = null;
            using (SqlConnection conn = new SqlConnection(_cadena))
            {
                using (SqlCommand cmd = new SqlCommand("spEmployeeSelectAll", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
                    {
                        if (dr != null)
                        {
                            result = new List<Employee>();

                            while (dr.Read())
                            {
                                Employee entity = new Employee();
                                entity.EmployeeId = dr.GetInt32(0);
                                entity.FullName = dr.GetString(1);
                                entity.Phone = dr.GetString(2);
                                entity.DUI = dr.GetString(3);
                                entity.StatusId = dr.GetInt32(4);


                                result.Add(entity);
                            }
                        }
                    }
                }
            }
            return result;
        }
        public bool Insert(Employee entity)
        {
            bool result = false;
            using (SqlConnection conn = new SqlConnection(_cadena))
            {
                using (SqlCommand cmd = new SqlCommand("spEmployeeInsert", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@FullName", entity.FullName);
                    cmd.Parameters.AddWithValue("@Phone", entity.Phone);
                    cmd.Parameters.AddWithValue("@DUI", entity.DUI);
                    cmd.Parameters.AddWithValue("@StatusId", entity.StatusId);
                    conn.Open();
                    result = cmd.ExecuteNonQuery() > 0;
                }
            }
            return result;
        }
        public bool Update(Employee entity)
        {
            bool result = false;

            using (SqlConnection conn = new SqlConnection(_cadena))
            {
                using (SqlCommand cmd = new SqlCommand("spEmployeeUpdate", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@EmployeeId", entity.EmployeeId);
                    cmd.Parameters.AddWithValue("@FullName", entity.FullName);
                    cmd.Parameters.AddWithValue("@Phone", entity.Phone);
                    cmd.Parameters.AddWithValue("@DUI", entity.DUI);
                    cmd.Parameters.AddWithValue("@StatusId", entity.StatusId);
                    conn.Open();
                    result = cmd.ExecuteNonQuery() > 0;
                }
            }
            return result;
        }
        public bool Delete(int id)
        {
            bool result = false;

            using (SqlConnection conn = new SqlConnection(_cadena))
            {
                using (SqlCommand cmd = new SqlCommand("spEmployeeDelete", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@EmployeeId", id);

                    conn.Open();
                    result = cmd.ExecuteNonQuery() > 0;
                }
            }
            return result;
        }
    }
}
