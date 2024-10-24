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
    public class DrinkBillDAL : Connection
    {
        private static DrinkBillDAL _instance;
        public static DrinkBillDAL Instance
        {
            get
            {
                return _instance ?? (_instance = new DrinkBillDAL());
            }
        }
        public List<DrinkBill> SelectAll()
        {
            List<DrinkBill> result = null;
            using (SqlConnection conn = new SqlConnection(_cadena))
            {
                using (SqlCommand cmd = new SqlCommand("spDrinkBillSelectAll", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
                    {
                        if (dr != null)
                        {
                            result = new List<DrinkBill>();

                            while (dr.Read())
                            {
                                DrinkBill entity = new DrinkBill();
                                entity.DrinkBillId = dr.GetInt32(0);
                                entity.Name = dr.GetString(1);
                                entity.Address = dr.GetString(2);
                                entity.Phone = dr.GetString(3);
                                entity.Email = dr.GetString(4);
                                entity.BillDate = dr.GetDateTime(5);
                                entity.ClientName = dr.GetString(6);
                                entity.DetailsSellDrinkId = dr.GetInt32(7);
                                entity.EmployeeId = dr.GetInt32(8);

                                result.Add(entity);
                            }
                        }
                    }
                }
            }
            return result;
        }
        public bool Insert(DrinkBill entity)
        {
            bool result = false;
            using (SqlConnection conn = new SqlConnection(_cadena))
            {
                using (SqlCommand cmd = new SqlCommand("spDrinkBillInsert", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Name", entity.Name);
                    cmd.Parameters.AddWithValue("@Address", entity.Address);
                    cmd.Parameters.AddWithValue("@Phone", entity.Phone);
                    cmd.Parameters.AddWithValue("@Email", entity.Email);
                    cmd.Parameters.AddWithValue("@BillDate", entity.BillDate);
                    cmd.Parameters.AddWithValue("@ClientName", entity.ClientName);
                    cmd.Parameters.AddWithValue("@DetailsSellDrinkId", entity.DetailsSellDrinkId);
                    cmd.Parameters.AddWithValue("@EmployeeId", entity.EmployeeId);
                    conn.Open();
                    result = cmd.ExecuteNonQuery() > 0;
                }
            }
            return result;
        }
        public bool Update(DrinkBill entity)
        {
            bool result = false;

            using (SqlConnection conn = new SqlConnection(_cadena))
            {
                using (SqlCommand cmd = new SqlCommand("spDrinkBillUpdate", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@DrinkBillId", entity.DrinkBillId);
                    cmd.Parameters.AddWithValue("@Name", entity.Name);
                    cmd.Parameters.AddWithValue("@Address", entity.Address);
                    cmd.Parameters.AddWithValue("@Phone", entity.Phone);
                    cmd.Parameters.AddWithValue("@Email", entity.Email);
                    cmd.Parameters.AddWithValue("@BillDate", entity.BillDate);
                    cmd.Parameters.AddWithValue("@ClientName", entity.ClientName);
                    cmd.Parameters.AddWithValue("@DetailsSellDrinkId", entity.DetailsSellDrinkId);
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
                using (SqlCommand cmd = new SqlCommand("spDrinkBillDelete", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@DrinkBillId", id);

                    conn.Open();
                    result = cmd.ExecuteNonQuery() > 0;
                }
            }
            return result;
        }
    }
}
