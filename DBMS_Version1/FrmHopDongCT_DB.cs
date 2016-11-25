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
    public partial class FrmHopDongCT_DB : Form
    {
        BussinessHopDongCT_DB bact_db = new BussinessHopDongCT_DB();
        BussinessCauThu bact = new BussinessCauThu();
        BussinessDoiBong badb = new BussinessDoiBong();
        DataTable dshd = new DataTable();
        DataTable dsct = new DataTable();
        DataTable dsdb = new DataTable();

        public FrmHopDongCT_DB()
        {
            InitializeComponent();
        }

        public void DataBind()
        {
            dshd = bact_db.getHopDongCT_DB().Tables[0];
            dsct = bact.getCauThu().Tables[0];
            dsdb = badb.getDoiBong().Tables[0];

            MaCT.DataSource = dsct;
            MaCT.DisplayMember = "TenCT";
            MaCT.ValueMember = "MaCT";

            MaDoi.DataSource = dsdb;
            MaDoi.DisplayMember = "TenDoi";
            MaDoi.ValueMember = "MaDoi";
            //Load len data grid
            dgvHDCT.DataSource = dshd;


            //clear binding
            txtLuong.DataBindings.Clear();
            NgayBD.DataBindings.Clear();
            NgayKT.DataBindings.Clear();
            cmbMaCT.DataBindings.Clear();
            cmbMaDoi.DataBindings.Clear();
            //

            txtLuong.DataBindings.Add("Text", dshd, "Luong");
            NgayBD.DataBindings.Add("Text", dshd, "NgBatDauHD");
            NgayKT.DataBindings.Add("Text", dshd, "NgKetThucHD");
           

            cmbMaDoi.DataSource = dsdb;
            cmbMaDoi.DisplayMember = "TenDoi";
            cmbMaDoi.ValueMember = "MaDoi";
            cmbMaDoi.DataBindings.Add("SelectedValue", dshd, "MaDoi");

            cmbMaCT.DataSource = dsct;
            cmbMaCT.DisplayMember = "TenCT";
            cmbMaCT.ValueMember = "MaCT";
            cmbMaCT.DataBindings.Add("SelectedValue", dshd, "MaCT");
        }
        private void FrmHopDongCT_DB_Load(object sender, EventArgs e)
        {
            
            DataBind();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string err = "";
            if (!bact_db.ThemHopDongCT_DB(ref err,cmbMaDoi.SelectedValue.ToString(), cmbMaCT.SelectedValue.ToString(),
                NgayBD.Value,NgayKT.Value,decimal.Parse(txtLuong.Text.Trim())))
                MessageBox.Show(err);
            else DataBind();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string err = "";
            if (!bact_db.CapNhatHopDongCT_DB(ref err, cmbMaDoi.SelectedValue.ToString(), cmbMaCT.SelectedValue.ToString(),
          NgayBD.Value, NgayKT.Value, decimal.Parse(txtLuong.Text.Trim())))
                MessageBox.Show(err);
            else DataBind();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string err = "";
            if (!bact_db.XoaHopDongCT_DB(ref err, cmbMaDoi.SelectedValue.ToString(), cmbMaCT.SelectedValue.ToString(), NgayBD.Value))
                MessageBox.Show(err);
            else DataBind();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataBind();
        }
    }
}
