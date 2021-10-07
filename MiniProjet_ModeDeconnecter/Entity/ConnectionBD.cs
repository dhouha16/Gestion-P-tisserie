using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data; 

namespace MiniProjet_ModeDeconnecter.Entity
{
    class ConnectionBD
    {
        public static SqlConnection con = new SqlConnection();
        public static DataSet ds = new DataSet();
        public static SqlDataAdapter adapter = new SqlDataAdapter();
        public static void Connecter()
        {
            if (con.State == ConnectionState.Closed)
            {
                string conString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename =C:\Users\Dhouha\Desktop\MiniProjet_ModeDeconnecter\MiniProjet_ModeDeconnecter\Patisserie.mdf; Integrated Security = True";
                con.ConnectionString = conString;
                con.Open();
            }
        }
        public static void Deconnecter()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }

    }
}
