using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DAL
    {
        public DataSet FetchView()
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    ConString.con.Open();
                    cmd.Connection = ConString.con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "TC_Fetch_Rainfall_Data";
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);

                    return ds;
                }

            }catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }
    }
}
