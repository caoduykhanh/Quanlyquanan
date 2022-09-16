using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class BanDAO : GeneralDAO
    {
        private static BanDAO instance; // tao singleton
        public static BanDAO Instance 
        {
            get { if (instance == null) instance = new BanDAO(); return BanDAO.instance; } 
            private set {BanDAO.instance = value; }
        }
        public static int TableWidth =100;
        public static int TableHeight = 100;
        private BanDAO()
        {

        }
        public List<Ban> LoadTableList()
        {
            List<Ban> banlist = new List<Ban>();
            DataTable data = GeneralDAO.Instance.GetTable("PROC_GETBAN");
            foreach (DataRow item in data.Rows)
            {
                Ban ban = new Ban(item);
                banlist.Add(ban);
            }
            return banlist;
        }
    }
}
