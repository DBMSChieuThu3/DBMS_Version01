using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DataAccessLayer;
namespace BussinessLayer
{
    public class BussinessDoiBong
    {
        DALayer dal ;
        public BussinessDoiBong()
        {
            dal = new DALayer();
        }

        public DataSet getDoiBong()
        {
            return dal.ExecuteQueryDataSet("Select * From DoiBong ",
                CommandType.Text, null);
        }

        public bool ThemDoiBong(ref string err, string MaDB, string TenDB,
            DateTime NgThanhLap, string MaTuoi)
        {
            return dal.MyExecuteNonQuery("sp_Ins_DB", CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaDB", MaDB),
                new SqlParameter("@TenDB", TenDB),
                new SqlParameter("@NgThanhLap", NgThanhLap),
                new SqlParameter("@MaTuoi", MaTuoi));
        }

        public bool XoaDoiBong(ref string err, string MaDB)
        {
            return dal.MyExecuteNonQuery("sp_Delete_DB",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaDB", MaDB));
        }

        public bool CapNhatDoiBong(ref string err, string MaDB, string TenDB,
            DateTime NgThanhLap, string MaTuoi)
        {
            return dal.MyExecuteNonQuery("sp_Update_DB", CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaDB", MaDB),
                new SqlParameter("@TenDB", TenDB),
                new SqlParameter("@NgThanhLap", NgThanhLap),
                new SqlParameter("@MaTuoi", MaTuoi));
        }
    }
}
