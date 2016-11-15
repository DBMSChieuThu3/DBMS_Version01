using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using System.Data;

namespace BussinessLayer
{
    class BussinessViTriSoTruong
    {
        DALayer dal = null;
        public BussinessViTriSoTruong()
        {
            dal = new DALayer();
        }

        public DataSet getViTriSoTruong()
        {
            return dal.ExecuteQueryDataSet("Select * From ViTriSoTruong ",
                CommandType.Text, null);
        }

    }
}
