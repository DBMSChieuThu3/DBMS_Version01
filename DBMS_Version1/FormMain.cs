using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMS_Version1
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnNtt_Click(object sender, EventArgs e)
        {
            (new FrmNhaTaiTro()).ShowDialog();
        }

        private void btnHlv_Click(object sender, EventArgs e)
        {
            (new FrmHuanLuyenVien()).ShowDialog();
        }

        private void btnTl_Click(object sender, EventArgs e)
        {
            (new FrmTroLyHLV()).ShowDialog();
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
            (new FrmHopDongHLV_DB()).ShowDialog();
        }

        private void trợLýĐộiBóngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new FrmHopDongTL_DB()).ShowDialog();
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
            (new FrmHuanLuyenVien()).ShowDialog();
        }

        private void trợLýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new FrmTroLyHLV()).ShowDialog();
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
            (new FrmHopDongHLV_DB()).ShowDialog();
        }

        private void btnTl_Db_Click(object sender, EventArgs e)
        {
            (new FrmHopDongTL_DB()).ShowDialog();
        }

        private void btnCt_Db_Click(object sender, EventArgs e)
        {
            (new FrmHopDongCT_DB()).ShowDialog();
        }
    }
}
