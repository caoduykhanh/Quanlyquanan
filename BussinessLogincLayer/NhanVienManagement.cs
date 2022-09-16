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
    public class NhanVienManagement
    {
        NhanVienDAO nvDao = new NhanVienDAO();
       
        public DataSet viewNhanVien()
        {
            return nvDao.getAllNhanVien();
           
        }
        public DataSet searchByName(string name)
        {
            return nvDao.searchByName(name);
        }
        public SqlDataReader getDetails(string id)
        {
            return nvDao.findById(id);
        }
        public int AddNhanVien(NhanVien nv)
        {
            // check validad
            return nvDao.createNhanVien(nv);
        }
        public int UpdateNhanVien(NhanVien nv)
        {
            // check validad
            return nvDao.updateNhanVien(nv);
        }
        public int DeleteNhanVien(string id)
        {
            // check validad
            return nvDao.deteleNhanVien(id);
        }
        public void closeConnection()
        {
            nvDao.closeConnection();
        }
       
    }
}
