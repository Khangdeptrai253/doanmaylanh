using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnBanMayLanhNhomMu.MyCompanyDTO
{
    public class KhachHangDTO
    {
        private static KhachHangDTO instance;

        public static KhachHangDTO Instance
        {
            get
            {
                if (instance == null) instance = new KhachHangDTO();
                return KhachHangDTO.instance;
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
        public int INkh(string MANNV, string TENNV, string DIACHI, string SDT)
        {
            string query = "INkh @manv , @tennv , @diachi , @sdt";
            int result = DataProvider.Instance.ExecutedNonQuery(query, new object[] { MANNV, TENNV, DIACHI, SDT });
            return result;
        }
        //sửa nhân viên
        public bool updatekh(string MANCC, string TENNCC, string DIACHI, string SDT)
        {
            string query = " updkh @makh , @tenkh , @diachi , @sdt";
            int result = DataProvider.Instance.ExecutedNonQuery(query, new object[] { MANCC, TENNCC, DIACHI, SDT });
            return result > 0;
        }
        //xóa nhân viên
        public bool idelkh(string pId)
        {
            string query = "idelkh @makh";
            int result = DataProvider.Instance.ExecutedNonQuery(query, new object[] { pId });
            return result > 0;
        }

        // tìm nhân viên

        public DataTable Findkh(string TENKH, string SDT)
        {
            string query = "Findkh @tenkh , @sdt";
            return DataProvider.Instance.ExecutedQuery(query, new object[] {TENKH, SDT });
        }
    }
}
