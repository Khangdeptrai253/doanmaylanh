using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnBanMayLanhNhomMu.MyCompanyDTO
{
    public class HoaDonBanDTO
    {
        private static HoaDonBanDTO instance;

        public static HoaDonBanDTO Instance
        {
            get
            {
                if (instance == null) instance = new HoaDonBanDTO();
                return HoaDonBanDTO.instance;
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
        public int inhdbc(string MAHDB, string MANV, string MAKH, string MAML, int SL, float DG,float TONGTIEN,DateTime NGAYBAN,string DIACHI)
        {
            string query = " inhdbc @mahdb , @manv , @makh , @maml , @soluong , @dongia , @tongtien , @ngayban , @diachi";
            int result = DataProvider.Instance.ExecutedNonQuery(query, new object[] { MAHDB,  MANV, MAKH,  MAML, SL,  DG, TONGTIEN,NGAYBAN,DIACHI });
            return result;
        }


        //sửa nhân viên
        public bool uphdb(string MAHDB, string MANV, string MAKH, string MAML, int SL, float DG, float TONGTIEN, DateTime NGAYBAN, string DIACHI)
        {
            string query = "uphdb @mahdb , @manv , @makh , @maml , @soluong , @dongia , @tongtien , @ngayban , @diachi ";
            int result = DataProvider.Instance.ExecutedNonQuery(query, new object[] { MAHDB, MANV, MAKH, MAML, SL, DG, TONGTIEN, NGAYBAN, DIACHI });
            return result > 0;
        }

        //xóa nhân viên
        public bool delhdb(string pId)
        {
            string query = "delhdb @mahdb";
            int result = DataProvider.Instance.ExecutedNonQuery(query, new object[] { pId });
            return result > 0;
        }

        // tìm nhân viên

        public DataTable iFindNCC(string pFind, string padd)
        {
            string query = "TimKiemNCC @tenncc , @diachi";
            return DataProvider.Instance.ExecutedQuery(query, new object[] { pFind, padd });
        }
    }
}
