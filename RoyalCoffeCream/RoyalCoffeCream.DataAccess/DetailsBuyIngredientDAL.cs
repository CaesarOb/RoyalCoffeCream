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
    public class DetailsBuyIngredientDAL : Connection
    {
        private static DetailsBuyIngredientDAL _instance;
        public static DetailsBuyIngredientDAL Instance
        {
            get
            {
                return _instance ?? (_instance = new DetailsBuyIngredientDAL());
            }
        }
        public List<DetailsBuyIngredient> SelectAll()
        {
            List<DetailsBuyIngredient> result = null;
            using (SqlConnection conn = new SqlConnection(_cadena))
            {
                using (SqlCommand cmd = new SqlCommand("spDetailsBuyIngredientSelectAll", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
                    {
                        if (dr != null)
                        {
                            result = new List<DetailsBuyIngredient>();

                            while (dr.Read())
                            {
                                DetailsBuyIngredient entity = new DetailsBuyIngredient();
                                entity.DetailsBuyIngredientId = dr.GetInt32(0);
                                entity.BuyIngredientId = dr.GetInt32(1);
                                entity.IngredientId = dr.GetInt32(2);
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
        public bool Insert(DetailsBuyIngredient entity)
        {
            bool result = false;
            using (SqlConnection conn = new SqlConnection(_cadena))
            {
                using (SqlCommand cmd = new SqlCommand("spDetailsBuyIngredientInsert", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@BuyIngredientId", entity.BuyIngredientId);
                    cmd.Parameters.AddWithValue("@IngredientId", entity.IngredientId);
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
        public bool Update(DetailsBuyIngredient entity)
        {
            bool result = false;

            using (SqlConnection conn = new SqlConnection(_cadena))
            {
                using (SqlCommand cmd = new SqlCommand("spDetailsBuyIngredientUpdate", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@DetailsBuyIngredientId", entity.DetailsBuyIngredientId);
                    cmd.Parameters.AddWithValue("@BuyIngredientId", entity.BuyIngredientId);
                    cmd.Parameters.AddWithValue("@IngredientId", entity.IngredientId);
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
                using (SqlCommand cmd = new SqlCommand("spDetailsBuyIngredientDelete", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@DetailsBuyIngredientId", id);

                    conn.Open();
                    result = cmd.ExecuteNonQuery() > 0;
                }
            }
            return result;
        }
    }
}
