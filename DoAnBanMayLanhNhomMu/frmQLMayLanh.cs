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
    public partial class frmQLMayLanh : Form
    {
        public frmQLMayLanh()
        {
            InitializeComponent();
        }
        ConnectCSDL con = new ConnectCSDL();
        public void LoadData()
        {

            string query = "select *  from MayLanh";

            dtgvQLML.DataSource = DataProvider.Instance.ExecutedQuery(query);
        }

        private void tx_Click(object sender, EventArgs e)
        {

        }

        private void frmQLMayLanh_Load(object sender, EventArgs e)
        {
            LoadData();
            string query = "select * from NhaCungCap";
            cbomncc.DataSource = DataProvider.Instance.ExecutedQuery(query);
            cbomncc.DisplayMember = "MANCC";
            cbomncc.ValueMember = "MANCC";
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            string maml = txtmaml.Text;
            string tenml = txttenml.Text;
            int soluong = int.Parse(txtsoluong.Text);
            int giaban = int.Parse(txtgiaban.Text);
            if (maml != string.Empty || tenml != string.Empty || cbomncc.SelectedValue != string.Empty || soluong != int.MinValue || giaban!= float.MinValue)
            {
                if (MayLanhDTO.Instance.inml(maml,tenml,cbomncc.SelectedValue.ToString(), soluong, giaban) == 1)
                {
                    MessageBox.Show("Susses!!\n" + maml + "\n" + tenml + "\n" + cbomncc.SelectedValue + "\n" + soluong + "\n" +"\n" + giaban + "\n");
                }

                //int pId = NhaCungCapDTO.Instance.getIdEmp(tenncc);
            }
            else
            {
                MessageBox.Show("Không được để trống ô điền");
            }
            LoadData();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string maml = txtmaml.Text;
            string tenml = txttenml.Text;
            int soluong = int.Parse(txtsoluong.Text);
            int giaban = int.Parse(txtgiaban.Text);
            if (maml != string.Empty || tenml != string.Empty || cbomncc.SelectedValue != string.Empty || soluong != int.MinValue || giaban != float.MinValue)
            {
                if (MayLanhDTO.Instance.updateml(maml, tenml, cbomncc.SelectedValue.ToString(), soluong, giaban))
                {
                    MessageBox.Show("Susses!!\n" + maml + "\n" + tenml + "\n" + cbomncc.SelectedValue + "\n" + soluong + "\n" + "\n" + giaban + "\n");
                }

                //int pId = NhaCungCapDTO.Instance.getIdEmp(tenncc);
            }
            else
            {
                MessageBox.Show("Không được để trống ô điền");
            }
            LoadData();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            frmMeNu tc = new frmMeNu();
            tc.Show();
            this.Hide();
        }

        private void cbomncc_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string pId =txtmaml.Text;
            string message = "Bạn chắc chắn muốn xóa";
            string title = "Xóa nhân viên";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            MessageBoxIcon messageBoxIcon = MessageBoxIcon.Question;
            DialogResult result = MessageBox.Show(message, title, buttons, messageBoxIcon);
            if (result == DialogResult.Yes)
            {
                if (MayLanhDTO.Instance.idelml(pId))
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

        private void btnlammoi_Click(object sender, EventArgs e)
        {
            txtmaml.Clear();
            txttenml.Clear();
            txtgiaban.Clear();
            txtsoluong.Clear();
        }
    }
}
