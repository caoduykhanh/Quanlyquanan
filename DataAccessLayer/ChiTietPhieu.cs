using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class ChiTietPhieu
    {
        private string mamon;
        private string maphieu;
        private int giamgia;
        private int soluong;
        public string MaMon
        {
            get { return mamon; }
            set { mamon = value; }
        }
        public string MaPhieu
        {
            get { return maphieu; } 
            set { maphieu = value; }
        }
        public int GiamGia
        {
            get { return giamgia; }
            set { giamgia = value; }
        }
        public int SoLuong
        {
            get { return soluong; }
            set { soluong = value; }
        }
        public ChiTietPhieu(string mamon,string maphieu,int giamgia,int soluong)
        {
            this.MaMon = mamon;
            this.MaPhieu = maphieu;
            this.GiamGia = giamgia;
            this.SoLuong = soluong;

        }
        public ChiTietPhieu(DataRow row)
        {
            this.MaMon = (string)row["MaMon"];
            this.MaPhieu = (string)row["MaPhieu"];
            this.GiamGia = (int)row["GiamGia"];
            this.SoLuong = (int)row["SoLuong"];
        }
    }
}
