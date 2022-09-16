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
using System.Data.SqlClient;

namespace XayDungHeThongQuanLyQuanAn
{
    public partial class FrmTable : Form
    {
        TableManagement mngTable = new TableManagement();
        BindingSource bs;
        public FrmTable()
        {
            InitializeComponent();
        }

        private void FrmTable_Load(object sender, EventArgs e)
        {
            DataSet ds = mngTable.viewTable();
            bs = new BindingSource();
            bs.DataSource = ds.Tables[0];
            gv_Table.DataSource = bs;
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            DataSet ds = null;
            if (txt_Search.Text.Trim() == " ")
            {
                ds = mngTable.searchByName(txt_Search.Text);
            }
            else
            {
                ds = mngTable.searchByName(txt_Search.Text);
            }


            bs = new BindingSource();
            bs.DataSource = ds.Tables[0];
            gv_Table.DataSource = bs;
        }

        private void gv_Table_Click(object sender, EventArgs e)
        {
            int index = gv_Table.CurrentRow.Index;
            string depnum = gv_Table.Rows[index].Cells[0].Value.ToString();
            SqlDataReader dr = mngTable.getDetails(depnum);
            if (dr.Read())
            {

                /*    txtId.Text = dr.GetString(1);*/
                //txt_departmentName.Text = dr.GetString(0);
                //txt_departmentNumber.Text = dr.GetDecimal(1).ToString();
                //txt_managerSSN.Text = dr.GetString(2);
                //dt_managerStartTime.Value = dr.GetDateTime(3);
                txt_Maban.Text = dr.GetInt32(0).ToString();
                txt_Tenban.Text = dr.GetString(1);
                txt_Songuoi.Text = dr.GetInt32(2).ToString();
                txt_Makv.Text = dr.GetInt32(3).ToString();
                txt_Trangthai.Text = dr.GetString(4);



            }
            mngTable.closeConnection();
        }

        private void btn_Themban_Click(object sender, EventArgs e)
        {
            Table tables = new Table()
            {

                
                MaBan = int.Parse(txt_Maban.Text.Trim()),
                TenBan = txt_Tenban.Text,
                SoNguoi = int.Parse(txt_Songuoi.Text.Trim()),
                MaKV = int.Parse(txt_Makv.Text.Trim()),
                TrangThai = txt_Trangthai.Text


            };
            //
            int result = mngTable.AddTable(tables);
            if (result < 0)
            {
                toolStripStatusLabel1.Text = " Save error !!!";

            }
            else
            {
                toolStripStatusLabel1.Text = "Creat Table successfully";
               

            }
            DataSet ds = mngTable.viewTable();
            bs = new BindingSource();
            bs.DataSource = ds.Tables[0];
            gv_Table.DataSource = bs;
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("ARE YOU SURE?", "CONFIRMATION", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                int result = mngTable.DeleteTable(txt_Maban.Text);
                if (result < 0)
                {
                    toolStripStatusLabel1.Text = "Delete error!!!";
                }
                else
                {
                    toolStripStatusLabel1.Text = "Delete Table done !!!";
                    
                }
                // refresh
                DataSet ds = mngTable.viewTable();
                bs = new BindingSource();
                bs.DataSource = ds.Tables[0];
                gv_Table.DataSource = bs;
            }
        }
    }
}
