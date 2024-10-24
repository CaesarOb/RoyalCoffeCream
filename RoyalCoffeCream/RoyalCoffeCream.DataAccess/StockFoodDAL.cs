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
    public class StockFoodDAL : Connection 
    {
        private static StockFoodDAL _instance;
        public static StockFoodDAL Instance
        {
            get
            {
                return _instance ?? (_instance = new StockFoodDAL());
            }
        }
        public List<StockFood> SelectAll()
        {
            List<StockFood> result = null;
            using (SqlConnection conn = new SqlConnection(_cadena))
            {
                using (SqlCommand cmd = new SqlCommand("spStockFoodSelectAll", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
                    {
                        if (dr != null)
                        {
                            result = new List<StockFood>();

                            while (dr.Read())
                            {
                                StockFood entity = new StockFood();
                                entity.StockFoodId = dr.GetInt32(0);
                                entity.FoodId = dr.GetInt32(1);
                                entity.Quantity = dr.GetInt32(2);

                                result.Add(entity);
                            }
                        }
                    }
                }
            }
            return result;
        }
        public bool Insert(StockFood entity)
        {
            bool result = false;
            using (SqlConnection conn = new SqlConnection(_cadena))
            {
                using (SqlCommand cmd = new SqlCommand("spStockFoodInsert", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@FoodId", entity.FoodId);
                    cmd.Parameters.AddWithValue("@Quantity", entity.Quantity);
                    conn.Open();
                    result = cmd.ExecuteNonQuery() > 0;
                }
            }
            return result;
        }
        public bool Update(StockFood entity)
        {
            bool result = false;

            using (SqlConnection conn = new SqlConnection(_cadena))
            {
                using (SqlCommand cmd = new SqlCommand("spStockFoodUpdate", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@StockFoodId", entity.StockFoodId);
                    cmd.Parameters.AddWithValue("@FoodId", entity.FoodId);
                    cmd.Parameters.AddWithValue("@Quantity", entity.Quantity);
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
                using (SqlCommand cmd = new SqlCommand("spStockFoodDelete", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@StockFoodId", id);

                    conn.Open();
                    result = cmd.ExecuteNonQuery() > 0;
                }
            }
            return result;
        }
    }
}
