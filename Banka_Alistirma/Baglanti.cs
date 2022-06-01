using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Banka_Alistirma
{
    class Baglanti
    {
        public SqlConnection con()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-Q087NT7\SQLEXPRESS01;Initial Catalog=DBBANKAALISTIRMA;Integrated Security=True");
            conn.Open();

            return conn;
        }
    }
}
