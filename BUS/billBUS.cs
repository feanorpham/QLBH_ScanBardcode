using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
using System.Data.SqlClient;
using System.Data;

namespace BUS
{
    public class billBUS
    {
        public dbConnect db = new dbConnect();
        public CTHD cTHD  = new CTHD();
        public billprint billprint = new billprint();
        public UserName userName = new UserName();
        public SumDTO sumDTO = new SumDTO();
        public billDTO billDTO = new billDTO();
        public ChamCong chamCong = new ChamCong();
        public int insertBill(CTHD cTHD)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into tb_CTHD values (@bardcode,@dongia,@soluong,@ngaytao,@charid)";
            cmd.Parameters.AddWithValue("@bardcode", cTHD.bardcode);
            cmd.Parameters.AddWithValue("@dongia", cTHD.dongiaSP);
            cmd.Parameters.AddWithValue("@soluong", cTHD.soluong);
            cmd.Parameters.AddWithValue("@ngaytao", cTHD.ngaytao);
            cmd.Parameters.AddWithValue("@charid", cTHD.CharID);
            return db.ExecutNonQuery(cmd);
        }
        public int insertPrintBill(billprint billprint)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into tb_HoaDon values (@sohoadon,@username,@tenhanghoa,@soluong,@ngaytao,@thanhtien,@hovaten)";
            cmd.Parameters.AddWithValue("@sohoadon", billprint.sohoadon);
            cmd.Parameters.AddWithValue("@username", billprint.username);
            cmd.Parameters.AddWithValue("@tenhanghoa", billprint.tenhanghoa);
            cmd.Parameters.AddWithValue("@soluong", billprint.soluong);
            cmd.Parameters.AddWithValue("@ngaytao", billprint.ngayban);
            cmd.Parameters.AddWithValue("@thanhtien", billprint.thanhtien);
            cmd.Parameters.AddWithValue("@hovaten", billprint.tennhanvien);
            return db.ExecutNonQuery(cmd);
        }
        public DataTable getdataBill(billDTO billDTO)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "exec printBill '" + billDTO.username + "','" + billDTO.sohoadon + "'";
            return db.ExeReader(cmd);
        }
        public DataTable getSumbill(SumDTO sumDTO)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "exec sumBill '" + sumDTO.SoHoaDon + "'";
            return db.ExeReader(cmd);
        }
        public DataTable getSoHoaDon(UserName userName)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "exec getSoHoaDon '" + userName.Users + "'";
            return db.ExeReader(cmd);
        }
        public int updatebBill(CTHD cTHD)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update tb_CTHD set Bardcode = @bardcode, DonGiaSP = @dongia, SoLuong = @soluong, CharID = @charid where NgayTao = @ngaytao";
            cmd.Parameters.AddWithValue("@bardcode", cTHD.bardcode);
            cmd.Parameters.AddWithValue("@dongia", cTHD.dongiaSP);
            cmd.Parameters.AddWithValue("@soluong", cTHD.soluong);
            cmd.Parameters.AddWithValue("@ngaytao", cTHD.ngaytao);
            cmd.Parameters.AddWithValue("@charid", cTHD.CharID);
            return db.ExecutNonQuery(cmd);
        }
        public DataTable getBardcodefrom_CTHD(billprint billprint)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "exec getBardcodefrom_CTHD '"+ billprint.ngayban + "'";
            return db.ExeReader(cmd);
        }
        public int deleteBillfrom_CTHD(CTHD cTHD)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from tb_CTHD where NgayTao = '" + cTHD.ngaytao + "'";
            return db.ExecutNonQuery(cmd);
        }
        public int insertChamChong(ChamCong chamCong)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into tb_ChamCong values (@username,@ngay,@tongtien)";
            cmd.Parameters.AddWithValue("@username", chamCong.UserName);
            cmd.Parameters.AddWithValue("@ngay", chamCong.datetimenow);
            cmd.Parameters.AddWithValue("@tongtien", chamCong.TongTien);
            return db.ExecutNonQuery(cmd);
        }
    }
}
