using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server.DAL
{

    internal class DataAccessLayer
    {
        private string strconn = "Data Source=DESKTOP-4G0NG1C;Initial Catalog=QuanLyPhongMay;Integrated Security=True";
        private SqlConnection conn;
        public bool TestConnection()
        {
            conn = new SqlConnection(strconn);
            try
            {
                conn.Open();
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
                return false;
            }

            return true;
        }
        public SqlConnection Connect()
        {
            conn = new SqlConnection(strconn);
            conn.Open();
            return conn;
        }
        public void DisConnect()
        {
            try
            {
                if (conn != null)
                    conn.Close();
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                conn.Close();
                conn.Dispose();
                conn = null;
            }
        }
        public bool runQuery(string strquery)
        {
            int check = 0;
            Connect();
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                SqlCommand cmd = new SqlCommand(strquery, conn);
                check = cmd.ExecuteNonQuery();
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (check > 0)
            {
                return true;
            }
            return false;
        }

        public DataTable getDataTable(string query)
        {
            Connect();
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            return dt;
        }
        public bool checkField(string tableName, string fieldName, string value)
        {
            string sqlQuery = "select * from " + tableName + " where " + fieldName + "= '" + value + "'";
            if (getDataTable(sqlQuery).Rows.Count > 0)
            {
                return true;
            }
            return false;
        }
    }
}
