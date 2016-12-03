        using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DataTransfer;

namespace DataAccessLayer
{
    public class DALayer
    {
        
        string strConnect = "Data Source =" + dtLayer.datasource + ";" + "Initial Catalog=" + dtLayer.database + ";" + "User ID =" + dtLayer.ID + ";" + "Password=" + dtLayer.password + ";";
        SqlConnection conn = null;
        SqlCommand cmd = null;
        SqlDataAdapter da = null;

        public DALayer()
        {
            conn = new SqlConnection(strConnect);
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            cmd = conn.CreateCommand();
        }

        public DataSet ExecuteQueryDataSet(string strSQL, CommandType ct, params SqlParameter[] p)
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            cmd.CommandText = strSQL;
            cmd.CommandType = ct;
            da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        public String ExecuteQueryDataSet2(string strSQL, CommandType ct, params SqlParameter[] p)
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            cmd.CommandText = strSQL;
            cmd.CommandType = ct;
            da = new SqlDataAdapter(cmd);
            String s = "";
            DataSet ds = new DataSet();
            da.Fill(ds);
            DataTable dt = new DataTable();
            dt = ds.Tables[0];
            s = dt.Rows[0][0].ToString();

            return s;
        }

        public DataSet ExecuteQueryDataSet3(
            string strSQL, CommandType ct,
            params SqlParameter[] param)
        {
            cmd.Parameters.Clear();
            cmd.CommandText = strSQL;
            cmd.CommandType = ct;
            foreach (SqlParameter p in param)
                cmd.Parameters.Add(p);
            da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            String s = "";
            DataTable dt = new DataTable();
            dt = ds.Tables[0];
            s = dt.Rows[0][0].ToString();
            return ds;
        }


        public bool MyExecuteNonQuery(string strSQL, CommandType ct, ref string error, params SqlParameter[] param)
        {
            bool f = false;
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            cmd.Parameters.Clear();
            cmd.CommandText = strSQL;
            cmd.CommandType = ct;
            foreach (SqlParameter p in param)
                cmd.Parameters.Add(p);
            try
            {
                cmd.ExecuteNonQuery();
                f = true;
            }
            catch (SqlException ex)
            {
                error = ex.Message;
            }
            finally
            {
                conn.Close();
            }
            return f;
        }
        public bool CheckConnect(string connectString)
        {
            try
            {
                SqlConnection connect = new SqlConnection(connectString);
                connect.Open();
                return true;
            }
            catch
            {
                return false;
            }
        }

    }
}

