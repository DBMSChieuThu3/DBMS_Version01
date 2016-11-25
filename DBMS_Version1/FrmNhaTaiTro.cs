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
        BussinessNhaTaiTro bantt = new BussinessNhaTaiTro();
        DataTable dsNTT = new DataTable();
        public FrmNhaTaiTro()
        {
            InitializeComponent();
        }
        public void DataBind()
        {
            dsNTT = bantt.getNhaTaiTro().Tables[0];


            //Load len data grid
            dgvNTT.DataSource = dsNTT;


            //clear binding
            txtMNTT.DataBindings.Clear();
            txtTNTT.DataBindings.Clear();
            txtDC.DataBindings.Clear();
            txtSDT.DataBindings.Clear();

            //
            txtMNTT.DataBindings.Add("Text", dsNTT, "MaNTT");
            txtTNTT.DataBindings.Add("Text", dsNTT, "TenNTT");
            txtDC.DataBindings.Add("Text", dsNTT, "DiaChi");
            txtSDT.DataBindings.Add("Text", dsNTT, "SoDT");
        }

        private void FrmNhaTaiTro_Load(object sender, EventArgs e)
        {
            DataBind();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string err = "";
            if (!bantt.ThemNhaTaiTro(ref err, txtMNTT.Text.Trim(), txtTNTT.Text.Trim(),
                txtDC.Text.Trim(), txtSDT.Text.Trim()))
                MessageBox.Show(err);
            else DataBind();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string err = "";
            if (!bantt.CapNhatNTT(ref err, txtMNTT.Text.Trim(), txtTNTT.Text.Trim(),
                txtDC.Text.Trim(), txtSDT.Text.Trim()))
                MessageBox.Show(err);
            else DataBind();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string err = "";
            if (!bantt.XoaNhaTaiTro(ref err, txtMNTT.Text.Trim()))
                MessageBox.Show(err);
            else DataBind();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
