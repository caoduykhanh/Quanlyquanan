using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLayer;
namespace XayDungHeThongQuanLyQuanAn
{
    public partial class FrmBan : Form
    {

        public FrmBan()
        {
            InitializeComponent();
            
        }

        private void FrmBan_Load(object sender, EventArgs e)
        {
            LoadTable();
            LoadCategory();
           
        }
        void LoadCategory()
        {
            List<Category>listCategory = CategoryDAO.Instance.GetListCategory();
            cb_Category.DataSource = listCategory;
            cb_Category.DisplayMember = "TenLoai";
        }
        void LoadFoodListByCategory(int id)
        {
            List<Food> listFood = FoodDAO.Instance.GetFoodByCategoryID(id);
            cb_Food.DataSource = listFood;
            cb_Food.DisplayMember = "TenMon";
        }
        void LoadTable()
        {
            List<Ban> banlist = BanDAO.Instance.LoadTableList();
            foreach (Ban item in banlist)
            {
                Button btn = new Button() {Width = BanDAO.TableWidth ,Height = BanDAO.TableHeight};
                btn.Text = item.tenban + Environment.NewLine + item.trangthai +Environment.NewLine+ item.maban;
                btn.Click += Btn_Click;
                btn.Tag = item;
                switch (item.trangthai) //kiem tra ban trong hay ko
                {
                    case "Trong":
                        btn.BackColor = Color.GreenYellow;
                        break;
                    default:
                        btn.BackColor = Color.Red;
                        break;
                }
                
                flp_Ban.Controls.Add(btn);
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            int tableID =((sender as Button ).Tag as Ban).MaBan;
            lv_Bill.Tag = (sender as Button).Tag;
            ShowBill(tableID);
        }

        void ShowBill(int id)
        {
            lv_Bill.Items.Clear();
            List<BillMenu> listbillinfo = BillMenuDAO.Instance.GetlistMenuByTable(id);
            float TongTien = 0;
            foreach (BillMenu item in listbillinfo)
            {
                ListViewItem listitem = new ListViewItem(item.TenMon);
                listitem.SubItems.Add(item.SoLuong.ToString());
                listitem.SubItems.Add(item.DonGia.ToString());
                listitem.SubItems.Add(item.TongTien.ToString());
                TongTien += item.TongTien;
                lv_Bill.Items.Add(listitem);
            }
            CultureInfo culture = new CultureInfo("vi-VN");// chuyen doi dong 
            txt_TongTien.Text = TongTien.ToString("c",culture);
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            new FrmTable().Show();
            this.Hide();
        }

        private void cb_Category_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;
            ComboBox cb = sender as ComboBox;

            if (cb.SelectedItem == null)
                return;

            Category selected = cb.SelectedItem as Category;
            id = selected.MaLoai;

            LoadFoodListByCategory(id);
        }

        private void cb_Food_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_AddFood_Click(object sender, EventArgs e)
        {
            Table table = lv_Bill.Tag as Table;
            string idBill =  PhieuDAO.Instance.GetUncheckBillIdByTableId(table.MaBan);
            string foodID = (cb_Food.SelectedItem as Food).MaMon;
            int soluong = (int)nmFoodCount.Value;
            if (idBill == null)
            {
                PhieuDAO.Instance.InsertBill(table.MaBan);
                ChiTietPhieuDAO.Instance.InsertBillInfo(PhieuDAO.Instance.GetMaxIDBill(),foodID , soluong );
            }
            else
            {
                ChiTietPhieuDAO.Instance.InsertBillInfo(idBill, foodID, soluong);

            }
        }
    }
}
