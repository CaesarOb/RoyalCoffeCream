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
    public class UserTypeDAL : Connection
    {
        private static UserTypeDAL _instance;
        public static UserTypeDAL Instance
        {
            get
            {
                return _instance ?? (_instance = new UserTypeDAL());
            }
        }
        public List<UserType> SelectAll()
        {
            List<UserType> result = null;
            using (SqlConnection conn = new SqlConnection(_cadena))
            {
                using (SqlCommand cmd = new SqlCommand("spUserTypeSelectAll", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
                    {
                        if (dr != null)
                        {
                            result = new List<UserType>();

                            while (dr.Read())
                            {
                                UserType entity = new UserType();
                                entity.UserTypeId = dr.GetInt32(0);
                                entity.AccessLevel = dr.GetString(1);
                                entity.Permission = dr.GetString(2);
                                entity.Work = dr.GetString(3);


                                result.Add(entity);
                            }
                        }
                    }
                }
            }
            return result;
        }
        public bool Insert(UserType entity)
        {
            bool result = false;
            using (SqlConnection conn = new SqlConnection(_cadena))
            {
                using (SqlCommand cmd = new SqlCommand("spUserTypeInsert", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@AccessLevel", entity.AccessLevel);
                    cmd.Parameters.AddWithValue("@Permission", entity.Permission);
                    cmd.Parameters.AddWithValue("@Work", entity.Work);
                    conn.Open();
                    result = cmd.ExecuteNonQuery() > 0;
                }
            }
            return result;
        }
        public bool Update(UserType entity)
        {
            bool result = false;

            using (SqlConnection conn = new SqlConnection(_cadena))
            {
                using (SqlCommand cmd = new SqlCommand("spUserTypeUpdate", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@UserTypeId", entity.UserTypeId);
                    cmd.Parameters.AddWithValue("@AccessLevel", entity.AccessLevel);
                    cmd.Parameters.AddWithValue("@Permission", entity.Permission);
                    cmd.Parameters.AddWithValue("@Work", entity.Work);
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
                using (SqlCommand cmd = new SqlCommand("spUserTypeDelete", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@UserTypeId", id);

                    conn.Open();
                    result = cmd.ExecuteNonQuery() > 0;
                }
            }
            return result;
        }
    }
}
