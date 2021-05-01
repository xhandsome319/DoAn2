using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLGV
{
    public partial class fGiaoDienChinh : Form
    {
        public fGiaoDienChinh()
        {
            InitializeComponent();
            LoadComboboxKhoa();
            LoadComboboxTruong();
        }

        private void fGiaoDienChinh_Activated(object sender, EventArgs e)
        {
            Connection kn = new Connection();
            kn.openConn();
            string sql = "select * from  GiaoVien";
            DataTable dl = kn.loadDataTable(sql);
            dgvGV.DataSource = dl;

            string sql2 = "select * from HocPhan";
            DataTable dl2 = kn.loadDataTable(sql2);
            dgvHP.DataSource = dl2;

            string sql3 = "select MaGD,GiaoVien.MaGV,HoTen,MaHP,TenHP,NgayBD,NgayKT from GiangDay, GiaoVien, HocPhan where GiangDay.HPGiangDay = HocPhan.MaHP and GiaoVien.MaGV = GiangDay.MaGV";
            DataTable dl3 = kn.loadDataTable(sql3);
            dgvGD.DataSource = dl3;


            kn.closeConn();
        }

        void FormLoad()
        {
            Connection kn = new Connection();
            kn.openConn();
            string sql = "select * from  GiaoVien";
            DataTable dl = kn.loadDataTable(sql);
            dgvGV.DataSource = dl;
            kn.closeConn();
        }

        private void dgvGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int hang;
            hang = dgvGV.CurrentRow.Index;
            textBox1.Text = dgvGV.Rows[hang].Cells[0].Value.ToString();
            textBox2.Text = dgvGV.Rows[hang].Cells[1].Value.ToString();
            textBox3.Text = dgvGV.Rows[hang].Cells[2].Value.ToString();
            textBox4.Text = dgvGV.Rows[hang].Cells[3].Value.ToString();
            textBox5.Text = dgvGV.Rows[hang].Cells[4].Value.ToString();

            textBox6.Text = dgvGV.Rows[hang].Cells[5].Value.ToString();
            textBox7.Text = dgvGV.Rows[hang].Cells[6].Value.ToString();
            textBox8.Text = dgvGV.Rows[hang].Cells[7].Value.ToString();
            textBox9.Text = dgvGV.Rows[hang].Cells[8].Value.ToString();
            textBox10.Text = dgvGV.Rows[hang].Cells[9].Value.ToString();

            textBox11.Text = dgvGV.Rows[hang].Cells[10].Value.ToString();
            cbMaKhoa.Text = dgvGV.Rows[hang].Cells[11].Value.ToString();
            cbMaTruong.Text = dgvGV.Rows[hang].Cells[12].Value.ToString();
        }

        public void LoadComboboxKhoa()
        {
            Connection kn = new Connection();
            kn.openConn();
            string sql = "select MaKhoa from Khoa";
            DataTable dl = kn.loadDataTable(sql);
            cbMaKhoa.DataSource = dl;
            cbMaKhoa.DisplayMember = "MaKhoa";
            kn.closeConn();
        }
        public void LoadComboboxTruong()
        {
            Connection kn = new Connection();
            kn.openConn();
            string sql = "select MaTruong from NoiDaoTao";
            DataTable dl = kn.loadDataTable(sql);
            cbMaTruong.DataSource = dl;
            cbMaTruong.DisplayMember = "MaTruong";
            kn.closeConn();
        }

        private void btThemKhoa1_Click(object sender, EventArgs e)
        {
            fThemKhoa f = new fThemKhoa();
            f.ShowDialog();
            LoadComboboxKhoa();

        }

        private void btThemTruong1_Click(object sender, EventArgs e)
        {
            fThemTruong f = new fThemTruong();
            f.ShowDialog();
            LoadComboboxTruong();
        }

        private void btLamTrong_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();

            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();

            textBox11.Clear();
        }

        private void btThemGV_Click(object sender, EventArgs e)
        {
            string magv, hoten, ngsinh, phai, quequan, ngbdlam, hv, ndhv, hh, ndhh, loaigv, mak, matrdt;
            magv = textBox1.Text;
            hoten = textBox2.Text;
            ngsinh = textBox3.Text;
            phai = textBox4.Text;
            quequan = textBox5.Text;

            ngbdlam = textBox6.Text;
            hv = textBox7.Text;
            ndhv = textBox8.Text;
            hh = textBox9.Text;
            ndhh = textBox10.Text;

            loaigv = textBox11.Text;
            mak = cbMaKhoa.Text;
            matrdt = cbMaTruong.Text;

            try
            {
                Connection kn = new Connection();
                kn.openConn();

                string sql = "insert into GiaoVien values( '" + magv + "',N'" + hoten + "','" + ngsinh + "',N'" + phai + "',N'" + quequan + "',N'" + ngbdlam + "',N'" + hv + "','" + ndhv + "',N'" + hh + "','" + ndhh + "',N'" + loaigv + "','" + mak + "','" + matrdt + "') ";
                int kq = kn.executeUpdate(sql);
                if (kq == 1)
                    MessageBox.Show("Thêm Thành Công");
                else
                    MessageBox.Show("Không Thể Thêm");
                kn.closeConn();
                FormLoad();
            }
            catch (Exception)
            { MessageBox.Show("Vui lòng nhập thông tin hợp lý");  }
           
        }

        private void btLuuLai_Click(object sender, EventArgs e)
        {
            string magv, hoten, ngsinh, phai, quequan, ngbdlam, hv, ndhv, hh, ndhh, loaigv, mak, matrdt;
            magv = textBox1.Text;
            hoten = textBox2.Text;
            ngsinh = textBox3.Text;
            phai = textBox4.Text;
            quequan = textBox5.Text;

            ngbdlam = textBox6.Text;
            hv = textBox7.Text;
            ndhv = textBox8.Text;
            hh = textBox9.Text;
            ndhh = textBox10.Text;

            loaigv = textBox11.Text;
            mak = cbMaKhoa.Text;
            matrdt = cbMaTruong.Text;

            try
            {
                Connection kn = new Connection();
                kn.openConn();

                string sql = "Update GiaoVien set HoTen=N'" + hoten + "',NgaySinh='" + ngsinh + "',Phai =N'" + phai + "',QueQuan =N'" + quequan + "',NgayBDLam =N'" + ngbdlam + "',HocVi =N'" + hv + "',NamDatHocVi ='" + ndhv + "',HocHam =N'" + hh + "',NamDatHocHam ='" + ndhh + "',LoaiGV =N'" + loaigv + "',MaKhoa ='" + mak + "',MaTruongDT ='" + matrdt + "'where MaGV = '" + magv + "' ";

                int kq = kn.executeUpdate(sql);
                if (kq == 1)
                    MessageBox.Show("Chỉnh Sửa Thành Công");
                else
                    MessageBox.Show("Không Thể Chỉnh Sửa");
                kn.closeConn();
                FormLoad();
            }
            catch (Exception)
            { MessageBox.Show("Vui lòng nhập thông tin hợp lý"); }

        }

        private void btXoaGV_Click(object sender, EventArgs e)
        {
            string magv;
            magv = textBox1.Text;

            try
            {
                Connection kn = new Connection();
                kn.openConn();
                string sql = "delete from GiaoVien where MaGV='" + magv + "'  ";
                int kq = kn.executeUpdate(sql);
                if (kq == 1)
                    MessageBox.Show("Xóa Thành Công");
                else
                    MessageBox.Show("Không Thể Xóa");
                kn.closeConn();
                FormLoad();
            }
            catch (Exception)
            { }
            
        }

        private void dgvHP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int hang;
            hang = dgvHP.CurrentRow.Index;
            tbMaHP.Text = dgvHP.Rows[hang].Cells[0].Value.ToString();
            tbTenHP.Text = dgvHP.Rows[hang].Cells[1].Value.ToString();
            tbLoaiHP.Text = dgvHP.Rows[hang].Cells[2].Value.ToString();
            tbSoTC.Text = dgvHP.Rows[hang].Cells[3].Value.ToString();
            tbHocKy.Text = dgvHP.Rows[hang].Cells[4].Value.ToString();

        }

        private void btLamTrongHP_Click(object sender, EventArgs e)
        {
            tbMaHP.Clear();
            tbTenHP.Clear();
            tbLoaiHP.Clear();
            tbSoTC.Clear();
            tbHocKy.Clear();
        }

        private void btThemHP_Click(object sender, EventArgs e)
        {
            string mahp, tenhp, loaihp, sotc, hocky;
            mahp = tbMaHP.Text;
            tenhp = tbTenHP.Text;
            loaihp = tbLoaiHP.Text;
            sotc = tbSoTC.Text;
            hocky = tbHocKy.Text;

            try
            {
                Connection kn = new Connection();
                kn.openConn();
                string sql = "insert into HocPhan values('" + mahp + "',N'" + tenhp + "',N'" + loaihp + "','" + sotc + "',N'" + hocky + "'  )";
                int kq = kn.executeUpdate(sql);
                if (kq == 1)
                    MessageBox.Show("Thêm Thành Công");
                else
                    MessageBox.Show("Không Thể Thêm");
                kn.closeConn();
                FormLoad();
            }
            catch (Exception)
            { MessageBox.Show("Vui lòng nhập thông tin hợp lý"); }

        }

        private void btLuuHP_Click(object sender, EventArgs e)
        {
            string mahp, tenhp, loaihp, sotc, hocky;
            mahp = tbMaHP.Text;
            tenhp = tbTenHP.Text;
            loaihp = tbLoaiHP.Text;
            sotc = tbSoTC.Text;
            hocky = tbHocKy.Text;
            try
            {
                Connection kn = new Connection();
                kn.openConn();
                string sql = "update HocPhan set TenHP=N'" + tenhp + "',LoaiHP=N'" + loaihp + "',SoTC='" + sotc + "',HocKy=N'" + hocky + "' where MaHP='" + mahp + "' ";
                int kq = kn.executeUpdate(sql);
                if (kq == 1)
                    MessageBox.Show("Sửa Thành Công");
                else
                    MessageBox.Show("Không Thể Sửa");
                kn.closeConn();
                FormLoad();
            }
            catch (Exception)
            { MessageBox.Show("Vui lòng nhập thông tin hợp lý"); }

        }

        private void btXoaHP_Click(object sender, EventArgs e)
        {
            string mahp;
            mahp = tbMaHP.Text;
            try
            {
                Connection kn = new Connection();
                kn.openConn();
                string sql = "delete from HocPhan where MaHP='" + mahp + "'  ";
                int kq = kn.executeUpdate(sql);
                if (kq == 1)
                    MessageBox.Show("Xóa Thành Công");
                else
                    MessageBox.Show("Không Thể Xóa");
                kn.closeConn();
                FormLoad();
            }
            catch (Exception)
            { }
            
        }

        private void dgvGD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int hang;
            hang = dgvGD.CurrentRow.Index;
            tbMaGD.Text = dgvGD.Rows[hang].Cells[0].Value.ToString();
            tbGDMaGV.Text= dgvGD.Rows[hang].Cells[1].Value.ToString();
            tbGDMaHP.Text= dgvGD.Rows[hang].Cells[3].Value.ToString();
            tbNgayBD.Text= dgvGD.Rows[hang].Cells[5].Value.ToString();
            tbNgayKT.Text= dgvGD.Rows[hang].Cells[6].Value.ToString();
        }

        private void btLamTrongGD_Click(object sender, EventArgs e)
        {
            tbMaGD.Clear();
            tbGDMaGV.Clear();
            tbGDMaHP.Clear();
            tbNgayBD.Clear();
            tbNgayKT.Clear();
        }

        private void btThemGD_Click(object sender, EventArgs e)
        {
            string magd, magv2, mahp2, ngbd, ngkt;
            magd = tbMaGD.Text;
            magv2 = tbGDMaGV.Text;
            mahp2 = tbGDMaHP.Text;
            ngbd = tbNgayBD.Text;
            ngkt = tbNgayKT.Text;

            try
            {
                Connection kn = new Connection();
                kn.openConn();
                string sql = "insert into GiangDay values('" + magd + "','" + magv2 + "','" + mahp2 + "','" + ngbd + "','" + ngkt + "')";
                int kq = kn.executeUpdate(sql);
                if (kq == 1)
                    MessageBox.Show("Thêm Thành Công");
                else
                    MessageBox.Show("Không Thể Thêm");
                kn.closeConn();
                FormLoad();
            }
            catch (Exception)
            { MessageBox.Show("Vui lòng nhập thông tin hợp lý"); }
            
        }

        private void btLuuGD_Click(object sender, EventArgs e)
        {
            string magd, magv2, mahp2, ngbd, ngkt;
            magd = tbMaGD.Text;
            magv2 = tbGDMaGV.Text;
            mahp2 = tbGDMaHP.Text;
            ngbd = tbNgayBD.Text;
            ngkt = tbNgayKT.Text;

            try
            {
                Connection kn = new Connection();
                kn.openConn();
                string sql = "update GiangDay set MaGV='" + magv2 + "',HPGiangDay='" + mahp2 + "',NgayBD='" + ngbd + "',NgayKT='" + ngkt + "' where MaGD='" + magd + "' ";
                int kq = kn.executeUpdate(sql);
                if (kq == 1)
                    MessageBox.Show("Sửa Thành Công");
                else
                    MessageBox.Show("Không Thể Sửa");
                kn.closeConn();
                FormLoad();
            }
            catch (Exception)
            { MessageBox.Show("Vui lòng nhập thông tin hợp lý"); }

        }

        private void btXoaGD_Click(object sender, EventArgs e)
        {
            string magd;
            magd = tbMaGD.Text;
            try
            {
                Connection kn = new Connection();
                kn.openConn();
                string sql = "delete from GiangDay where MaGD='" + magd + "'  ";
                int kq = kn.executeUpdate(sql);
                if (kq == 1)
                    MessageBox.Show("Xóa Thành Công");
                else
                    MessageBox.Show("Không Thể Xóa");
                kn.closeConn();
                FormLoad();
            }
            catch (Exception)
            { }


           
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string tim;
            tim = tbTimKiem.Text;

            Connection ketnoi = new Connection();
            ketnoi.openConn();

            string sql = "SELECT * FROM GiaoVien WHERE MaGV + HoTen + HocHam + HocVi + LoaiGV + MaKhoa  like N'%" + tim + "%'";
            DataTable dt = ketnoi.loadDataTable(sql);
            dgvGV.DataSource = dt;
            dgvGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ketnoi.closeConn();

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            FormLoad();
        }
    }
}
