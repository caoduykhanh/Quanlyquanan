using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class PhieuDAO
    {
        private  static PhieuDAO instance;
        public static PhieuDAO Instance
        {
            get { if (instance == null) instance = new PhieuDAO(); return PhieuDAO.instance; }
           private set { PhieuDAO.instance = value; }
        }
        private PhieuDAO() { }
        public string GetUncheckBillIdByTableId(int id)
        {

            DataTable data = GeneralDAO.Instance.ExecuteQuery("select * from PHIEU Where MaBan = " + id + " AND Status = 0");

            if (data.Rows.Count > 0)
            {
                Phieu phieu = new Phieu(data.Rows[0]);
                return phieu.MaPhieu;

            }else
            {
                return null;
            }
           
        }
        public void InsertBill(int id )
        {
            GeneralDAO.Instance.ExecuteNonQuery("exec USP_InsertBill @MaBan", new object[] {id});
        }
        public string GetMaxIDBill()
        {
            try
            {
                 return (string)GeneralDAO.Instance.ExecuteScalar("select MAX(MaPhieu)From Phieu");
            }
            catch
            {
                return null;
            }
            
        }
    }
}
