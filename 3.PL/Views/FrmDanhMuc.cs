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
    public partial class FrmDanhMuc : Form
    {
        IDanhMucService _IdanhMucService;
        Guid _idWhenClick;
        public FrmDanhMuc()
        {
            InitializeComponent();
            _IdanhMucService = new DanhMucService();
            LoadData();
        }
        public void LoadData()
        {
            dgriDanhMuc.ColumnCount = 2;
            dgriDanhMuc.Columns[0].Name = "ID";
            dgriDanhMuc.Columns[0].Visible = false;
            dgriDanhMuc.Columns[1].Name = "TenDanhMuc";
            dgriDanhMuc.Rows.Clear();
            foreach (var x in _IdanhMucService.GetAll())
            {
                dgriDanhMuc.Rows.Add(x.IdDanhMuc, x.TenDanhMuc);
            }
        }
        public DanhMuc GetDataFromDb()
        {
            return new DanhMuc() { TenDanhMuc = txtDanhMuc.Text };
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_IdanhMucService.Add(GetDataFromDb()));
            LoadData();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (_idWhenClick == Guid.Empty)
            {
                MessageBox.Show("không tìm thấy sản phẩm");
            }
            else
            {
                var danhMuc = GetDataFromDb();
                danhMuc.IdDanhMuc = _idWhenClick;
                MessageBox.Show(_IdanhMucService.Delete(danhMuc));
                LoadData();
            }
        }
        private void dgridDanhMuc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            if (rowindex == -1 || rowindex == _IdanhMucService.GetAll().Count) return;
            _idWhenClick = Guid.Parse(dgriDanhMuc.Rows[rowindex].Cells[0].Value.ToString());
            var danhMuc = _IdanhMucService.GetAll().FirstOrDefault(c => c.IdDanhMuc == _idWhenClick);
            txtDanhMuc.Text = danhMuc.TenDanhMuc;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (_idWhenClick == Guid.Empty)
            {
                MessageBox.Show("không tìm thấy sản phẩm");
            }
            else
            {
                var danhMuc = GetDataFromDb();
                danhMuc.IdDanhMuc = _idWhenClick;
                MessageBox.Show(_IdanhMucService.Update(danhMuc));
                LoadData();
            }
        }
    }
}
