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
            foreach (var x in )
            {
                dgridSanPham.Rows.Add(x.IdDanhMuc, x.TenDanhMuc);
            }
        }
        public SanPham GetDataFromDb()
        {
            return new SanPham() {  = txtSanPham.Text };
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(.Add(GetDataFromDb()));
            LoadData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var sanPham = GetDataFromDb();
            sanPham. = _idWhenClick;
            MessageBox.Show(_IdanhMucService.Delete(danhMuc));
            LoadData();
        }

        private void dgridDanhMuc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            if (rowindex == -1 || rowindex == _IdanhMucService.GetAll().Count) return;
            _idWhenClick = Guid.Parse(dgridDanhMuc.Rows[rowindex].Cells[0].Value.ToString());
            var danhMuc = _IdanhMucService.GetAll().FirstOrDefault(c => c.IdDanhMuc == _idWhenClick);
            txtDanhMuc.Text = sanPham.TenDanhMuc;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var danhMuc = GetDataFromDb();
            danhMuc.IdDanhMuc = _idWhenClick;
            MessageBox.Show(_IdanhMucService.Update(danhMuc));
            LoadData();
        }



    }
}
