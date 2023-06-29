using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnBanMayLanhNhomMu.MyCompanyDTO
{

   public class DataProvider
    {
        private static DataProvider instance;
        public static DataProvider Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DataProvider();
                }
                return DataProvider.instance;
            }

            private set
            {
                instance = value;
            }
        }
        private DataProvider() { }


        private string con = @"Data Source= DESKTOP-2DPJ3C8\SQLEXPRESS;Initial Catalog=QLCUAHANGBANMAYLANH;Integrated Security=True";


        public DataTable ExecutedQuery(string query, object[] parameter = null)
        {


            DataTable data = new DataTable();
            using (SqlConnection _cnn = new SqlConnection(con))
            {
                _cnn.Open();

                SqlCommand cmd = new SqlCommand(query, _cnn);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains("@"))
                        {
                            cmd.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);

                sqlDataAdapter.Fill(data);

                _cnn.Close();
            }

            return data;

        }

        public int ExecutedNonQuery(string query, object[] parameter = null)
        {

            int data = 0;

            using (SqlConnection _cnn = new SqlConnection(con))
            {
                _cnn.Open();

                SqlCommand cmd = new SqlCommand(query, _cnn);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains("@"))
                        {
                            cmd.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);

                data = cmd.ExecuteNonQuery();

                _cnn.Close();
            }

            return data;

        }

        public object ExecutedScalar(string query, object[] parameter = null)
        {

            object data = 0;

            using (SqlConnection _cnn = new SqlConnection(con))
            {
                _cnn.Open();

                SqlCommand cmd = new SqlCommand(query, _cnn);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains("@"))
                        {
                            cmd.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);

                data = cmd.ExecuteScalar();

                _cnn.Close();
            }

            return data;

        }

    }
}
