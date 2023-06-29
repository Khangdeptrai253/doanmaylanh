using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnBanMayLanhNhomMu.MyCompanyDTO
{
    public  class NhanVienDTO
    {
        private static NhanVienDTO instance;

        public static NhanVienDTO Instance
        {
            get
            {
                if (instance == null) instance = new NhanVienDTO();
                return NhanVienDTO.instance;
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
        public int newnv(string MANV, string TENNV,string GIOITINH, string DIACHI, string SDT)
        {
            string query = "INnv @manv , @tennv , @gioitinh , @diachi , @sdt";
            int result = DataProvider.Instance.ExecutedNonQuery(query, new object[] { MANV,  TENNV,  GIOITINH, DIACHI,  SDT });
            return result;
        }


        //sửa nhân viên
        public bool updatenv(string MANCC, string TENNCC,string GIOITINH, string DIACHI, string SDT)
        {
            string query = "updanv @mancc , @tenncc , @gioitinh , @diachi , @sdt";
            int result = DataProvider.Instance.ExecutedNonQuery(query, new object[] { MANCC, TENNCC,GIOITINH, DIACHI, SDT });
            return result > 0;
        }

        //xóa nhân viên
        public bool idelnv(string pId)
        {
            string query = "delnv @manv";
            int result = DataProvider.Instance.ExecutedNonQuery(query, new object[] { pId });
            return result > 0;
        }

        // tìm nhân viên

        public DataTable findnv(string pFind, string pPhone)
        {
            string query = "findnv @tennv , @sdt";
            return DataProvider.Instance.ExecutedQuery(query, new object[] { pFind,pPhone });
        }
    }
}
