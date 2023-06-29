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
    public partial class frmQuanLyHDB : Form
    {
        public frmQuanLyHDB()
        {
            InitializeComponent();
        }


        public void loaddata()
        {
            string query = "select *  from HoaDonBan";

            dtgvhoadonban.DataSource = DataProvider.Instance.ExecutedQuery(query);
        }
        private void btnthem_Click(object sender, EventArgs e)
        {
            string mahdb = txtmahd.Text;
            string manv = txtmanv.Text;
            string makh = txtmakh.Text;
            string maml = txtmaml.Text;
            int soluong = int.Parse(txtsoluong.Text);
            float dongia = float.Parse(txtdg.Text);
            float tongtien = (float)dongia * soluong;
            txttongtien.Text = tongtien.ToString(); 
            DateTime ngayban = dateTimePicker1.Value;
            string diachi = txtdiachi.Text;
            if (mahdb != string.Empty || manv != string.Empty || makh != string.Empty || maml != string.Empty || soluong != int.MinValue || dongia != float.MinValue || tongtien != float.MinValue || diachi != string.Empty )
            {
                if (HoaDonBanDTO.Instance.inhdbc(mahdb,manv,makh,maml,soluong,dongia,tongtien,ngayban,diachi) == 1)
                {
                    MessageBox.Show("Susses!!\n" + mahdb + "\n" + manv + "\n" + makh + "\n" +maml + "\n" + soluong + "\n" + dongia +"\n" + tongtien + "\n" + ngayban +"\n" + diachi +"\n");
                }

                //int pId = NhaCungCapDTO.Instance.getIdEmp(tenncc);
            }
            else
            {
                MessageBox.Show("Không được để trống ô điền");
            }
            loaddata();
        }

        private void frmQuanLyHDB_Load(object sender, EventArgs e)
        {
            loaddata();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string pId = txtmahd.Text;
            string message = "Bạn chắc chắn muốn xóa";
            string title = "Xóa nhân viên";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            MessageBoxIcon messageBoxIcon = MessageBoxIcon.Question;
            DialogResult result = MessageBox.Show(message, title, buttons, messageBoxIcon);
            if (result == DialogResult.Yes)
            {
                if (HoaDonBanDTO.Instance.delhdb(pId))
                {
                    MessageBox.Show("Xóa thành công!");

                }
            }
            else
            {
                this.Hide();
            }
            loaddata();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string mahdb = txtmahd.Text;
            string manv = txtmanv.Text;
            string makh = txtmakh.Text;
            string maml = txtmaml.Text;
            int soluong = int.Parse(txtsoluong.Text);
            float dongia = float.Parse(txtdg.Text);
            float tongtien = (float)dongia * soluong;
            txttongtien.Text = tongtien.ToString();
            DateTime ngayban = dateTimePicker1.Value;
            string diachi = txtdiachi.Text;
            if (mahdb != string.Empty || manv != string.Empty || makh != string.Empty || maml != string.Empty || soluong != int.MinValue || dongia != float.MinValue || tongtien != float.MinValue || diachi != string.Empty)
            {
                if (HoaDonBanDTO.Instance.uphdb(mahdb, manv, makh, maml, soluong, dongia, tongtien, ngayban, diachi))
                {
                    MessageBox.Show("Susses!!\n" + mahdb + "\n" + manv + "\n" + makh + "\n" + maml + "\n" + soluong + "\n" + dongia + "\n" + tongtien + "\n" + ngayban + "\n" + diachi + "\n");
                }

                //int pId = NhaCungCapDTO.Instance.getIdEmp(tenncc);
            }
            else
            {
                MessageBox.Show("Không được để trống ô điền");
            }
            loaddata();
        }

        private void btnlammoi_Click(object sender, EventArgs e)
        {
            txtmahd.Clear();
            txtmanv.Clear();
            txtmakh.Clear();
            txtmaml.Clear();
            txtsoluong.Clear();
            txtdg.Clear();
            txttongtien.Clear();
            txtdiachi.Clear();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            frmMeNu tc = new frmMeNu();
            tc.Show();
            tc.Hide();
            frmmenunhanvien td = new frmmenunhanvien();
            td.Show();
            this.Hide(); ;
        }
    }
}
