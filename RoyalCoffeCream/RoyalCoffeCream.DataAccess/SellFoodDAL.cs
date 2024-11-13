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
    public class SellFoodDAL : Connection
    {
        private static SellFoodDAL _instance;
        public static SellFoodDAL Instance
        {
            get
            {
                return _instance ?? (_instance = new SellFoodDAL());
            }
        }
        public List<SellFood> SelectAll()
        {
            List<SellFood> result = null;
            using (SqlConnection conn = new SqlConnection(_cadena))
            {
                using (SqlCommand cmd = new SqlCommand("spSellFoodSelectAll", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
                    {
                        if (dr != null)
                        {
                            result = new List<SellFood>();

                            while (dr.Read())
                            {
                                SellFood entity = new SellFood();
                                entity.SellFoodId = dr.GetInt32(0);
                                entity.SellDate = dr.GetDateTime(1);
                                entity.Price = dr.GetDecimal(2);
                                entity.UserId = dr.GetInt32(3);

                                result.Add(entity);
                            }
                        }
                    }
                }
            }
            return result;
        }
        public int Insert(SellFood entity)
        {
            int result = 0;
            using (SqlConnection conn = new SqlConnection(_cadena))
            {
                using (SqlCommand cmd = new SqlCommand("spSellFoodInsert", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@SellDate", entity.SellDate);
                    cmd.Parameters.AddWithValue("@Price", entity.Price);
                    cmd.Parameters.AddWithValue("@UserId", entity.UserId);
                    conn.Open();
                    result = (int)cmd.ExecuteScalar();
                }
            }
            return result;
        }
        public bool Update(SellFood entity)
        {
            bool result = false;

            using (SqlConnection conn = new SqlConnection(_cadena))
            {
                using (SqlCommand cmd = new SqlCommand("spSellFoodUpdate", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@SellFoodId", entity.SellFoodId);
                    cmd.Parameters.AddWithValue("@SellDate", entity.SellDate);
                    cmd.Parameters.AddWithValue("@Price", entity.Price);
                    cmd.Parameters.AddWithValue("@UserId", entity.UserId);
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
                using (SqlCommand cmd = new SqlCommand("spSellFoodDelete", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@SellFoodId", id);

                    conn.Open();
                    result = cmd.ExecuteNonQuery() > 0;
                }
            }
            return result;
        }
    }
}
