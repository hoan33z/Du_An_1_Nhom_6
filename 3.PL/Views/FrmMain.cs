using _1.DAL.Models;
using _2.BUS.IServices;
using _2.BUS.Service;
using _3_GUI_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.PL.Views
{
    public partial class FrmMain : Form

    {
        INhanVienService _iNhanVien;

        public static NhanVien _inFoNhanVien;
        
        public FrmMain(string title)
        {
            InitializeComponent();
            _iNhanVien = new NhanVienService();
            _inFoNhanVien = new NhanVien();
            _inFoNhanVien = _iNhanVien.getlstNv().FirstOrDefault(c => c.Email == title);
            if (_inFoNhanVien.TrangThaiPass==false)
            {
                MessageBox.Show("Bạn phải đổi mật khẩu khi lần đầu đăng nhập vào hệ thông !!!", "Thông báo");
                loadForm.Controls.Clear();
                title = _inFoNhanVien.Email;
                FrmChangePassword frm = new FrmChangePassword(title);
                frm.TopLevel = false;
                loadForm.Controls.Add(frm);
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.Dock = DockStyle.Fill;
                frm.Show();
                menu_quanLy.Enabled = false;
                menu_thongKe.Enabled = false;
            }
            else 
            {
                loadForm.Controls.Clear();
                FrmTTKhachHang frm = new FrmTTKhachHang(_inFoNhanVien.IdNhanVien);
                frm.TopLevel = false;
                loadForm.Controls.Add(frm);
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.Dock = DockStyle.Fill;
                frm.Show();
            }

            if (_inFoNhanVien.IdLoaiTk == false)
            {
                qlNhanVien.Enabled = false;
            }
            else
            {
                qlNhanVien.Enabled = true;
            }
        }
        public static NhanVien sendnhanvien()
        {
            return _inFoNhanVien;
        }
                
        private void menu_thongkeTonKho_Click(object sender, EventArgs e)
        {
            loadForm.Controls.Clear();            
            FrmThongKeTonKho frm = new FrmThongKeTonKho();
            frm.TopLevel = false;
            loadForm.Controls.Add(frm);
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void ThongKeDoanhThu_Click(object sender, EventArgs e)
        {
            loadForm.Controls.Clear();
            FrmThongKeDoanhThu frm = new FrmThongKeDoanhThu();
            frm.TopLevel = false;
            loadForm.Controls.Add(frm);
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void menu_myInfor_Click(object sender, EventArgs e)
        {
            loadForm.Controls.Clear();
            string title = _inFoNhanVien.Email;
            FrmThongTinNv frm = new FrmThongTinNv(title);
            frm.TopLevel = false;
            loadForm.Controls.Add(frm);
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void menu_DoiMk_Click(object sender, EventArgs e)
        {
            loadForm.Controls.Clear();
            string title = _inFoNhanVien.Email;
            FrmChangePassword frm = new FrmChangePassword(title);
            frm.TopLevel = false;
            loadForm.Controls.Add(frm);
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void qlNhanVien_Click(object sender, EventArgs e)
        {
            loadForm.Controls.Clear();
            FrmNhanVien frm = new FrmNhanVien();
            frm.TopLevel = false;
            loadForm.Controls.Add(frm);
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }
        private void qlSanPhamCT_Click(object sender, EventArgs e)
        {
            loadForm.Controls.Clear();
            FrmCTSanPham frm = new FrmCTSanPham();
            frm.TopLevel = false;
            loadForm.Controls.Add(frm);
            loadForm.Height= frm.Height;
            loadForm.Width= frm.Width;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void QLLoaiSp_Click(object sender, EventArgs e)
        {
            loadForm.Controls.Clear();
            FrmSanPham frm = new FrmSanPham();
            frm.TopLevel = false;
            loadForm.Controls.Add(frm);
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void loạiSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadForm.Controls.Clear();
            FrmLoaiSp frm = new FrmLoaiSp();
            frm.TopLevel = false;
            loadForm.Controls.Add(frm);
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }
        private void quảnLýKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadForm.Controls.Clear();
            FrmTTKhachHang frm = new FrmTTKhachHang(_inFoNhanVien.IdNhanVien);
            frm.TopLevel = false;
            loadForm.Controls.Add(frm);
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }
        private void QLKhacToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadForm.Controls.Clear();
            FrmDanhMuc frm = new FrmDanhMuc();
            FrmSanPham frm1 = new FrmSanPham();
            FrmLoaiSp frm2 = new FrmLoaiSp();
            FrmNhaCungCap frm3 = new FrmNhaCungCap();
            FrmDonVi frm4 = new FrmDonVi();
            frm.TopLevel = false;
            frm1.TopLevel = false;
            frm2.TopLevel = false;
            frm3.TopLevel = false;
            frm4.TopLevel = false;
            loadForm.Controls.Add(frm);
            loadForm.Controls.Add(frm1);
            loadForm.Controls.Add(frm2);
            loadForm.Controls.Add(frm3);
            loadForm.Controls.Add(frm4);
            frm.Show();
            frm1.Show();
            frm2.Show();
            frm3.Show();
            frm4.Show();
        }

        private void DangXuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLogin frmlg = new FrmLogin();
            frmlg.Show();
        }

        private void thanhtoanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmThanhToan frmtt = new FrmThanhToan(Guid.Empty);
            frmtt.TopLevel = false;
            loadForm.Controls.Add(frmtt);
            frmtt.Show();
        }

        private void thốngKêHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadForm.Controls.Clear();
            FrmQuanLyHoaDon frm = new FrmQuanLyHoaDon();
            frm.TopLevel = false;
            loadForm.Controls.Add(frm);
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }
    }
}
