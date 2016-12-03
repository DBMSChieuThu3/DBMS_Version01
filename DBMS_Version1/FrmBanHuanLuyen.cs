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
    public partial class FrmBanHuanLuyen : Form
    {
        BussinessBanHL babhl = new BussinessBanHL();
        //Khai báo ds cầu thủ
        DataTable dsbhl = new DataTable();
        DataTable dslbanhl = new DataTable();
    

        public FrmBanHuanLuyen()
        {

            InitializeComponent();
        }
        void DataBind()
        {
            dsbhl = babhl.getBanHL().Tables[0];
            dslbanhl = babhl.getLoaiBanHL().Tables[0];

            MaLoai.DataSource = dslbanhl;
            MaLoai.ValueMember = "MaLoai";
            MaLoai.DisplayMember = "TenLoai";
            

            dgvBHL.DataSource = dsbhl;
            //Load dữ liệu lên Vị trí sở trường



            txtMBHL.DataBindings.Clear();
            txtTBHL.DataBindings.Clear();
            NgaySinh.DataBindings.Clear();
            txtDC.DataBindings.Clear();
            cboxLoai.DataBindings.Clear();


            //binding
            txtMBHL.DataBindings.Add("Text", dsbhl, "MaBHL");
            txtTBHL.DataBindings.Add("Text", dsbhl, "TenBHL");
            NgaySinh.DataBindings.Add("Text", dsbhl, "NgSinh");
            txtDC.DataBindings.Add("Text", dsbhl, "DiaChi");

            cboxLoai.DataSource = dslbanhl;
            cboxLoai.ValueMember = "MaLoai";
            cboxLoai.DisplayMember = "TenLoai";

            cboxLoai.DataBindings.Add("SelectedValue", dsbhl, "MaLoai");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string err = "";
            if (!babhl.ThemBanHL(ref err, txtMBHL.Text.Trim(), txtTBHL.Text.Trim(),
                NgaySinh.Value, txtDC.Text.Trim(), cboxLoai.SelectedValue.ToString()))
                MessageBox.Show(err);
            else DataBind();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string err = "";
            if (!babhl.CapNhatBanHL(ref err, txtMBHL.Text.Trim(), txtTBHL.Text.Trim(),
                NgaySinh.Value, txtDC.Text.Trim(), cboxLoai.SelectedValue.ToString()))
                MessageBox.Show(err);
            else DataBind();
        }


        private void btnXoa_Click(object sender, EventArgs e)
        {
            string err = "";
            if (!babhl.XoaBanHL(ref err, txtMBHL.Text.Trim()))
                MessageBox.Show(err);
            else DataBind();
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void FrmHuanLuyenVien_Load(object sender, EventArgs e)
        {
            DataBind();
        }

        private void btn_Reset(object sender, EventArgs e)
        {
            DataBind();
        }
    }
}
