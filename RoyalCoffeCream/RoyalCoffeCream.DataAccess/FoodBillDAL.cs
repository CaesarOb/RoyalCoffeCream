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
    public class FoodBillDAL : Connection
    {
        private static FoodBillDAL _instance;
        public static FoodBillDAL Instance
        {
            get
            {
                return _instance ?? (_instance = new FoodBillDAL());
            }
        }
        public List<FoodBill> SelectAll()
        {
            List<FoodBill> result = null;
            using (SqlConnection conn = new SqlConnection(_cadena))
            {
                using (SqlCommand cmd = new SqlCommand("spFoodBillSelectAll", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
                    {
                        if (dr != null)
                        {
                            result = new List<FoodBill>();

                            while (dr.Read())
                            {
                                FoodBill entity = new FoodBill();
                                entity.FoodBillId = dr.GetInt32(0);
                                entity.Name = dr.GetString(1);
                                entity.Address = dr.GetString(2);
                                entity.Phone = dr.GetString(3);
                                entity.Email = dr.GetString(4);
                                entity.BillDate = dr.GetDateTime(5);
                                entity.ClientName = dr.GetString(6);
                                entity.DetailsSellFoodId = dr.GetInt32(7);
                                entity.EmployeeId = dr.GetInt32(8);

                                result.Add(entity);
                            }
                        }
                    }
                }
            }
            return result;
        }
        public bool Insert(FoodBill entity)
        {
            bool result = false;
            using (SqlConnection conn = new SqlConnection(_cadena))
            {
                using (SqlCommand cmd = new SqlCommand("spFoodBillDALInsert", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Name", entity.Name);
                    cmd.Parameters.AddWithValue("@Address", entity.Address);
                    cmd.Parameters.AddWithValue("@Phone", entity.Phone);
                    cmd.Parameters.AddWithValue("@Email", entity.Email);
                    cmd.Parameters.AddWithValue("@BillDate", entity.BillDate);
                    cmd.Parameters.AddWithValue("@ClientName", entity.ClientName);
                    cmd.Parameters.AddWithValue("@DetailsSellFoodId", entity.DetailsSellFoodId);
                    cmd.Parameters.AddWithValue("@EmployeeId", entity.EmployeeId);
                    conn.Open();
                    result = cmd.ExecuteNonQuery() > 0;
                }
            }
            return result;
        }
        public bool Update(FoodBill entity)
        {
            bool result = false;

            using (SqlConnection conn = new SqlConnection(_cadena))
            {
                using (SqlCommand cmd = new SqlCommand("spFoodBillUpdate", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@FoodBillId", entity.FoodBillId);
                    cmd.Parameters.AddWithValue("@Name", entity.Name);
                    cmd.Parameters.AddWithValue("@Address", entity.Address);
                    cmd.Parameters.AddWithValue("@Phone", entity.Phone);
                    cmd.Parameters.AddWithValue("@Email", entity.Email);
                    cmd.Parameters.AddWithValue("@BillDate", entity.BillDate);
                    cmd.Parameters.AddWithValue("@ClientName", entity.ClientName);
                    cmd.Parameters.AddWithValue("@DetailsSellFoodId", entity.DetailsSellFoodId);
                    cmd.Parameters.AddWithValue("@EmployeeId", entity.EmployeeId);
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
                using (SqlCommand cmd = new SqlCommand("spFoodBillDelete", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@FoodBillId", id);

                    conn.Open();
                    result = cmd.ExecuteNonQuery() > 0;
                }
            }
            return result;
        }
    }
}
