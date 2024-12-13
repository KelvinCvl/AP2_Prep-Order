using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace AP2_Prep_Order
{
    internal class Bdd
    {
        //public static SqlConnection db_connect = new SqlConnection("Server=localhost;Database=ap2prep'order;Trusted_Connection=True;");

        public static SqlConnection db_connect = new SqlConnection("Data Source=P-SANS\\SQLEXPRESS;Initial Catalog=ap2prep'order;User ID=P-SANS\\Kelvin;Integrated Security=True;TrustServerCertificate=True;");
    }
}
