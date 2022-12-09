using _1.DAL.Models;
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
    public partial class FrmSanPham : Form
    {
        ISanPhamService _IsanPhamService;
        Guid _idWhenClick;
        public FrmSanPham()
        {
            InitializeComponent();
            _IsanPhamService= new SanPhamService();
            LoadData();
        }
        public void LoadData()
        {
            dgridSanPham.ColumnCount = 2;
            dgridSanPham.Columns[0].Name = "ID";
            dgridSanPham.Columns[0].Visible = false;
            dgridSanPham.Columns[1].Name = "TenSanPham";
            dgridSanPham.Rows.Clear();
            foreach (var x in _IsanPhamService.GetAll())
            {
                dgridSanPham.Rows.Add(x.IdSp, x.TenSp);
            }
        }
        public SanPham GetDataFromDb()
        {
            return new SanPham() { TenSp = txtSanPham.Text };
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (_idWhenClick == Guid.Empty)
            {
                MessageBox.Show("không tìm thấy sản phẩm");
            }
            else
            {
                var sanPham = GetDataFromDb();
                sanPham.IdSp = _idWhenClick;
                MessageBox.Show(_IsanPhamService.Delete(sanPham));
                LoadData();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (_idWhenClick == Guid.Empty)
            {
                MessageBox.Show("không tìm thấy sản phẩm");
            }
            else
            {
                var sanPham = GetDataFromDb();
                sanPham.IdSp = _idWhenClick;
                MessageBox.Show(_IsanPhamService.Update(sanPham));
                LoadData();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_IsanPhamService.Add(GetDataFromDb()));
            LoadData();
        }

        private void dgridSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            if (rowindex == -1 || rowindex == _IsanPhamService.GetAll().Count) return;
            _idWhenClick = Guid.Parse(dgridSanPham.Rows[rowindex].Cells[0].Value.ToString());
            var sanPham = _IsanPhamService.GetAll().FirstOrDefault(c => c.IdSp == _idWhenClick);
            txtSanPham.Text = sanPham.TenSp;

        }
    }
}
