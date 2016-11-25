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
    public partial class FrmTuoi : Form
    {
        BussinessTuoi batuoi = new BussinessTuoi();
        DataTable dstuoi = new DataTable();
        public FrmTuoi()
        {
            InitializeComponent();
        }
        public void DataBind()
        {
            dstuoi = batuoi.getTuoi().Tables[0];

            //load len data grid
            dgvTuoi.DataSource = dstuoi;

            //clear data bind
            txtMT.DataBindings.Clear();
            txtTuoi.DataBindings.Clear();

            //binding
            txtMT.DataBindings.Add("Text", dstuoi, "MaTuoi");
            txtTuoi.DataBindings.Add("Text", dstuoi, "Tuoi");

            //

        }
        private void FrmTuoi_Load(object sender, EventArgs e)
        {
            DataBind();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string err = "";
            if (!batuoi.ThemLuaTuoi(ref err, txtMT.Text.Trim(),Int32.Parse(txtTuoi.Text)))
                MessageBox.Show(err);
            else DataBind();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string err = "";
            if (!batuoi.CapNhatLuaTuoi(ref err, txtMT.Text.Trim(), Int32.Parse(txtTuoi.Text.Trim().ToString())))
                MessageBox.Show(err);
            else DataBind();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string err = "";
            if (!batuoi.XoaLuaTuoi(ref err, txtMT.Text.Trim()))
                MessageBox.Show(err);
            else DataBind();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
