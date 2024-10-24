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
    public class DetailsBuyUtensiltDAL : Connection
    {
        private static DetailsBuyUtensiltDAL _instance;
        public static DetailsBuyUtensiltDAL Instance
        {
            get
            {
                return _instance ?? (_instance = new DetailsBuyUtensiltDAL());
            }
        }
        public List<DetailsBuyUtensilt> SelectAll()
        {
            List<DetailsBuyUtensilt> result = null;
            using (SqlConnection conn = new SqlConnection(_cadena))
            {
                using (SqlCommand cmd = new SqlCommand("spDetailsBuyUtensiltSelectAll", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
                    {
                        if (dr != null)
                        {
                            result = new List<DetailsBuyUtensilt>();

                            while (dr.Read())
                            {
                                DetailsBuyUtensilt entity = new DetailsBuyUtensilt();
                                entity.DetailsBuyUtensiltId = dr.GetInt32(0);
                                entity.BuyUtensilId = dr.GetInt32(1);
                                entity.UtensilId = dr.GetInt32(2);
                                entity.Quantity = dr.GetInt32(3);
                                entity.Total = dr.GetDecimal(4);
                                entity.StatusFactureId = dr.GetInt32(5);
                                entity.Discount = dr.GetDecimal(6);

                                result.Add(entity);
                            }
                        }
                    }
                }
            }
            return result;
        }
        public bool Insert(DetailsBuyUtensilt entity)
        {
            bool result = false;
            using (SqlConnection conn = new SqlConnection(_cadena))
            {
                using (SqlCommand cmd = new SqlCommand("spDetailsBuyUtensiltInsert", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@BuyUtensilId", entity.BuyUtensilId);
                    cmd.Parameters.AddWithValue("@UtensilId", entity.UtensilId);
                    cmd.Parameters.AddWithValue("@Quantity", entity.Quantity);
                    cmd.Parameters.AddWithValue("@Total", entity.Total);
                    cmd.Parameters.AddWithValue("@StatusFactureId", entity.StatusFactureId);
                    cmd.Parameters.AddWithValue("@Discount", entity.Discount);
                    conn.Open();
                    result = cmd.ExecuteNonQuery() > 0;
                }
            }
            return result;
        }
        public bool Update(DetailsBuyUtensilt entity)
        {
            bool result = false;

            using (SqlConnection conn = new SqlConnection(_cadena))
            {
                using (SqlCommand cmd = new SqlCommand("spDetailsBuyUtensiltUpdate", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@DetailsBuyUtensiltId", entity.DetailsBuyUtensiltId);
                    cmd.Parameters.AddWithValue("@BuyUtensilId", entity.BuyUtensilId);
                    cmd.Parameters.AddWithValue("@UtensilId", entity.UtensilId);
                    cmd.Parameters.AddWithValue("@Quantity", entity.Quantity);
                    cmd.Parameters.AddWithValue("@Total", entity.Total);
                    cmd.Parameters.AddWithValue("@StatusFactureId", entity.StatusFactureId);
                    cmd.Parameters.AddWithValue("@Discount", entity.Discount);
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
                using (SqlCommand cmd = new SqlCommand("spDetailsBuyUtensiltDelete", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@DetailsBuyUtensiltId", id);

                    conn.Open();
                    result = cmd.ExecuteNonQuery() > 0;
                }
            }
            return result;
        }
    }
}
