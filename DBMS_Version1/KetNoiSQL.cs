using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataAccessLayer
{
    public class KetNoiSQL
    {
        public string connstr;
        public void LoadServerName(ComboBox cbServerName)
        {
            try
            {
                string myServer = Environment.MachineName;
                DataTable servers = SqlDataSourceEnumerator.Instance.GetDataSources();
                for (int i = 0; i < servers.Rows.Count; i++)
                {
                    if (myServer == servers.Rows[i]["ServerName"].ToString())
                    {
                        cbServerName.Items.Add(servers.Rows[i]["ServerName"] + "\\" + servers.Rows[i]["InstanceName"]);

                    }
                    else
                    {
                        cbServerName.Items.Add(servers.Rows[i]["ServerName"]);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Không thể load được Server Name!! : " + e.Message);
            }

        }
        public SqlConnection con;
        public int GetConnect(ComboBox Authen, TextBox name, TextBox pass, ComboBox servername, ComboBox database)
        {
            try
            {
                if (Authen.Text.Equals("Windows Authentication"))
                {
                    con = new SqlConnection("Data Source =" + servername.Text + ";Integrated Security=true;");

                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT name FROM SYSDATABASES", con);
                    DataTable table = new DataTable();
                    da.Fill(table);
                    database.DataSource = table;
                    database.ValueMember = "name";
                    return 1;

                }
                else
                {
                    connstr = "Data Source=" + servername.Text + ";Initial Catalog=" + database.Text + ";User ID="
                        + name.Text + ";password=" + pass.Text;

                    con = new SqlConnection("Data Source = " + servername.Text + " ;User = " + name.Text + "; Password = "
                        + pass.Text + "");
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT name FROM SYSDATABASES", con);
                    DataTable table = new DataTable();
                    da.Fill(table);
                    database.DataSource = table;
                    database.ValueMember = "name";
                    return 1;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Kết nối thất bại!! : " + e.Message);
                return 0;
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
    }
}
