using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLayer;
using BussinessLogincLayer;
namespace XayDungHeThongQuanLyQuanAn
{
    public partial class FrmRegister : Form
    {

        AccountManagement mngAccount = new AccountManagement();
        BindingSource bs;

        public FrmRegister()
        {
            InitializeComponent();
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            

        }

        private void txt_Username_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            new FrmLogin().Show();
            this.Hide();
        }

        private void btn_Register_Click_1(object sender, EventArgs e)
        {
            Account account = new Account()
            {
                //DepartmentName = txt_departmentName.Text,
                //DepartmentNumber = Convert.ToDecimal(txt_departmentNumber.Text),
                //ManagerSSN = txt_managerSSN.Text,
                //ManagerStartTime = dt_managerStartTime.Value
                ID = txt_Id.Text,
                TaiKhoan = txt_Username.Text,
                MatKhau = txt_Password.Text,
                ChucVu = txt_ChucVu.Text,
                MaNV = txt_Manv.Text
            };


            //
            int result = mngAccount.AddAccount(account);
            if (result < 0)
            {
                toolStripStatusLabel1.Text = " Save error !!!";

            }
            else
            {
                toolStripStatusLabel1.Text = "Creat Department successfully";
                new FrmLogin().Show();
                this.Hide();

            }
            DataSet ds = mngAccount.viewAccount();
            bs = new BindingSource();
            bs.DataSource = ds.Tables[0];
        }

        private void FrmRegister_Load(object sender, EventArgs e)
        {

        }
    }
}
