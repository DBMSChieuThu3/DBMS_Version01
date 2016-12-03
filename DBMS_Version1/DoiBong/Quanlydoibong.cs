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

namespace DBMS_Version1.DoiBong
{
    public partial class Quanlydoibong : Form
    {
        public static string madoibong;
       // public static string tendoibong;
        public void Databind()
        {
            BussinessDoiBong badb = new BussinessDoiBong();
            DataTable db = new DataTable();
            DataTable ntt = new DataTable();
            DataTable bhl = new DataTable();
            DataTable ct = new DataTable();
          

            db = badb.getDoiBongTheoMa(madoibong).Tables[0];

            lblTenDoi.Text = db.Rows[0]["TenDoi"].ToString();   //Lấy tên đội bóng từ mã đội form chọn đội

            //Load DS cầu thủ theo mã đội
            ct = badb.getCauThuTheoMa(madoibong).Tables[0];
            ntt = badb.getNhaTaiTroTheoMa(madoibong).Tables[0];
            bhl = badb.getBanHLTheoMa(madoibong).Tables[0];

            

            dgvCauThu.DataSource = ct;
            dgvNhaTaiTro.DataSource = ntt;
            dgvBanHuanLuyen.DataSource = bhl;

            //Danh sách NTT theo mã đội
            //Danh sách Ban huấn luyện theo mã đội
            //------Tất cả phải còn Hợp đồng--------

            lblGK.Text = "";
            lblCB.Text = "";
            lblLB.Text = "";
            lblRB.Text = "";
            lblCDM.Text = "";
            lblRM.Text = "";
            lblCM.Text = "";
            lblLM.Text = "";
            lblST.Text = "";
            lblLWF.Text = "";
            lblRWF.Text = "";
            for (int i = 0; i < ct.Rows.Count; i++)
            {
                if(ct.Rows[i]["MaVT"].ToString()=="GK")
                    lblGK.Text +="\n"+ ct.Rows[i]["TenCT"].ToString();
                if (ct.Rows[i]["MaVT"].ToString() == "CB")
                    lblCB.Text += "\n" + ct.Rows[i]["TenCT"].ToString();
                if (ct.Rows[i]["MaVT"].ToString() == "LB")
                    lblLB.Text += "\n" + ct.Rows[i]["TenCT"].ToString();
                if (ct.Rows[i]["MaVT"].ToString() == "RB")
                    lblRB.Text += "\n" + ct.Rows[i]["TenCT"].ToString();
                if (ct.Rows[i]["MaVT"].ToString() == "CDM")
                    lblCDM.Text += "\n" + ct.Rows[i]["TenCT"].ToString();
                if (ct.Rows[i]["MaVT"].ToString() == "RM")
                    lblRM.Text += "\n" + ct.Rows[i]["TenCT"].ToString();
                if (ct.Rows[i]["MaVT"].ToString() == "CM")
                    lblCM.Text += "\n" + ct.Rows[i]["TenCT"].ToString();
                if (ct.Rows[i]["MaVT"].ToString() == "LM")
                    lblLM.Text += "\n" + ct.Rows[i]["TenCT"].ToString();
                if (ct.Rows[i]["MaVT"].ToString() == "ST")
                    lblST.Text += "\n" + ct.Rows[i]["TenCT"].ToString();
                if (ct.Rows[i]["MaVT"].ToString() == "LWF")
                    lblLWF.Text += "\n" + ct.Rows[i]["TenCT"].ToString();
                if (ct.Rows[i]["MaVT"].ToString() == "RWF")
                    lblRWF.Text += "\n" + ct.Rows[i]["TenCT"].ToString();
            }
        
        }
        public Quanlydoibong()
        {
            InitializeComponent();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Quanlydoibong_Load(object sender, EventArgs e)
        {
            Databind();
        }
    }
}
