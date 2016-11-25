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
        BussinessTuoi batuoi = new BussinessTuoi();
        DataTable dsdb = new DataTable();
        DataTable dstuoi = new DataTable();
       

        public FrmDoiBong()
        {
            InitializeComponent();
        }
        public void DataBind()
        {
            dsdb = badb.getDoiBong().Tables[0];
            dstuoi = batuoi.getTuoi().Tables[0];
            //Load len data grid
            MaTuoi.DataSource = dstuoi;
            MaTuoi.DisplayMember = "Tuoi";
            MaTuoi.ValueMember = "MaTuoi";

            dgvDB.DataSource = dsdb;


            //clear binding
            txtMDB.DataBindings.Clear();
            txtTDB.DataBindings.Clear();
            NgayTL.DataBindings.Clear();
            cmbMT.DataBindings.Clear();

            //
            txtMDB.DataBindings.Add("Text", dsdb, "MaDoi");
            txtTDB.DataBindings.Add("Text", dsdb, "TenDoi");
            NgayTL.DataBindings.Add("Text", dsdb, "NgayThanhLap");

            cmbMT.DataSource = dstuoi;
            cmbMT.DisplayMember = "Tuoi";
            cmbMT.ValueMember = "MaTuoi";
            cmbMT.DataBindings.Add("SelectedValue", dsdb, "MaTuoi");
        }
        private void FrmDoiBong_Load(object sender, EventArgs e)
        {
            DataBind();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string err = "";
            if (!badb.ThemDoiBong(ref err, txtMDB.Text.Trim(), txtTDB.Text.Trim(),
                NgayTL.Value,cmbMT.SelectedValue.ToString() ))
                MessageBox.Show(err);
            else DataBind();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string err = "";
            if (!badb.CapNhatDoiBong(ref err, txtMDB.Text.Trim(), txtTDB.Text.Trim(),
                NgayTL.Value, cmbMT.SelectedValue.ToString()))
                MessageBox.Show(err);
            else DataBind();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string err = "";
            if (!badb.XoaDoiBong(ref err, txtMDB.Text.Trim()))
                MessageBox.Show(err);
            else DataBind();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
