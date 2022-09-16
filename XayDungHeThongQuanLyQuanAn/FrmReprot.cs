using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XayDungHeThongQuanLyQuanAn
{
    public partial class FrmReprot : Form
    {
        public FrmReprot()
        {
            InitializeComponent();
        }

        private void FrmReprot_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-1ABFDIDK\SQLEXPRESS;Initial Catalog=QLQUANAN;User ID=sa;Password=1");
        private void btn_Report_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Select * From PHIEU", connection);
            SqlDataAdapter d = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            d.Fill(dt);
            reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource source = new ReportDataSource("DataSet1",dt);
            reportViewer1.LocalReport.ReportPath = @"C:\Users\ASUS\Desktop\Simminar\ProjectPM\QuanLyQuanAn\XayDungHeThongQuanLyQuanAn\Report1.rdlc";
            reportViewer1.LocalReport.DataSources.Add(source);
            reportViewer1.RefreshReport();
        }
    }
}
