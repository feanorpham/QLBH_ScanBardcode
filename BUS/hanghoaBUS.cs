using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class hanghoaBUS
    {
        public nhacungcapDTO nhacungcapDTO = new nhacungcapDTO();
        public ScanHangHoa scanHang = new ScanHangHoa();
        public dbConnect db = new dbConnect();
        public int insertHangHoa(ScanHangHoa scanHang)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into tb_HangHoa values(@bardcode,@tenhanghoa,@dongiasp,@manhacc,@ngaysx,@ngayhethan)";
            cmd.Parameters.AddWithValue("@bardcode", scanHang.Bardcode);
            cmd.Parameters.AddWithValue("@tenhanghoa", scanHang.TenHangHoa);
            cmd.Parameters.AddWithValue("dongiasp", scanHang.DonGiaSP);
            cmd.Parameters.AddWithValue("@manhacc", scanHang.MaNhaCC);
            cmd.Parameters.AddWithValue("@ngaysx", scanHang.NgayXS);
            cmd.Parameters.AddWithValue("@ngayhethan", scanHang.NgayHetHan);
            return db.ExecutNonQuery(cmd);
        }
        public int updateHangHoa(ScanHangHoa scanHang)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update tb_HangHoa set TenHangHoa = @tenhanghoa, DonGiaSP = @dongiasp, MaNhaCC = @manhacc, NgaySX = @ngaysx, NgayHetHan = @ngayhethan where Bardcode = @bardcode";
            cmd.Parameters.AddWithValue("@bardcode", scanHang.Bardcode);
            cmd.Parameters.AddWithValue("@tenhanghoa", scanHang.TenHangHoa);
            cmd.Parameters.AddWithValue("dongiasp", scanHang.DonGiaSP);
            cmd.Parameters.AddWithValue("@manhacc", scanHang.MaNhaCC);
            cmd.Parameters.AddWithValue("@ngaysx", scanHang.NgayXS);
            cmd.Parameters.AddWithValue("@ngayhethan", scanHang.NgayHetHan);
            return db.ExecutNonQuery(cmd);
        }
        public int deleteHangHoa(ScanHangHoa scanHang)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from tb_HangHoa where Bardcode = '" + scanHang.Bardcode + "'";
            return db.ExecutNonQuery(cmd);
        }
        public int insertNhaCC(nhacungcapDTO nhacungcapDTO)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into tb_NhaCungCap values(@manhacc,@tennhacc)";
            cmd.Parameters.AddWithValue("@manhacc", nhacungcapDTO.MaNhaCC);
            cmd.Parameters.AddWithValue("@tennhacc", nhacungcapDTO.TenNhaCC);
            return db.ExecutNonQuery(cmd);
        }
        public int updateNhaCC(nhacungcapDTO nhacungcapDTO)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update tb_NhaCungCap set TenNhaCC = @tennhacc where MaNhaCC = '" + nhacungcapDTO.MaNhaCC + "'";
            cmd.Parameters.AddWithValue("@tennhacc", nhacungcapDTO.TenNhaCC);
            return db.ExecutNonQuery(cmd);
        }
        public int deleteNhaCC(nhacungcapDTO nhacungcapDTO)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from tb_NhaCungCap where MaNhaCC = '" + nhacungcapDTO.MaNhaCC + "'";
            return db.ExecutNonQuery(cmd);
        }
        public DataTable getdataHangHoa()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select* from tb_HangHoa";
            return db.ExeReader(cmd);
        }
        public DataTable getdataNhaCC()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select* from tb_NhaCungCap";
            return db.ExeReader(cmd);
        }
        public DataTable checkNhaCC(nhacungcapDTO nhacungcapDTO)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "exec CheckNhaCC '" + nhacungcapDTO.MaNhaCC + "', '" + nhacungcapDTO.TenNhaCC + "'";
            return db.ExeReader(cmd);
        }
        public DataTable checkBardcode(ScanHangHoa scanHang)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "exec CheckBardcode '" + scanHang.Bardcode + "'";
            return db.ExeReader(cmd);
        }
        public DataTable checkMaNhaCC(nhacungcapDTO nhacungcapDTO)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "exec CheckMaNhaCC '" + nhacungcapDTO.MaNhaCC + "'";
            return db.ExeReader(cmd);
        }
        public DataTable countHangHoa()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select* from countHangHoa";
            return db.ExeReader(cmd);
        }
        public DataTable countNhaCC()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select* from countNhaCC";
            return db.ExeReader(cmd);
        }
        public DataTable getdataHangHoa(ScanHangHoa scanHangHoa)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select* from tb_HangHoa where MaNhaCC = '" + scanHangHoa.MaNhaCC + "'";
            return db.ExeReader(cmd);
        }
    }
}
