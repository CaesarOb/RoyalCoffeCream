using RoyalCoffeCream.Entity;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace RoyalCoffeCream.DataAccess
{
    public class CategoryDAL : Connection
    {
        private static CategoryDAL _instance;
        public static CategoryDAL Instance
        {
            get
            {
                return _instance ?? (_instance = new CategoryDAL());
            }
        }

        public List<Category> SelectAll()
        {
            List<Category> result = null;
            using (SqlConnection conn = new SqlConnection(_cadena))
            {
                using (SqlCommand cmd = new SqlCommand("spCategorySelectAll", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
                    {
                        if(dr != null)
                        {
                            result = new List<Category>();

                            while (dr.Read())
                            {
                                Category entity = new Category();
                                entity.CategoryId = dr.GetInt32(0);
                                entity.Name = dr.GetString(1);
                                entity.StatusId = dr.GetInt32(2);

                                result.Add(entity);
                            }
                        }
                    }
                }
            }
            return result;
        }
        public bool Insert(Category entity)
        {
            bool result = false;
            using (SqlConnection conn = new SqlConnection(_cadena))
            {
                using (SqlCommand cmd = new SqlCommand("spCategoryInsert", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Name", entity.Name);
                    cmd.Parameters.AddWithValue("@StatusId", entity.StatusId);
                    conn.Open();
                    result = cmd.ExecuteNonQuery()>0;
                }
            }
            return result;
        }
        public bool Update(Category entity)
        {
            bool result = false;

            using (SqlConnection conn = new SqlConnection(_cadena))
            {
                using (SqlCommand cmd = new SqlCommand("spCategoryUpdate", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@CategoryId", entity.CategoryId);
                    cmd.Parameters.AddWithValue("@Name", entity.Name);
                    cmd.Parameters.AddWithValue("@StatusId", entity.StatusId);
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
                using (SqlCommand cmd = new SqlCommand("spCategoryDelete", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@CategoryId", id);

                    conn.Open();
                    result = cmd.ExecuteNonQuery() > 0;
                }
            }
            return result;
        }
    }
}
