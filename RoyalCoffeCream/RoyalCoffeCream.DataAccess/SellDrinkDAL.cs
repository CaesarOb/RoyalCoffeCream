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
    public class SellDrinkDAL : Connection
    {
        private static SellDrinkDAL _instance;
        public static SellDrinkDAL Instance
        {
            get
            {
                return _instance ?? (_instance = new SellDrinkDAL());
            }
        }
        public List<SellDrink> SelectAll()
        {
            List<SellDrink> result = null;
            using (SqlConnection conn = new SqlConnection(_cadena))
            {
                using (SqlCommand cmd = new SqlCommand("spSellDrinkSelectAll", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
                    {
                        if (dr != null)
                        {
                            result = new List<SellDrink>();

                            while (dr.Read())
                            {
                                SellDrink entity = new SellDrink();
                                entity.SellDrinkId = dr.GetInt32(0);
                                entity.SellDate = dr.GetDateTime(1);
                                entity.Price = dr.GetDecimal(2);

                                result.Add(entity);
                            }
                        }
                    }
                }
            }
            return result;
        }
        public bool Insert(SellDrink entity)
        {
            bool result = false;
            using (SqlConnection conn = new SqlConnection(_cadena))
            {
                using (SqlCommand cmd = new SqlCommand("spSellDrinkInsert", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@SellDate", entity.SellDate);
                    cmd.Parameters.AddWithValue("@Price", entity.Price);
                    conn.Open();
                    result = cmd.ExecuteNonQuery() > 0;
                }
            }
            return result;
        }
        public bool Update(SellDrink entity)
        {
            bool result = false;

            using (SqlConnection conn = new SqlConnection(_cadena))
            {
                using (SqlCommand cmd = new SqlCommand("spSellDrinkUpdate", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@SellDrinkId", entity.SellDrinkId);
                    cmd.Parameters.AddWithValue("@SellDate", entity.SellDate);
                    cmd.Parameters.AddWithValue("@Price", entity.Price);
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
                using (SqlCommand cmd = new SqlCommand("spSellDrinkDelete", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@SellDrinkId", id);

                    conn.Open();
                    result = cmd.ExecuteNonQuery() > 0;
                }
            }
            return result;
        }
    }
}
