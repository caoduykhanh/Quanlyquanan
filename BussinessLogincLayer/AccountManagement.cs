using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
namespace BussinessLogincLayer
{
    public class AccountManagement
    {
        AccountDAO acDAO = new AccountDAO();
        public DataSet viewAccount()
        {
            return acDAO.getAllAccount();
        }
        public bool checkLogin(string username, string password)
        {
            return acDAO.checkLogin(username, password);
        }
        public int AddAccount(Account account)
        {
            // check validad
            return acDAO.createAccount(account);
        }
        public bool isExistUserName(string userName)
        {
            List<Account> lst = acDAO.getAllAccounts();
            foreach (Account acc in lst)
            {
                string userName_indb = acc.TaiKhoan;
                if (userName_indb == userName)
                {
                    return true;
                }

            }
            return false;
        }

        public void closeConnection()
        {

            acDAO.closeConnection();
        }


    }
}
