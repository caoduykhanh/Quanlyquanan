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
namespace XayDungHeThongQuanLyQuanAn
{
    public partial class FrmFood : Form
    {
        LoaiMonManagement mnglist = new LoaiMonManagement();
        BindingSource bs = new BindingSource();
        SqlConnection con = new SqlConnection("Data source = LAPTOP-1ABFDIDK\\SQLEXPRESS;user id = sa;" + "password=1;initial catalog = QLQUANAN");
        public FrmFood()
        {
            InitializeComponent();
        }

        private void FrmFood_Load(object sender, EventArgs e)
        {
            loadCatelogy();

            loadFood();


        }
        private void loadCatelogy()
        {
            //complex data binding 
            DataSet ds = mnglist.viewMaLoai();
            bs.DataSource = ds.Tables[0];
            lst_categories.DataSource = bs;
            // simple data binding
            lst_categories.DisplayMember = "TenLoai";


            //txt_departmentName.DataBindings.Add("Text", bs, "Dname");
            //txt_departmentNumber.DataBindings.Add("Text", bs, "Dnumber");
            //dt_managerStartTime.DataBindings.Add("Value", bs, "Mgr_start_date");
            //txt_managername.DataBindings.Add("Text", bs, "Mgr_ssn");

        }

        private void lst_categories_SelectedIndexChanged(object sender, EventArgs e)
        {
                LoadProduct();
            //lv_food.View = View.Details;
           

        }
        private void loadFood()
        {
           
            con.Open();

            SqlCommand cmd = new SqlCommand("Select  * from vw_Food ", con);
            cmd.Connection = con;
            SqlDataReader reader;
            
            reader = cmd.ExecuteReader();
            // collum list
            lv_food.Columns.Add("STT", 70);
            lv_food.Columns.Add("MaMon", 70);
            lv_food.Columns.Add("TenMon", 70);
            lv_food.Columns.Add("MoTa", 70);
            lv_food.Columns.Add("DonGia", 70);
            lv_food.Columns.Add("MaLoai", 70);
            lv_food.Columns.Add("TenLoai", 70);
            lv_food.Columns.Add("Image", 100);


            while (reader.Read())
            {
                ListViewItem list = new ListViewItem(reader["STT"].ToString());
                list.SubItems.Add(reader["MaMon"].ToString());
                list.SubItems.Add(reader["TenMon"].ToString());
                list.SubItems.Add(reader["MoTa"].ToString());
                list.SubItems.Add(reader["DonGia"].ToString());
                list.SubItems.Add(reader["MaLoai"].ToString());
                list.SubItems.Add(reader["TenLoai"].ToString());
                list.SubItems.Add(reader["Path"].ToString());
                lv_food.Items.Add(list);
            }

            reader.Close();
            con.Close();

        }
        private void LoadProduct()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select DISTINCT * from vw_Food Where MaLoai Like'%" + lst_categories.Text + "%' or TenLoai Like'%" + lst_categories.Text+ "%'",con);
            cmd.Connection = con;
            SqlDataReader reader;
            //cmd.CommandType = CommandType.Text;
            //cmd.CommandText = "Select * from vw_Food Where TenLoai Like'%" + lst_categories + "%' or MaLoai Like'%" + lst_categories + "%'";
            reader = cmd.ExecuteReader();
           
            lv_food.Items.Clear();
            // Data is accessible through the DataReader object here.
            
                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(reader["STT"].ToString()); // Or you can specify column name - ListViewItem item = new ListViewItem(reader["column_name"].ToString()); 
                    item.SubItems.Add(reader["MaMon"].ToString());
                    item.SubItems.Add(reader["TenMon"].ToString());
                    item.SubItems.Add(reader["MoTa"].ToString());
                    item.SubItems.Add(reader["DonGia"].ToString());
                    item.SubItems.Add(reader["MaLoai"].ToString());
                    item.SubItems.Add(reader["TenLoai"].ToString());
                    item.SubItems.Add(reader["Path"].ToString());
                    lv_food.Items.Add(item);

                }
                
           
            reader.Close();
            con.Close();
        }
           

        private void lv_food_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
