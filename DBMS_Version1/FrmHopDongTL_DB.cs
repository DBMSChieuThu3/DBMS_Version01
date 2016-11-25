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
    public partial class FrmHopDongTL_DB : Form
    {
        BussinessHopDongTL_DB batl_db = new BussinessHopDongTL_DB();
        BussinessTroLy batl = new BussinessTroLy();
        BussinessDoiBong badb = new BussinessDoiBong();
        DataTable dshd = new DataTable();
        DataTable dsntt = new DataTable();
        DataTable dsdb = new DataTable();

        public FrmHopDongTL_DB()
        {
            InitializeComponent();
        }

        public void DataBind()
        {
            dshd = batl_db.getHopDongTL_DB().Tables[0];
            dsntt = batl.getTroLi().Tables[0];
            dsdb = badb.getDoiBong().Tables[0];

            MaTL.DataSource = dsntt;
            MaTL.DisplayMember = "TenTL";
            MaTL.ValueMember = "MaTL";

            MaDoi.DataSource = dsdb;
            MaDoi.DisplayMember = "TenDoi";
            MaDoi.ValueMember = "MaDoi";
            //Load len data grid
            dgvTL.DataSource = dshd;


            //clear binding
            txtLuong.DataBindings.Clear();
            NgayBD.DataBindings.Clear();
            NgayKT.DataBindings.Clear();
            cmbTL.DataBindings.Clear();
            cmbMaDoi.DataBindings.Clear();
            //

            txtLuong.DataBindings.Add("Text", dshd, "Luong");
            NgayBD.DataBindings.Add("Text", dshd, "NgBatDauHD");
            NgayKT.DataBindings.Add("Text", dshd, "NgKetThucHD");


            cmbMaDoi.DataSource = dsdb;
            cmbMaDoi.DisplayMember = "TenDoi";
            cmbMaDoi.ValueMember = "MaDoi";
            cmbMaDoi.DataBindings.Add("SelectedValue", dshd, "MaDoi");

            cmbTL.DataSource = dsntt;
            cmbTL.DisplayMember = "TenTL";
            cmbTL.ValueMember = "MaTL";
            cmbTL.DataBindings.Add("SelectedValue", dshd, "MaTL");
        }
        private void FrmHopDongHLV_DB_Load(object sender, EventArgs e)
        {

            DataBind();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string err = "";
            if (!batl_db.ThemHopDongTL_DB(ref err, cmbMaDoi.SelectedValue.ToString(), cmbTL.SelectedValue.ToString(),
                NgayBD.Value, NgayKT.Value, decimal.Parse(txtLuong.Text.Trim())))
                MessageBox.Show(err);
            else DataBind();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string err = "";
            if (!batl_db.CapNhatHopDongTL_DB(ref err, cmbMaDoi.SelectedValue.ToString(), cmbTL.SelectedValue.ToString(),
          NgayBD.Value, NgayKT.Value, decimal.Parse(txtLuong.Text.Trim())))
                MessageBox.Show(err);
            else DataBind();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string err = "";
            if (!batl_db.XoaHopDongTL_CT(ref err, cmbMaDoi.SelectedValue.ToString(), cmbTL.SelectedValue.ToString(), NgayBD.Value))
                MessageBox.Show(err);
            else DataBind();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            DataBind();
        }
    }
}
