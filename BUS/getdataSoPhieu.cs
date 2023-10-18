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
    public class getdataSoPhieu
    {
        public countSoPhieu soPhieu = new countSoPhieu();
        public dbConnect db = new dbConnect();
        public DataTable getSoHoaDon(countSoPhieu soPhieu)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select* from countSoHoaDon";
            return db.ExeReader(cmd);
        }
        public DataTable getMaHoaDon(countSoPhieu soPhieu)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select* from countMaHoaDon";
            return db.ExeReader(cmd);
        }
        public int updateMaHoaDon(countSoPhieu soPhieu)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "exec restMaHoaDon " + soPhieu.SoPhieu + "";
            return db.ExecutNonQuery(cmd);
        }
    }
}
