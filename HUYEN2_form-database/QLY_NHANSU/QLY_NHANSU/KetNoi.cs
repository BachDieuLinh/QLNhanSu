using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QLY_NHANSU
{
    class KetNoi
    {
        SqlConnection kn = new SqlConnection();
        static public String connect()
        {
            return @"Data Source=VAIO;Initial Catalog=QUANLY_NHANSU;Integrated Security=True";
        }    
    }
}
