using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnBanMayLanhNhomMu.MyCompanyDTO
{
    public class NhaCungCapDTO
    {
         private static NhaCungCapDTO instance;

        public static NhaCungCapDTO Instance
        {
            get
            {
                if (instance == null) instance = new NhaCungCapDTO();
                return NhaCungCapDTO.instance;
            }
            private set => instance = value;
        }


        // lấy id Nha Cung Cap 
        //public int getIdEmp(string pName)
        //{
        //    string query = "getIdNcc @TenNCC";
        //    int result = (int)DataProvider.Instance.ExecutedScalar(query, new object[] { pName });
        //    return result;
        //}


        //thêm mới nhân viên
        public int newEmployee(string MANCC, string TENNCC, string DIACHI, string SDT)
        {
            string query = "INncc @mancc , @tenncc , @diachi , @sdt";
            int result = DataProvider.Instance.ExecutedNonQuery(query, new object[] { MANCC, TENNCC, DIACHI, SDT});
            return result;
        }


        //sửa nhân viên
        public bool updateNCC(string MANCC, string TENNCC, string DIACHI, string SDT)
        {
            string query = "updaNCC @mancc , @tenncc , @diachi , @sdt";
            int result = DataProvider.Instance.ExecutedNonQuery(query, new object[] { MANCC, TENNCC, DIACHI, SDT });
            return result > 0;
        }

        //xóa nhân viên
        public bool idelncc(string pId)
        {
            string query = "idelncc @mancc";
            int result = DataProvider.Instance.ExecutedNonQuery(query, new object[] { pId });
            return result > 0;
        }

        // tìm nhân viên

        public DataTable iFindNCC(string pFind,string padd)
        {
            string query = "TimKiemNCC @tenncc , @diachi";
            return DataProvider.Instance.ExecutedQuery(query, new object[] { pFind,padd });
        }
    }
}
