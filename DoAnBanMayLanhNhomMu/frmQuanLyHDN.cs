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
    public partial class frmQuanLyHDN : Form
    {
        public frmQuanLyHDN()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    

        public void LoadData()
        {
            string query = "select *  from HoaDonNhap";

            dtgvHDNhap.DataSource = DataProvider.Instance.ExecutedQuery(query);
        }
        private void frmQuanLyHDN_Load(object sender, EventArgs e)
        {
            LoadData();
            //cbomancc.DataSource = con.GetData("select * from NhaCungCap");
            string query = "select * from NhaCungCap";
            cbomancc.DataSource = DataProvider.Instance.ExecutedQuery(query);
            cbomancc.ValueMember = "MANCC";
            cbomancc.DisplayMember = "MANCC";
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            string mahdn = txtmahoadon.Text;
            string manv = txtmanv.Text;
            string maml = txtmaml.Text;
            int soluong = int.Parse(txtsoluong.Text);
            float dongia = float.Parse(txtdongia.Text);
            float tongtien = (float)soluong * dongia;
            DateTime ngayban = dateTimePicker1.Value;
            string diachi = txtdiachi.Text;
            if (mahdn != string.Empty || manv != string.Empty || maml != string.Empty || cbomancc.SelectedValue != string.Empty || soluong != int.MinValue || dongia != float.MinValue || tongtien != float.MinValue || diachi != string.Empty)
            {
                if (HoaDonNhapDTO.Instance.inhdn(mahdn, manv, maml, cbomancc.SelectedValue.ToString(), soluong, ngayban, diachi, dongia, tongtien) == 1)
                {
                    MessageBox.Show("Susses!!\n" + mahdn + "\n" + manv + "\n" + maml + "\n" + cbomancc.SelectedValue + "\n" + soluong + "\n"+ ngayban + "\n" + diachi + "\n" + dongia + "\n" + tongtien + "\n");
                }

                //int pId = NhaCungCapDTO.Instance.getIdEmp(tenncc);
            }
            else
            {
                MessageBox.Show("Không được để trống ô điền");
            }
            LoadData();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string pId = txtmahoadon.Text;
            string message = "Bạn chắc chắn muốn xóa";
            string title = "Xóa nhân viên";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            MessageBoxIcon messageBoxIcon = MessageBoxIcon.Question;
            DialogResult result = MessageBox.Show(message, title, buttons, messageBoxIcon);
            if (result == DialogResult.Yes)
            {
                if (HoaDonNhapDTO.Instance.delhdn(pId))
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
            string mahdn = txtmahoadon.Text;
            string manv = txtmanv.Text;
            string maml = txtmaml.Text;
            int soluong = int.Parse(txtsoluong.Text);
            float dongia = float.Parse(txtdongia.Text);
            float tongtien = (float)dongia * soluong;
            txttongtien.Text= tongtien.ToString();
            DateTime ngayban = dateTimePicker1.Value;
            string diachi = txtdiachi.Text;
            if (mahdn != string.Empty || manv != string.Empty || maml != string.Empty || cbomancc.SelectedValue != string.Empty || soluong != int.MinValue || dongia != float.MinValue || diachi != string.Empty)
            {
                if (HoaDonNhapDTO.Instance.uphdb(mahdn, manv, maml, cbomancc.SelectedValue.ToString(), soluong, dongia,tongtien,ngayban,diachi))
                {
                    MessageBox.Show("Susses!!\n" + mahdn + "\n" + manv + "\n" + maml + "\n" + cbomancc.SelectedValue + "\n" + soluong + "\n" + ngayban + "\n" + diachi + "\n" + dongia + "\n" + tongtien + "\n");
                }

                //int pId = NhaCungCapDTO.Instance.getIdEmp(tenncc);
            }
            else
            {
                MessageBox.Show("Không được để trống ô điền");
            }
            LoadData();
        }

        private void btnlammoi_Click(object sender, EventArgs e)
        {
            txtmahoadon.Clear();
            txtmanv.Clear();
            txtmaml.Clear();
            txtsoluong.Clear();
           
            txtdiachi.Clear();
            txtdongia.Clear();
         
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            frmMeNu tc = new frmMeNu();
            tc.Show();
            this.Hide();
        }
    }
}
