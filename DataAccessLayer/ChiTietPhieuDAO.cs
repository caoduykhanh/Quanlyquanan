using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class ChiTietPhieuDAO
    {
        private static ChiTietPhieuDAO instance;
        public static ChiTietPhieuDAO Instance
        {
            get { if (instance == null) instance = new ChiTietPhieuDAO(); return ChiTietPhieuDAO.instance; }
            private set { ChiTietPhieuDAO.instance = value; }
        }
        private ChiTietPhieuDAO() { }
        

        public List<ChiTietPhieu> GetlistBill(string id)
        {
            List<ChiTietPhieu> listbillinfo = new List<ChiTietPhieu>();
            DataTable data = GeneralDAO.Instance.ExecuteQuery("select * from CHITIETPHIEU Where MaPhieu = " +id );
            foreach (DataRow item in data.Rows)
            {
                ChiTietPhieu info = new ChiTietPhieu(item);
                listbillinfo.Add(info);
            }
            return listbillinfo;
        }
        public void InsertBillInfo(string MaPhieu, string MaMon,int soluong)
        {
            GeneralDAO.Instance.ExecuteNonQuery("USP_InsertBillInfo @MaMon, @MaPhieu, @SoLuong", new object[] { MaPhieu,MaMon,soluong });
        }
    }
}
