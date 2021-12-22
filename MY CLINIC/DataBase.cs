using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace MY_CLINIC
{
    internal class DataBase
    {
        public static string Con = "Data Source=(LocalDb)\\MSSQLLocalDB;Initial Catalog=MyClinic; Integrated Security=True";
        public static SqlConnection cn = new SqlConnection(Con);
        public static bool Login(string user, string pass)
        {
            cn.Open();

            SqlDataAdapter d=new SqlDataAdapter("select username, password from accounts where username='" + user + "'and password='" + pass + "'", cn);
            DataTable dt = new DataTable();
            d.Fill(dt);
            cn.Close();
            if (dt.Rows.Count > 0) return true;
            else return false;
        }
        public static void register(string user, string pass, string name)
        {
            string query="Insert Into Accounts (Username,Password,Name) Values('"+user+"','"+pass+"','"+name+"')";
            cn.Open();
            SqlCommand cmd = cn.CreateCommand();
            SqlDataAdapter d = new SqlDataAdapter(query, cn);
            d.SelectCommand.ExecuteNonQuery();
            cn.Close();
        }
    }
}
