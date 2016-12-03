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
using DataTransfer;
using BussinessLayer;
using DataAccessLayer;
using System.IO;

namespace DBMS_Version1
{
    public partial class FrmDangNhap : Form
    {
        //KetNoiSQL kn = new KetNoiSQL();
        public static string connect;
        public static string ketnoi;
        public static string tennv;
        public static string quyen;
        public static string strconnection;

        public FrmDangNhap()
        {
            InitializeComponent();
        }

        private void FrmDangNhap_Load(object sender, EventArgs e)
        {
            btn_connection.Enabled = false;
            txtServer.Text = "DATNGUYEN\\SQLEXPRESS";
            txtLogin.Text = "sa";
            txtPassword.Text = "1234";
        }

       

        public string connstr;
        public SqlConnection con;
        public int GetConnect(String name, String pass, String servername, ComboBox database)
        {
            try
            {
                    connstr = "Data Source=" + servername + ";Initial Catalog=" + database.SelectedText + ";User ID="
                        + name + ";password=" + pass;

                    con = new SqlConnection("Data Source = " + servername + " ;User = " + name + "; Password = "
                        + pass + "");
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT name FROM SYSDATABASES", con);
                    DataTable table = new DataTable();
                    da.Fill(table);
                    database.DataSource = table;
                    database.ValueMember = "name";
                    return 1;
               
            }
            catch (Exception e)
            {
                MessageBox.Show("Kết nối thất bại!! : " + e.Message);
                return 0;
            }
        }

        private void btn_check_Click(object sender, EventArgs e)
        {
            int x = GetConnect(txtLogin.Text, txtPassword.Text, txtServer.Text, cboxDatabase);
            connect = con.ConnectionString;
            ketnoi = connstr;
            if (x == 1)
            {
                dtLayer.datasource = txtServer.Text;
                dtLayer.ID = txtLogin.Text;
                dtLayer.password = txtPassword.Text;
                
                btn_connection.Enabled = true;

            }
        }

        public string LuuChuoiKetNoi(ComboBox database, string s, TextBox pass)
        {
            string StringConnection = s + " Password = " + pass.Text + "; Initial Catalog = " + database.Text + "";

            string filepath = "chuoiketnoi.txt";
            FileStream fs = new FileStream(filepath, FileMode.Create, FileAccess.Write);
            StreamWriter sWriter = new StreamWriter(fs, Encoding.UTF8);
            sWriter.Write(StringConnection);

            sWriter.Flush();
            sWriter.Close();
            fs.Close();
            return StringConnection;
        }
        private void btn_connection_Click(object sender, EventArgs e)
        {
            strconnection =  LuuChuoiKetNoi(cboxDatabase, connect, txtPassword);
          
            dtLayer.database = cboxDatabase.Text;
            

            this.Close();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            // Hiện hộp thoại hỏi đáp 
            traloi = MessageBox.Show("Chắc không?", "Trả lời",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            // Kiểm tra có nhắp chọn nút Ok không? 
            if (traloi == DialogResult.OK) Application.Exit();
        }

        private void txtServer_TextChanged(object sender, EventArgs e)
        {
            btn_connection.Enabled = false;
        }

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {
            btn_connection.Enabled = false;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            btn_connection.Enabled = false;
        }
    }
}
