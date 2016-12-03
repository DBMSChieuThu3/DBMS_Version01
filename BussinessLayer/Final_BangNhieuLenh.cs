using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer
{
    public class Final_BangNhieuLenh
    {
        DALayer da = null;

        public Final_BangNhieuLenh()
        {
            da = new DALayer();
        }
        //Danh sách các tân binh cua đội bóng
        public DataSet DSTanBinhTheoThoiDiemCuaDoi(String MaDoi,DateTime ngay)
        {
            String date = ngay.ToString("MM-dd-yyyy");
            return da.ExecuteQueryDataSet("Select * From dbo.[funcB2_TanBinh]('" + MaDoi + "','" + date + "')",
               CommandType.Text, null);
        }
        public DataSet CauthuMoiDoiTheoMua()
        {
            return da.ExecuteQueryDataSet(" Select * From dbo.[funcB2_CTmoiDoitheoMua]()",
              CommandType.Text, null);
        }
        
        public DataSet DanhsachthanhvienDoiBong(String MaDoi, DateTime ngay)
        {
            String date = ngay.ToString("MM-dd-yyyy");
            return da.ExecuteQueryDataSet("Select * From dbo.[funcB2_DanhSachNhanVienDoi]('" + MaDoi + "','" + date + "')",
              CommandType.Text, null);
        }
    }
}
