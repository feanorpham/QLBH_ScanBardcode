using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;
using AForge.Video.DirectShow;
using AForge.Video;
using ZXing;
using System.Globalization;
using System.Security.Cryptography;

namespace WindowsFormsApp2
{
    public partial class FormHangHoa : Form
    {
        public Human human = new Human();
        public getdataHumanBUS humanBUS = new getdataHumanBUS();
        public ScanHangHoa scanHang = new ScanHangHoa();
        public nhacungcapDTO nhacungcapDTO = new nhacungcapDTO();
        public hanghoaBUS hanghoaBUS = new hanghoaBUS();
        public UserName userName = new UserName();
        public DataTable dt = new DataTable();
        public LinkAudio linkAudio = new LinkAudio();
        public getdataScanBUS sc = new getdataScanBUS();
        FilterInfoCollection filter;
        VideoCaptureDevice captureDevice;
        Bitmap bitmap = null;
        public FormHangHoa(UserName userName)
        {
            InitializeComponent();
            groupBox4.Enabled = false;
            this.userName = userName;
            txtbMaCC.Enabled = false;
        }

        private void cmbChucNang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbChucNang.SelectedItem.ToString() == "Thêm nhà cung cấp")
            {
                groupBox4.Enabled = true;
                groupBox2.Enabled = false;
                loadNhaCC();
            }
            else if (cmbChucNang.SelectedItem.ToString() == "Danh sách hàng hóa")
            {
                FormHangHoa_Load(sender, e);
                groupBox4.Enabled = false;
                groupBox2.Enabled = false;
                txtbMaCC.Text = "";
                txtbTenNhaCC.Text = "";
                deletevalues();
            }
            else if (cmbChucNang.SelectedItem.ToString() == "Danh sách nhà cung cấp")
            {
                loadNhaCC();
                groupBox4.Enabled = false;
                txtbMaCC.Text = "";
                txtbTenNhaCC.Text = "";
                txtbMaNhaCC.Enabled = false;
                deletevalues();
            }
            else
            {
                FormHangHoa_Load(sender, e);
                groupBox4.Enabled = false;
                groupBox2.Enabled = true;
                txtbMaCC.Text = "";
                txtbTenNhaCC.Text = "";
                txtbBardcode.Enabled = false;
            }
        }
        bool CheckNhaCC(string a)
        {
            nhacungcapDTO.MaNhaCC = a.ToString();
            dt = hanghoaBUS.checkMaNhaCC(nhacungcapDTO);
            return dt.Rows.Count > 0;
        }
        bool CheckBardcode(string a)
        {
            scanHang.Bardcode = a.ToString();
            dt = hanghoaBUS.checkBardcode(scanHang);
            return dt.Rows.Count > 0;
        }
        bool CheckValues()
        {
            return string.IsNullOrEmpty(txtbBardcode.Text) || string.IsNullOrEmpty(txtbTenHangHoa.Text) ||
                   string.IsNullOrEmpty(txtbMaNhaCC.Text) || string.IsNullOrEmpty(txtbDonGiaSP.Text);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbChucNang.Text))
                MessageBox.Show("Hãy chọn chức năng");
            else if (cmbChucNang.SelectedItem.ToString() == "Danh sách hàng hóa")
            {
                FormHangHoa_Load(sender, e);
            }
            else if (cmbChucNang.SelectedItem.ToString() == "Danh sách nhà cung cấp")
            {
                dt = hanghoaBUS.getdataNhaCC();
                if (dt.Rows.Count > 0)
                {
                    dgvHangHoa.DataSource = dt;
                }
            }
            else if (cmbChucNang.SelectedItem.ToString() == "Thêm nhà cung cấp")
            {
                if (CheckNhaCC(txtbMaCC.Text) == true)
                {
                    MessageBox.Show("Mã nhà cung cấp đã tồn tại");
                }
                else
                {
                    if (txtbTenNhaCC.Text != "")
                    {
                        nhacungcapDTO.MaNhaCC = txtbMaCC.Text;
                        nhacungcapDTO.TenNhaCC = txtbTenNhaCC.Text;
                        hanghoaBUS.insertNhaCC(nhacungcapDTO);
                        MessageBox.Show("Done");
                        txtbTenNhaCC.Text = "";
                        txtbMaCC.Text = "";
                        loadNhaCC();
                        FormLoand();
                    }
                    else
                    {
                        MessageBox.Show("Chưa nhập đủ thông tin");
                    }
                }
            }
            /*           else if (cmbChucNang.SelectedItem.ToString() == "Sửa nhà cung cấp")
                       {
                           nhacungcapDTO.MaNhaCC = txtbMaCC.Text;
                           nhacungcapDTO.TenNhaCC = txtbTenNhaCC.Text;
                           if (CheckNhaCC() == false)
                           {
                               MessageBox.Show("Mã nhà cung cấp hoặc tên nhà cung cấp đã tồn tại");
                           }
                           else
                           {
                               hanghoaBUS.updateNhaCC(nhacungcapDTO);
                               MessageBox.Show("Done");
                               txtbTenNhaCC.Text = "";
                               txtbMaNhaCC.Text = "";
                           }
                       }
            */
            else
            {
                if (CheckValues() == false)
                {
                    scanHang.Bardcode = txtbBardcode.Text;
                    scanHang.TenHangHoa = txtbTenHangHoa.Text;
                    scanHang.MaNhaCC = txtbMaNhaCC.Text;
                    scanHang.DonGiaSP = float.Parse(txtbDonGiaSP.Text);
                    scanHang.NgayXS = dateTimePicker1.Text.ToString();
                    scanHang.NgayHetHan = dateTimePicker2.Text.ToString();
                    if (CheckBardcode(scanHang.Bardcode) == false && CheckNhaCC(scanHang.MaNhaCC) == true)
                    {
                        hanghoaBUS.insertHangHoa(scanHang);
                        MessageBox.Show("Done");
                        deletevalues();
                        FormHangHoa_Load(sender, e);
                    }
                    else
                        MessageBox.Show("Mã bardcode đã tồn tại hoặc mã nhà cung cấp chưa tồn tại ");
                }
                else
                {
                    MessageBox.Show("Chưa nhập đủ thông tin");
                }
            }
        }
        private void FormHangHoa_Load(object sender, EventArgs e)
        {
            dt = hanghoaBUS.getdataHangHoa();
            if (dt.Rows.Count > 0)
            {
                dgvHangHoa.DataSource = dt;
            }
            human.UserName = userName.Users.ToString();
            dt = humanBUS.getHuman(human);
            hovaten.Text = dt.Rows[0][1].ToString();
            dt = hanghoaBUS.countHangHoa();
            tongsomathang.Text = dt.Rows[0][0].ToString();
            dt = hanghoaBUS.countNhaCC();
            tongsonhacungcap.Text = dt.Rows[0][0].ToString();
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
                    scanHang.Bardcode = txtbBardcode.Text;
                    dt = sc.ScanHangHoa(scanHang);
                    if (dt.Rows.Count > 0)
                    {
                        string a = txtbBardcode.Text.ToString();
                        string b = a.Substring(0, 7);
                        scanHang.TenHangHoa = txtbTenHangHoa.Text = dt.Rows[0][1].ToString();
                        scanHang.NgayXS = dateTimePicker1.Text = dt.Rows[0][2].ToString();
                        scanHang.NgayHetHan = dateTimePicker2.Text = dt.Rows[0][3].ToString();
                        scanHang.MaNhaCC = b;
                        txtbDonGiaSP.Text = dt.Rows[0][4].ToString();
                        scanHang.DonGiaSP = float.Parse(dt.Rows[0][4].ToString());
                        if (string.IsNullOrEmpty(cmbChucNang.Text))
                        {
                            txtbMaCC.Text = b;
                            txtbMaNhaCC.Text = b;
                        }
                        else if (cmbChucNang.SelectedItem.ToString() == "Thêm nhà cung cấp")
                        {
                            txtbMaCC.Text = b;
                        }
                        else if (cmbChucNang.SelectedItem.ToString() == "Thêm hàng hóa")
                            txtbMaNhaCC.Text = b;
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thầy hàng hóa hãy thêm hàng hóa và bật lại scan!!");
                        string a = scanHang.Bardcode;
                        string b = a.Substring(0, 7);
                        scanHang.MaNhaCC = b;
                        if (string.IsNullOrEmpty(cmbChucNang.Text))
                        {
                            txtbMaCC.Text = b;
                        }
                        else if (cmbChucNang.SelectedItem.ToString() == "Thêm nhà cung cấp")
                        {
                            txtbMaCC.Text = b;
                        }
                        else if (cmbChucNang.SelectedItem.ToString() == "Thêm hàng hóa")
                            txtbMaNhaCC.Text = b;
                    }
                    timer1.Stop();
                    if (captureDevice.IsRunning)
                        captureDevice.Stop();
                }
            }
        }
        private void dgvHangHoa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvHangHoa.CurrentRow.Index;
            if (dgvHangHoa.Columns[e.ColumnIndex].HeaderText == "Update")
            {
                if (string.IsNullOrEmpty(cmbChucNang.Text))
                {
                    scanHang.Bardcode = dgvHangHoa.Rows[i].Cells["pbardcode"].Value.ToString();
                    scanHang.TenHangHoa = dgvHangHoa.Rows[i].Cells["TenHangHoa"].Value.ToString();
                    scanHang.DonGiaSP = float.Parse(dgvHangHoa.Rows[i].Cells["DonGiaSP"].Value.ToString());
                    scanHang.MaNhaCC = dgvHangHoa.Rows[i].Cells["MaNhaCC"].Value.ToString();
                    scanHang.NgayXS = dgvHangHoa.Rows[i].Cells["NgaySX"].Value.ToString();
                    scanHang.NgayHetHan = dgvHangHoa.Rows[i].Cells["NgayHetHan"].Value.ToString();
                    hanghoaBUS.updateHangHoa(scanHang);
                    MessageBox.Show("Done");
                    FormHangHoa_Load(sender, e);
                }
                else if (cmbChucNang.SelectedItem.ToString() == "Danh sách nhà cung cấp" || cmbChucNang.SelectedItem.ToString() == "Thêm nhà cung cấp")
                {
                    nhacungcapDTO.MaNhaCC = dgvHangHoa.Rows[i].Cells[2].Value.ToString();
                    nhacungcapDTO.TenNhaCC = dgvHangHoa.Rows[i].Cells[3].Value.ToString();
                    hanghoaBUS.updateNhaCC(nhacungcapDTO);
                    MessageBox.Show("Done");
                    loadNhaCC();
                }
                else
                {
                    scanHang.Bardcode = dgvHangHoa.Rows[i].Cells["Bardcode"].Value.ToString();
                    scanHang.TenHangHoa = dgvHangHoa.Rows[i].Cells["TenHangHoa"].Value.ToString();
                    scanHang.DonGiaSP = float.Parse(dgvHangHoa.Rows[i].Cells["DonGiaSP"].Value.ToString());
                    scanHang.MaNhaCC = dgvHangHoa.Rows[i].Cells["MaNhaCC"].Value.ToString();
                    scanHang.NgayXS = dgvHangHoa.Rows[i].Cells["NgaySX"].Value.ToString();
                    scanHang.NgayHetHan = dgvHangHoa.Rows[i].Cells["NgayHetHan"].Value.ToString();
                    hanghoaBUS.updateHangHoa(scanHang);
                    MessageBox.Show("Done");
                    FormHangHoa_Load(sender, e);
                }
            }
            else if (dgvHangHoa.Columns[e.ColumnIndex].HeaderText == "Delete")
            {
                if (string.IsNullOrEmpty(cmbChucNang.Text))
                {
                    scanHang.Bardcode = dgvHangHoa.Rows[i].Cells["pbardcode"].Value.ToString();
                    if (MessageBox.Show("Bạn có chắc chắn muốn sóa", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        hanghoaBUS.deleteHangHoa(scanHang);
                        MessageBox.Show("Done");
                        FormHangHoa_Load(sender, e);
                    }
                }
                else if (cmbChucNang.SelectedItem.ToString() == "Danh sách nhà cung cấp" || cmbChucNang.SelectedItem.ToString() == "Thêm nhà cung cấp")
                {
                    if (checkData(dgvHangHoa.Rows[i].Cells["MaNhaCC"].Value.ToString()) == true)
                        MessageBox.Show("Bạn phải xóa toàn bộ hàng hóa của nhà cung cấp " +
                                        dgvHangHoa.Rows[i].Cells["MaNhaCC"].Value.ToString() +
                                        " đi mới có thể xóa nhà cung cấp");
                    else
                    {
                        nhacungcapDTO.MaNhaCC = dgvHangHoa.Rows[i].Cells["MaNhaCC"].Value.ToString();
                        if (MessageBox.Show("Bạn có chắc chắn muốn sóa", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            hanghoaBUS.deleteNhaCC(nhacungcapDTO);
                            MessageBox.Show("Done");
                            loadNhaCC();
                            FormLoand();
                        }
                    }
                }
                else
                {
                    scanHang.Bardcode = dgvHangHoa.Rows[i].Cells["Bardcode"].Value.ToString();
                    if (MessageBox.Show("Bạn có chắc chắn muốn sóa", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        hanghoaBUS.deleteHangHoa(scanHang);
                        MessageBox.Show("Done");
                        FormHangHoa_Load(sender, e);
                    }
                }
            }
        }
        public void loadNhaCC()
        {
            dt = hanghoaBUS.getdataNhaCC();
            dgvHangHoa.DataSource = dt;
        }
        public void deletevalues()
        {
            txtbBardcode.Text = "";
            txtbTenHangHoa.Text = "";
            txtbMaCC.Text = "";
            txtbMaNhaCC.Text = "";
            txtbDonGiaSP.Text = "";
        }

        private void btunXoa_Click(object sender, EventArgs e)
        {
            deletevalues();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            date.Text = DateTime.Now.ToString();
        }

        bool checkData(string a)
        {
            scanHang.MaNhaCC = a.ToString();
            dt = hanghoaBUS.getdataHangHoa(scanHang);
            return dt.Rows.Count > 0;
        }

        public void FormLoand()
        {
            dt = hanghoaBUS.getdataHangHoa();
            if (dt.Rows.Count > 0)
            {
                human.UserName = userName.Users.ToString();
                dt = humanBUS.getHuman(human);
                hovaten.Text = dt.Rows[0][1].ToString();
                dt = hanghoaBUS.countHangHoa();
                tongsomathang.Text = dt.Rows[0][0].ToString();
                dt = hanghoaBUS.countNhaCC();
                tongsonhacungcap.Text = dt.Rows[0][0].ToString();
            }
        }
    }
}
