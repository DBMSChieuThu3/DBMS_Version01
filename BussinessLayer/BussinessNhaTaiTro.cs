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
    public class BussinessNhaTaiTro
    {
        DALayer dal = null;
        public BussinessNhaTaiTro()
        {
            dal = new DALayer();
        }

        public DataSet getNhaTaiTro()
        {
            return dal.ExecuteQueryDataSet("Select * From NhaTaiTro ",
                CommandType.Text, null);
        }

        public bool ThemNhaTaiTro(ref string err, string MaNTT, string TenNTT,
             string DiaChi, string SoDT)
        {
            return dal.MyExecuteNonQuery("sp_Ins_NhaTaiTro", CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaNTT", MaNTT),
                new SqlParameter("@TenNTT", TenNTT),
                new SqlParameter("@DiaChi", DiaChi),
                new SqlParameter("@SoDT", SoDT));
        }

        public bool XoaNhaTaiTro(ref string err, string MaNTT)
        {
            return dal.MyExecuteNonQuery("sp_Delete_NTT",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaNTT", MaNTT));
        }

        public bool CapNhatNTT(ref string err, string MaNTT, string TenNTT,
             string DiaChi, string SoDT)
        {
            return dal.MyExecuteNonQuery("sp_Update_NhaTaiTro", CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaNTT", MaNTT),
                new SqlParameter("@TenNTT", TenNTT),
                new SqlParameter("@DiaChi", DiaChi),
                new SqlParameter("@SoDT", SoDT));
        }
    }
}
