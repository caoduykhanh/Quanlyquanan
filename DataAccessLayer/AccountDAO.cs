using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class AccountDAO : GeneralDAO

    {
        public DataSet getAllAccount()
        {
            return getAll("Account");
        }
        public List<Account> getAllAccounts()
        {
            List<Account> lst = new List<Account>();

            DataSet ds = getAll("Account");
            DataTable dt = ds.Tables[0];
            foreach (DataRow dr in dt.Rows)
            {
                Account acc = new Account()
                {

                    ID = dr["ID"].ToString(),
                    TaiKhoan= dr["TaiKhoan"].ToString(),
                    MatKhau = dr["MatKhau"].ToString(),
                    ChucVu = dr["ChucVu"].ToString(),
                    MaNV = dr["ChucVu"].ToString()

                };
                lst.Add(acc);
            }

            return lst;

        }
        public bool checkLogin(string username, string password)
        {
            getConnection();
            SqlDataReader dr = findById("Account", "TaiKhoan='" + username + "' and MatKhau='" + password + "'");
            if (dr.Read())
            {
                closeConnection();
                return true;
            }
            else
            {
                closeConnection();
                return false;
            }
        }
        public int createAccount(Account account)
        {
            try
            {

                string sql = string.Format("insert [Account] " +
                                    "                      values('{0}','{1}','{2}','{3}','{4}')",
                                                          account.ID,account.TaiKhoan,account.MatKhau,account.ChucVu,account.MaNV);


                return insert_update_Delete(sql); // -1 if error


            }
            catch (Exception ex)
            {
                // log
                return -1;
            }

        }


    }
}
