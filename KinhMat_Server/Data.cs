using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace KinhMat_Server
{
    class Data
    {
        SqlConnection conn;
        public void Get_KN()
        {
            string choikn = @"Data Source=DESKTOP-OG2B35Q;Initial Catalog=kinhmat;Integrated Security=True";
            conn = new SqlConnection(choikn);
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            conn.Open();
        }
        public void ExecuteNonquery(string sql)
        {
            Get_KN();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
        }
        public DataTable Get_Table(string sql)
        {
            Get_KN();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds.Tables[0];
        }
        public string ExecuteScalar(string query)
        {
            Get_KN();
            SqlCommand sqlCmd = new SqlCommand(query, conn);
            string kq=(string)sqlCmd.ExecuteScalar();
            return kq;
        }

        public int ExecuteScalar_int(string query)
        {
            Get_KN();
            SqlCommand sqlCmd = new SqlCommand(query, conn);
            int kq = (int)sqlCmd.ExecuteScalar();
            return kq;
        }
        public SqlDataReader get_comboBox(string query)
        {
            Get_KN();
            SqlCommand sqlCmd = new SqlCommand(query, conn);
            SqlDataReader dataReader = sqlCmd.ExecuteReader();
            return dataReader;
        }
    }
}
