using _1.DAL.Models;
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
    public partial class SanPham : Form
    {
        public SanPham()
        {
            InitializeComponent();
        }
        public void LoadData()
        {
            dgridSanPham.ColumnCount = 2;
            dgridSanPham.Columns[0].Name = "ID";
            dgridSanPham.Columns[0].Visible = false;
            dgridSanPham.Columns[1].Name = "TenDanhMuc";
            dgridSanPham.Rows.Clear();
            //foreach (var x in )
            //{
            //    dgridSanPham.Rows.Add(x.IdDanhMuc, x.TenDanhMuc);
            //}
        }
        //public SanPham GetDataFromDb()
        //{
        //    return new SanPham() {  = txtSanPham.Text };
        //}
    }
}
