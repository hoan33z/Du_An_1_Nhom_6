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

        private void button2_Click(object sender, EventArgs e)
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmLogin frm = new FrmLogin();
            frm.ShowDialog();
        }
    }
}
