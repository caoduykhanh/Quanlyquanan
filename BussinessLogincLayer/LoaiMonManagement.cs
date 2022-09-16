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
   public class LoaiMonManagement
    {
        LoaiMonDAO MLDao = new LoaiMonDAO();

        public DataSet viewMaLoai()
        {
            return MLDao.getAllMaLoai();
        }
       
        public void closeConnection()
        {
            MLDao.closeConnection();
        }
        
    }
}
