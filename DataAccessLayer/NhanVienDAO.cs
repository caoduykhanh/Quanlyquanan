using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
   public class NhanVienDAO :GeneralDAO
    {
        public DataSet getAllNhanVien()
        {

            return getAll("NhanVien");
        }
        public DataSet searchByName(string name)
        {
            return search("NhanVien", "HoTen like '%" + name + "%'");
        }
        public SqlDataReader findById(string id)
        {
            getConnection();
            SqlDataReader dr = findById("NhanVien", " MaNV = '" + id + "'");
            //CloseConnection();
            return dr;
        }
        public int createNhanVien(NhanVien nv)
        {
            try
            {
                //Fname, Minit, Lname, Ssn, Bdate, Address, Sex, Salary, Super_ssn, Dno, Email, Password, Phone
                string sql = string.Format("insert [NHANVIEN] " +
                                    "                      values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}')",
                                                           nv.MaNV, nv.HoTen,nv.DiaChi,nv.SDT, nv.NgayVaoLam.ToString("yyyy/MM/dd"), 
                                                           nv.SoNgayLam, nv.LuongCoBan,nv.Sex,nv.NgaySinh.ToString("yyyy/MM/dd"),
                                                           nv.Ca,nv.MaKV,nv.ChucVu);
                return insert_update_Delete(sql); // -1 if error

            }
            catch (Exception ex)
            {
                // log
                return -1;
            }

        }
        public int updateNhanVien(NhanVien nv)
        {
            try
            {
                
                string sql = "update [NHANVIEN] set HoTen='" + nv.HoTen + "',DiaChi='" + nv.DiaChi + "'," +
                    "SDT='" + nv.SDT + "',NgayVaoLam='" + nv.NgayVaoLam.ToString("yyyy/MM/dd") + "'," +
                    "SoNgayLam='" + nv.SoNgayLam + "', LuongCoBan='" + nv.LuongCoBan + "'," +
                    "Sex='" + nv.Sex + "',NgaySinh='" + nv.NgaySinh.ToString("yyyy/MM/dd") + "'," +
                    "Ca='" + nv.Ca + "', MaKV='" + nv.MaKV + "', " +
                    "ChucVu='" + nv.ChucVu + "' where MaNV='" + nv.MaNV + "' ";
               
                
                return insert_update_Delete(sql); //-1 if error
            }
            catch (Exception ex)
            {
                //log
                return -1;
            }
        }
        public int deteleNhanVien(string id)
        {
            try
            {
                string sql = "delete [NHANVIEN] where MaNV='" + id + "'";
                return insert_update_Delete(sql); //-1 if error
            }
            catch (Exception ex)
            {
                //log
                return -1;
            }
        }
    }
}
