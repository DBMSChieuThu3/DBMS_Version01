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
    public class BussinessHopDongTL_DB
    {
        DALayer dal = null;
        public BussinessHopDongTL_DB()
        {
            dal = new DALayer();
        }

        public DataSet getHopDongTL_DB()
        {
            return dal.ExecuteQueryDataSet("Select * From HopDongTL_DB ",
                CommandType.Text, null);
        }

        public bool ThemHopDongTL_DB(ref string err, string MaDoi, string MaTL,
            DateTime NgBatDauHD, DateTime NgKetThucHD, decimal Luong)
        {
            return dal.MyExecuteNonQuery("sp_Ins_HopDongTL_DB", CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaDoi", MaDoi),
                new SqlParameter("@MaTL", MaTL),
                new SqlParameter("@NgBatDauHD", NgBatDauHD),
                new SqlParameter("@NgKetThucHD", NgKetThucHD),
                new SqlParameter("@Luong", Luong));
        }

        public bool XoaHopDongTL_CT(ref string err, string MaDoi, string MaTL, DateTime NgBatDauHD)
        {
            return dal.MyExecuteNonQuery("sp_Delete_HopDongTL_DB",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaDoi", MaDoi),
                new SqlParameter("@MaTL", MaTL),
                new SqlParameter("@NgBatDauHD", NgBatDauHD));
        }

        public bool CapNhatHopDongTL_DB(ref string err, string MaDoi, string MaTL,
            DateTime NgBatDauHD, DateTime NgKetThucHD, decimal Luong)
        {
            return dal.MyExecuteNonQuery("sp_Update_HopDongTL_DB", CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaDoi", MaDoi),
                new SqlParameter("@MaTL", MaTL),
                new SqlParameter("@NgBatDauHD", NgBatDauHD),
                new SqlParameter("@NgKetThucHD", NgKetThucHD),
                new SqlParameter("@Luong", Luong));
        }
    }
}
