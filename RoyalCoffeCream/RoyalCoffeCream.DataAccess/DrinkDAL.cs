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
    public class DrinkDAL : Connection
    {
        private static DrinkDAL _instance;
        public static DrinkDAL Instance
        {
            get
            {
                return _instance ?? (_instance = new DrinkDAL());
            }
        }
        public List<Drink> SelectAll()
        {
            List<Drink> result = null;
            using (SqlConnection conn = new SqlConnection(_cadena))
            {
                using (SqlCommand cmd = new SqlCommand("spDrinkSelectAll", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
                    {
                        if (dr != null)
                        {
                            result = new List<Drink>();

                            while (dr.Read())
                            {
                                Drink entity = new Drink();
                                entity.DrinkId = dr.GetInt32(0);
                                entity.Name = dr.GetString(1);
                                entity.Description = dr.GetString(2);
                                entity.Price = dr.GetDecimal(3);
                                entity.SizeId = dr.GetInt32(4);
                                entity.CategoryId = dr.GetInt32(5);
                                entity.StatusProductId = dr.GetInt32(6);


                                result.Add(entity);
                            }
                        }
                    }
                }
            }
            return result;
        }
        public bool Insert(Drink entity)
        {
            bool result = false;
            using (SqlConnection conn = new SqlConnection(_cadena))
            {
                using (SqlCommand cmd = new SqlCommand("spDrinkInsert", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Name", entity.Name);
                    cmd.Parameters.AddWithValue("@Description", entity.Description);
                    cmd.Parameters.AddWithValue("@Price", entity.Price);
                    cmd.Parameters.AddWithValue("@SizeId", entity.SizeId);
                    cmd.Parameters.AddWithValue("@CategoryId", entity.CategoryId);
                    cmd.Parameters.AddWithValue("@StatusProductId", entity.StatusProductId);
                    conn.Open();
                    result = cmd.ExecuteNonQuery() > 0;
                }
            }
            return result;
        }
        public bool Update(Drink entity)
        {
            bool result = false;

            using (SqlConnection conn = new SqlConnection(_cadena))
            {
                using (SqlCommand cmd = new SqlCommand("spDrinkUpdate", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@DrinkId", entity.DrinkId);
                    cmd.Parameters.AddWithValue("@Name", entity.Name);
                    cmd.Parameters.AddWithValue("@Description", entity.Description);
                    cmd.Parameters.AddWithValue("@Price", entity.Price);
                    cmd.Parameters.AddWithValue("@SizeId", entity.SizeId);
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
                using (SqlCommand cmd = new SqlCommand("spDrinkDelete", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@DrinkId", id);

                    conn.Open();
                    result = cmd.ExecuteNonQuery() > 0;
                }
            }
            return result;
        }
    }
}
