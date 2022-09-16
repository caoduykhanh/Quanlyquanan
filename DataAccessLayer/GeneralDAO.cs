using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class GeneralDAO
    {
        private static GeneralDAO instance;
        public static GeneralDAO Instance
        {
            get { if (instance == null) instance = new GeneralDAO(); return GeneralDAO.instance; }
            private set { GeneralDAO.instance = value; }
        }
   
    
      
        public string connectionString = "Data source = LAPTOP-1ABFDIDK\\SQLEXPRESS;user id = sa;" + "password=1;initial catalog = QLQUANAN";
        SqlConnection con = null;
        public DataSet getAll(string tblName)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from " + tblName, connectionString);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        public DataSet getCatelogy(string tblName)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from " + tblName, connectionString);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        public DataTable GetTable(string tblName)
        {
            SqlDataAdapter da = new SqlDataAdapter("EXEC " + tblName, connectionString);
            DataTable ds = new DataTable();
            da.Fill(ds);
            return ds;
        }
        public DataSet search(string tblName, string whereSql)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from " + tblName + " Where " + whereSql, connectionString);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        

        public SqlConnection getConnection()
        {
            if (con == null)
                con = new SqlConnection(connectionString);
            con.Open();
            return con;
        }
        public void closeConnection()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
        public void closeConnection(SqlConnection con)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
        public SqlDataReader findById(string tblName, string where_primarykey_id)
        {
            string sql = "Select * from " + tblName + " Where " + where_primarykey_id;

            SqlCommand cmd = new SqlCommand(sql, con);

            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }
        

        public int insert_update_Delete(string sql)
        {

            SqlConnection con = getConnection();
            SqlCommand cmd = new SqlCommand(sql, con);

            int result = cmd.ExecuteNonQuery();
            closeConnection(con);
            return result;
        }
        public DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(data);

                connection.Close();
            }

            return data;
        }
        public int ExecuteNonQuery(string query, object[] parameter = null)
        {
            int data = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                data = command.ExecuteNonQuery();

                connection.Close();
            }

            return data;
        }
        public object ExecuteScalar(string query, object[] parameter = null)
        {
            object data = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                data = command.ExecuteScalar();

                connection.Close();
            }

            return data;
        }

    }
}
