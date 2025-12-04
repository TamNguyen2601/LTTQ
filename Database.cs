using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace NguyenVanTam_231230895_LTTQ
{
    internal class Database
    {
        string connString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\TamNguyen\\source\\repos\\NguyenVanTam_231230895_LTTQ\\QLSach.mdf;Integrated Security=True";
        SqlConnection sqlConnection;

        private void Connect()
        {
            sqlConnection = new SqlConnection(connString);
            if(sqlConnection.State != ConnectionState.Open)
            {
                sqlConnection.Open();
            }
        }
        private void DisConnect()
        {
            if(sqlConnection.State != ConnectionState.Closed)
            {
                sqlConnection.Close();
            }
        }

        public DataTable ReadData(string sql)
        {
            Connect();
            DataTable dt = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sql, sqlConnection);
            sqlDataAdapter.Fill(dt);
            DisConnect();
            return dt;
        }

        public void UpdateData(string sql)
        {
            Connect();
            SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            DisConnect();
            sqlCommand.Dispose();
        }
    }
}
