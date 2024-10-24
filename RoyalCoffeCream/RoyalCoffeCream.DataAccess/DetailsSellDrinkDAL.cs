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
    public class DetailsSellDrinkDAL : Connection
    {
        private static DetailsSellDrinkDAL _instance;
        public static DetailsSellDrinkDAL Instance
        {
            get
            {
                return _instance ?? (_instance = new DetailsSellDrinkDAL());
            }
        }
        public List<DetailsSellDrink> SelectAll()
        {
            List<DetailsSellDrink> result = null;
            using (SqlConnection conn = new SqlConnection(_cadena))
            {
                using (SqlCommand cmd = new SqlCommand("spDetailsSellDrinkSelectAll", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
                    {
                        if (dr != null)
                        {
                            result = new List<DetailsSellDrink>();

                            while (dr.Read())
                            {
                                DetailsSellDrink entity = new DetailsSellDrink();
                                entity.DetailsSellDrinkId = dr.GetInt32(0);
                                entity.SellDrinkId = dr.GetInt32(1);
                                entity.DrinkId = dr.GetInt32(2);
                                entity.Quantity = dr.GetInt32(3);
                                entity.Total = dr.GetDecimal(4);
                                entity.StatusFactureId = dr.GetInt32(5);

                                result.Add(entity);
                            }
                        }
                    }
                }
            }
            return result;
        }
        public bool Insert(DetailsSellDrink entity)
        {
            bool result = false;
            using (SqlConnection conn = new SqlConnection(_cadena))
            {
                using (SqlCommand cmd = new SqlCommand("spDetailsSellDrinkInsert", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@SellDrinkId", entity.SellDrinkId);
                    cmd.Parameters.AddWithValue("@DrinkId", entity.DrinkId);
                    cmd.Parameters.AddWithValue("@Quantity", entity.Quantity);
                    cmd.Parameters.AddWithValue("@Total", entity.Total);
                    cmd.Parameters.AddWithValue("@StatusFactureId", entity.StatusFactureId);
                    conn.Open();
                    result = cmd.ExecuteNonQuery() > 0;
                }
            }
            return result;
        }
        public bool Update(DetailsSellDrink entity)
        {
            bool result = false;

            using (SqlConnection conn = new SqlConnection(_cadena))
            {
                using (SqlCommand cmd = new SqlCommand("spDetailsSellDrinkUpdate", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@DetailsSellDrinkId", entity.DetailsSellDrinkId);
                    cmd.Parameters.AddWithValue("@SellDrinkId", entity.SellDrinkId);
                    cmd.Parameters.AddWithValue("@DrinkId", entity.DrinkId);
                    cmd.Parameters.AddWithValue("@Quantity", entity.Quantity);
                    cmd.Parameters.AddWithValue("@Total", entity.Total);
                    cmd.Parameters.AddWithValue("@StatusFactureId", entity.StatusFactureId);
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
                using (SqlCommand cmd = new SqlCommand("spDetailsSellDrinkDelete", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@DetailsSellDrinkId", id);

                    conn.Open();
                    result = cmd.ExecuteNonQuery() > 0;
                }
            }
            return result;
        }
    }
}
