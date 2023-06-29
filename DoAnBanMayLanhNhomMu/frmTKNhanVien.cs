using DoAnBanMayLanhNhomMu.MyCompanyDTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnBanMayLanhNhomMu
{
    public partial class frmTKNhanVien : Form
    {
        public frmTKNhanVien()
        {
            InitializeComponent();
        }
        public void loadData()
        {
            string query = "select *  from NhanVien";
            datgvtknv.DataSource = DataProvider.Instance.ExecutedQuery(query);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    
        private void btnquaylai_Click(object sender, EventArgs e)
        {
            frmMeNu tc = new frmMeNu();
            tc.Show();
            this.Hide();
        }

      

        private void frmTKNhanVien_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            string pFind = txtnhapten.Text;
            string pPhone = txtsdt.Text;
            DataTable dataTable = NhanVienDTO.Instance.findnv(pFind, pPhone);
            if (dataTable.Rows.Count == 0)
            {
                MessageBox.Show("Find Fail, tên hoặc số điện thoại không tồn tại");
            }
            else
            {
                datgvtknv.DataSource = dataTable;
            }
        }

    }
}
