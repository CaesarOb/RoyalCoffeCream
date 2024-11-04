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
    public class IngredientDAL : Connection
    {
        private static IngredientDAL _instance;
        public static IngredientDAL Instance
        {
            get
            {
                return _instance ?? (_instance = new IngredientDAL());
            }
        }
        public List<Ingredient> SelectAll()
        {
            List<Ingredient> result = null;
            using (SqlConnection conn = new SqlConnection(_cadena))
            {
                using (SqlCommand cmd = new SqlCommand("spIngredientSelectAll", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
                    {
                        if (dr != null)
                        {
                            result = new List<Ingredient>();

                            while (dr.Read())
                            {
                                Ingredient entity = new Ingredient();
                                entity.IngredientId = dr.GetInt32(0);
                                entity.Name = dr.GetString(1);
                                entity.SizeId = dr.GetInt32(2);
                                entity.StatusId = dr.GetInt32(3);
                                entity.ExpirationDate = dr.GetString(4);

                                result.Add(entity);
                            }
                        }
                    }
                }
            }
            return result;
        }
        public bool Insert(Ingredient entity)
        {
            bool result = false;
            using (SqlConnection conn = new SqlConnection(_cadena))
            {
                using (SqlCommand cmd = new SqlCommand("spIngredientInsert", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Name", entity.Name);
                    cmd.Parameters.AddWithValue("@SizeId", entity.SizeId);
                    cmd.Parameters.AddWithValue("@StatusId", entity.StatusId);
                    cmd.Parameters.AddWithValue("@ExpirationDate", entity.ExpirationDate);
                    conn.Open();
                    result = cmd.ExecuteNonQuery() > 0;
                }
            }
            return result;
        }
        public bool Update(Ingredient entity)
        {
            bool result = false;

            using (SqlConnection conn = new SqlConnection(_cadena))
            {
                using (SqlCommand cmd = new SqlCommand("spIngredientUpdate", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IngredientId", entity.IngredientId);
                    cmd.Parameters.AddWithValue("@Name", entity.Name);
                    cmd.Parameters.AddWithValue("@SizeId", entity.SizeId);
                    cmd.Parameters.AddWithValue("@StatusId", entity.StatusId);
                    cmd.Parameters.AddWithValue("@ExpirationDate", entity.ExpirationDate);
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
                using (SqlCommand cmd = new SqlCommand("spIngredientDelete", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IngredientId", id);

                    conn.Open();
                    result = cmd.ExecuteNonQuery() > 0;
                }
            }
            return result;
        }
    }
}
