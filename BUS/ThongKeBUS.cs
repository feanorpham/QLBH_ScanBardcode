using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using System.Data.SqlClient;
using System.Data;
using DTO;

namespace BUS
{
    public class ThongKeBUS
    {
        public dbConnect db = new dbConnect();
        public DataTable getThongKeThang(string thang)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "exec ThongKeThang '" + thang + "'";
            return db.ExeReader(cmd);
        }
        public DataTable getThongKeNam(string nam)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "exec ThongKeNam '" + nam + "'";
            return db.ExeReader(cmd);
        }
        public DataTable getThongKeNV(string ten)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "exec TongTienNV N'" + ten + "'";
            return db.ExeReader(cmd);
        }
    }
}
