using _1.DAL.Models;
using _2.BUS.IServices;
using _2.BUS.Service;
using _2.BUS.ViewModels;
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
    public partial class FrmThongKeDoanhThu : Form
    {
        ISanPhamService _ISanPhamService;
        private VatLieuDbContext _db;
        public FrmThongKeDoanhThu()
        {
            InitializeComponent();
            
            dgrid_doanhThu.Enabled = false;
            _ISanPhamService = new SanPhamService();
            _db = new VatLieuDbContext();
            
        }
           
       

        public void dt_tuNgay_ValueChanged(object sender, EventArgs e)
        {
            if (dt_tuNgay.Value > dt_denNgay.Value)
            {
                MessageBox.Show("Ngày không hợp lệ!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dt_tuNgay.Select();
                return;
            }
        }

        public void dt_tuNgay_Leave(object sender, EventArgs e)
        {
            if (dt_tuNgay.Value > dt_denNgay.Value)
            {
                MessageBox.Show("Ngày không hợp lệ!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dt_tuNgay.Select();
                return;
            }
        }

        public void dt_denNgay_ValueChanged(object sender, EventArgs e)
        {
            if (dt_tuNgay.Value > dt_denNgay.Value)
            {
                MessageBox.Show("Ngày không hợp lệ!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dt_tuNgay.Select();
                return;
            }
        }

        public void dt_denNgay_Leave(object sender, EventArgs e)
        {
            if (dt_tuNgay.Value > dt_denNgay.Value)
            {
                MessageBox.Show("Ngày không hợp lệ!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dt_tuNgay.Select();
                return;
            }
        }

        public void FrmThongKeDoanhThu_Load(object sender, EventArgs e)
        {
            dt_tuNgay.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dt_denNgay.Value = DateTime.Now;
        }
    }
}
