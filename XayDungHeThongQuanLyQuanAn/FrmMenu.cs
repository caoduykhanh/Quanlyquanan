using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BussinessLogincLayer;
using DataAccessLayer;

namespace XayDungHeThongQuanLyQuanAn
{
    public partial class FrmMenu : Form
    {
        MenuManagement mngMenu = new MenuManagement();
        BindingSource bs;
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void btnThemMon_Click(object sender, EventArgs e)
        {

        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            DataSet ds = mngMenu.viewMenu();
            bs = new BindingSource();
            bs.DataSource = ds.Tables[0];
            gv_menu.DataSource = bs;
        }

        private void gv_menu_Click(object sender, EventArgs e)
        {
            int index = gv_menu.CurrentRow.Index;
            string depnum = gv_menu.Rows[index].Cells[1].Value.ToString();
            SqlDataReader dr = mngMenu.getDetails(depnum);
            if (dr.Read())
            {

                /*    txtId.Text = dr.GetString(1);*/
                //txt_departmentName.Text = dr.GetString(0);
                //txt_departmentNumber.Text = dr.GetDecimal(1).ToString();
                //txt_managerSSN.Text = dr.GetString(2);
                //dt_managerStartTime.Value = dr.GetDateTime(3);
                txtStt.Text = dr.GetInt32(0).ToString();
                txtMaMon.Text = dr.GetString(1);
                txtTenMon.Text = dr.GetString(2);
                txtMoTa.Text = dr.GetString(3);
                txtDonGia.Text = dr.GetInt32(4).ToString();
                txtMaLoai.Text = dr.GetInt32(5).ToString();
                picMenu.ImageLocation = @"../../dataImage/"+dr.GetString(6);
            }
            mngMenu.closeConnection();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            DataSet ds = null;
            if (txtTimKiem.Text.Trim() == " ")
            {
                ds = mngMenu.searchByName(txtTimKiem.Text);
            }
            else
            {
                ds = mngMenu.searchByName(txtTimKiem.Text);
            }


            bs = new BindingSource();
            bs.DataSource = ds.Tables[0];
            gv_menu.DataSource = bs;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
           Menus me = new Menus()

            {

               //DepartmentName = txt_departmentName.Text,
               //DepartmentNumber = Convert.ToDecimal(txt_departmentNumber.Text),
               //ManagerSSN = txt_managerSSN.Text,
               //ManagerStartTime = dt_managerStartTime.Value
                STT = int.Parse(txtStt.Text.Trim()),
                MaMon =txtMaMon.Text,
                TenMon =txtTenMon.Text,
                MoTa =txtMoTa.Text,
                DonGia = int.Parse(txtDonGia.Text.Trim()),
                MaLoai = int.Parse(txtMaLoai.Text.Trim()),
                Path = txt_path.Text


           };
            //
            int result = mngMenu.AddMenu(me);
            if (result < 0)
            {
                toolStripStatusLabel1.Text = " Save error !!!";

            }
            else
            {
                toolStripStatusLabel1.Text = "Creat Menu successfully";

            }
            DataSet ds = mngMenu.viewMenu();
            bs = new BindingSource();
            bs.DataSource = ds.Tables[0];
            gv_menu.DataSource = bs;
        }


        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            Menus me = new Menus()

            {

                //DepartmentName = txt_departmentName.Text,
                //DepartmentNumber = Convert.ToDecimal(txt_departmentNumber.Text),
                //ManagerSSN = txt_managerSSN.Text,
                //ManagerStartTime = dt_managerStartTime.Value
                STT = int.Parse(txtStt.Text.Trim()),
                MaMon = txtMaMon.Text,
                TenMon = txtTenMon.Text,
                MoTa = txtMoTa.Text,
                DonGia = int.Parse(txtDonGia.Text.Trim()),
                MaLoai = int.Parse(txtMaLoai.Text.Trim()),
                Path = txt_path.Text
            };
            int result = mngMenu.UpdateMenu(me);
            if (result < 0)
            {
                toolStripStatusLabel1.Text = "Update error!!!";
            }
            else
            {
                toolStripStatusLabel1.Text = "update Menu done !!!";
            }
            // refresh
            DataSet ds = mngMenu.viewMenu();
            bs = new BindingSource();
            bs.DataSource = ds.Tables[0];
            gv_menu.DataSource = bs;

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("ARE YOU SURE?", "CONFIRMATION", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                int result = mngMenu.DeleteMenu(txtMaMon.Text); 
                if (result < 0)
                {
                    toolStripStatusLabel1.Text = "Delete error!!!";
                }
                else
                {
                    toolStripStatusLabel1.Text = "Delete Menu done !!!";
                }
                // refresh
                DataSet ds = mngMenu.viewMenu();
                bs = new BindingSource();
                bs.DataSource = ds.Tables[0];
                gv_menu.DataSource = bs;
            }
        }

        private void btn_Browser_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                picMenu.Image = new Bitmap(openFileDialog1.OpenFile());
                 lbl_Path.Text = openFileDialog1.FileName;
                txt_path.Text = openFileDialog1.SafeFileName;

                toolStripStatusLabel1.Text = "open file ...";
            }
        }

        private void btn_Upload_Click(object sender, EventArgs e)
        {
          
        }

        private void btn_Upload_Click_1(object sender, EventArgs e)
        {
            try
            {
                string fileName = openFileDialog1.SafeFileName;
                string rootPath = @"../../dataImage";
                File.Copy(openFileDialog1.FileName, rootPath + "/" + fileName, true);
                toolStripStatusLabel1.Text = "Save file sucessfully!";
            }
            catch (Exception ex)
            {
                toolStripStatusLabel1.Text = ex.Message;
            }
        }
    }
}
