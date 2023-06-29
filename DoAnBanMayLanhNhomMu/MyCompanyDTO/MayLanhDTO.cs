using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DoAnBanMayLanhNhomMu.MyCompanyDTO
{
    internal class MayLanhDTO

    {
        private static MayLanhDTO instance;

        public static MayLanhDTO  Instance
        {
            get
            {
                if (instance == null) instance = new MayLanhDTO();
                return MayLanhDTO.instance;
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
        public int inml(string MAML, string TENMl, string MANCC, int SOLUONG, int GIABAN)
        {
            string query = "inml @maml , @tenml , @mancc , @soluong , @giaban";
            int result = DataProvider.Instance.ExecutedNonQuery(query, new object[] { MAML, TENMl, MANCC, SOLUONG, GIABAN });
            return result;
        }

 
        public bool updateml(string MAML, string TENMl, string MANCC, int SOLUONG, int GIABAN)
        {
            string query = "updateml @maml , @tenml , @mancc , @soluong , @giaban";
            int result = DataProvider.Instance.ExecutedNonQuery(query, new object[] { MAML, TENMl, MANCC, SOLUONG, GIABAN });
            return result > 0;
        }

        //xóa nhân viên
        public bool idelml(string pId)
        {
            string query = "delml @maml";
            int result = DataProvider.Instance.ExecutedNonQuery(query, new object[] { pId });
            return result > 0;
        }

        // tìm nhân viên

        public DataTable timml(string pFind)
        {
            string query = "timml @tenml";
            return DataProvider.Instance.ExecutedQuery(query, new object[] { pFind });
        }
        public int getName (string name)
        {
            string query = "laymancc";
            int result = DataProvider.Instance.ExecutedNonQuery(query,new object[] { name });
            return result;

        }
    }
}
