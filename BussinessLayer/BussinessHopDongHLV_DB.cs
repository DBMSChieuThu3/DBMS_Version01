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
    public class BussinessHopDongHLV_DB
    {
        DALayer dal = null;
        public BussinessHopDongHLV_DB()
        {
            dal = new DALayer();
        }

        public DataSet getHopDongHLV_DB()
        {
            return dal.ExecuteQueryDataSet("Select * From HopDongHLV_DB ",
                CommandType.Text, null);
        }

        public bool ThemHopDongHLV_DB(ref string err, string MaDoi, string MaHLV,
            DateTime NgBatDauHD, string NgKetThucHD, decimal Luong)
        {
            return dal.MyExecuteNonQuery("sp_Ins_HopDongHLV_DB", CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaDoi", MaDoi),
                new SqlParameter("@MaHLV", MaHLV),
                new SqlParameter("@NgBatDauHD", NgBatDauHD),
                new SqlParameter("@NgKetThucHD", NgKetThucHD),
                new SqlParameter("@Luong", Luong));
        }

        public bool XoaHopDongHLV_CT(ref string err, string MaDoi, string MaHLV, DateTime NgBatDauHD)
        {
            return dal.MyExecuteNonQuery("sp_Delete_HopDongHLV_DB",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaDoi", MaDoi),
                new SqlParameter("@MaHLV", MaHLV),
                new SqlParameter("@NgBatDauHD", NgBatDauHD));
        }

        public bool CapNhatHopDongHLV_DB(ref string err, string MaDoi, string MaHLV,
            DateTime NgBatDauHD, string NgKetThucHD, decimal Luong)
        {
            return dal.MyExecuteNonQuery("sp_Update_HopDongHLV_DB", CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaDoi", MaDoi),
                new SqlParameter("@MaHLV", MaHLV),
                new SqlParameter("@NgBatDauHD", NgBatDauHD),
                new SqlParameter("@NgKetThucHD", NgKetThucHD),
                new SqlParameter("@Luong", Luong));
        }
    }
}
