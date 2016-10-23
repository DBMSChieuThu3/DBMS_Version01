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
        BussinessCauThu ctBussiness = new BussinessCauThu();
        bool them = true;
        public FrmCauThu()
        {
            
            InitializeComponent();
        }
        void LoadData()
        {
            try
            {
                //Dua du lieu SQL len dgv
                dgvCT.DataSource = ctBussiness.getCauThu();
                //Thay doi do rong cot
                dgvCT.AutoResizeColumns();
                // Xoa trong cac doi tuong trong Panel
                this.txtMCT.ResetText();
                this.txtTCT.ResetText();
                this.NgaySinh.ResetText();
                this.txtDC.ResetText();
                this.txtSDT.ResetText();
                this.cmbVTST.ResetText();
                //khong cho thao tac tren cac nut Luu/Huy
                this.btnLuu.Enabled = false;
                
                //Cho cac thoa tac tren cac nut them/sua/xoa/Thoat
                this.btnThem.Enabled = true;
                this.btnSua.Enabled = true;
                this.btnLuu.Enabled = true;
                this.btnXoa.Enabled = true;
                dgvCT_CellContentClick(null,null);
            }
            catch(SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table Cầu thủ");
            }
        }
        
        private void dgvCT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //Kich hoat bien them
            them = true;
            //Xoa trong cac doi tuong
            this.txtMCT.ResetText();
            this.txtTCT.ResetText();
            this.NgaySinh.ResetText();
            this.txtDC.ResetText();
            this.txtSDT.ResetText();
            this.cmbVTST.ResetText();
            // Cho cac thao tac tren cac nut Luu/huy
            this.btnLuu.Enabled = true;
            //khong cho cac thao tac tren cac nut con lai
            this.btnExit.Enabled = false;
            this.btnLuu.Enabled = false;
            this.btnReset.Enabled = false;
            this.btnSua.Enabled = false;
            //Dua con tro chuot toi vi tri MaCT
            this.txtMCT.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

        }
    }
}
