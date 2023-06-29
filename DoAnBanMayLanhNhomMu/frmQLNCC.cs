using DoAnBanMayLanhNhomMu.MyCompanyDTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnBanMayLanhNhomMu
{
    public partial class frmQLNCC : Form
    {
       // BindingSource BindingSourceEmp = new BindingSource();
        public frmQLNCC()
        {
            InitializeComponent();
        }
        public void loadEmpList()
        {
            string query = "select *  from NhaCungCap";

            dtgvqlncc.DataSource = DataProvider.Instance.ExecutedQuery(query);
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            string mancc = txtmncc.Text;
            string   tenncc = txttenncc.Text;
            string diachi = txtdiachi.Text;
            string sdt = txtsdt.Text;
            if (mancc != string.Empty || tenncc != string.Empty || diachi != string.Empty || sdt != string.Empty)
            {
                    if (NhaCungCapDTO.Instance.newEmployee(mancc, tenncc, diachi, sdt) == 1)
                    {
                        MessageBox.Show("Susses!!\n" + mancc + "\n" + tenncc + "\n" + diachi + "\n" + sdt + "\n");
                    }

                    //int pId = NhaCungCapDTO.Instance.getIdEmp(tenncc);
                }
                else
                {
                    MessageBox.Show("Không được để trống ô điền");
                }            
        }

        private void frmQLNCC_Load(object sender, EventArgs e)
        {
            loadEmpList();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string pId = txtmncc.Text;
            string message = "Bạn chắc chắn muốn xóa";
            string title = "Xóa nhân viên";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            MessageBoxIcon messageBoxIcon = MessageBoxIcon.Question;
            DialogResult result = MessageBox.Show(message, title, buttons, messageBoxIcon);
            if (result == DialogResult.Yes)
            {
                if (NhaCungCapDTO.Instance.idelncc(pId))
                {
                    MessageBox.Show("Xóa thành công!");

                }
            }
            else
            {
                this.Hide();
            }
            loadEmpList();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string MaNCC = txtmncc.Text;
            string TenNCC = txttenncc.Text;
            string DiaChi = txtdiachi.Text;
            string SDT = txtsdt.Text;
            string message = "cập nhật thành công";
            string title = "Cập nhật";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            MessageBoxIcon messageBoxIcon = MessageBoxIcon.Question;
            DialogResult result = MessageBox.Show(message, title, buttons, messageBoxIcon);

            if (NhaCungCapDTO.Instance.updateNCC(MaNCC,TenNCC,DiaChi,SDT))
            {
                MessageBox.Show("Cập nhật thành công!");
                if (result == DialogResult.Yes)
                {
                    loadEmpList();
                }

            }
            else
            {
                MessageBox.Show("Cập nhật thất bại!");
            }
        }

        private void btnlammoi_Click(object sender, EventArgs e)
        {
            txttenncc.Clear();
            txtmncc.Clear();
            txtdiachi.Clear();
            txtsdt.Clear();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            frmMeNu tc = new frmMeNu();
            tc.Show();
            this.Hide();
        }


    }
}
