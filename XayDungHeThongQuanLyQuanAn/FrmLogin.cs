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
   
    public partial class FrmLogin : Form
    {
        AccountManagement mngAccount = new AccountManagement();
        BindingSource bs;

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            
        }
        private void btn_Login_Click(object sender, EventArgs e)
        {
    


        }
       
        private void txt_Username_Validating(object sender, CancelEventArgs e)
        {
        //    e.Cancel = true;
        //    if (string.IsNullOrEmpty(txt_Username.Text))
        //    {
        //        errorProvider1.SetError(txt_Username, "Username is left blank!");
        //    }
        //    else
        //    {
        //        errorProvider1.SetError(txt_Username, null);

        //        e.Cancel = false;

        //    }
        }

        private void txt_Password_Validating(object sender, CancelEventArgs e)
        {
        //    e.Cancel = true;
        //    if (string.IsNullOrEmpty(txt_Password.Text))
        //    {
        //        errorProvider1.SetError(txt_Password, "Password is not left blank!");
        //    }
        //    else if (txt_Password.Text.Trim().Length < 6)
        //    {
        //        errorProvider1.SetError(txt_Password, " at least 6 characters");
        //    }
        //    else
        //    {
        //        errorProvider1.SetError(txt_Password, null);
        //        e.Cancel = false;
        //    }
        }

        private void btn_Login_Click_1(object sender, EventArgs e)
        {
            Account account = new Account();
            {
                account.TaiKhoan = txt_Username.Text;
                account.MatKhau = txt_Password.Text;
            }
            bool result = mngAccount.checkLogin(account.TaiKhoan, account.MatKhau);
            if (result)
            {

                new FrmTrangChinh().Show();
                this.Hide();

                //MessageBox.Show("Login Successful" + account.ChucVu);
            }
            else
            {

                MessageBox.Show("Login Failed");
            }
        }

        private void btn_Register_Click_1(object sender, EventArgs e)
        {
            new FrmRegister().Show();
            this.Hide();
        }
    }
}
