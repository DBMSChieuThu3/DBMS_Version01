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
    public class Final_BangMotLenh
    {
        DALayer da = null;

        public Final_BangMotLenh()
        {
            da = new DALayer();
        }

        //Xuất ra danh sách tất cả các mùa giải từ thời điểm datatime
        public DataSet AllMuaGiai(DateTime ngay)
        {
            String date = ngay.ToString("MM-dd-yyyy");
            return da.ExecuteQueryDataSet("Select * From dbo.[funcBang_AllMuaGiai]('"+date+"')",
                CommandType.Text, null);
        }
        //Xuất ra danh sách cầu thủ theo mã vị trí
        public DataSet CauThuTheoViTri(String MaViTri)
        {
            
            return da.ExecuteQueryDataSet("Select * From dbo.[funcBang_DSCauThuTheoViTri]('" + MaViTri + "')",
                CommandType.Text, null);
        }
        //Danh sách cầu thủ sắp hết hạn hợp đồng theo Đội
        //public DataSet CauThuHetHanHDtheoDoi(String MaDoi)
        //{

        //    return da.ExecuteQueryDataSet("Select * From dbo.[funcBang_DSCTSapHetHan]('" + MaDoi + "')",
        //        CommandType.Text, null);
        //}
        //Danh sách chính xác số tuổi cầu thủ theo Mã Đội
        public DataSet TuoiCauThuNhapDoi(String MaDoi)
        {

            return da.ExecuteQueryDataSet("Select * From dbo.[funcBang_SoTuoiCauThu]('" + MaDoi + "')",
                CommandType.Text, null);
        }

        //Danh sách các cầu thủ có tuổi bé hơn ... 
        public DataSet TuoiCauThuNhapTuoi(int Tuoi)
        {

            return da.ExecuteQueryDataSet("Select * From dbo.[funcBang_TuoiCauThuNhapTuoi]('" + Tuoi.ToString() + "')",
                CommandType.Text, null);
        }
        //Danh sách luong cau thủ va thông tin còn lai của hợp đồng
        public DataSet Luong_ThoiGianHDCauThuTheoDoi(String MaDoi)
        {

            return da.ExecuteQueryDataSet("Select * From dbo.[funcBang_LuongCT_ThoiGianConLaiHopDong]('" + MaDoi + "')",
                CommandType.Text, null);
        }

        //Danh sách thành viên đội bóng và chức vụ
        public DataSet Danhsachnhanviendoi(String MaDoi,DateTime ngay)
        {
            String date = ngay.ToString("MM-dd-yyyy");
            return da.ExecuteQueryDataSet("Select * From dbo.[funcBang_DanhSachNhanVienDoi]('" + MaDoi + "','" + date + "')",
                CommandType.Text, null);
        }
        //Danh sách nhà tài trợ còn hợp đồng của đội
        public DataSet DanhSachNhaTaiTroTheoDoi(String MaDoi)
        {
            return da.ExecuteQueryDataSet("Select * From dbo.[funcBang_DSNTTTheoDoi]('" + MaDoi + "')",
                CommandType.Text, null);
        }
        //Lương năm của ban huấn luyên5
        public DataSet LuongNamCuaBHLtheoNgayCuThe(DateTime ngay)
        {
            String date = ngay.ToString("MM-dd-yyyy");
            return da.ExecuteQueryDataSet("Select * From dbo.[funcBang_LuongBHLTheoMuaGiai]('" + date + "')",
                CommandType.Text, null);
        }
    }
}
