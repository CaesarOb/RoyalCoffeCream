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
    public class BuyUtensilDAL : Connection
    {
        private static BuyUtensilDAL _instance;
        public static BuyUtensilDAL Instance
        {
            get
            {
                return _instance ?? (_instance = new BuyUtensilDAL());
            }
        }
        public List<BuyUtensil> SelectAll()
        {
            List<BuyUtensil> result = null;
            using (SqlConnection conn = new SqlConnection(_cadena))
            {
                using (SqlCommand cmd = new SqlCommand("spBuyUtensilSelectAll", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
                    {
                        if (dr != null)
                        {
                            result = new List<BuyUtensil>();

                            while (dr.Read())
                            {
                                BuyUtensil entity = new BuyUtensil();
                                entity.BuyUtensilId = dr.GetInt32(0);
                                entity.SupplyDate = dr.GetDateTime(1);
                                entity.Price = dr.GetDecimal(2);
                                entity.SupplierId = dr.GetInt32(3);
                                entity.UserId = dr.GetInt32(4);

                                result.Add(entity);
                            }
                        }
                    }
                }
            }
            return result;
        }
        public int Insert(BuyUtensil entity)
        {
            int result = 0;
            using (SqlConnection conn = new SqlConnection(_cadena))
            {
                using (SqlCommand cmd = new SqlCommand("spBuyUtensilInsert", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@SupplyDate", entity.SupplyDate);
                    cmd.Parameters.AddWithValue("@Price", entity.Price);
                    cmd.Parameters.AddWithValue("@SupplierId", entity.SupplierId);
                    cmd.Parameters.AddWithValue("@UserId", entity.UserId);
                    conn.Open();
                    result = (int)cmd.ExecuteScalar();
                }
            }
            return result;
        }
        public bool Update(BuyUtensil entity)
        {
            bool result = false;

            using (SqlConnection conn = new SqlConnection(_cadena))
            {
                using (SqlCommand cmd = new SqlCommand("spBuyUtensilUpdate", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@BuyUtensilId", entity.BuyUtensilId);
                    cmd.Parameters.AddWithValue("@SupplyDate", entity.SupplyDate);
                    cmd.Parameters.AddWithValue("@Price", entity.Price);
                    cmd.Parameters.AddWithValue("@SupplierId", entity.SupplierId);
                    cmd.Parameters.AddWithValue("@UserId", entity.UserId);
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
                using (SqlCommand cmd = new SqlCommand("spBuyIngreBuyUtensilDelete", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@BuyUtensilId", id);

                    conn.Open();
                    result = cmd.ExecuteNonQuery() > 0;
                }
            }
            return result;
        }
    }
}
