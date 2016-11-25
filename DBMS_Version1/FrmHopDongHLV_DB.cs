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
    public partial class FrmHopDongHLV_DB : Form
    {
        BussinessHopDongHLV_DB bahlv_db = new BussinessHopDongHLV_DB();
        BussinessHLV bahlv = new BussinessHLV();
        BussinessDoiBong badb = new BussinessDoiBong();
        DataTable dshd = new DataTable();
        DataTable dsct = new DataTable();
        DataTable dsdb = new DataTable();

        public FrmHopDongHLV_DB()
        {
            InitializeComponent();
        }

        public void DataBind()
        {
            dshd = bahlv_db.getHopDongHLV_DB().Tables[0];
            dsct = bahlv.getHLV().Tables[0];
            dsdb = badb.getDoiBong().Tables[0];

            MaHLV.DataSource = dsct;
            MaHLV.DisplayMember = "TenHLV";
            MaHLV.ValueMember = "MaHLV";

            MaDoi.DataSource = dsdb;
            MaDoi.DisplayMember = "TenDoi";
            MaDoi.ValueMember = "MaDoi";
            //Load len data grid
            dgvHDHLV.DataSource = dshd;


            //clear binding
            txtLuong.DataBindings.Clear();
            NgayBD.DataBindings.Clear();
            NgayKT.DataBindings.Clear();
            cmbMaHLV.DataBindings.Clear();
            cmbMaDoi.DataBindings.Clear();
            //

            txtLuong.DataBindings.Add("Text", dshd, "Luong");
            NgayBD.DataBindings.Add("Text", dshd, "NgBatDauHD");
            NgayKT.DataBindings.Add("Text", dshd, "NgKetThucHD");


            cmbMaDoi.DataSource = dsdb;
            cmbMaDoi.DisplayMember = "TenDoi";
            cmbMaDoi.ValueMember = "MaDoi";
            cmbMaDoi.DataBindings.Add("SelectedValue", dshd, "MaDoi");

            cmbMaHLV.DataSource = dsct;
            cmbMaHLV.DisplayMember = "TenHLV";
            cmbMaHLV.ValueMember = "MaHLV";
            cmbMaHLV.DataBindings.Add("SelectedValue", dshd, "MaHLV");
        }
        private void FrmHopDongHLV_DB_Load(object sender, EventArgs e)
        {

            DataBind();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string err = "";
            if (!bahlv_db.ThemHopDongHLV_DB(ref err, cmbMaDoi.SelectedValue.ToString(), cmbMaHLV.SelectedValue.ToString(),
                NgayBD.Value, NgayKT.Value, decimal.Parse(txtLuong.Text.Trim())))
                MessageBox.Show(err);
            else DataBind();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string err = "";
            if (!bahlv_db.CapNhatHopDongHLV_DB(ref err, cmbMaDoi.SelectedValue.ToString(), cmbMaHLV.SelectedValue.ToString(),
          NgayBD.Value, NgayKT.Value, decimal.Parse(txtLuong.Text.Trim())))
                MessageBox.Show(err);
            else DataBind();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string err = "";
            if (!bahlv_db.XoaHopDongHLV_CT(ref err, cmbMaDoi.SelectedValue.ToString(), cmbMaHLV.SelectedValue.ToString(), NgayBD.Value))
                MessageBox.Show(err);
            else DataBind();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
