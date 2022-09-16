using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class BillMenu
    {
        public BillMenu(string tenmon,int soluong,int dongia, float tongtien)
        {
            this.TenMon = tenmon;
            this.SoLuong = soluong;
            this.DonGia = dongia;
            this.TongTien = tongtien;
        }
        public BillMenu(DataRow row)
        {
            this.TenMon = row["TenMon"].ToString();
            this.SoLuong = (int)row["SoLuong"];
            this.DonGia = (int)row["DonGia"];
            this.TongTien = (float)Convert.ToDouble(row["TongTien"].ToString());
        }
        private string tenmon;
        private int soluong;
        private int dongia;
        private float tongtien;
        public string TenMon
        {
            get { return tenmon; }
            set { tenmon = value; }
        }
        public int SoLuong
        {
            get { return soluong; }
            set { soluong = value; }
        }
        public int DonGia
        {
            get { return dongia; }
            set { dongia = value; }
        }
        public float TongTien
        {
            get { return tongtien; }
            set { tongtien = value; }
        }

    }
}
