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
using BussinessLogincLayer;
using DataAccessLayer;
namespace XayDungHeThongQuanLyQuanAn
{
    public partial class FrmNhanVien : Form
    {
        NhanVienManagement mngNhanVien = new NhanVienManagement();
        BindingSource bs;
        public FrmNhanVien()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void FrmNhanVien_Load(object sender, EventArgs e)
        {
            DataSet ds = mngNhanVien.viewNhanVien();
            bs = new BindingSource();
            bs.DataSource = ds.Tables[0];
            gv_NhanVien.DataSource = bs;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            DataSet ds = null;
            if (txtTimKiem.Text.Trim() == " ")
            {
                ds = mngNhanVien.searchByName(txtTimKiem.Text);
            }
            else
            {
                ds = mngNhanVien.searchByName(txtTimKiem.Text);
            }


            bs = new BindingSource();
            bs.DataSource = ds.Tables[0];
            gv_NhanVien.DataSource = bs;
        }

        private void gv_NhanVien_Click(object sender, EventArgs e)
        {
            int index = gv_NhanVien.CurrentRow.Index;
            string MaNV = gv_NhanVien.Rows[index].Cells[0].Value.ToString();
            SqlDataReader dr = mngNhanVien.getDetails(MaNV);
            if (dr.Read())
            {
                //txtId.Text = dr.GetString(3);
                //txtAddress.Text = dr.GetString(5);// address cột thứ 5 sql
                //txtFullname.Text = dr.GetString(0) + " " + dr.GetString(1) + " " + dr.GetString(2);
                //dtdob.Value = dr.GetDateTime(4);
                //txtEmail.Text = dr.GetString(10);
                //txtPassword.Text = dr.GetString(11);
                //txtPhone.Text = dr.GetString(12);
                txtMaNV.Text = dr.GetString(0);
                txtHoTen.Text = dr.GetString(1);
                txtDiaChi.Text = dr.GetString(2);
                txtSDT.Text = dr.GetString(3);
                dt_NVL.Value = dr.GetDateTime(4);
                txtSoNgayLam.Text=dr.GetString(5);
                txtLuongCoBan.Text = dr.GetInt32(6).ToString();
                txtSex.Text = dr.GetString(7);
                dt_NgaySinh.Value = dr.GetDateTime(8);
                txtCa.Text = dr.GetString(9);
                txtMaKV.Text = dr.GetInt32(10).ToString();
                txtChucVu.Text = dr.GetString(11);

            }
            mngNhanVien.closeConnection();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            NhanVien nv = new NhanVien()
            {

                //FirstName = txtFullname.Text,
                //Address = txtAddress.Text,
                //Ssn = txtId.Text,
                //Dob = dtdob.Value,
                //Password = txtPassword.Text,
                //Emails = txtEmail.Text,
                //Phone = txtPhone.Text

                MaNV = txtMaNV.Text,
                HoTen = txtHoTen.Text,
                DiaChi = txtDiaChi.Text,
                SDT = txtSDT.Text,
                NgayVaoLam=dt_NVL.Value,
                SoNgayLam = txtSoNgayLam.Text,
                LuongCoBan = int.Parse(txtLuongCoBan.Text.Trim()),
                Sex = txtSex.Text,
                NgaySinh =dt_NgaySinh.Value,
                Ca = txtCa.Text,
                MaKV = int.Parse(txtMaKV.Text.Trim()),
                ChucVu = txtChucVu.Text


            };
            //
            int result = mngNhanVien.AddNhanVien(nv);
            if (result < 0)
            {
                toolStripStatusLabel1.Text = " Save error !!!";

            }
            else
            {
                toolStripStatusLabel1.Text = "Creat NhanVien successfully";

            }
            DataSet ds = mngNhanVien.viewNhanVien();
            bs = new BindingSource();
            bs.DataSource = ds.Tables[0];
            gv_NhanVien.DataSource = bs;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien()
            {

                //FirstName = txtFullname.Text,
                //Address = txtAddress.Text,
                //Ssn = txtId.Text,
                //Dob = dtdob.Value,
                //Password = txtPassword.Text,
                //Emails = txtEmail.Text,
                //Phone = txtPhone.Text

                MaNV = txtMaNV.Text,
                HoTen = txtHoTen.Text,
                DiaChi = txtDiaChi.Text,
                SDT = txtSDT.Text,
                NgayVaoLam = dt_NVL.Value,
                SoNgayLam = txtSoNgayLam.Text,
                LuongCoBan = int.Parse(txtLuongCoBan.Text.Trim()),
                Sex = txtSex.Text,
                NgaySinh = dt_NgaySinh.Value,
                Ca = txtCa.Text,
                MaKV = int.Parse(txtMaKV.Text.Trim()),
                ChucVu = txtChucVu.Text


            };
            int result = mngNhanVien.UpdateNhanVien(nv);
            if (result < 0)
            {
                toolStripStatusLabel1.Text = "Update error!!!";
            }
            else
            {
                toolStripStatusLabel1.Text = "update NhanVien done !!!";
            }
            // refresh
            DataSet ds = mngNhanVien.viewNhanVien();
            bs = new BindingSource();
            bs.DataSource = ds.Tables[0];
            gv_NhanVien.DataSource = bs;

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("ARE YOU SURE?", "CONFIRMATION", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                int result = mngNhanVien.DeleteNhanVien(txtMaNV.Text); // cot phone dang su dung lam khoa chinh ssn
                if (result < 0)
                {
                    toolStripStatusLabel1.Text = "Delete error!!!";
                }
                else
                {
                    toolStripStatusLabel1.Text = "Delete NhanVien done !!!";
                }
                // refresh
                DataSet ds = mngNhanVien.viewNhanVien();
                bs = new BindingSource();
                bs.DataSource = ds.Tables[0];
                gv_NhanVien.DataSource = bs;
            }
        }

        private void gv_NhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
