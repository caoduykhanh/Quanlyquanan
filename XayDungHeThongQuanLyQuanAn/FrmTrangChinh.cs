using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BussinessLogincLayer;
namespace XayDungHeThongQuanLyQuanAn
{
    public partial class FrmTrangChinh : Form
    {
       
        private Form currentChildForm;
        private void OpenChildForm(Form childFrom)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childFrom;
            childFrom.TopLevel = false;
            childFrom.FormBorderStyle = FormBorderStyle.None;
            childFrom.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childFrom);
            panelDesktop.Tag = childFrom;
            childFrom.BringToFront();
            childFrom.Show();

        }
        public FrmTrangChinh()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmMenu());


        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmNhanVien());
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            new FrmLogin().Show();
            this.Hide();
        }

        private void btnBan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmBan());
        }

        private void FrmTrangChinh_Load(object sender, EventArgs e)
        {

            
        }
        

        private void btn_Food_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmFood());
        }

        private void btnTrangChinh_Click(object sender, EventArgs e)
        {

        }
    }
}
