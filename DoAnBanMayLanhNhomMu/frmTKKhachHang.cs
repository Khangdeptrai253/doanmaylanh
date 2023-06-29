using DoAnBanMayLanhNhomMu.MyCompanyDTO;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace DoAnBanMayLanhNhomMu
{
    public partial class frmTKKhachHang : Form
    {
        BindingSource BindingSourceEmp = new BindingSource();

        public frmTKKhachHang()
        {
            InitializeComponent();
        }

        public void loadData()
        {
            string query = "select *  from KhachHang";

            dtgvttkh.DataSource = DataProvider.Instance.ExecutedQuery(query);
        }
        private void btntim_Click(object sender, EventArgs e)
        {
            string TENKH = txttenkh.Text;
            string SDT = txtsdt.Text;
            DataTable dataTable = KhachHangDTO.Instance.Findkh(TENKH, SDT);
            if (dataTable.Rows.Count == 0)
            {
                MessageBox.Show("Find Fail, tên hoặc địa chỉ không tồn tại");
            }
            else
            {
                dtgvttkh.DataSource = dataTable;
            }
        }
        private void txttenkh_TextChanged(object sender, EventArgs e)
        {

            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length == 0)
                this.errorProvider1.SetError(ctr, "you must enter a name");
            else
                this.errorProvider1.Clear();
        }

        private void btnquaylai_Click(object sender, EventArgs e)
        {
            frmmenunhanvien td = new frmmenunhanvien();
            td.Show();
            this.Hide(); ;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmTKKhachHang_Load(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
