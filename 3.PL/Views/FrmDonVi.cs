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
    public partial class FrmDonVi : Form
    {
        IDonViService _IdonViService;
        Guid _idWhenClick;
        public FrmDonVi()
        {
            InitializeComponent();
            _IdonViService = new DonViService();
            LoadData();
        }
        public void LoadData()
        {
            dgriDonVi.ColumnCount = 2;
            dgriDonVi.Columns[0].Name = "ID";
            dgriDonVi.Columns[0].Visible = false;
            dgriDonVi.Columns[1].Name = "TenDonVi";
            dgriDonVi.Rows.Clear();
            foreach (var x in _IdonViService.GetAll())
            {
                dgriDonVi.Rows.Add(x.IdDonVi, x.TenDonVi);
            }
        }
        public DonVi GetDataFromDb()
        {
            return new DonVi() { TenDonVi = txtDonVi.Text };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_IdonViService.Add(GetDataFromDb()));
            LoadData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (_idWhenClick == Guid.Empty)
            {
                MessageBox.Show("không tìm thấy sản phẩm");
            }
            else
            {
                var DonVi = GetDataFromDb();
                DonVi.IdDonVi = _idWhenClick;
                MessageBox.Show(_IdonViService.Update(DonVi));
                LoadData();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (_idWhenClick == Guid.Empty)
            {
                MessageBox.Show("không tìm thấy sản phẩm");
            }
            else
            {
                var DonVi = GetDataFromDb();
                DonVi.IdDonVi = _idWhenClick;
                MessageBox.Show(_IdonViService.Delete(DonVi));
                LoadData();
            }
        }

        private void dgriDonVi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            if (rowindex == -1 || rowindex == _IdonViService.GetAll().Count) return;
            _idWhenClick = Guid.Parse(dgriDonVi.Rows[rowindex].Cells[0].Value.ToString());
            var donVi = _IdonViService.GetAll().FirstOrDefault(c => c.IdDonVi == _idWhenClick);
            txtDonVi.Text = donVi.TenDonVi;

        }
    }
}
