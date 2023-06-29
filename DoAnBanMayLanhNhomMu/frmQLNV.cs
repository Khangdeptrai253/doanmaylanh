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
    public partial class frmQLNV : Form
    {
        public frmQLNV()
        {
            InitializeComponent();
        }
        ConnectCSDL con = new ConnectCSDL();

        public void LoadData()
        {
            string query = "select *  from NhanVien";

            dtgvqlnv.DataSource = DataProvider.Instance.ExecutedQuery(query);
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            string manv = txtmanv.Text;
            string tennv = txttennv.Text;
            string gioitinh = txtgioitinh.Text;
            string diachi = txtdiachi.Text;
            string sdt = txtsdt.Text;
            if (manv != string.Empty || tennv != string.Empty || diachi != string.Empty || gioitinh != string.Empty || sdt != string.Empty)
            {
                if (NhanVienDTO.Instance.newnv(manv, tennv,gioitinh, diachi, sdt) == 1)
                {
                    MessageBox.Show("Susses!!\n" + manv + "\n" + tennv + "\n" + "\n" + gioitinh + "\n" + diachi + "\n" + sdt + "\n");
                }

                //int pId = NhaCungCapDTO.Instance.getIdEmp(tenncc);
            }
            else
            {
                MessageBox.Show("Không được để trống ô điền");
            }
            LoadData();
        }

        private void frmQLNV_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string manv = txtmanv.Text;
            string message = "Bạn chắc chắn muốn xóa";
            string title = "Xóa nhân viên";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            MessageBoxIcon messageBoxIcon = MessageBoxIcon.Question;
            DialogResult result = MessageBox.Show(message, title, buttons, messageBoxIcon);
            if (result == DialogResult.Yes)
            {
                if (NhanVienDTO.Instance.idelnv(manv))
                {
                    MessageBox.Show("Xóa thành công!");

                }
            }
            else
            {
                this.Hide();
            }
            LoadData();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string MaNCC = txtmanv.Text;
            string TenNCC = txttennv.Text;
            string GioiTinh = txtgioitinh.Text;
            string DiaChi = txtdiachi.Text;
            string SDT = txtsdt.Text;
            string message = "cập nhật thành công";
            string title = "Cập nhật";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            MessageBoxIcon messageBoxIcon = MessageBoxIcon.Question;
            DialogResult result = MessageBox.Show(message, title, buttons, messageBoxIcon);

            if (NhanVienDTO.Instance.updatenv(MaNCC, TenNCC,GioiTinh, DiaChi, SDT))
            {
                MessageBox.Show("Cập nhật thành công!");
                if (result == DialogResult.Yes)
                {
                    LoadData();
                }
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại!");
            }
        }

        private void btnlammoi_Click(object sender, EventArgs e)
        {
            txtmanv.Clear();
            txttennv.Clear();
            txtgioitinh.Clear();
            txtdiachi.Clear();
            txtsdt.Clear();
        }

        private void btnquaylai_Click(object sender, EventArgs e)
        {
            frmMeNu tc = new frmMeNu();
            tc.Show();
            this.Hide();
        }
    }
}
