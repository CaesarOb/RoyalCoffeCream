using RoyalCoffeCream.Entity;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace RoyalCoffeCream.DataAccess
{
    public class BuyIngredientDAL : Connection
    {
        private static BuyIngredientDAL _instance;
        public static BuyIngredientDAL Instance
        {
            get
            {
                return _instance ?? (_instance = new BuyIngredientDAL());
            }
        }
        public List<BuyIngredient> SelectAll()
        {
            List<BuyIngredient> result = null;
            using (SqlConnection conn = new SqlConnection(_cadena))
            {
                using (SqlCommand cmd = new SqlCommand("spBuyIngredientSelectAll", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
                    {
                        if (dr != null)
                        {
                            result = new List<BuyIngredient>();

                            while (dr.Read())
                            {
                                BuyIngredient entity = new BuyIngredient();
                                entity.BuyIngredientId = dr.GetInt32(0);
                                entity.SupplyDate = dr.GetDateTime(1);
                                entity.Price = dr.GetDecimal(2);
                                entity.SupplierId = dr.GetInt32(3);
                                entity.UserId = dr.GetInt32(4);

                                result.Add(entity);
                            }
                        }
                    }
                }
            }
            return result;
        }
        public int Insert(BuyIngredient entity)
        {
            int result = 0;
            using (SqlConnection conn = new SqlConnection(_cadena))
            {
                using (SqlCommand cmd = new SqlCommand("spBuyIngredientInsert", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@SupplyDate", entity.SupplyDate);
                    cmd.Parameters.AddWithValue("@Price", entity.Price);
                    cmd.Parameters.AddWithValue("@SupplierId", entity.SupplierId);
                    cmd.Parameters.AddWithValue("@UserId", entity.UserId);
                    conn.Open();
                    result = (int)cmd.ExecuteScalar();
                }
            }
            return result;
        }
        public bool Update(BuyIngredient entity)
        {
            bool result = false;

            using (SqlConnection conn = new SqlConnection(_cadena))
            {
                using (SqlCommand cmd = new SqlCommand("spBuyIngredientUpdate", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@BuyIngredientId", entity.BuyIngredientId);
                    cmd.Parameters.AddWithValue("@SupplyDate", entity.SupplyDate);
                    cmd.Parameters.AddWithValue("@Price", entity.Price);
                    cmd.Parameters.AddWithValue("@SupplierId", entity.SupplierId);
                    cmd.Parameters.AddWithValue("UserId", entity.UserId);
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
                using (SqlCommand cmd = new SqlCommand("spBuyIngredientDelete", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@BuyIngredientId", id);

                    conn.Open();
                    result = cmd.ExecuteNonQuery() > 0;
                }
            }
            return result;
        }
    }
}
