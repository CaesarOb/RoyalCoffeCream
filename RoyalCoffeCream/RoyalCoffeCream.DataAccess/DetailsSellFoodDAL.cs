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
    public class DetailsSellFoodDAL : Connection
    {
        private static DetailsSellFoodDAL _instance;
        public static DetailsSellFoodDAL Instance
        {
            get
            {
                return _instance ?? (_instance = new DetailsSellFoodDAL());
            }
        }
        public List<DetailsSellFood> SelectAll()
        {
            List<DetailsSellFood> result = null;
            using (SqlConnection conn = new SqlConnection(_cadena))
            {
                using (SqlCommand cmd = new SqlCommand("spDetailsSellFoodSelectAll", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
                    {
                        if (dr != null)
                        {
                            result = new List<DetailsSellFood>();

                            while (dr.Read())
                            {
                                DetailsSellFood entity = new DetailsSellFood();
                                entity.DetailsSellFoodId = dr.GetInt32(0);
                                entity.SellFoodId = dr.GetInt32(1);
                                entity.FoodId = dr.GetInt32(2);
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
        public bool Insert(DetailsSellFood entity)
        {
            bool result = false;
            using (SqlConnection conn = new SqlConnection(_cadena))
            {
                using (SqlCommand cmd = new SqlCommand("spDetailsSellFoodInsert", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@SellFoodId", entity.SellFoodId);
                    cmd.Parameters.AddWithValue("@FoodId", entity.FoodId);
                    cmd.Parameters.AddWithValue("@Quantity", entity.Quantity);
                    cmd.Parameters.AddWithValue("@Total", entity.Total);
                    cmd.Parameters.AddWithValue("@StatusFactureId", entity.StatusFactureId);
                    conn.Open();
                    result = cmd.ExecuteNonQuery() > 0;
                }
            }
            return result;
        }
        public bool Update(DetailsSellFood entity)
        {
            bool result = false;

            using (SqlConnection conn = new SqlConnection(_cadena))
            {
                using (SqlCommand cmd = new SqlCommand("spDetailsSellFoodUpdate", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@DetailsSellFoodId", entity.DetailsSellFoodId);
                    cmd.Parameters.AddWithValue("@SellFoodId", entity.SellFoodId);
                    cmd.Parameters.AddWithValue("@FoodId", entity.FoodId);
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
                using (SqlCommand cmd = new SqlCommand("spDetailsSellFoodDelete", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@DetailsSellFoodId", id);

                    conn.Open();
                    result = cmd.ExecuteNonQuery() > 0;
                }
            }
            return result;
        }
    }
}
