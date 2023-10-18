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
    public partial class FormDoanhThu : Form
    {
        public DataTable dt = new DataTable();
        public UserName userName = new UserName();
        public Human human = new Human();
        public ThongKeBUS ThongKeBUS = new ThongKeBUS();
        public FormDoanhThu(UserName userName)
        {
            InitializeComponent();
            this.userName = userName;
        }

        private void btunKT_Click(object sender, EventArgs e)
        {
            if(txtbNhap.Text != "" && rdTKthang.Checked == true)
            {
               dt.Clear();
               dt = ThongKeBUS.getThongKeThang(txtbNhap.Text);
                if (dt.Rows.Count > 0)
                    dgvTK.DataSource = dt;
                else
                    MessageBox.Show("Không có dữ liệu về tháng " + txtbNhap.Text + " !");
            }
            else if(txtbNhap.Text != "" && rdTKnam.Checked == true)
            {
                dt.Clear();
                dt = ThongKeBUS.getThongKeNam(txtbNhap.Text);
                if(dt.Rows.Count > 0)
                    dgvTK.DataSource = dt;
                else
                    MessageBox.Show("Không có dữ liệu về năm " + txtbNhap.Text + " !");
            }
            else if(txtbNhap.Text != "" && rdTKNV.Checked == true)
            {
                dt.Clear();
                dt = ThongKeBUS.getThongKeNV(txtbNhap.Text);
                if (dt.Rows.Count > 0)
                    dgvTK.DataSource = dt;
                else
                    MessageBox.Show("Không có dữ liệu về nhân viên " + txtbNhap.Text + " !");
            }
            else
            {
                if(rdXuatExe.Checked == true)
                {
                    if(saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        ToExcel(dgvTK, saveFileDialog1.FileName);
                    }
                }
            }
        }

        private void ToExcel(DataGridView dgvTK, string fileName)
        {
            Microsoft.Office.Interop.Excel.Application excel;
            Microsoft.Office.Interop.Excel.Workbook workbook;
            Microsoft.Office.Interop.Excel.Worksheet worksheet;
            try
            {
                excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Visible = false;
                excel.DisplayAlerts = false;
                workbook = excel.Workbooks.Add(Type.Missing);
                worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets["Sheet1"];
                worksheet.Name = "Sheet1";
                for(int i = 0; i < dgvTK.ColumnCount; i++)
                {
                    worksheet.Cells[1, i + 1] = dgvTK.Columns[i].HeaderText;
                }
                for(int i = 0; i < dgvTK.RowCount; i++)
                {
                    for(int j = 0; j < dgvTK.ColumnCount; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dgvTK.Rows[i].Cells[j].Value.ToString();
                    }
                }
                workbook.SaveAs(fileName);
                workbook.Close();
                excel.Quit();
                MessageBox.Show("Done");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
