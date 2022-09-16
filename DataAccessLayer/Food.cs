using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public  class Food
    {
        public Food (int stt, string mamon,string tenmon,string mota,int dongia,int maloai,string path)
        {
            this.STT = stt;
            this.MaMon = mamon;
            this.TenMon = tenmon;
            this.MoTa = mota;
            this.DonGia = dongia;
            this.Maloai = maloai;
            this.Path = path;
        }
        public Food (DataRow row )
        {
            this.STT = (int)row["STT"];
            this.MaMon = row["MaMon"].ToString();
            this.TenMon = row["TenMon"].ToString();
            this.MoTa = row["MoTa"].ToString();
            this.DonGia = (int)row["DonGia"];
            this.Maloai = (int)row["MaLoai"];
            this.Path = row["Path"].ToString();
        }
        private int stt;
        public int STT
        {
            get { return stt; }
            set { stt = value; }
        }
        private string mamon;
        public string MaMon
        {
            get { return mamon; }
            set { mamon = value; }
        }
        private string tenmon;
        public string TenMon
        {
            get { return tenmon; }  
            set { tenmon = value; }
                
        }
        private string mota;
        public string MoTa
        {
            get { return mota; }
            set { mota = value; }
        }
        private int dongia;
        public int DonGia
        {
            get { return dongia; }
            set { dongia = value; }
        }
        private int maloai;
        public int Maloai
        {
            get { return maloai; }
            set { maloai = value; }
        }
        private string path;
        public string Path
        {
            get { return path; }
            set { path = value; }
        }
    }
}
