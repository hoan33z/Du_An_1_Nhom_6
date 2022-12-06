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

        private void FrmThongKeDoanhThu_Load(object sender, EventArgs e)
        {

        }
    }
}



