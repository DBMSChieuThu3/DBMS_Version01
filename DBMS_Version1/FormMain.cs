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
    public partial class FormMain : Form
    {
        
        public FormMain()
        {
            FrmDangNhap form = new FrmDangNhap();
            form.ShowDialog();
            InitializeComponent();
        }

        private void btnNtt_Click(object sender, EventArgs e)
        {
            (new FrmNhaTaiTro()).ShowDialog();
        }

        private void btnHlv_Click(object sender, EventArgs e)
        {
            (new FrmBanHuanLuyen()).ShowDialog();
        }

 

        private void btnCt_Click(object sender, EventArgs e)
        {
            (new FrmCauThu()).ShowDialog();
        }

        private void btnTuoi_Click(object sender, EventArgs e)
        {
            (new FrmTuoi()).ShowDialog();
        }

        private void nhàTàiTrợĐộiBóngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new FrmHopDongNTT_DB()).ShowDialog();
        }

        private void huấnLuyệnViênĐộiBóngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new FrmHopDongBHL_DB()).ShowDialog();
        }



        private void cầuThủĐộiBóngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new FrmHopDongCT_DB()).ShowDialog();
        }

        private void nhàTàiTrợToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new FrmNhaTaiTro()).ShowDialog();
        }

        private void huấnLuyệnViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new FrmBanHuanLuyen()).ShowDialog();
        }



        private void cầuThủToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new FrmCauThu()).ShowDialog();
        }

        private void tuổiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new FrmTuoi()).ShowDialog();
        }

        private void btnNtt_Db_Click(object sender, EventArgs e)
        {
            (new FrmHopDongNTT_DB()).ShowDialog();
        }

        private void btnHlv_Db_Click(object sender, EventArgs e)
        {
            (new FrmHopDongBHL_DB()).ShowDialog();
        }



        private void btnCt_Db_Click(object sender, EventArgs e)
        {
            (new FrmHopDongCT_DB()).ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblChuChay.Location = new Point(lblChuChay.Location.X, lblChuChay.Location.Y - 1);
            if (lblChuChay.Location.Y < -lblChuChay.Height)
            {
                lblChuChay.Location = new Point(lblChuChay.Location.X, pnlTinTheThao.Height);
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            lblChuChay.Text =
                "Việt Nam cần thêm một điểm để tránh \n"
                + " sớm gặp Thái Lan \n"
                + "Đại chiến London và các trận cầu \n"
                + "nảy lửa cuối tuần này\n"
                + "HLV Tây Ban Nha bầu Messi làm\n"
                + "Cầu thủ hay nhất năm của FIFA\n"
                + "Malaysia bỏ ý định rút khỏi AFF\n"
                + "Cup 2016\n"
                + "Đội của Balotelli bị loại khỏi \n"
                + "Europa League\n" 
                + "CLB Sông Lam Nghệ An mời ông \n"
                + "Đạt về làm HLV trưởng\n"
                + "Ông Quang vỡ nợ nên bán rẻ \n"
                + "Đội Bóng chính mình sáng lập";


            timer1.Enabled = true;
        }

        private void btnDoiBong_Click(object sender, EventArgs e)
        {
            (new DoiBong.ChonDoi()).ShowDialog();
        }

        private void độiBóngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new FrmDoiBong()).ShowDialog();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            (new FrmCuoiKy()).ShowDialog();
        }
    }
}
