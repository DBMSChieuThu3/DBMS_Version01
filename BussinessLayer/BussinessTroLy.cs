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
    public class BussinessTroLy
    {
        DALayer dal = null;
        public BussinessTroLy()
        {
            dal = new DALayer();
        }

        public DataSet getTroLi()
        {
            return dal.ExecuteQueryDataSet("Select * From TroLi ",
                CommandType.Text, null);
        }

        public bool ThemTroLi(ref string err, string MaTL, string TenTL,
            DateTime NgSinh, string DiaChi, string SoDT)
        {
            return dal.MyExecuteNonQuery("sp_Ins_TroLi", CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaTL", MaTL),
                new SqlParameter("@TenTL", TenTL),
                new SqlParameter("@NgSinh", NgSinh),
                new SqlParameter("@DiaChi", DiaChi),
                new SqlParameter("@SoDT", SoDT));
        }

        public bool XoaTroLi(ref string err, string MaTL)
        {
            return dal.MyExecuteNonQuery("sp_Delete_TL",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaTL", MaTL));
        }

        public bool CapNhatTroLi(ref string err, string MaTL, string TenTL,
            DateTime NgSinh, string DiaChi, string SoDT)
        {
            return dal.MyExecuteNonQuery("sp_Update_TroLi", CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaTL", MaTL),
                new SqlParameter("@TenTL", TenTL),
                new SqlParameter("@NgSinh", NgSinh),
                new SqlParameter("@DiaChi", DiaChi),
                new SqlParameter("@SoDT", SoDT));
        }

    }
}
