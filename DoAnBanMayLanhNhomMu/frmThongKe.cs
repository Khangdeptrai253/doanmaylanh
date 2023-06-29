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
    public partial class frmThongKe : Form
    {
        public frmThongKe()
        {
            InitializeComponent();
        }
        ConnectCSDL con = new ConnectCSDL();
        public void Load_Data()
        {
            con.ketnoi();
            dtgvThongKe.DataSource = con.GetData("select * from NhaCungCap");
            con.NgatKetNoi();
        }
        private void btnThongKe_Click(object sender, EventArgs e)
        {
            if (rdohdban.Checked == true)
            {
                con.ketnoi();
                Load_Data();
                string sqlTK = "select * from HoaDonBan where NGAYBAN = '" + mskthangnam.Text + "'";
                dtgvThongKe.DataSource = con.GetData(sqlTK);
            }
            if (rdohdnhap.Checked == true)
            {
                con.ketnoi();
                Load_Data();
                string sqlTK = "select * from HoaDonNhap where NGAYBAN = '" + mskthangnam.Text + "'";
                dtgvThongKe.DataSource = con.GetData(sqlTK);
            }
            else
                MessageBox.Show("không có dữ liệu");
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            frmMeNu tc = new frmMeNu();
            tc.Show();
            this.Hide();
        }
    }
}
