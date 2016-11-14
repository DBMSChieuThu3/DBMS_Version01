using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DataAccessLayer;
using BussinessLayer;

namespace DBMS_Version1
{
    public partial class FrmNhaTaiTro : Form
    {
        BussinessNhaTaiTro db = new BussinessNhaTaiTro();
        DataSet dsNTT = new DataSet();
        public FrmNhaTaiTro()
        {
            InitializeComponent();
        }
        public void DanhSachNTT()
        {
            dsNTT = db.getNhaTaiTro();
            dgvNTT.DataSource = dsNTT.Tables[0];
        }

        private void FrmNhaTaiTro_Load(object sender, EventArgs e)
        {
            DanhSachNTT();
        }
    }
}
