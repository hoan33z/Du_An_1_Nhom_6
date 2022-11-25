using _2.BUS.IServices;
using _2.BUS.Service;
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
    public partial class FrmThongTinNv : Form
    {
        INhanVienService _iNhanVien;
        public FrmThongTinNv(string title)
        {
            InitializeComponent();
            _iNhanVien = new NhanVienService();
            txt_Email.Text = title;
            txt_Email.Enabled = false;
            loadForm();
        }
        public void loadForm()
        {
            var acc = _iNhanVien.getlstNv().FirstOrDefault(c => c.Email == txt_Email.Text);
            txt_DiaChi.Text = acc.DiaChi;
            txt_Name.Text = acc.TenNv;
            txt_SDT.Text = acc.SDT;
            cbx_gioiTinh.Text = acc.GioiTinh == true ? "Nam" : "Nữ";
            dateTimePicker1.Value = acc.NamSinh.Date;
        }


    }
}
