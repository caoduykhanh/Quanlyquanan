using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class LoaiMonDAO :GeneralDAO
    {
        public DataSet getAllMaLoai()
        {
            return getCatelogy("LoaiMon");
        }
        

    }
}
