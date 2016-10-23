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
    class BussinessHopDongNTT_DB
    {
        DALayer dal = null;
        public BussinessHopDongNTT_DB()
        {
            dal = new DALayer();
        }

        public DataSet getHopDongNTT_DB()
        {
            return dal.ExecuteQueryDataSet("Select * From HopDongNTT_DB ",
                CommandType.Text, null);
        }

        public bool ThemHopDongNTT_DB(ref string err, string MaDoi, string MaNTT,
            DateTime NgBatDauHD, string NgKetThucHD, decimal TienTaiTro)
        {
            return dal.MyExecuteNonQuery("sp_Ins_HopDongNTT_DB", CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaDoi", MaDoi),
                new SqlParameter("@MaNTT", MaNTT),
                new SqlParameter("@NgBatDauHD", NgBatDauHD),
                new SqlParameter("@NgKetThucHD", NgKetThucHD),
                new SqlParameter("@TienTaiTro", TienTaiTro));
        }

        public bool XoaHopDongNTT_CT(ref string err, string MaDoi, string MaNTT, DateTime NgBatDauHD)
        {
            return dal.MyExecuteNonQuery("sp_Delete_HopDongNTT_DB",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaDoi", MaDoi),
                new SqlParameter("@MaNTT", MaNTT),
                new SqlParameter("@NgBatDauHD", NgBatDauHD));
        }

        public bool CapNhatHopDongNTT_DB(ref string err, string MaDoi, string MaNTT,
            DateTime NgBatDauHD, string NgKetThucHD, decimal TienTaiTro)
        {
            return dal.MyExecuteNonQuery("sp_Update_HopDongNTT_DB", CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaDoi", MaDoi),
                new SqlParameter("@MaNTT", MaNTT),
                new SqlParameter("@NgBatDauHD", NgBatDauHD),
                new SqlParameter("@NgKetThucHD", NgKetThucHD),
                new SqlParameter("@TienTaiTro", TienTaiTro));
        }
    }
}
