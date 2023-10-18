using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Configuration;

namespace DAO
{
    public class dbConnect
    {
        static string path = Path.GetFullPath(Environment.CurrentDirectory);
        string c = "Data Source=feanor;Initial Catalog=QLBH;Integrated Security=True";
        string a = "Data Source=(localdb)\\v11.0;AttachDbFileName="+path+@"\"+databaseName+ ";Integrated Security=True";
        static string databaseName = "QLBH.mdf";
        static string connectString = ConfigurationManager.ConnectionStrings["myconnection"].ConnectionString;
        public SqlConnection con = new SqlConnection(connectString);
        public SqlConnection getcon()
        {
            if(con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }
        public int ExecutNonQuery(SqlCommand cmd)
        {
            cmd.Connection = getcon();
            int rowsaffected = -1;
            rowsaffected = cmd.ExecuteNonQuery();
            con.Close();
            return rowsaffected;
        }
        public object ExeScalar(SqlCommand cmd)
        {
            cmd.Connection= getcon();
            object obj = -1;
            obj = cmd.ExecuteScalar();
            con.Close();
            return obj;
        }
        public DataTable ExeReader(SqlCommand cmd)
        {
            cmd.Connection = getcon();
            SqlDataReader sdr;
            DataTable dt = new DataTable();
            sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();
            return dt;
        }
    }
}
