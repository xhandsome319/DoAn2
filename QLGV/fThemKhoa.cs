using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLGV
{
    public partial class fThemKhoa : Form
    {
        public fThemKhoa()
        {
            InitializeComponent();
        }

        private void btThemKhoa2_Click(object sender, EventArgs e)
        {
            string makhoa, tenkhoa;
            makhoa = tbMaK.Text;
            tenkhoa = tbTenK.Text;

            try
            {
                Connection kn = new Connection();
                kn.openConn();
                string sql = "insert into Khoa values('" + makhoa + "',N'" + tenkhoa + "') ";
                int kq = kn.executeUpdate(sql);
                if (kq == 1)
                    MessageBox.Show("Thêm Thành Công");
                else
                    MessageBox.Show("Không Thể Thêm");
                kn.closeConn();
                LoadFormKhoa();
            }
            catch (Exception)
            { MessageBox.Show("Vui lòng nhập thông tin hợp lý"); }

        }

        private void fThemKhoa_Activated(object sender, EventArgs e)
        {
            Connection kn = new Connection();
            kn.openConn();
            string sql = "select * from  Khoa";
            DataTable dl = kn.loadDataTable(sql);
            dgv_Khoa.DataSource = dl;
        }

        void LoadFormKhoa()
        {
            Connection kn = new Connection();
            kn.openConn();
            string sql = "select * from  Khoa";
            DataTable dl = kn.loadDataTable(sql);
            dgv_Khoa.DataSource = dl;
        }

        private void dgv_Khoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int hang;
            hang = dgv_Khoa.CurrentRow.Index;
            tbMaK.Text = dgv_Khoa.Rows[hang].Cells[0].Value.ToString();
            tbTenK.Text = dgv_Khoa.Rows[hang].Cells[1].Value.ToString();
        }

        private void bt_KLamTrong_Click(object sender, EventArgs e)
        {
            tbMaK.Clear();
            tbTenK.Clear();
        }

        private void bt_KLuuLai_Click(object sender, EventArgs e)
        {
            string mak, tenk;
            mak = tbMaK.Text;
            tenk = tbTenK.Text;

            try
            {
                Connection kn = new Connection();
                kn.openConn();
                string sql = "update Khoa set TenKhoa=N'" + tenk + "'where MaKhoa='" + mak + "'";
                int kq = kn.executeUpdate(sql);
                if (kq == 1)
                    MessageBox.Show("Sửa Thành Công");
                else
                    MessageBox.Show("Không Thể Sửa");
                kn.closeConn();
                LoadFormKhoa();
            }
            catch (Exception)
            { MessageBox.Show("Vui lòng nhập thông tin hợp lý"); }

        }

        private void bt_KXoa_Click(object sender, EventArgs e)
        {
            string mak;
            mak = tbMaK.Text;

            try
            {
                Connection kn = new Connection();
                kn.openConn();
                string sql = "delete from Khoa where MaKhoa='" + mak + "'  ";
                int kq = kn.executeUpdate(sql);
                if (kq == 1)
                    MessageBox.Show("Xóa Thành Công");
                else
                    MessageBox.Show("Không Thể Xóa");
                kn.closeConn();
                LoadFormKhoa();
            }
            catch (Exception)
            { }
            
        }
    }
}
