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
    public class BussinessHopDongBHL_DB
    {
        
        DALayer dal = null;
        public BussinessHopDongBHL_DB()
        {
            dal = new DALayer();
        }

        public DataSet getHopDongBHL_DB()
        {
            return dal.ExecuteQueryDataSet("Select * From HopDongBHL_DB ",
                CommandType.Text, null);
        }

        public bool ThemHopDongBHL_DB(ref string err, string MaDoi, string MaBHL,
            DateTime NgBatDauHD, DateTime NgKetThucHD, decimal Luong)
        {
            return dal.MyExecuteNonQuery("sp_Ins_HopDongBHL_DB", CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaDoi", MaDoi),
                new SqlParameter("@MaBHL", MaBHL),
                new SqlParameter("@NgBatDauHD", NgBatDauHD),
                new SqlParameter("@NgKetThucHD", NgKetThucHD),
                new SqlParameter("@Luong", Luong));
        }

        public bool XoaHopDongBHL_DB(ref string err, string MaDoi, string MaBHL, DateTime NgBatDauHD)
        {
            return dal.MyExecuteNonQuery("sp_Delete_BHL_DB",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaDoi", MaDoi),
                new SqlParameter("@MaBHL", MaBHL),
                new SqlParameter("@NgBatDauHD", NgBatDauHD));
        }

        public bool CapNhatHopDongBHL_DB(ref string err, string MaDoi, string MaBHL,
            DateTime NgBatDauHD, DateTime NgKetThucHD, decimal Luong)
        {
            return dal.MyExecuteNonQuery("sp_Update_BHL_DB", CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaDoi", MaDoi),
                new SqlParameter("@MaBHL", MaBHL),
                new SqlParameter("@NgBatDauHD", NgBatDauHD),
                new SqlParameter("@NgKetThucHD", NgKetThucHD),
                new SqlParameter("@Luong", Luong));
        }
    }
}
