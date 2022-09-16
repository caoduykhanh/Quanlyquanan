using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Category
    {
        public Category (int maloai , string tenloai)
        {
            this.MaLoai = maloai;
            this.Tenloai = tenloai;
        }
        public Category(DataRow row)
        {
            this.MaLoai = (int)row["MaLoai"];
            this.Tenloai = row["TenLoai"].ToString();
        }
        private int maloai;
        public  int MaLoai
        {
            get { return maloai; }
            set { maloai = value; }
        }
        private string tenloai;
        public string Tenloai
        {
            get { return tenloai; }
            set { tenloai = value; }

        }
    }
}
