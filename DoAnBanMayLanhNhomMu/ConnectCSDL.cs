using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace DoAnBanMayLanhNhomMu
{
    public class ConnectCSDL
    {
        static string connectsql = @"Data Source=DESKTOP-2DPJ3C8\SQLEXPRESS;Initial Catalog=QLCUAHANGBANMAYLANH;Integrated Security=True";
        SqlConnection conn;
        SqlCommand sqlCom;
        SqlCommand sqlCom2 = new SqlCommand();
        DataTable dt;
        public void ketnoi()
        {
            conn = new SqlConnection(connectsql);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
        }
        public void NgatKetNoi()
        {
            conn.Close();
        }
        public void ThucThi(string strSQL)
        {
            //Bƣớc 1: Kết nối tới CSLD (Gọi phƣơng thức KetNoi) 
            ketnoi();
            //Bƣớc 2: Khởi tạo và gọi phƣơng thức của đối tƣợng Command 
            sqlCom = new SqlCommand(strSQL, conn);
            sqlCom.ExecuteNonQuery();
            //Bƣớc 3: Ngắt kết nối 
            NgatKetNoi();
        }
        public DataTable GetData(string strSQL)
        {
            SqlDataAdapter DA;
            dt = new DataTable();
            //khoi tao gia tri cho doi tuong sqldataadapter
            DA = new SqlDataAdapter(strSQL, conn);
            DA.Fill(dt);
            return dt;
        }
    }
}
