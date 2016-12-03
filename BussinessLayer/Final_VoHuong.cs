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
    public class Final_VoHuong
    {
        DALayer dal = null;

        public Final_VoHuong()
        {
            dal = new DALayer();
        }
        //Nhập mã cầu thủ cho biết Mức lương cầu thủ đó tại thời điểm
        public String LuongCauThu(String MaCauThu, DateTime ngay)
        {
            String date = ngay.ToString("MM-dd-yyyy");
            return dal.ExecuteQueryDataSet2("select dbo.funcVH_LuongCauThu('" + MaCauThu + "','" + date + "')",
                CommandType.Text, null);
        }
        //Nhập thời điểm cho biết mùa giải hiện tại
        public String MuaGiai(DateTime ngay)
        {
            String date = ngay.ToString("MM-dd-yyyy");
            return dal.ExecuteQueryDataSet2("select dbo.[funcVH_MuaGiai]('" + date + "')",
                CommandType.Text, null);
        }
        //Nhập mã đội cho 1 câu nhân xét Tài chính của đội này
        public String NhanXetTaiChinh(String MaDoi)
        {
            
            return dal.ExecuteQueryDataSet2("select dbo.[funcVH_NhanXetTaiChinh]('" + MaDoi + "')",
                CommandType.Text, null);
        }

        //Nhập mã đội cho biết số lượng cầu thủ sắp hết hạn: HĐ < 30 ngày
        public String SoCTSapHetHanHD(String MaDoi)
        {

            return dal.ExecuteQueryDataSet2("select dbo.[funcVH_SoCTGanHetHan]('" + MaDoi + "')",
                CommandType.Text, null);
        }
        //Nhập mã đội , thời điểm -> Số lượng cầu thủ của đôi tại thời điểm
        public String SoCTTaiThoiDiem(String MaDoi,DateTime ngay)
        {
            String date = ngay.ToString("MM-dd-yyyy");
            return dal.ExecuteQueryDataSet2("select dbo.[funcVH_SoLuongCauThuDoiBong]('" + MaDoi + "','" + date + "')",
                CommandType.Text, null);
        }
        //Nhập mã BHL cho ra tên BHL
        public String TenBHLTheoMa(String MaCT)
        {

            return dal.ExecuteQueryDataSet2("select dbo.[funcVH_TenBanHL]('" + MaCT + "')",
                CommandType.Text, null);
        }

        //Nhập mã Đội cho ra tuổi của đội
        public String TuoiDoiTheoMa(String MaDoi)
        {

            return dal.ExecuteQueryDataSet2("select dbo.[funcVH_TuoiDoi]('" + MaDoi + "')",
                CommandType.Text, null);
        }
        //Nhập mã CT cho ra Vị trí cầu thủ đó sở trường
        public String ViTriTheoMaCauThu(String MaCT)
        {

            return dal.ExecuteQueryDataSet2("select dbo.[funcVH_ViTriCauThu]('" + MaCT + "')",
                CommandType.Text, null);
        }
    }
}
