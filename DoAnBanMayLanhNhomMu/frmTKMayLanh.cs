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
    public partial class frmTKMayLanh : Form
    {
        public frmTKMayLanh()
        {
            InitializeComponent();
        }
        public void LoadData()
        {
            string query = "select *  from MayLanh";

            dtgvtkml.DataSource = DataProvider.Instance.ExecutedQuery(query);
        }



        private void btnquaylai_Click(object sender, EventArgs e)
        {
           
            frmmenunhanvien td = new frmmenunhanvien();
            td.Show();
            this.Hide();
        }

        private void btntk_Click(object sender, EventArgs e)
        {
            string TENML = txttktheoten.Text;
            DataTable dataTable = MayLanhDTO.Instance.timml(TENML);
            if (dataTable.Rows.Count == 0)
            {
                MessageBox.Show("Find Fail, tên hoặc địa chỉ không tồn tại");
            }
            else
            {
                dtgvtkml.DataSource = dataTable;
            }
        }

        private void frmTKMayLanh_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
