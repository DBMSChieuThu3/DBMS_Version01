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
using DataTransfer;
using BussinessLayer;

namespace DBMS_Version1
{
    public partial class FrmDangNhap : Form
    {
        
        public FrmDangNhap()
        {
            InitializeComponent();
            txtPass.PasswordChar = '•';
        }

        private void FrmDangNhap_Load(object sender, EventArgs e)
        {
            
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DALayer da = new DALayer();
            string ChuoiKn = "data source=" + txtServer.Text + ";";
            ChuoiKn += "initial catalog=" + txtDatabase.Text + ";";
            ChuoiKn += "user id =" + txtID.Text + ";" + "password=" + txtPass.Text + ";";
            da.CheckConnect(ChuoiKn);
            if (da.CheckConnect(ChuoiKn) == true)
            {
                MessageBox.Show("Kết nối thành công", "Thông báo!");
                dtLayer.ID = txtID.Text;
                dtLayer.password = txtPass.Text;
                dtLayer.datasource = txtServer.Text;
                dtLayer.database = txtDatabase.Text;
                this.Close();
            }
            else
            {
                MessageBox.Show("Kết nối thất bại", "Lỗi!");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                txtPass.Focus();
        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                btnOK.PerformClick();
        }

        private void txtServer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                txtDatabase.Focus();
        }

        private void txtDatabase_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                txtID.Focus();
        }
    }
}
