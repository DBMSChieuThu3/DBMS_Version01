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
    public class BussinessCauThu
    {
        DALayer dal = null;
        public BussinessCauThu()
        {
            dal = new DALayer();
        }

        public DataSet getCauThu()
        {
            return dal.ExecuteQueryDataSet("Select * From CauThu ",
                CommandType.Text, null);
        }

        public bool ThemCauThu(ref string err, string MaCT, string TenCT,
            DateTime NgSinh, string DiaChi, string SoDT, string ViTriST)
        {
            return dal.MyExecuteNonQuery("sp_Ins_CT", CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaCT", MaCT),
                new SqlParameter("@TenCT", TenCT),
                new SqlParameter("@NgSinh", NgSinh),
                new SqlParameter("@DiaChi", DiaChi),
                new SqlParameter("@SoDT", SoDT),
                new SqlParameter("@ViTriST", ViTriST));
        }

        public bool XoaCauThu(ref string err, string MaCT)
        {
            return dal.MyExecuteNonQuery("sp_Delete_CT",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaCT", MaCT));
        }

        public bool CapNhatCauThu(ref string err, string MaCT, string TenCT,
            DateTime NgSinh, string DiaChi, string SoDT, string ViTriST)
        {
            return dal.MyExecuteNonQuery("sp_Update_CT", CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaCT", MaCT),
                new SqlParameter("@TenCT", TenCT),
                new SqlParameter("@NgSinh", NgSinh),
                new SqlParameter("@DiaChi", DiaChi),
                new SqlParameter("@SoDT", SoDT),
                new SqlParameter("@ViTriST", ViTriST));
        }

    }
}

