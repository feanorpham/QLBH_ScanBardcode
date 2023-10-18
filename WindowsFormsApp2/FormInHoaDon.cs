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
using Microsoft.Reporting.WinForms;
using System.Reflection.Emit;

namespace WindowsFormsApp2
{
    public partial class FormInHoaDon : Form
    {
        public billDTO billDTO = new billDTO();
        public SumDTO sumDTO = new SumDTO();
        public billBUS billBUS  = new billBUS();
        public UserName userName = new UserName();
        public DataTable dt = new DataTable();
        public FormInHoaDon(UserName userName)
        {
            InitializeComponent();
            this.userName = userName;
            dt = billBUS.getSoHoaDon(userName);
            if(dt.Rows.Count > 0)
            {
                cmbSoHoaDon.DisplayMember = "SoHoaDon";
                cmbSoHoaDon.DataSource = dt;
            }
            billDTO.username = userName.Users;
        }

        private void FormInHoaDon_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void btunIn_Click(object sender, EventArgs e)
        {
            billDTO.username = userName.Users;
            billDTO.sohoadon = int.Parse(cmbSoHoaDon.Text);
            sumDTO.SoHoaDon = billDTO.sohoadon;
            dt = billBUS.getdataBill(billDTO);
            if(dt.Rows.Count > 0)
            {
                DataTable dt2 = new DataTable();
                dt2 = billBUS.getSumbill(sumDTO);
                reportViewer1.LocalReport.DataSources.Clear();
                ReportDataSource dataSource = new ReportDataSource("DataSet1",dt);
                ReportDataSource dataSource1 = new ReportDataSource("DataSet2", dt2);
                reportViewer1.LocalReport.DataSources.Add(dataSource);
                reportViewer1.LocalReport.DataSources.Add(dataSource1);
                DateTime date1 = DateTime.Now;
                string datetime = date1.ToString();
                ReportParameter date = new ReportParameter("date", datetime, false);
                reportViewer1.LocalReport.SetParameters(date);
                reportViewer1.RefreshReport();
            }
            
        }
    }
}
