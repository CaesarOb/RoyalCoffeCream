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
    public class RecordDAL : Connection
    {
        private static RecordDAL _instance;
        public static RecordDAL Instance
        {
            get
            {
                return _instance ?? (_instance = new RecordDAL());

            }
        }
        public List<Record> SelectAll()
        {
            List<Record> result = null;
            using (SqlConnection conn = new SqlConnection(_cadena))
            {
                using (SqlCommand cmd = new SqlCommand("spRecordSelectAll", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
                    {
                        if (dr != null)
                        {
                            result = new List<Record>();

                            while (dr.Read())
                            {
                                Record entity = new Record();
                                entity.RecordId = dr.GetInt32(0);
                                entity.EventDate = dr.GetDateTime(1);
                                entity.EventDetails = dr.GetString(2);

                                result.Add(entity);
                            }
                        }
                    }
                }
            }
            return result;
        }
    }
}
