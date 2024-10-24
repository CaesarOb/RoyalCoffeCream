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
    public class BUserDAL : Connection
    {
        private static BUserDAL _instance;
        public static BUserDAL Instance
        {
            get
            {
                return _instance ?? (_instance = new BUserDAL());

            }
        }
        public List<BUser> SelectAll()
        {
            List<BUser> result = null;
            using (SqlConnection conn = new SqlConnection(_cadena))
            {
                using (SqlCommand cmd = new SqlCommand("spBUserSelectAll", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
                    {
                        if (dr != null)
                        {
                            result = new List<BUser>();

                            while (dr.Read())
                            {
                                BUser entity = new BUser();
                                entity.UserId = dr.GetInt32(0);
                                entity.Passcode = dr.GetString(1);
                                entity.Nick = dr.GetString(2);
                                entity.EmployeeId = dr.GetInt32(3);
                                entity.UserTypeId = dr.GetInt32(4);
                                entity.StatusId = dr.GetInt32(5);

                                result.Add(entity);
                            }
                        }
                    }
                }
            }
            return result;
        }
        public bool Insert(BUser entity)
        {
            bool result = false;
            using (SqlConnection conn = new SqlConnection(_cadena))
            {
                using (SqlCommand cmd = new SqlCommand("spBUserInsert", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Passcode", entity.Passcode);
                    cmd.Parameters.AddWithValue("@Nick", entity.Nick);
                    cmd.Parameters.AddWithValue("@EmployeeId", entity.EmployeeId);
                    cmd.Parameters.AddWithValue("@UserTypeId", entity.UserTypeId);
                    cmd.Parameters.AddWithValue("@StatusId", entity.StatusId);
                    conn.Open();
                    result = cmd.ExecuteNonQuery() > 0;
                }
            }
            return result;
        }
        public bool Update(BUser entity)
        {
            bool result = false;

            using (SqlConnection conn = new SqlConnection(_cadena))
            {
                using (SqlCommand cmd = new SqlCommand("spBUserUpdate", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@UserId", entity.UserId);
                    cmd.Parameters.AddWithValue("@Passcode", entity.Passcode);
                    cmd.Parameters.AddWithValue("@Nick", entity.Nick);
                    cmd.Parameters.AddWithValue("@EmployeeId", entity.EmployeeId);
                    cmd.Parameters.AddWithValue("@UserTypeId", entity.UserTypeId);
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
                using (SqlCommand cmd = new SqlCommand("spBUserDelete", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@UserId", id);

                    conn.Open();
                    result = cmd.ExecuteNonQuery() > 0;
                }
            }
            return result;
        }
        public BUser ValidateSession(string nick, string passcode)
        {
            BUser result = null;

            using (SqlConnection conn = new SqlConnection(_cadena))
            {
                using (SqlCommand cmd = new SqlCommand("spBUserValidate", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Passcode", passcode);
                    cmd.Parameters.AddWithValue("@Nick", nick);

                    conn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
                    {
                        if (dr != null)
                        {
                            result = new BUser();

                            while (dr.Read())
                            {
                                result.Passcode = dr.GetString(0);
                                result.Nick = dr.GetString(1);
                                result.EmployeeId = dr.GetInt32(2);
                                result.UserTypeId = dr.GetInt32(3);

                            }
                        }
                    }
                }
            }
            return result;
        }
    }
}
