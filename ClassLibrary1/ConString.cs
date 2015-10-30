using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace DataAccessLayer
{
    class ConString
    {
        public static SqlConnection con;
        static ConString()
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["DB"].ConnectionString);
        }

    }
}
