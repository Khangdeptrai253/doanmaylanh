using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnBanMayLanhNhomMu.MyCompanyDTO
{
    public class HoaDonNhapDTO
    {
        private static HoaDonNhapDTO instance;


        public static HoaDonNhapDTO Instance
        {
            get
            {
                if (instance == null) instance = new HoaDonNhapDTO();
                return HoaDonNhapDTO.instance;
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


        public int inhdn(string MAHDB, string MANV, string MAKH, string MAML, int SL, DateTime NGAYBAN, string DIACHI, float DG, float TONGTIEN)
        {
            string query = " inhdn  @mahdb , @manv , @makh , @maml , @soluong , @dongia , @tongtien , @ngayban , @diachi";
            int result = DataProvider.Instance.ExecutedNonQuery(query, new object[] { MAHDB, MANV, MAKH, MAML, SL, NGAYBAN, DIACHI, DG, TONGTIEN, });
            return result;
        }


        public bool uphdb(string MAHDB, string MANV, string MAKH, string MAML, int SL, float DG, float TONGTIEN, DateTime NGAYBAN, string DIACHI)
        {
            string query = "uphdb @mahdb , @manv , @makh , @maml , @soluong , @dongia , @tongtien , @ngayban , @diachi ";
            int result = DataProvider.Instance.ExecutedNonQuery(query, new object[] { MAHDB, MANV, MAKH, MAML, SL, DG, TONGTIEN, NGAYBAN, DIACHI });
            return result > 0;
        }
        public bool delhdn(string pId)
        {
            string query = "delhdn @mahdn";
            int result = DataProvider.Instance.ExecutedNonQuery(query, new object[] { pId });
            return result > 0;
        }
        public DataTable iFindNCC(string pFind, string padd)
        {
            string query = "TimKiemNCC @tenncc , @diachi";
            return DataProvider.Instance.ExecutedQuery(query, new object[] { pFind, padd });
        }
    }
}
