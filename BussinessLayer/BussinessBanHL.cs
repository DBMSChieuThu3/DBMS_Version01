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
    public class BussinessBanHL
    {
        DALayer dal = null;
        public BussinessBanHL()
        {
            dal = new DALayer();
        }

        public DataSet getLoaiBanHL()
        {
            return dal.ExecuteQueryDataSet("Select * From LoaiBanHuanLuyen ",
                CommandType.Text, null);
        }
        public DataSet getBanHL()
        {
            return dal.ExecuteQueryDataSet("Select * From BanHL ",
                CommandType.Text, null);
        }

        public bool ThemBanHL(ref string err, string MaBHL, string TenBHL,
            DateTime NgSinh, string DiaChi, string MaLoai)
        {
            return dal.MyExecuteNonQuery("sp_Ins_BHL", CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaBHL", MaBHL),
                new SqlParameter("@TenBHL", TenBHL),
                new SqlParameter("@NgSinh", NgSinh),
                new SqlParameter("@DiaChi", DiaChi),
                new SqlParameter("@MaLoai", MaLoai));
        }

        public bool XoaBanHL(ref string err, string MaBHL)
        {
            return dal.MyExecuteNonQuery("sp_Delete_BHL",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaBHL", MaBHL));
        }

        public bool CapNhatBanHL(ref string err, string MaBHL, string TenBHL,
            DateTime NgSinh, string DiaChi, string MaLoai)
        {
            return dal.MyExecuteNonQuery("sp_Update_BanHL", CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaBHL", MaBHL),
                new SqlParameter("@TenBHL", TenBHL),
                new SqlParameter("@NgSinh", NgSinh),
                new SqlParameter("@DiaChi", DiaChi),
                new SqlParameter("@MaLoai", MaLoai));
        }

    }
}

