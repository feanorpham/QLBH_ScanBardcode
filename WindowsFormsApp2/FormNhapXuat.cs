using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video.DirectShow;
using AForge.Video;
using ZXing;
using BUS;
using DTO;
using System.Globalization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WindowsFormsApp2
{
    public partial class FormNhapXuat : Form
    {
        private static float thanhtien = 0;
        private static int count = 0;
        public nhacungcapDTO nhacungcapDTO = new nhacungcapDTO();
        public ctnxDTO ctnxDTO = new ctnxDTO();
        public NhapXuatBUS  nhapXuat = new NhapXuatBUS();
        public LinkAudio linkAudio = new LinkAudio();
        public ScanHangHoa sc = new ScanHangHoa();
        public getdataScanBUS scanBUS = new getdataScanBUS();
        public UserName userName = new UserName();
        public countSoPhieu countSo = new countSoPhieu();
        public Human human = new Human();
        public getdataHumanBUS humanBUS = new getdataHumanBUS();
        Bitmap bitmap = null;
        DataTable dt = new DataTable();
        FilterInfoCollection filter;
        VideoCaptureDevice captureDevice;
        public FormNhapXuat(UserName userName)
        {
            this.userName = userName;
            InitializeComponent();
        }

        private void btunScan_Click(object sender, EventArgs e)
        {
            filter = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            captureDevice = new VideoCaptureDevice(filter[0].MonikerString);
            captureDevice.NewFrame += CaptureDevice_NewFrame;
            captureDevice.Start();
            timer1.Start();
        }
        private void CaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            bitmap = (Bitmap)eventArgs.Frame.Clone();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (bitmap != null)
            {
                BarcodeReader reader = new BarcodeReader();
                Result result = reader.Decode(bitmap);
                if (result != null)
                {
                    linkAudio.audioScan();
                    txtbBardcode.Text = result.ToString();
                    sc.Bardcode = txtbBardcode.Text;
                    dt = scanBUS.ScanHangHoa(sc);
                    if (dt.Rows.Count > 0)
                    {
                        string a = txtbBardcode.Text.ToString();
                        string b = a.Substring(0, 7);
                        txtMaNhaCC.Text = b;
                        ctnxDTO.Bardcode = txtbBardcode.Text = dt.Rows[0][0].ToString();
                        ctnxDTO.DonGiaSP = float.Parse(txtbdongiaSP.Text = dt.Rows[0][4].ToString());
                    }
                    else
                    {
                        MessageBox.Show("hàng hóa chưa có trong cdsl hay thêm hàng hóa");
                        string a = txtbBardcode.Text.ToString();
                        string b = a.Substring(0, 7);
                        txtMaNhaCC.Text = b;
                    }
                    timer1.Stop();
                    if (captureDevice.IsRunning)
                        captureDevice.Stop();
                }
            }
        }

        private void FormNhapXuat_Load(object sender, EventArgs e)
        {
            dt = nhapXuat.coutSoPhieu();
            if(dt.Rows.Count > 0)
            {
                countSo.SoPhieu = int.Parse(dt.Rows[0][0].ToString());
                count = countSo.SoPhieu;
            }
            count++;
            txtbSoNhapXuat.Text = count.ToString();
            human.UserName = userName.Users;
            dt = humanBUS.getHuman(human);
            hovaten.Text = dt.Rows[0][1].ToString();
        }
        bool checkvaluesP()
        {
            if(txtbBardcode.Text == "" || txtbsoluong.Text == "" || txtbdongiaSP.Text == "")
                return false;
            return true;
        }
        bool checkvaluesNX()
        {
            if(txtMaNhaCC.Text == "" || txtbSoLuongNCC.Text == "" || txtbThanhTien.Text == "")
                return false;
            return true;
        }
        private void btunThem_Click(object sender, EventArgs e)
        {
            if(checkvaluesP() == true)
            {
                ctnxDTO.SoNhapXuat = txtbSoNhapXuat.Text;
                ctnxDTO.Bardcode = txtbBardcode.Text;
                ctnxDTO.SoLuong = int.Parse(txtbsoluong.Text);
                ctnxDTO.DonGiaSP = float.Parse(txtbdongiaSP.Text);
                ctnxDTO.NgayTao = dateTimePicker2.Text;
                human.UserName = userName.Users;
                dt = humanBUS.getHuman(human);
                if (dt.Rows.Count > 0)
                {
                    string charid = dt.Rows[0][0].ToString();
                    ctnxDTO.CharID = charid;
                }
                addCTNX(ctnxDTO.SoNhapXuat, ctnxDTO.Bardcode, ctnxDTO.SoLuong, ctnxDTO.DonGiaSP);
                nhapXuat.insertCTNX(ctnxDTO);
                TinhTien();
            }
            else
            {
                MessageBox.Show("Chưa nhập đủ thông tin");
            }
            if(cmbChucNang.SelectedItem.ToString() == "Thêm phiếu nhập" && cmbnhapxuat.SelectedItem.ToString() == "Nhập")
            {

            }
        }
        public void addCTNX(string sophieu, string bardcode, int soluong, float dongiasp)
        {
            thanhtien = soluong * dongiasp;
            string time = DateTime.Now.ToString();
            dgvNhapXuat.Rows.Add(sophieu, bardcode, soluong, dongiasp,time,thanhtien);
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            date.Text = DateTime.Now.ToString();
        }
        public void loadNhapXuat()
        {
            countSo.SoPhieu = int.Parse(txtbSoNhapXuat.Text);
            dt = nhapXuat.getvaluesCTNX(countSo);
            if(dt.Rows.Count > 0)
            {
                dgvNhapXuat.DataSource = dt;
            }
        }
        public void TinhTien()
        {
            float sum = 0;
            for (int i = 0; i < dgvNhapXuat.Rows.Count; i++)
            {
                sum += Convert.ToInt64(dgvNhapXuat.Rows[i].Cells[5].Value);
            }
            txtbThanhTien.Text = sum.ToString();
            float count = 0;
            for(int i = 0; i < dgvNhapXuat.Rows.Count; i++)
            {
                count += Convert.ToInt64(dgvNhapXuat.Rows[i].Cells[2].Value);
            }
            txtbSoLuongNCC.Text = count.ToString();
        }
    }
}
