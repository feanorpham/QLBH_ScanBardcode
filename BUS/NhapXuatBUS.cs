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
    public class NhapXuatBUS
    {
        public nhapxuatDTO nhapxuatDTO = new nhapxuatDTO();
        public ctnxDTO ctnxDTO = new ctnxDTO();
        public dbConnect db = new dbConnect();
        public countSoPhieu countSoPhieu = new countSoPhieu();
        public DataTable coutSoPhieu()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select* from countNhapXuat";
            return db.ExeReader(cmd);
        }
        public int insertNhapXuat(nhapxuatDTO nhapxuatDTO)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into tb_NhapXuat values(@sophieunhap,@manhacc,@ngaytao,@soluong,@thanhtien,@loai)";
            cmd.Parameters.AddWithValue("@sophieunhap", nhapxuatDTO.SoNhapXuat);
            cmd.Parameters.AddWithValue("@manhacc", nhapxuatDTO.MaNhaCC);
            cmd.Parameters.AddWithValue("@ngaytao", nhapxuatDTO.NgayTao);
            cmd.Parameters.AddWithValue("@soluong", nhapxuatDTO.SoLuong);
            cmd.Parameters.AddWithValue("@thanhtien", nhapxuatDTO.ThanhTien);
            cmd.Parameters.AddWithValue("@loai", nhapxuatDTO.Loai);
            return db.ExecutNonQuery(cmd);
        }
        public int insertCTNX(ctnxDTO ctnxDTO)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into tb_CTNX values(@sophieunhap,@bardcode,@soluong,@dongiasp,@ngaytao,@charid)";
            cmd.Parameters.AddWithValue("@sophieunhap", ctnxDTO.SoNhapXuat);
            cmd.Parameters.AddWithValue("@bardcode", ctnxDTO.Bardcode);
            cmd.Parameters.AddWithValue("@soluong", ctnxDTO.SoLuong);
            cmd.Parameters.AddWithValue("@dongiasp", ctnxDTO.DonGiaSP);
            cmd.Parameters.AddWithValue("@ngaytao", ctnxDTO.NgayTao);
            cmd.Parameters.AddWithValue("@charid", ctnxDTO.CharID);
            return db.ExecutNonQuery(cmd);
        }
        public DataTable getvaluesCTNX(countSoPhieu countSoPhieu)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "exec getdataCTNX '" + countSoPhieu.SoPhieu + "'";
            return db.ExeReader(cmd);
        }
    }
}
