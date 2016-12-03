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
        //Get đội bóng theo mã
        public DataSet getDoiBongTheoMa(String madoibong)
        {
            return dal.ExecuteQueryDataSet("Select * From DoiBong where MaDoi='"+madoibong+"'",
               CommandType.Text, null);
        }
        //get NTT còn hợp đồng theo mã Đôi
        public DataSet getNhaTaiTroTheoMa(String madoibong)
        {
            return dal.ExecuteQueryDataSet("select TenNTT,TienTaiTro from NhaTaiTro ntt, HopDongNTT_DB hd where ntt.MaNTT = hd.MaNTT " +
               " and MaDoi = '"+madoibong+"' and GETDATE() >= NgBatDauHD and GETDATE() <= NgKetThucHD",
               CommandType.Text, null);
        }
        //get BHL còn hợp đồng theo Mã ĐỘi
        public DataSet getBanHLTheoMa(String madoibong)
        {
            return dal.ExecuteQueryDataSet("select TenBHL,TenLoai from BanHL bhl,HopDongBHL_DB hd,LoaiBanHuanLuyen loai "+
            " where loai.MaLoai = bhl.MaLoai and bhl.MaBHL = hd.MaBHL and MaDoi = '" + madoibong + "' and GETDATE() >= NgBatDauHD and GETDATE() <= NgKetThucHD",
               CommandType.Text, null);
        }

        //Get Cầu thủ còn hợp đồng theo mã Đội
        public DataSet getCauThuTheoMa(String madoibong)
        {
            return dal.ExecuteQueryDataSet("select TenCT,vt.MaVT,TenVT from CauThu ct,HopDongCT_DB hd,ViTri vt" +
            " where vt.MaVT=ct.MaVT and ct.MaCT = hd.MaCT and MaDoi = '" + madoibong + "' and GETDATE() >= NgBatDauHD and GETDATE() <= NgKetThucHD",
                CommandType.Text, null);
        }

        public bool ThemDoiBong(ref string err, string MaDoi, string TenDoi,
            DateTime NgayThanhLap, string MaTuoi)
        {
            return dal.MyExecuteNonQuery("sp_Ins_DB", CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaDoi", MaDoi),
                new SqlParameter("@TenDoi", TenDoi),
                new SqlParameter("@NgayThanhLap", NgayThanhLap),
                new SqlParameter("@MaTuoi", MaTuoi));
        }

        public bool XoaDoiBong(ref string err, string MaDoi)
        {
            return dal.MyExecuteNonQuery("sp_Delete_DB",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaDoi", MaDoi));
        }

        public bool CapNhatDoiBong(ref string err, string MaDoi, string TenDoi,
            DateTime NgayThanhLap, string MaTuoi)
        {
            return dal.MyExecuteNonQuery("sp_Update_DB", CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaDoi", MaDoi),
                new SqlParameter("@TenDoi", TenDoi),
                new SqlParameter("@NgayThanhLap", NgayThanhLap),
                new SqlParameter("@MaTuoi", MaTuoi));
        }


    }
}
