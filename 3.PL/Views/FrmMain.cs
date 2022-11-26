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
            if (_inFoNhanVien.IdLoaiTk == false)
            {
                btn_NhanVien.Enabled = false;
            }
            else
            {
                btn_NhanVien.Enabled = true;
            }
            load(loadForm);
        }
        public static NhanVien sendnhanvien()
        {
            return _inFoNhanVien;
        }
        public static void load(Panel loadForm)
        {
            loadForm.Controls.Clear();
            FrmSanPham frm = new FrmSanPham();
            frm.TopLevel = false;
            loadForm.Controls.Add(frm);
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void btn_NhanVien_Click(object sender, EventArgs e)
        {
            loadForm.Controls.Clear();
            FrmNhanVien frm = new FrmNhanVien();
            frm.TopLevel = false;
            loadForm.Controls.Add(frm);
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void btn_hoSo_Click(object sender, EventArgs e)
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


        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmLogin frm = new FrmLogin();
            frm.ShowDialog();
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            loadForm.Controls.Clear();
            FrmTTKhachHang frm = new FrmTTKhachHang(_inFoNhanVien.IdNhanVien);
            frm.TopLevel = false;
            loadForm.Controls.Add(frm);
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            loadForm.Controls.Clear();
            FrmThanhToan frm = new FrmThanhToan(_inFoNhanVien.IdNhanVien);
            frm.TopLevel = false;
            loadForm.Controls.Add(frm);
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Left;
            frm.Show();
        }

        private void btnDatHang_Click(object sender, EventArgs e)
        {
            loadForm.Controls.Clear();
            FrmDatHang frm = new FrmDatHang(_inFoNhanVien.IdNhanVien);
            frm.TopLevel = false;
            loadForm.Controls.Add(frm);
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            loadForm.Controls.Clear();
            FrmCTSanPham frm = new FrmCTSanPham();
            frm.TopLevel = false;
            loadForm.Controls.Add(frm);
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            loadForm.Controls.Clear();
            FrmChangePassword frm = new FrmChangePassword(_inFoNhanVien.Email);
            frm.TopLevel = false;
            loadForm.Controls.Add(frm);
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void btnQLKhac_Click(object sender, EventArgs e)
        {
            loadForm.Controls.Clear();
            FrmDanhMuc dm = new FrmDanhMuc();
            FrmDonVi dv = new FrmDonVi();
            FrmLoaiSp lsp = new FrmLoaiSp();
            FrmNhaCungCap ncc = new FrmNhaCungCap();
            FrmSanPham sp = new FrmSanPham();
            dm.TopLevel = false;
            loadForm.Controls.Add(dm);
            dm.Show();
            dv.TopLevel = false;
            loadForm.Controls.Add(dv);
            dv.Show();
            lsp.TopLevel = false;
            loadForm.Controls.Add(lsp);
            lsp.Show();
            ncc.TopLevel = false;
            loadForm.Controls.Add(ncc);
            ncc.Show();
            sp.TopLevel = false;
            loadForm.Controls.Add(sp);
            sp.Show();
        }
    }
}
