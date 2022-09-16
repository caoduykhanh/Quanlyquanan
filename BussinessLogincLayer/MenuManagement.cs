using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
namespace BussinessLogincLayer
{
    public class MenuManagement
    {
        MenusDAO meDao = new MenusDAO();
       
        public DataSet viewMenu()
        {
            return meDao.getAllMenu();
        }
        public DataSet searchByName(string name)
        {
            return meDao.searchByName(name);
        }
        public SqlDataReader getDetails(string id)
        {
            return meDao.findById(id);
        }
        public int AddMenu(Menus me)
        {
            // check validad
            return meDao.createMenu(me);
        }
        public int UpdateMenu(Menus me)
        {
            // check validad
            return meDao.updateMenu(me);
        }
        public int DeleteMenu(string id)
        {
            // check validad
            return meDao.deteleMenu(id);
        }
        public void closeConnection()
        {
            meDao.closeConnection();
        }
    }
}
