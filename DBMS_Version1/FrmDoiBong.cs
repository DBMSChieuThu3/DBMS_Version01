using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BussinessLayer;

namespace DBMS_Version1
{
    public partial class FrmDoiBong : Form
    {
        BussinessDoiBong badb = new BussinessDoiBong();
        Bus
        DataTable dsdb = new DataTable();

        public FrmDoiBong()
        {
            InitializeComponent();
        }
        public void DataBind()
        {
            dsdb = badb.getDoiBong().Tables[0];

            //clear binding
            txtMDB.DataBindings.Clear();
            txtTDB.DataBindings.Clear();
            NgayTL.DataBindings.Clear();
            cmbMT.DataBindings.Clear();
            //
            txtMDB.DataBindings.Add("Text", dsdb, "MaDoi");
        }
        private void FrmDoiBong_Load(object sender, EventArgs e)
        {
            DataBind();
        }
    }
}
