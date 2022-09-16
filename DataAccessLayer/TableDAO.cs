using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class TableDAO : GeneralDAO
    {
        public DataSet getAllTable()
        {
            return getAll("BAN");
        }
        public DataSet searchByName(string name)
        {
            return search("BAN", "TenBan like '%" + name + "%'");
        }
        public SqlDataReader findById(string id)
        {
            getConnection();
            SqlDataReader dr = findById("BAN", "MaBan= '" + id + "' ");
            //closeConnection();
            return dr;
        }
        public int createTable(Table tables)
        {
            try
            {

                string sql = string.Format("insert [BAN] " +
                                    "                      values('{0}','{1}','{2}','{3}','{4}')",
                                                          tables.MaBan, tables.TenBan, tables.SoNguoi, tables.MaKV,tables.TrangThai);
                return insert_update_Delete(sql); // -1 if error

            }
            catch (Exception ex)
            {
                // log
                return -1;
            }

        }
        public int deteleTable(string id)
        {
            try
            {
                string sql = "delete [BAN] where MaBan ='" + id + "'";
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
