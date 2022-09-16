using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Ban
    {
        public Ban (int maban,string tenban,int songuoi,int makv,string trangthai)
        {
            this.MaBan = maban;
            this.Tenban = tenban;
            this.SoNguoi = songuoi;
            this.MaKV = makv;
            this.TrangThai = trangthai;
        }
        public Ban (DataRow row)
        {
            this.MaBan= (int)row["MaBan"];
            this.Tenban = row["TenBan"].ToString();
            this.SoNguoi = (int)row["SoNguoi"];
            this.MaKV = (int)row["MaKV"];
            this.TrangThai = row["TrangThai"].ToString();
        }
        public int maban;
        public int MaBan
        {
            get { return maban;}
            set { maban = value; }
        }

        public string tenban;
        public string Tenban
        {
            get { return Tenban; }
            set { tenban = value; }
        }

        public int songuoi;
        public int SoNguoi 
        { 
            get { return SoNguoi; } 
            set { songuoi = value; } 
        }

        public int makv;
        public int MaKV
        {
            get { return MaKV; }
            set { makv = value; }
        }

        public string trangthai;
        public string TrangThai
        {
            get { return TrangThai; }
            set { trangthai = value; }
        }
        
    }
}
