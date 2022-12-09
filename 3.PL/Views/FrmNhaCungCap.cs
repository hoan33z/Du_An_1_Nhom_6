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
    public partial class FrmNhaCungCap : Form
    {
        INhaCungCapService _InhaCungCapService;
        Guid _idWhenClick;
        public FrmNhaCungCap()
        {
            InitializeComponent();
            _InhaCungCapService= new NhaCungCapService();
            LoadData();
        }
        public void LoadData()
        {
            dgridNhaCC.ColumnCount = 2;
            dgridNhaCC.Columns[0].Name = "ID";
            dgridNhaCC.Columns[0].Visible = false;
            dgridNhaCC.Columns[1].Name = "TenNhaCC";
            dgridNhaCC.Rows.Clear();
            foreach (var x in _InhaCungCapService.GetAll())
            {
                dgridNhaCC.Rows.Add(x.IdNhaCungCap, x.TenNhaCungCap);
            }
        }
        public NhaCungCap getNhaCC()
        {
            return new NhaCungCap() { TenNhaCungCap = txtNhaCC.Text };
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show(_InhaCungCapService.Add(getNhaCC()));
            LoadData();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (_idWhenClick == Guid.Empty)
            {
                MessageBox.Show("không tìm thấy sản phẩm");
            }
            else
            {
                var NhaCC = getNhaCC();
                NhaCC.IdNhaCungCap = _idWhenClick;
                MessageBox.Show(_InhaCungCapService.Update(NhaCC));
                LoadData();
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (_idWhenClick == Guid.Empty)
            {
                MessageBox.Show("không tìm thấy sản phẩm");
            }
            else
            {
                var NhaCC = getNhaCC();
                NhaCC.IdNhaCungCap = _idWhenClick;
                MessageBox.Show(_InhaCungCapService.Delete(NhaCC));
                LoadData();
            }
        }

        private void dgridNhaCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            if (rowindex == -1 || rowindex == _InhaCungCapService.GetAll().Count) return;
            _idWhenClick = Guid.Parse(dgridNhaCC.Rows[rowindex].Cells[0].Value.ToString());
            var NhaCC = _InhaCungCapService.GetAll().FirstOrDefault(c => c.IdNhaCungCap == _idWhenClick);
            txtNhaCC.Text = NhaCC.TenNhaCungCap;


        }
    }
}

