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
    public class SupplierDAL : Connection
    {
        private static SupplierDAL _instance;
        public static SupplierDAL Instance
        {
            get
            {
                return _instance ?? (_instance = new SupplierDAL());
            }
        }
        public List<Supplier> SelectAll()
        {
            List<Supplier> result = null;
            using (SqlConnection conn = new SqlConnection(_cadena))
            {
                using (SqlCommand cmd = new SqlCommand("spSupplierSelectAll", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
                    {
                        if (dr != null)
                        {
                            result = new List<Supplier>();

                            while (dr.Read())
                            {
                                Supplier entity = new Supplier();
                                entity.SupplierId = dr.GetInt32(0);
                                entity.Name = dr.GetString(1);
                                entity.ContactName = dr.GetString(2);
                                entity.Phone = dr.GetString(3);
                                entity.Address = dr.GetString(4);
                                entity.StatusId = dr.GetInt32(5);

                                result.Add(entity);
                            }
                        }
                    }
                }
            }
            return result;
        }
        public bool Insert(Supplier entity)
        {
            bool result = false;
            using (SqlConnection conn = new SqlConnection(_cadena))
            {
                using (SqlCommand cmd = new SqlCommand("spSupplierInsert", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Name", entity.Name);
                    cmd.Parameters.AddWithValue("@ContactName", entity.ContactName);
                    cmd.Parameters.AddWithValue("@Phone", entity.Phone);
                    cmd.Parameters.AddWithValue("@Address", entity.Address);
                    cmd.Parameters.AddWithValue("@StatusId", entity.StatusId);
                    conn.Open();
                    result = cmd.ExecuteNonQuery() > 0;
                }
            }
            return result;
        }
        public bool Update(Supplier entity)
        {
            bool result = false;

            using (SqlConnection conn = new SqlConnection(_cadena))
            {
                using (SqlCommand cmd = new SqlCommand("spSupplierUpdate", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@SupplierId", entity.SupplierId);
                    cmd.Parameters.AddWithValue("@Name", entity.Name);
                    cmd.Parameters.AddWithValue("@ContactName", entity.ContactName);
                    cmd.Parameters.AddWithValue("@Phone", entity.Phone);
                    cmd.Parameters.AddWithValue("@Address", entity.Address);
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
                using (SqlCommand cmd = new SqlCommand("spSupplierDelete", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@SupplierId", id);

                    conn.Open();
                    result = cmd.ExecuteNonQuery() > 0;
                }
            }
            return result;
        }
    }
}
