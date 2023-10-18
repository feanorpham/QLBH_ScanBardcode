using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
using System.Data.SqlClient;
using System.Data;

namespace BUS
{
    public class getdataScanBUS
    {
        public dbConnect db = new dbConnect();
        public ScanHangHoa scanHangHoa = new ScanHangHoa();
        public DataTable ScanHangHoa(ScanHangHoa scanHangHoa)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "exec scanBardcode '" + scanHangHoa.Bardcode + "'";
            return db.ExeReader(cmd);
        }
    }
}
