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
    public partial class FrmHopDongNTT_DB : Form
    {
        BussinessHopDongNTT_DB bantt_db = new BussinessHopDongNTT_DB();
        BussinessNhaTaiTro bantt = new BussinessNhaTaiTro();
        BussinessDoiBong badb = new BussinessDoiBong();
        DataTable dshd = new DataTable();
        DataTable dsntt = new DataTable();
        DataTable dsdb = new DataTable();

        public FrmHopDongNTT_DB()
        {
            InitializeComponent();
        }

        public void DataBind()
        {
            dshd = bantt_db.getHopDongNTT_DB().Tables[0];
            dsntt = bantt.getNhaTaiTro().Tables[0];
            dsdb = badb.getDoiBong().Tables[0];

            MaNTT.DataSource = dsntt;
            MaNTT.DisplayMember = "TenNTT";
            MaNTT.ValueMember = "MaNTT";

            MaDoi.DataSource = dsdb;
            MaDoi.DisplayMember = "TenDoi";
            MaDoi.ValueMember = "MaDoi";
            //Load len data grid
            dgvHDNTT.DataSource = dshd;


            //clear binding
            txtTienTaiTro.DataBindings.Clear();
            NgayBD.DataBindings.Clear();
            NgayKT.DataBindings.Clear();
            cmbNTT.DataBindings.Clear();
            cmbMaDoi.DataBindings.Clear();
            //

            txtTienTaiTro.DataBindings.Add("Text", dshd, "TienTaiTro");
            NgayBD.DataBindings.Add("Text", dshd, "NgBatDauHD");
            NgayKT.DataBindings.Add("Text", dshd, "NgKetThucHD");


            cmbMaDoi.DataSource = dsdb;
            cmbMaDoi.DisplayMember = "TenDoi";
            cmbMaDoi.ValueMember = "MaDoi";
            cmbMaDoi.DataBindings.Add("SelectedValue", dshd, "MaDoi");

            cmbNTT.DataSource = dsntt;
            cmbNTT.DisplayMember = "TenNTT";
            cmbNTT.ValueMember = "MaNTT";
            cmbNTT.DataBindings.Add("SelectedValue", dshd, "MaNTT");
        }
        private void FrmHopDongHLV_DB_Load(object sender, EventArgs e)
        {

            DataBind();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string err = "";
            if (!bantt_db.ThemHopDongNTT_DB(ref err, cmbMaDoi.SelectedValue.ToString(), cmbNTT.SelectedValue.ToString(),
                NgayBD.Value, NgayKT.Value, decimal.Parse(txtTienTaiTro.Text.Trim())))
                MessageBox.Show(err);
            else DataBind();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string err = "";
            if (!bantt_db.CapNhatHopDongNTT_DB(ref err, cmbMaDoi.SelectedValue.ToString(), cmbNTT.SelectedValue.ToString(),
          NgayBD.Value, NgayKT.Value, decimal.Parse(txtTienTaiTro.Text.Trim())))
                MessageBox.Show(err);
            else DataBind();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string err = "";
            if (!bantt_db.XoaHopDongNTT_CT(ref err, cmbMaDoi.SelectedValue.ToString(), cmbNTT.SelectedValue.ToString(), NgayBD.Value))
                MessageBox.Show(err);
            else DataBind();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
