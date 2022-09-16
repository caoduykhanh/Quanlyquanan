using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
   public class MenusDAO :GeneralDAO
    {
        public DataSet getAllMenu()
        {
            return getAll("Menu");
        }
        public DataSet searchByName(string name)
        {
            return search("Menu", "TenMon like '%" + name + "%'");
        }
        public SqlDataReader findById(string id)
        {
            getConnection();
            SqlDataReader dr = findById("Menu", "MaMon= '" + id + "' ");
            //closeConnection();
            return dr;
        }
        public int createMenu(Menus me)
        {
            try
            {
        
                string sql = string.Format("insert [MENU] " +
                                    "                      values('{0}','{1}','{2}','{3}','{4}','{5}','{6}')",
                                                          me.STT,me.MaMon, me.TenMon, me.MoTa,me.DonGia,me.MaLoai,me.Path);
                return insert_update_Delete(sql); // -1 if error

            }
            catch (Exception ex)
            {
                // log
                return -1;
            }

        }
        public int updateMenu(Menus me)
        {
            try
            {
                string sql = "update [MENU] set STT ='" + me.STT + "',TenMon ='" + me.TenMon+ "',MoTa ='" + me.MoTa + "',DonGia ='" + me.DonGia + "',MaLoai ='" + me.MaLoai + "',Path ='" + me.Path + "' where MaMon ='" + me.MaMon + "' ";
                return insert_update_Delete(sql); //-1 if error
            }
            catch (Exception ex)
            {
                //log
                return -1;
            }
        }
        public int deteleMenu(string id)
        {
            try
            {
                string sql = "delete [MENU] where MaMon ='" + id + "'";
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
