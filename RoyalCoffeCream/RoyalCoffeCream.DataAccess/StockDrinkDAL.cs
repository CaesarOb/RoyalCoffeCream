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
    public class StockDrinkDAL : Connection
    {
        private static StockDrinkDAL _instance;
        public static StockDrinkDAL Instance
        {
            get
            {
                return _instance ?? (_instance = new StockDrinkDAL());
            }
        }
        public List<StockDrink> SelectAll()
        {
            List<StockDrink> result = null;
            using (SqlConnection conn = new SqlConnection(_cadena))
            {
                using (SqlCommand cmd = new SqlCommand("spStockDrinkSelectAll", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
                    {
                        if (dr != null)
                        {
                            result = new List<StockDrink>();

                            while (dr.Read())
                            {
                                StockDrink entity = new StockDrink();
                                entity.StockDrinkId = dr.GetInt32(0);
                                entity.DrinkId = dr.GetInt32(1);
                                entity.Quantity = dr.GetInt32(2);

                                result.Add(entity);
                            }
                        }
                    }
                }
            }
            return result;
        }
        public bool Insert(StockDrink entity)
        {
            bool result = false;
            using (SqlConnection conn = new SqlConnection(_cadena))
            {
                using (SqlCommand cmd = new SqlCommand("spStockKDrinkInsert", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@DrinkId", entity.DrinkId);
                    cmd.Parameters.AddWithValue("@Quantity", entity.Quantity);
                    conn.Open();
                    result = cmd.ExecuteNonQuery() > 0;
                }
            }
            return result;
        }
        public bool Update(StockDrink entity)
        {
            bool result = false;

            using (SqlConnection conn = new SqlConnection(_cadena))
            {
                using (SqlCommand cmd = new SqlCommand("spStockDrinkUpdate", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@StockDrinkId", entity.StockDrinkId);
                    cmd.Parameters.AddWithValue("@DrinkId", entity.DrinkId);
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
                using (SqlCommand cmd = new SqlCommand("spStockDrinkDelete", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@StockDrinkId", id);

                    conn.Open();
                    result = cmd.ExecuteNonQuery() > 0;
                }
            }
            return result;
        }
    }
}
