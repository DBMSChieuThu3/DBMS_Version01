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
    public partial class FrmHuanLuyenVien : Form
    {
        BussinessHLV bahlv = new BussinessHLV();
        //Khai báo ds cầu thủ
        DataTable dshlv = new DataTable();
    

        public FrmHuanLuyenVien()
        {

            InitializeComponent();
        }
        void DataBind()
        {
            dshlv = bahlv.getHLV().Tables[0];
            dgvHLV.DataSource = dshlv;
            //Load dữ liệu lên Vị trí sở trường



            txtMHLV.DataBindings.Clear();
            txtTHLV.DataBindings.Clear();
            NgaySinh.DataBindings.Clear();
            txtDC.DataBindings.Clear();
            txtSDT.DataBindings.Clear();


            //binding
            txtMHLV.DataBindings.Add("Text", dshlv, "MaHLV");
            txtTHLV.DataBindings.Add("Text", dshlv, "TenHLV");
            NgaySinh.DataBindings.Add("Text", dshlv, "NgSinh");
            txtDC.DataBindings.Add("Text", dshlv, "DiaChi");
            txtSDT.DataBindings.Add("Text", dshlv, "SoDT");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string err = "";
            if (!bahlv.ThemHLV(ref err, txtMHLV.Text.Trim(), txtTHLV.Text.Trim(),
                NgaySinh.Value, txtDC.Text.Trim(), txtSDT.Text.Trim()))
                MessageBox.Show(err);
            else DataBind();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string err = "";
            if (!bahlv.CapNhatHLV(ref err, txtMHLV.Text.Trim(), txtTHLV.Text.Trim(),
                NgaySinh.Value, txtDC.Text.Trim(), txtSDT.Text.Trim()))
                MessageBox.Show(err);
            else DataBind();
        }


        private void btnXoa_Click(object sender, EventArgs e)
        {
            string err = "";
            if (!bahlv.XoaHLV(ref err, txtMHLV.Text.Trim()))
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
