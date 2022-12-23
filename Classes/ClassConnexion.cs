using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
//using System.Data.SQLite;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Windows.Forms;

namespace suivibouteilles.Classes
{
    class ClassConnexion
    {
        public SqlConnection con = new SqlConnection();
        public SqlCommand cmd = new SqlCommand();
        public SqlCommand cmd1 = new SqlCommand();
        public SqlDataAdapter da = new SqlDataAdapter();
        public DataSet ds = new DataSet();
        public SqlDataReader dr;
        public DataTable dt = new DataTable();
        public ClassConnexion(String connectionString)
        {
            con = new SqlConnection(connectionString);
        }

        public ClassConnexion()
        {
            // TODO: Complete member initialization
        }
        public void connecter()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.ConnectionString = ConfigurationManager.ConnectionStrings["suivibouteilles.Properties.Settings.suivibouteillesConnectionString"].ConnectionString;
                con.Open();
            }
        }
        //------------------
        public void deconnecter()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}
