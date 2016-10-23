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
    public class BussinessTuoi
    {
        DALayer dal = null;
        public BussinessTuoi()
        {
            dal = new DALayer();
        }

        public DataSet getTuoi()
        {
            return dal.ExecuteQueryDataSet("Select * From Tuoi ",
                CommandType.Text, null);
        }

        public bool ThemLuaTuoi(ref string err, string MaTuoi, int Tuoi)
        {
            return dal.MyExecuteNonQuery("sp_Ins_Tuoi", CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaTuoi", MaTuoi),
                new SqlParameter("@Tuoi", Tuoi));
        }

        public bool XoaLuaTuoi(ref string err, string MaTuoi)
        {
            return dal.MyExecuteNonQuery("sp_Delete_Tuoi",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaTuoi", MaTuoi));
        }

        public bool CapNhatLuaTuoi(ref string err, string MaTuoi, int Tuoi)
        {
            return dal.MyExecuteNonQuery("sp_Update_Tuoi", CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaTuoi", MaTuoi),
                new SqlParameter("@Tuoi", Tuoi));
        }
    }
}
