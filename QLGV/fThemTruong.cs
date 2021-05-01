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
    public partial class fThemTruong : Form
    {
     

        public fThemTruong()
        {
            InitializeComponent();
        }

        private void btThemTruong2_Click(object sender, EventArgs e)
        {
            string matruong, tentruong, thanhpho, quocgia;
            matruong = tbMaTr.Text;
            tentruong = tbTenTr.Text;
            thanhpho = tbTp.Text;
            quocgia = tbQg.Text;

            try
            {
                Connection kn = new Connection();
                kn.openConn();
                string sql = "insert into NoiDaoTao values('" + matruong + "',N'" + tentruong + "',N'" + thanhpho + "',N'" + quocgia + "') ";
                int kq = kn.executeUpdate(sql);
                if (kq == 1)
                    MessageBox.Show("Thêm Thành Công");
                else
                    MessageBox.Show("Không Thể Thêm");
                kn.closeConn();

                LoadNoiDaoTao();
            }
            catch (Exception)
            { MessageBox.Show("Vui lòng nhập thông tin hợp lý"); }

        }

        private void fThemTruong_Activated(object sender, EventArgs e)
        {
            Connection kn = new Connection();
            kn.openConn();
            string sql = "select * from  NoiDaoTao";
            DataTable dl = kn.loadDataTable(sql);
            dgvTruong.DataSource = dl;
        }
        void LoadNoiDaoTao()
        {
            Connection kn = new Connection();
            kn.openConn();
            string sql = "select * from  NoiDaoTao";
            DataTable dl = kn.loadDataTable(sql);
            dgvTruong.DataSource = dl;
        }

        private void dgvTruong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int hang;
            hang = dgvTruong.CurrentRow.Index;
            tbMaTr.Text = dgvTruong.Rows[hang].Cells[0].Value.ToString();
            tbTenTr.Text = dgvTruong.Rows[hang].Cells[1].Value.ToString();
            tbTp.Text = dgvTruong.Rows[hang].Cells[2].Value.ToString();
            tbQg.Text = dgvTruong.Rows[hang].Cells[3].Value.ToString();

        }

        private void btTLamTrong_Click(object sender, EventArgs e)
        {
            tbMaTr.Clear();
            tbTenTr.Clear();
            tbTp.Clear();
            tbQg.Clear();
        }

        private void btTLuuLai_Click(object sender, EventArgs e)
        {
            string matr, tentr, tp, qg;

            matr = tbMaTr.Text;
            tentr = tbTenTr.Text;
            tp = tbTp.Text;
            qg = tbQg.Text;

            try
            {
                Connection kn = new Connection();
                kn.openConn();
                string sql = "update NoiDaoTao set TenTruong=N'" + tentr + "',ThanhPho=N'" + tp + "',QuocGia=N'" + qg + "'   where MaTruong='" + matr + "'";
                int kq = kn.executeUpdate(sql);
                if (kq == 1)
                    MessageBox.Show("Sửa Thành Công");
                else
                    MessageBox.Show("Không Thể Sửa");
                kn.closeConn();
                LoadNoiDaoTao();
            }
            catch (Exception)
            { MessageBox.Show("Vui lòng nhập thông tin hợp lý"); }
            
        }

        private void btTXoaTruong_Click(object sender, EventArgs e)
        {
            string matr;
            matr = tbMaTr.Text;

            try
            {
                Connection kn = new Connection();
                kn.openConn();
                string sql = "delete from NoiDaoTao where MaTruong='" + matr + "'  ";
                int kq = kn.executeUpdate(sql);
                if (kq == 1)
                    MessageBox.Show("Xóa Thành Công");
                else
                    MessageBox.Show("Không Thể Xóa");
                kn.closeConn();
                LoadNoiDaoTao();
            }
            catch (Exception)
            { }
            
        }
    }
}
