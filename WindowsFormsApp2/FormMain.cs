using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;

namespace WindowsFormsApp2
{
    public partial class FormMain : Form
    {
        public UserName user = new UserName();
        public FormMain()
        {
            InitializeComponent();
            menuHoaDon.Enabled = false;
            dmHangHoa.Enabled = false;
            menuBaoCao.Enabled = false;
        }
        public FormMain(string UserName, string PassWord, string PhanQuyen)
        {
            InitializeComponent();
            user.Users = UserName;
            user.Password = PassWord;
            user.PhanQuyen = PhanQuyen;
            if(user.PhanQuyen == "Nhân viên bán hàng")
            {
                dmHangHoa.Enabled = false;
                menuBaoCao.Enabled= false;
            }
            else if(user.PhanQuyen == "Thủ kho")
            {
                menuHoaDon.Enabled = false;
                menuBaoCao.Enabled = false;
            }
            else
            {
                menuHoaDon.Enabled = false;
                dmHangHoa.Enabled = false;
            }
        }

        private void hdThanhToan_Click(object sender, EventArgs e)
        {
            FormThanhToan formThanhToan = new FormThanhToan(user);
            formThanhToan.Show();
        }

        private void hhInfo_Click(object sender, EventArgs e)
        {
            FormHangHoa formHangHoa = new FormHangHoa(user);
            formHangHoa.Show();
        }

        private void hhNhap_Click(object sender, EventArgs e)
        {
            FormNhapXuat formNhapXuat = new FormNhapXuat(user);
            formNhapXuat.Show();
        }

        private void HT_thoat_Click(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
            this.Hide();
        }

        private void bcDoanhThu_Click(object sender, EventArgs e)
        {
            FormDoanhThu formDoanhThu = new FormDoanhThu(user);
            formDoanhThu.Show();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
    }
}
