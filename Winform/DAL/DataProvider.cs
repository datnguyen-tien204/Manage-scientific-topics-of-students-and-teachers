using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Runtime.InteropServices;

namespace DAL
{
    public class DataProvider
    {
        protected static DataProvider instance;
        //string connStr = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;


        //protected string connStr = @"Data Source=NGUYENTIENDAT;Initial Catalog=DA_Database_1;Integrated Security=True";
        protected string connStr = @"Data Source=NGUYENTIENDAT;Initial Catalog=TestForImages;Integrated Security=True";

        public static DataProvider Instance
        {
            get { if (instance == null) instance = new DataProvider(); return DataProvider.instance; }
            private set { DataProvider.Instance = value; }
        }

        protected DataProvider() { }

        public DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                connection.Open();

                SqlCommand sqlCommand = new SqlCommand(query, connection);
                

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string para in listPara)
                    {
                        Console.WriteLine(para);
                        if (para.Contains("@"))
                        {
                            sqlCommand.Parameters.AddWithValue(para, parameter[i]);
                            i++;
                        }
                    }
                }
                
                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);

                adapter.Fill(data);
                

                connection.Close();
            }
            return data;
        }
        public DataTable ExecuteQueryAccount(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                connection.Open();

                SqlCommand sqlCommand = new SqlCommand(query, connection);

                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);

                adapter.Fill(data);

                connection.Close();
            }
            return data;
        }



        public int ExecuteNonQuery(string query, object[] parameter = null)
        {
            int data = 0;
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                connection.Open();

                SqlCommand sqlCommand = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string para in listPara)
                    {
                        if (para.Contains("@"))
                        {
                            sqlCommand.Parameters.AddWithValue(para, parameter[i]);
                            i++;
                        }
                    }
                }
                data = sqlCommand.ExecuteNonQuery();

                connection.Close();
            }
            return data;
        }

        public object ExecuteScalar(string query, object[] parameter = null)
        {
            object data = 0;
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                connection.Open();

                SqlCommand sqlCommand = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string para in listPara)
                    {
                        if (para.Contains("@"))
                        {
                            sqlCommand.Parameters.AddWithValue(para, parameter[i]);
                            i++;
                        }
                    }
                }
                data = sqlCommand.ExecuteScalar();

                connection.Close();
            }
            return data;
        }
        public List<int> GetAllMaHoiDong(string query)
        {
            List<int> maHoiDongList = new List<int>();

            DataTable data = ExecuteQuery(query);

            foreach (DataRow row in data.Rows)
            {
                int maHoiDong = Convert.ToInt32(row["MaHoiDong"]);
                maHoiDongList.Add(maHoiDong);
            }

            return maHoiDongList;
        }
        public DataSet ExecuteQueryDataSet(string query, object[] parameter = null)
        {
            DataSet dataSet = new DataSet();
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                connection.Open();

                SqlCommand sqlCommand = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string para in listPara)
                    {
                        if (para.Contains("@"))
                        {
                            sqlCommand.Parameters.AddWithValue(para, parameter[i]);
                            i++;
                        }
                    }
                }

                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);

                adapter.Fill(dataSet);

                connection.Close();
            }
            return dataSet;
        }
    }
}
