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
using BussinessLayer;
namespace DBMS_Version1
{
    public partial class FrmCauThu : Form
    {
        BussinessCauThu bact = new BussinessCauThu();
        BussinessViTriSoTruong bavt = new BussinessViTriSoTruong();
        //Khai báo ds cầu thủ
        DataTable dsct = new DataTable();
        DataTable dsvt = new DataTable();
        
        public FrmCauThu()
        {
            
            InitializeComponent();
        }
        void DataBind()
        {
            dsct = bact.getCauThu().Tables[0];
            dsvt = bavt.getViTriSoTruong().Tables[0];

            MaVT.DataSource = dsvt;
            MaVT.DisplayMember = "TenViTri";
            MaVT.ValueMember = "MaVT";

            dgvCT.DataSource = dsct;
            //Load dữ liệu lên Vị trí sở trường
           


            txtMCT.DataBindings.Clear();
            txtTCT.DataBindings.Clear();
            NgaySinh.DataBindings.Clear();
            txtDC.DataBindings.Clear();
            txtSDT.DataBindings.Clear();
            cmbVTST.DataBindings.Clear();

           
            //binding
            txtMCT.DataBindings.Add("Text", dsct, "MaCT");
            txtTCT.DataBindings.Add("Text", dsct, "TenCT");
            NgaySinh.DataBindings.Add("Text", dsct, "NgSinh");
            txtDC.DataBindings.Add("Text", dsct, "DiaChi");
            txtSDT.DataBindings.Add("Text", dsct, "SoDT");
            
            //Load dữ liệu lên Vị trí sở trường
            cmbVTST.DataSource = dsvt;
            cmbVTST.DisplayMember = "TenViTri";
            cmbVTST.ValueMember = "MaVT";
            cmbVTST.DataBindings.Add("SelectedValue", dsct, "MaVT");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string err = "";
            if (!bact.ThemCauThu(ref err, txtMCT.Text.Trim(), txtTCT.Text.Trim(),
                NgaySinh.Value, txtDC.Text.Trim(), txtSDT.Text.Trim(), cmbVTST.SelectedValue.ToString()))
                MessageBox.Show(err);
            else DataBind();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string err = "";
            if (!bact.CapNhatCauThu(ref err, txtMCT.Text.Trim(), txtTCT.Text.Trim(),
                NgaySinh.Value, txtDC.Text.Trim(), txtSDT.Text.Trim(), cmbVTST.SelectedValue.ToString()))
                MessageBox.Show(err);
            else DataBind();
        }


        private void btnXoa_Click(object sender, EventArgs e)
        {
            string err = "";
            if (!bact.XoaCauThu(ref err, txtMCT.Text.Trim()))
                MessageBox.Show(err);
            else DataBind();
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void FrmCauThu_Load(object sender, EventArgs e)
        {
            DataBind();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataBind();
        }
    }
}
