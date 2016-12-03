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

namespace DBMS_Version1.DoiBong
{
    public partial class ChonDoi : Form
    {
        public string madoi="";
        public ChonDoi()
        {
            InitializeComponent();
        }

        private void btnTiep_Click(object sender, EventArgs e)
        {
            String madoi = cmbDoiBong.SelectedValue.ToString();
            DoiBong.Quanlydoibong.madoibong = madoi;

            (new DoiBong.Quanlydoibong()).ShowDialog();
            Dispose();
            
        }

        private void ChonDoi_Load(object sender, EventArgs e)
        {
            BussinessDoiBong badb = new BussinessDoiBong();
            DataTable dtdb = new DataTable();

            dtdb = badb.getDoiBong().Tables[0];

            cmbDoiBong.DataSource = dtdb;
            cmbDoiBong.DisplayMember = "TenDoi";
            cmbDoiBong.ValueMember = "MaDoi";
        }
    }
}
