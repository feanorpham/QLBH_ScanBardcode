using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
namespace WindowsFormsApp2
{
    public partial class FormLogin : Form
    {
        public UserName userName = new UserName();
        public LoginBus loginBus = new LoginBus();
        DataTable dt = new DataTable();
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btunLogin_Click(object sender, EventArgs e)
        {
            userName.Users = txtbUsers.Text;
            userName.Password = txtPassword.Text;
            dt = loginBus.login(userName);
            if(dt.Rows.Count > 0 )
            {
                MessageBox.Show("Đăng nhập thành công");
                FormMain main = new FormMain(dt.Rows[0][0].ToString(), dt.Rows[0][1].ToString(), dt.Rows[0][2].ToString());
                main.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại, tài khoản hoặc mật khẩu sai!!");
            }
        }
    }
}
