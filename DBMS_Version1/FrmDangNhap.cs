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
    public partial class FrmDangNhap : Form
    {
        //Tạo tài khoản đăng nhập mặc định
        public string ID = "admin";
        public string Pass = "admin";

        

        
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
            if (txtID.Text == ID && txtPass.Text == Pass)
            {
                MessageBox.Show("Ban đã đăng nhập thành công!");
                Close();
            }
            else
            {
                if (txtID.Text != ID)
                {
                    MessageBox.Show("Sai tên truy cập!");
                    txtID.Focus();
                }
                else
                {
                    if (txtPass.Text != Pass)
                    {
                        MessageBox.Show("Sai Mật khẩu!");
                        txtPass.Focus();
                    }
                }
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
    }
}
