using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Phieu
    {
        private string maphieu;
        private string manv;
        private DateTime? ngaytao;
        private int maban;
        private DateTime? ngaythanhtoan;
        private int status;
        public string MaPhieu
        {
            get { return maphieu; }
            set { maphieu = value; }

        }
        public string MaNV
        {
            get { return manv; }
            set { manv = value; }

        }
        public DateTime? NgayTao
        {
            get { return ngaytao; } 
            set { ngaytao = value; }
        }
        public int MaBan
        {
            get { return maban; }
            set { maban = value; }
        }
        public DateTime? NgayThanhToan
        {
            get { return ngaythanhtoan; }
            set { ngaythanhtoan = value; }
        }
        public int Status
        {
            get { return status; }
            set { status = value; }
        }
        public Phieu(string maphieu, string manv, DateTime?ngaytao,int maban,DateTime?ngaythanhtoan,int status )
        {
            this.MaPhieu= maphieu;
            this.MaNV= manv;
            this.NgayTao=ngaytao;
            this.MaBan = maban;
            this.NgayThanhToan=ngaythanhtoan;
            this.Status = status;
        }
        public Phieu(DataRow row)
        {
            this.MaPhieu = (string)row["MaPhieu"];
            this.MaNV = (string)row["MaNV"];
            this.NgayTao = (DateTime?)row["NgayTao"];
            this.MaBan = (int)row["MaBan"];
            var datecheckouttemp = row["NgayThanhToan"];
              if(datecheckouttemp.ToString() != "")
            this.NgayThanhToan = (DateTime?)datecheckouttemp;
            this.Status = (int)row["Status"];
        }

    }
}
