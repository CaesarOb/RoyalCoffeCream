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
    public class FoodDAL : Connection
    {
        private static FoodDAL _instance;
        public static FoodDAL Instance
        {
            get
            {
                return _instance ?? (_instance = new FoodDAL());
            }
        }
        public List<Food> SelectAll()
        {
            List<Food> result = null;
            using (SqlConnection conn = new SqlConnection(_cadena))
            {
                using (SqlCommand cmd = new SqlCommand("spFoodSelectAll", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
                    {
                        if (dr != null)
                        {
                            result = new List<Food>();

                            while (dr.Read())
                            {
                                Food entity = new Food();
                                entity.FoodId = dr.GetInt32(0);
                                entity.Name = dr.GetString(1);
                                entity.Description = dr.GetString(2);
                                entity.Price = dr.GetDecimal(3);
                                entity.CategoryId = dr.GetInt32(4);
                                entity.StatusProductId = dr.GetInt32(5);

                                result.Add(entity);
                            }
                        }
                    }
                }
            }
            return result;
        }
        public bool Insert(Food entity)
        {
            bool result = false;
            using (SqlConnection conn = new SqlConnection(_cadena))
            {
                using (SqlCommand cmd = new SqlCommand("spFoodInsert", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Name", entity.Name);
                    cmd.Parameters.AddWithValue("@Description", entity.Description);
                    cmd.Parameters.AddWithValue("@Price", entity.Price);
                    cmd.Parameters.AddWithValue("@CategoryId", entity.CategoryId);
                    cmd.Parameters.AddWithValue("@StatusProductId", entity.StatusProductId);
                    conn.Open();
                    result = cmd.ExecuteNonQuery() > 0;
                }
            }
            return result;
        }
        public bool Update(Food entity)
        {
            bool result = false;

            using (SqlConnection conn = new SqlConnection(_cadena))
            {
                using (SqlCommand cmd = new SqlCommand("spFoodUpdate", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@FoodId", entity.FoodId);
                    cmd.Parameters.AddWithValue("@Name", entity.Name);
                    cmd.Parameters.AddWithValue("@Description", entity.Description);
                    cmd.Parameters.AddWithValue("@Price", entity.Price);
                    cmd.Parameters.AddWithValue("@CategoryId", entity.CategoryId);
                    cmd.Parameters.AddWithValue("@StatusProductId", entity.StatusProductId);
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
                using (SqlCommand cmd = new SqlCommand("spFoodDelete", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@FoodId", id);

                    conn.Open();
                    result = cmd.ExecuteNonQuery() > 0;
                }
            }
            return result;
        }
    }
}
