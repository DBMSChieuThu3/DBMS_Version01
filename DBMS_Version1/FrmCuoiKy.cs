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
    public partial class FrmCuoiKy : Form
    {
        Final_VoHuong final = new Final_VoHuong();
        BussinessCauThu bact = new BussinessCauThu();
        DataTable dtct = new DataTable();
        DataTable dtct2 = new DataTable();
        BussinessBanHL babhl = new BussinessBanHL();
        DataTable dtbhl = new DataTable();
        BussinessDoiBong badb = new BussinessDoiBong();
        BussinessViTriSoTruong bavt = new BussinessViTriSoTruong();
        BussinessTuoi batuoi = new BussinessTuoi();

        DataTable dtdb = new DataTable();
        DataTable dtdb2 = new DataTable();
        DataTable dtdb3 = new DataTable();
        DataTable dtdb4 = new DataTable();
        //String ketqua = "";

        Final_BangMotLenh final2 = new Final_BangMotLenh();
        DataTable dtvtbang = new DataTable();
        DataTable dtdbbang = new DataTable();
        DataTable dtdbbang2 = new DataTable();
        DataTable dtdbbang3 = new DataTable();

        DataTable dtdbbang0 = new DataTable();
        DataTable dtdbbang02 = new DataTable();
        DataTable dtdbbang03 = new DataTable();

        DataTable dttuoibang = new DataTable();


        Final_BangNhieuLenh final3 = new Final_BangNhieuLenh();
        DataTable dtdbNhieuLenh = new DataTable();
        DataTable dtdbNhieuLenh2 = new  DataTable();

        public FrmCuoiKy()
        {
            InitializeComponent();
        }
        public void DataBind()
        {
            dtct = bact.getCauThu().Tables[0];
            cboxCauThu.DataSource = dtct;
            cboxCauThu.DisplayMember = "TenCT";
            cboxCauThu.ValueMember = "MaCT";

            dtdb = badb.getDoiBong().Tables[0];
            cboxDoiBong.DataSource = dtdb;
            cboxDoiBong.DisplayMember = "TenDoi";
            cboxDoiBong.ValueMember = "MaDoi";

            //dtdb2 = badb.getDoiBong().Tables[0];
            //cboxDoiBong2.DataSource = dtdb2;
            //cboxDoiBong2.DisplayMember = "TenDoi";
            //cboxDoiBong2.ValueMember = "MaDoi";

            dtdb3 = badb.getDoiBong().Tables[0];
            cboxDoiBong3.DataSource = dtdb3;
            cboxDoiBong3.DisplayMember = "TenDoi";
            cboxDoiBong3.ValueMember = "MaDoi";

            dtbhl = babhl.getBanHL().Tables[0];
            cboxBHL.DataSource = dtbhl;
            cboxBHL.DisplayMember = "MaBHL";
            cboxBHL.ValueMember = "MaBHL";



            dtdb4= badb.getDoiBong().Tables[0];
            cboxDoiBong4.DataSource = dtdb4;
            cboxDoiBong4.DisplayMember = "TenDoi";
            cboxDoiBong4.ValueMember = "MaDoi";

            dtct2 = bact.getCauThu().Tables[0];
            cboxCauThu2.DataSource = dtct2;
            cboxCauThu2.DisplayMember = "TenCT";
            cboxCauThu2.ValueMember = "MaCT";

            //Phần tra bảng

            dtvtbang = bavt.getViTriSoTruong().Tables[0];
            cboxViTriBang.DataSource = dtvtbang;
            cboxViTriBang.DisplayMember = "TenVT";
            cboxViTriBang.ValueMember = "MaVT";

            //dtdbbang = badb.getDoiBong().Tables[0];
            //cboxDoiBang.DataSource = dtdbbang;
            //cboxDoiBang.DisplayMember = "TenDoi";
            //cboxDoiBang.ValueMember = "MaDoi";

            dtdbbang2 = badb.getDoiBong().Tables[0];
            cboxDoiBang2.DataSource = dtdbbang2;
            cboxDoiBang2.DisplayMember = "TenDoi";
            cboxDoiBang2.ValueMember = "MaDoi";

            //dtdbbang3 = badb.getDoiBong().Tables[0];
            //cboxDoiBang3.DataSource = dtdbbang3;
            //cboxDoiBang3.DisplayMember = "TenDoi";
            //cboxDoiBang3.ValueMember = "MaDoi";


            //dtdbbang0= badb.getDoiBong().Tables[0];
            //cboxBang0.DataSource = dtdbbang0;
            //cboxBang0.DisplayMember = "TenDoi";
            //cboxBang0.ValueMember = "MaDoi";

            dtdbbang02 = badb.getDoiBong().Tables[0];
            cboxBang02.DataSource = dtdbbang02;
            cboxBang02.DisplayMember = "TenDoi";
            cboxBang02.ValueMember = "MaDoi";

            dtdbbang03 = badb.getDoiBong().Tables[0];
            cboxBang03.DataSource = dtdbbang03;
            cboxBang03.DisplayMember = "TenDoi";
            cboxBang03.ValueMember = "MaDoi";


            dtdbNhieuLenh = badb.getDoiBong().Tables[0];
            cboxNhieuLenh.DataSource = dtdbNhieuLenh;
            cboxNhieuLenh.DisplayMember = "TenDoi";
            cboxNhieuLenh.ValueMember = "MaDoi";


            dtdbNhieuLenh2 = badb.getDoiBong().Tables[0];
            cboxNhieuLenh2.DataSource = dtdbNhieuLenh2;
            cboxNhieuLenh2.DisplayMember = "TenDoi";
            cboxNhieuLenh2.ValueMember = "MaDoi";
        }
        private void FrmCuoiKy_Load(object sender, EventArgs e)
        {
            DataBind();
        }

        private void btnTra1_Click(object sender, EventArgs e)
        {
            txtKetQua.Text = final.LuongCauThu(cboxCauThu.SelectedValue.ToString(), dtimeThoiDiem.Value);
        }

        private void btnTra2_Click(object sender, EventArgs e)
        {
            txtKetQua.Text = final.MuaGiai(dtime2.Value);
        }

        private void btnTra3_Click(object sender, EventArgs e)
        {
            String doi = cboxDoiBong.SelectedValue.ToString();
            txtKetQua.Text = final.NhanXetTaiChinh(doi);
        }

        //private void btnTra4_Click(object sender, EventArgs e)
        //{
        //    String doi = cboxDoiBong2.SelectedValue.ToString();
        //    txtKetQua.Text = final.SoCTSapHetHanHD(doi);
        //}

        private void btnTra5_Click(object sender, EventArgs e)
        {
            txtKetQua.Text = final.SoCTTaiThoiDiem(cboxDoiBong3.SelectedValue.ToString(),dtime3.Value);
        }

        private void btnTra6_Click(object sender, EventArgs e)
        {
            txtKetQua.Text = final.TenBHLTheoMa(cboxBHL.SelectedValue.ToString());
        }

        private void btnTra7_Click(object sender, EventArgs e)
        {
            txtKetQua.Text = final.TuoiDoiTheoMa(cboxDoiBong4.SelectedValue.ToString());
        }

        private void btnTra8_Click(object sender, EventArgs e)
        {
            txtKetQua.Text = final.ViTriTheoMaCauThu(cboxCauThu2.SelectedValue.ToString());
        }

        //Phần tra bảng 

        private void btnTraBang_Click(object sender, EventArgs e)
        {
            dgvKetQuaBang.DataSource = final2.AllMuaGiai(dtimeBang.Value).Tables[0];
        }

        private void btnTraBang2_Click(object sender, EventArgs e)
        {
            dgvKetQuaBang.DataSource = final2.CauThuTheoViTri(cboxViTriBang.SelectedValue.ToString()).Tables[0];
        }

        //private void btnTraBang3_Click(object sender, EventArgs e)
        //{
        //    dgvKetQuaBang.DataSource = final2.CauThuHetHanHDtheoDoi(cboxDoiBang.SelectedValue.ToString()).Tables[0];
        //}

        private void btnTraBang4_Click(object sender, EventArgs e)
        {
            dgvKetQuaBang.DataSource = final2.TuoiCauThuNhapDoi(cboxDoiBang2.SelectedValue.ToString()).Tables[0];
        }

        private void btnTraBang5_Click(object sender, EventArgs e)
        {
            dgvKetQuaBang.DataSource = final2.TuoiCauThuNhapTuoi(Int32.Parse(numTuoi.Value.ToString())).Tables[0];   
        }

        //private void btnBang0_Click(object sender, EventArgs e)
        //{
        //    dgvKetQuaBang.DataSource = final2.Danhsachnhanviendoi(cboxBang0.SelectedValue.ToString(), dtimeBang.Value).Tables[0];
        //}

        private void btnTra02_Click(object sender, EventArgs e)
        {
            dgvKetQuaBang.DataSource = final2.DanhSachNhaTaiTroTheoDoi(cboxBang02.SelectedValue.ToString()).Tables[0];
        }

        private void btnTra03_Click(object sender, EventArgs e)
        {
            dgvKetQuaBang.DataSource = final2.LuongNamCuaBHLtheoNgayCuThe(dtimeBang02.Value).Tables[0];
        }

        private void btnTra04_Click(object sender, EventArgs e)
        {
            dgvKetQuaBang.DataSource = final2.Luong_ThoiGianHDCauThuTheoDoi(cboxBang03.SelectedValue.ToString()).Tables[0];
        }
        /// <summary>
        /// Nhiều lệnh
        /// </summary>

        private void btnNhieuLenh_Click(object sender, EventArgs e)
        {
            dgvKetQuaBang.DataSource = final3.DanhsachthanhvienDoiBong(cboxNhieuLenh.SelectedValue.ToString(), dtimeNhieuLenh.Value).Tables[0];
        }

        private void btnNhieuLenh2_Click(object sender, EventArgs e)
        {
            dgvKetQuaBang.DataSource = final3.DSTanBinhTheoThoiDiemCuaDoi(cboxNhieuLenh2.SelectedValue.ToString(), dtimeNhieuLenh2.Value).Tables[0];
        }

        private void btnNhieuLenh3_Click(object sender, EventArgs e)
        {
            dgvKetQuaBang.DataSource = final3.CauthuMoiDoiTheoMua().Tables[0];
        }
    }
}
