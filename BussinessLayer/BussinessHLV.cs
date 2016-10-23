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
    public class BussinessHLV
    {
        DALayer dal = null;
        public BussinessHLV()
        {
            dal = new DALayer();
        }

        public DataSet getHLV()
        {
            return dal.ExecuteQueryDataSet("Select * From HLV ",
                CommandType.Text, null);
        }

        public bool ThemHLV(ref string err, string MaHLV, string TenHLV,
            DateTime NgSinh, string DiaChi, string SoDT)
        {
            return dal.MyExecuteNonQuery("sp_Ins_HLV", CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaHLV", MaHLV),
                new SqlParameter("@TenHLV", TenHLV),
                new SqlParameter("@NgSinh", NgSinh),
                new SqlParameter("@DiaChi", DiaChi),
                new SqlParameter("@SoDT", SoDT));
        }

        public bool XoaHLV(ref string err, string MaHLV)
        {
            return dal.MyExecuteNonQuery("sp_Delete_HLV",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaHLV", MaHLV));
        }

        public bool CapNhatHLV(ref string err, string MaHLV, string TenHLV,
            DateTime NgSinh, string DiaChi, string SoDT)
        {
            return dal.MyExecuteNonQuery("sp_Update_HLV", CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaHLV", MaHLV),
                new SqlParameter("@TenHLV", TenHLV),
                new SqlParameter("@NgSinh", NgSinh),
                new SqlParameter("@DiaChi", DiaChi),
                new SqlParameter("@SoDT", SoDT));
        }

    }
}

