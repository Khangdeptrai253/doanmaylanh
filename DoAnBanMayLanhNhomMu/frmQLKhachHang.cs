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
    public partial class frmQLKhachHang : Form
    {
        public frmQLKhachHang()
        {
            InitializeComponent();
        }
        public void loadData()
        {
            string query = "select *  from KhachHang";

            dtgvqlkh.DataSource = DataProvider.Instance.ExecutedQuery(query);
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }      
        private void frmQLKhachHang_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            string makh = txtmakh.Text;
            string tenkh = txttenkh.Text;
            string diachi = txtdiachi.Text;
            string sdt = txtsdt.Text;
            if (makh!= string.Empty || tenkh != string.Empty || diachi != string.Empty || sdt != string.Empty)
            {
                if (KhachHangDTO.Instance.INkh(makh, tenkh, diachi, sdt) == 1)
                {
                    MessageBox.Show("Susses!!\n" + makh + "\n" + tenkh + "\n" + diachi + "\n" + sdt + "\n");
                }

                //int pId = NhaCungCapDTO.Instance.getIdEmp(tenncc);
            }
            else
            {
                MessageBox.Show("Không được để trống ô điền");
            }
            loadData();
        }
        private void btnsua_Click(object sender, EventArgs e)
        {
            string MAKH = txtmakh.Text;
            string TENKH = txttenkh.Text;
            string DiaChi = txtdiachi.Text;
            string SDT = txtsdt.Text;
            string message = "cập nhật thành công";
            string title = "Cập nhật";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            MessageBoxIcon messageBoxIcon = MessageBoxIcon.Question;
            DialogResult result = MessageBox.Show(message, title, buttons, messageBoxIcon);

            if (KhachHangDTO.Instance.updatekh(MAKH, TENKH, DiaChi, SDT))
            {
                MessageBox.Show("Cập nhật thành công!");
                if (result == DialogResult.Yes)
                {
                   loadData();
                }

            }
            else
            {
                MessageBox.Show("Cập nhật thất bại!");
            }
        }
        private void btnlammoi_Click(object sender, EventArgs e)
        {
            txttenkh.Clear();
            txtmakh.Clear();
            txtdiachi.Clear();
            txtsdt.Clear();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string MAKH = txtmakh.Text;
            string message = "Bạn chắc chắn muốn xóa";
            string title = "Xóa nhân viên";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            MessageBoxIcon messageBoxIcon = MessageBoxIcon.Question;
            DialogResult result = MessageBox.Show(message, title, buttons, messageBoxIcon);
            if (result == DialogResult.Yes)
            {
                if (KhachHangDTO.Instance.idelkh(MAKH))
                {
                    MessageBox.Show("Xóa thành công!");

                }
            }
            else
            {
                this.Hide();
            }
            loadData();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
          
        }

        private void btnquaylai_Click(object sender, EventArgs e)
        {
            frmmenunhanvien td = new frmmenunhanvien();
            td.Show();
            this.Hide();
        }


    }
}
