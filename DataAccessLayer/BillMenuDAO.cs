using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class BillMenuDAO
    {
        private static BillMenuDAO instance;
        public static BillMenuDAO Instance
        {
            get { if (instance == null) instance = new BillMenuDAO(); return BillMenuDAO.instance; }
            private set { BillMenuDAO.instance = value; }
        }
        private BillMenuDAO() { }
        public List<BillMenu> GetlistMenuByTable(int id)
        {
            List<BillMenu> listbillmenu = new List<BillMenu>();
            string sql = "select m.TenMon,ct.SoLuong, m.DonGia,m.DonGia*ct.SoLuong As TongTien from PHIEU as p, CHITIETPHIEU as ct,MENU as m where ct.MaPhieu = p.MaPhieu AND ct.MaMon = m.MaMon AND p.Status = 0 AND p.MaBan = "+ id;
            DataTable data = GeneralDAO.Instance.ExecuteQuery(sql);
            foreach (DataRow item in data.Rows)
            {
                BillMenu billmenu = new BillMenu(item);
                listbillmenu.Add(billmenu);
            }
            return listbillmenu;
        }
    }
}
