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
using AForge.Video.DirectShow;
using AForge.Video;
using ZXing;
using System.Security.Cryptography;
using System.Globalization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace WindowsFormsApp2
{
    public partial class FormThanhToan : Form
    {
        private static int count = 0;

        //   bool checkvalue = true;
        public UserName userName = new UserName();
        public ScanHangHoa hangHoa = new ScanHangHoa();
        public Human human = new Human();
        public CTHD cTHD = new CTHD();
        public countSoPhieu countSo = new countSoPhieu();
        public billprint billprint = new billprint();
        public getdataScanBUS sc = new getdataScanBUS();
        public getdataHumanBUS humanBUS = new getdataHumanBUS();
        public billBUS billBUS = new billBUS();
        public LinkAudio linkAudio = new LinkAudio();
        public getdataSoPhieu getdataSoPhieu = new getdataSoPhieu();
        public ChamCong chamCong = new ChamCong();
        Bitmap bitmap = null;
        DataTable dt = new DataTable();
        FilterInfoCollection filter;
        VideoCaptureDevice captureDevice;

        public FormThanhToan(UserName userName)
        {
            InitializeComponent();
            this.userName = userName;
            txtbSoHoaDon.Enabled = false;
            txtbSoTien.Enabled = false;
            txtbDonGia.Enabled = false;
            txtbBardcode.Enabled = false;
            txtbTenHangHoa.Enabled = false;
            txtbSotientra.Enabled = false;
            btunStop.Enabled = false;
        }

        private void btunScan_Click(object sender, EventArgs e)
        {
            filter = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            captureDevice = new VideoCaptureDevice(filter[0].MonikerString);
            captureDevice.NewFrame += CaptureDevice_NewFrame;
            captureDevice.Start();
            timer1.Start();
            btunStop.Enabled = true;
        }

        private void CaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            bitmap = (Bitmap)eventArgs.Frame.Clone();
        }

        /*
        private void scanBardcode(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
            BarcodeReader reader = new BarcodeReader();
            var result = reader.Decode(bitmap);
            if (result != null)
            {
                linkAudio.audioScan();
                txtbBardcode.Invoke(new MethodInvoker(delegate ()
                {
                    txtbBardcode.Text = result.ToString();
                    hangHoa.Bardcode = txtbBardcode.Text;
                    dt = sc.ScanHangHoa(hangHoa);
                    if (dt.Rows.Count > 0)
                    {
                        txtbTenHangHoa.Text = dt.Rows[0][1].ToString();
                        txtbNgaySX.Text = dt.Rows[0][2].ToString();
                        txtbNgayHH.Text = dt.Rows[0][3].ToString();
                        txtbDonGia.Text = dt.Rows[0][4].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thầy hàng hóa");
                    }
                }));
            }
        }
        */
        private void btunStop_Click(object sender, EventArgs e)
        {
            if (captureDevice.IsRunning)
                captureDevice.Stop();
            btunStop.Enabled = false;
        }

        private void btunXoa_Click(object sender, EventArgs e)
        {
            if (captureDevice.IsRunning)
            {
                captureDevice.Stop();
                xoaTextBoxt();
            }
            else
            {
                xoaTextBoxt();
            }

        }

        bool check()
        {
            return string.IsNullOrEmpty(txtbBardcode.Text) || string.IsNullOrEmpty(txtbTenHangHoa.Text) ||
                   string.IsNullOrEmpty(dateTimePicker1.Text) || string.IsNullOrEmpty(dateTimePicker2.Text) ||
                   string.IsNullOrEmpty(txtbDonGia.Text) || string.IsNullOrEmpty(txtbSoLuong.Text);
        }

        private void btunThem_Click(object sender, EventArgs e)
        {
            if (check() == false)
            {
                addBill(userName.Users, txtbTenHangHoa.Text, txtbSoLuong.Text, txtbDonGia.Text);
                cTHD.bardcode = txtbBardcode.Text;
                cTHD.dongiaSP = txtbDonGia.Text;
                cTHD.soluong = txtbSoLuong.Text;
                cTHD.ngaytao = DateTime.Now.ToString();
                billBUS.insertBill(cTHD);
                MessageBox.Show("Done!!");
                xoaTextBoxt();
                dgvHoaDon.Refresh();
                captureDevice.NewFrame += CaptureDevice_NewFrame;
                captureDevice.Start();
                timer1.Start();

            }
            else
            {
                MessageBox.Show("Chưa nhập đủ thông tin");
            }
        }

        public void addBill(string User, string TenHangHoa, string SoLuong, string DonGiaSP)
        {
            float sum = 0;
            sum = float.Parse(SoLuong) * float.Parse(DonGiaSP);
            string time = DateTime.Now.ToString();
            human.UserName = userName.Users.ToString();
            dt = humanBUS.getHuman(human);
            if (dt.Rows.Count > 0)
            {
                string name = dt.Rows[0][1].ToString();
                cTHD.CharID = dt.Rows[0][0].ToString();
                dgvHoaDon.Rows.Add(txtbSoHoaDon.Text, User, TenHangHoa, SoLuong, time, sum, name);
                TinhTien();
            }
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
                    hangHoa.Bardcode = txtbBardcode.Text;
                    dt = sc.ScanHangHoa(hangHoa);
                    if (dt.Rows.Count > 0)
                    {
                        hangHoa.TenHangHoa = txtbTenHangHoa.Text = dt.Rows[0][1].ToString();
                        hangHoa.NgayXS = dateTimePicker1.Text = dt.Rows[0][2].ToString();
                        hangHoa.NgayHetHan = dateTimePicker2.Text = dt.Rows[0][3].ToString();
                        txtbDonGia.Text = dt.Rows[0][4].ToString();
                        hangHoa.DonGiaSP = float.Parse(dt.Rows[0][4].ToString(),
                            CultureInfo.InvariantCulture.NumberFormat);
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thầy hàng hóa hãy bật lại scan");
                        xoaTextBoxt();
                    }

                    timer1.Stop();
                    if (captureDevice.IsRunning)
                        captureDevice.Stop();
                }
            }
        }

        private void FormThanhToan_Load(object sender, EventArgs e)
        {
            float sumCN = 0;
            float sumCN2 = 0;
            DataTable count1 = new DataTable();
            count1 = getdataSoPhieu.getSoHoaDon(countSo);
            if (count1.Rows.Count > 0)
            {
                countSo.SoHoaDon = int.Parse(count1.Rows[0][0].ToString());
                count = countSo.SoHoaDon;
            }

            count++;
            txtbSoHoaDon.Text = count.ToString();
            if (txtbSoTien.Text != "")
            {
                sumCN += float.Parse(txtbSoTien.Text);
            }

            human.UserName = userName.Users.ToString();
            dt = humanBUS.getHuman(human);
            hovaten.Text = dt.Rows[0][1].ToString();
            if (tongtienthu.Text != "" && txtbSoTien.Text != "")
            {
                sumCN2 = float.Parse(tongtienthu.Text) + sumCN;
                tongtienthu.Text = sumCN2.ToString();
            }
            else
            {
                tongtienthu.Text = sumCN.ToString();
            }

            xoaValue();
        }

        public void TinhTien()
        {
            float sum = 0;
            for (int i = 0; i < dgvHoaDon.Rows.Count; i++)
            {
                sum += Convert.ToInt64(dgvHoaDon.Rows[i].Cells[5].Value);
            }

            txtbSoTien.Text = sum.ToString();
        }

        private void btunIn_Click(object sender, EventArgs e)
        {
            FormInHoaDon formInHoaDon = new FormInHoaDon(userName);
            formInHoaDon.Show();
        }

        public void insertprintBill()
        {
            billprint.username = userName.Users;
            human.UserName = userName.Users.ToString();
            dt = humanBUS.getHuman(human);
            billprint.tennhanvien = dt.Rows[0][1].ToString();
        }

        private void btunLuu_Click(object sender, EventArgs e)
        {
            if (dgvHoaDon.Rows.Count == 0 || string.IsNullOrEmpty(txtbSotientra.Text))
                MessageBox.Show("Chưa có hàng hóa trong giỏ hàng hoặc chưa tính tiền cho khách hàng");
            else
            {
                for (int i = 0; i < dgvHoaDon.Rows.Count; i++)
                {
                    billprint.sohoadon = int.Parse(dgvHoaDon.Rows[i].Cells[0].Value.ToString());
                    billprint.username = dgvHoaDon.Rows[i].Cells[1].Value.ToString();
                    billprint.tenhanghoa = dgvHoaDon.Rows[i].Cells[2].Value.ToString();
                    billprint.soluong = int.Parse(dgvHoaDon.Rows[i].Cells[3].Value.ToString());
                    billprint.ngayban = dgvHoaDon.Rows[i].Cells[4].Value.ToString();
                    billprint.thanhtien = float.Parse(dgvHoaDon.Rows[i].Cells[5].Value.ToString());
                    billprint.tennhanvien = dgvHoaDon.Rows[i].Cells[6].Value.ToString();
                    billBUS.insertPrintBill(billprint);
                }

                MessageBox.Show("Done");
                txtbSotienkhachdua.Text = "";
                txtbSotientra.Text = "";
                FormThanhToan_Load(sender, e);
            }
        }

        public void xoaValue()
        {
            txtbBardcode.Text = "";
            txtbDonGia.Text = "";
            txtbSoLuong.Text = "";
            dateTimePicker1.Text = "";
            dateTimePicker2.Text = "";
            txtbTenHangHoa.Text = "";
            txtbSoTien.Text = "";
            dgvHoaDon.Rows.Clear();
            dgvHoaDon.Refresh();
        }

        public void xoaTextBoxt()
        {
            txtbBardcode.Text = "";
            txtbDonGia.Text = "";
            txtbSoLuong.Text = "";
            txtbTenHangHoa.Text = "";
            dateTimePicker1.Text = "";
            dateTimePicker2.Text = "";
        }

        private void dgvHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvHoaDon.CurrentRow.Index;
            if (dgvHoaDon.Columns[e.ColumnIndex].HeaderText == "Update")
            {
                billprint.ngayban = dgvHoaDon.Rows[i].Cells[4].Value.ToString();
                dt = billBUS.getBardcodefrom_CTHD(billprint);
                cTHD.bardcode = dt.Rows[0][0].ToString();
                cTHD.dongiaSP = dt.Rows[0][1].ToString();
                cTHD.soluong = dgvHoaDon.Rows[i].Cells[3].Value.ToString();
                cTHD.ngaytao = billprint.ngayban;
                billprint.tenhanghoa = dgvHoaDon.Rows[i].Cells[2].Value.ToString();
                human.UserName = userName.Users;
                dt = humanBUS.getHuman(human);
                if (dt.Rows.Count > 0)
                {
                    cTHD.CharID = dt.Rows[0][0].ToString();
                }

                billBUS.updatebBill(cTHD);
                MessageBox.Show("Done");
                float sum = 0;
                sum = float.Parse(cTHD.dongiaSP) * float.Parse(cTHD.soluong);
                dgvHoaDon.Rows[i].Cells[5].Value = sum;
                dgvHoaDon.Refresh();
                TinhTien();
            }
            else if (dgvHoaDon.Columns[e.ColumnIndex].HeaderText == "Delete")
            {
                cTHD.ngaytao = dgvHoaDon.Rows[i].Cells[4].Value.ToString();
                if (MessageBox.Show("Bạn có chắc chắn muốn sóa", "Thông báo", MessageBoxButtons.YesNo) ==
                    DialogResult.Yes)
                {
                    billBUS.deleteBillfrom_CTHD(cTHD);
                    dt = getdataSoPhieu.getMaHoaDon(countSo);
                    countSo.SoPhieu = int.Parse(dt.Rows[0][0].ToString());
                    getdataSoPhieu.updateMaHoaDon(countSo);
                    MessageBox.Show("Done");
                    dgvHoaDon.Rows.RemoveAt(i);
                    dgvHoaDon.Refresh();
                    TinhTien();
                }
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            date.Text = DateTime.Now.ToString();
        }

        private void btunChamCong_Click(object sender, EventArgs e)
        {
            chamCong.UserName = userName.Users;
            chamCong.datetimenow = DateTime.Now.ToString();
            chamCong.TongTien = float.Parse(tongtienthu.Text);
            billBUS.insertChamChong(chamCong);
            MessageBox.Show("Done");
        }

        private void Btuntinhtien_Click(object sender, EventArgs e)
        {
            float a = 0;
            if (dgvHoaDon.Rows.Count == 0 || string.IsNullOrEmpty(txtbSotienkhachdua.Text))
                MessageBox.Show("Chưa có hàng hóa hoặc chưa nhập số tiền khách đưa");
            else
            {
                a = float.Parse(txtbSotienkhachdua.Text) - float.Parse(txtbSoTien.Text);
                txtbSotientra.Text = a.ToString();
            }
        }
    }
}
