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
    public partial class FrmHopDongBHL_DB : Form
    {
        BussinessHopDongBHL_DB baBHL_db = new BussinessHopDongBHL_DB();
        BussinessBanHL baBHL = new BussinessBanHL();
        BussinessDoiBong badb = new BussinessDoiBong();
        DataTable dshd = new DataTable();
        DataTable dsct = new DataTable();
        DataTable dsdb = new DataTable();

        public FrmHopDongBHL_DB()
        {
            InitializeComponent();
        }

        public void DataBind()
        {
            dshd = baBHL_db.getHopDongBHL_DB().Tables[0];
            dsct = baBHL.getBanHL().Tables[0];
            dsdb = badb.getDoiBong().Tables[0];

            MaBHL.DataSource = dsct;
            MaBHL.DisplayMember = "TenBHL";
            MaBHL.ValueMember = "MaBHL";

            MaDoi.DataSource = dsdb;
            MaDoi.DisplayMember = "TenDoi";
            MaDoi.ValueMember = "MaDoi";
            //Load len data grid
            dgvHDBHL.DataSource = dshd;


            //clear binding
            txtLuong.DataBindings.Clear();
            NgayBD.DataBindings.Clear();
            NgayKT.DataBindings.Clear();
            cmbMaBHL.DataBindings.Clear();
            cmbMaDoi.DataBindings.Clear();
            //

            txtLuong.DataBindings.Add("Text", dshd, "Luong");
            NgayBD.DataBindings.Add("Text", dshd, "NgBatDauHD");
            NgayKT.DataBindings.Add("Text", dshd, "NgKetThucHD");


            cmbMaDoi.DataSource = dsdb;
            cmbMaDoi.DisplayMember = "TenDoi";
            cmbMaDoi.ValueMember = "MaDoi";
            cmbMaDoi.DataBindings.Add("SelectedValue", dshd, "MaDoi");

            cmbMaBHL.DataSource = dsct;
            cmbMaBHL.DisplayMember = "TenBHL";
            cmbMaBHL.ValueMember = "MaBHL";
            cmbMaBHL.DataBindings.Add("SelectedValue", dshd, "MaBHL");
        }
        private void FrmHopDongBHL_DB_Load(object sender, EventArgs e)
        {

            DataBind();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string err = "";
            if (!baBHL_db.ThemHopDongBHL_DB(ref err, cmbMaDoi.SelectedValue.ToString(), cmbMaBHL.SelectedValue.ToString(),
                NgayBD.Value, NgayKT.Value, decimal.Parse(txtLuong.Text.Trim())))
                MessageBox.Show(err);
            else DataBind();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string err = "";
            if (!baBHL_db.CapNhatHopDongBHL_DB(ref err, cmbMaDoi.SelectedValue.ToString(), cmbMaBHL.SelectedValue.ToString(),
          NgayBD.Value, NgayKT.Value, decimal.Parse(txtLuong.Text.Trim())))
                MessageBox.Show(err);
            else DataBind();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string err = "";
            if (!baBHL_db.XoaHopDongBHL_DB(ref err, cmbMaDoi.SelectedValue.ToString(), cmbMaBHL.SelectedValue.ToString(), NgayBD.Value))
                MessageBox.Show(err);
            else DataBind();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
