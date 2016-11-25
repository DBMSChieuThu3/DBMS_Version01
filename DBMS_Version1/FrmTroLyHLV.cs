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
    public partial class FrmTroLyHLV : Form
    {
        BussinessTroLy batl = new BussinessTroLy();
        DataTable dstl = new DataTable();
        public FrmTroLyHLV()
        {
            InitializeComponent();
        }
        public void DataBind()
        {
            dstl = batl.getTroLi().Tables[0];


            //Load len data grid
            dgvTLHLV.DataSource = dstl;


            //clear binding
            txtMTL.DataBindings.Clear();
            txtTTL.DataBindings.Clear();
            txtDC.DataBindings.Clear();
            NgaySinh.DataBindings.Clear();
            txtSDT.DataBindings.Clear();

            //
            txtMTL.DataBindings.Add("Text", dstl, "MaTL");
            txtTTL.DataBindings.Add("Text", dstl, "TenTL");
            NgaySinh.DataBindings.Add("Text", dstl, "NgSinh");
            txtDC.DataBindings.Add("Text", dstl, "DiaChi");
            txtSDT.DataBindings.Add("Text", dstl, "SoDT");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string err = "";
            if (!batl.ThemTroLi(ref err, txtMTL.Text.Trim(), txtTTL.Text.Trim(),NgaySinh.Value,
                txtDC.Text.Trim(), txtSDT.Text.Trim()))
                MessageBox.Show(err);
            else DataBind();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string err = "";
            if (!batl.CapNhatTroLi(ref err, txtMTL.Text.Trim(), txtTTL.Text.Trim(), NgaySinh.Value,
                txtDC.Text.Trim(), txtSDT.Text.Trim()))
                MessageBox.Show(err);
            else DataBind();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string err = "";
            if (!batl.XoaTroLi(ref err, txtMTL.Text.Trim()))
                MessageBox.Show(err);
            else DataBind();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmTroLyHLV_Load(object sender, EventArgs e)
        {
            DataBind();
        }
    }
}
