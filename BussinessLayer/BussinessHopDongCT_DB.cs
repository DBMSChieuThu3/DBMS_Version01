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
    public class BussinessHopDongCT_DB
    {
        DALayer dal = null;
        public BussinessHopDongCT_DB()
        {
            dal = new DALayer();
        }

        public DataSet getHopDongCT_DB()
        {
            return dal.ExecuteQueryDataSet("Select * From HopDongCT_DB ",
                CommandType.Text, null);
        }

        public bool ThemHopDongCT_DB(ref string err, string MaDoi, string MaCT,
            DateTime NgBatDauHD, DateTime NgKetThucHD, decimal Luong)
        {
            return dal.MyExecuteNonQuery("sp_Ins_HopDongCT_DB", CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaDoi", MaDoi),
                new SqlParameter("@MaCT", MaCT),
                new SqlParameter("@NgBatDauHD", NgBatDauHD),
                new SqlParameter("@NgKetThucHD", NgKetThucHD),
                new SqlParameter("@Luong", Luong));
        }

        public bool XoaHopDongCT_DB(ref string err, string MaDoi, string MaCT, DateTime NgBatDauHD)
        {
            return dal.MyExecuteNonQuery("sp_Delete_CT_DB",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaDoi", MaDoi),
                new SqlParameter("@MaCT", MaCT),
                new SqlParameter("@NgBatDauHD", NgBatDauHD));
        }

        public bool CapNhatHopDongCT_DB(ref string err, string MaDoi, string MaCT,
            DateTime NgBatDauHD, DateTime NgKetThucHD, decimal Luong)
        {
            return dal.MyExecuteNonQuery("sp_Update_CT_DB", CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaDoi", MaDoi),
                new SqlParameter("@MaCT", MaCT),
                new SqlParameter("@NgBatDauHD", NgBatDauHD),
                new SqlParameter("@NgKetThucHD", NgKetThucHD),
                new SqlParameter("@Luong", Luong));
        }
    }
}
