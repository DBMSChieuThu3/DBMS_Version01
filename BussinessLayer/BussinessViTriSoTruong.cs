using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using System.Data;
using System.Data.SqlClient;

namespace BussinessLayer
{
    public class BussinessViTriSoTruong
    {
        DALayer dal ;
        public BussinessViTriSoTruong()
        {
            dal = new DALayer();
        }

        public DataSet getViTriSoTruong()
        {
            return dal.ExecuteQueryDataSet("Select * From ViTri ",
                CommandType.Text, null);
        }

        public bool ThemLuaTuoi(ref string err, string MaVT, string TenViTri)
        {
            return dal.MyExecuteNonQuery("sp_Ins_ViTri", CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaVT", MaVT),
                new SqlParameter("@TenVT", TenViTri));
        }

        public bool XoaLuaTuoi(ref string err, string MaVT)
        {
            return dal.MyExecuteNonQuery("sp_Delete_ViTri",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaVT", MaVT));
        }

        public bool CapNhatLuaTuoi(ref string err, string MaVT, string TenViTri)
        {
            return dal.MyExecuteNonQuery("sp_Update_ViTri", CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaVT", MaVT),
                new SqlParameter("@TenVT", TenViTri));
        }

    }
}
