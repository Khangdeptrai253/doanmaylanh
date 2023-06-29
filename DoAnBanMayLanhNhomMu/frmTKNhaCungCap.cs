using DoAnBanMayLanhNhomMu.MyCompanyDTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnBanMayLanhNhomMu
{
    public partial class frmTKNhaCungCap : Form
    {
        public frmTKNhaCungCap()
        {
            InitializeComponent();
        }
        public void loadEmpList()
        {
            string query = "select *  from NhaCungCap";

            dtgvncc.DataSource = DataProvider.Instance.ExecutedQuery(query);
        }
        private void btntimkiem_Click(object sender, EventArgs e)
        {
            string pFind = txttenncc.Text;
            string padd = txtdiachi.Text;
            DataTable dataTable = NhaCungCapDTO.Instance.iFindNCC(pFind,padd);
            if (dataTable.Rows.Count == 0)
            {
                MessageBox.Show("Find Fail, tên hoặc địa chỉ không tồn tại");
            }  
            else {
                dtgvncc.DataSource = dataTable;
            }
        }

      

        private void btnquaylai_Click(object sender, EventArgs e)
        {
            frmMeNu tc = new frmMeNu();
            tc.Show();
            this.Hide();
        }

        private void frmTKNhaCungCap_Load(object sender, EventArgs e)
        {
            loadEmpList();
        }

    }
}
