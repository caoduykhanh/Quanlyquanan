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
    public class TableManagement
    {
        TableDAO taDao = new TableDAO();

        public DataSet viewTable()
        {
            return taDao.getAllTable();
        }
        public DataSet searchByName(string name)
        {
            return taDao.searchByName(name);
        }
        public SqlDataReader getDetails(string id)
        {
            return taDao.findById(id);
        }
        public int AddTable(Table tables)
        {
            // check validad
            return taDao.createTable(tables);
        }
        public int DeleteTable(string id)
        {
            // check validad
            return taDao.deteleTable(id);
        }
        public void closeConnection()
        {
            taDao.closeConnection();
        }
    }
}
