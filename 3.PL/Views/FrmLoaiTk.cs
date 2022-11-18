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
    public partial class FrmLoaiTk : Form
    {
        ILoaiTKService _IloaiTKService;
        Guid _idWhenClick;
        public FrmLoaiTk()
        {
            InitializeComponent();
            _IloaiTKService = new LoaiTKService();
            LoadData();
        }
        public void LoadData()
        {
            dgridLoaiTk.ColumnCount = 2;
            dgridLoaiTk.Columns[0].Name = "ID";
            dgridLoaiTk.Columns[0].Visible = false;
            dgridLoaiTk.Columns[1].Name = "TenLoaiTk";
            dgridLoaiTk.Rows.Clear();
            foreach (var x in _IloaiTKService.GetAll())
            {
                dgridLoaiTk.Rows.Add(x.IdLoaiTK, x.TenLoaiTk);
            }
        }
        public LoaiTK GetDataFromDb()
        {
            return new LoaiTK() { TenLoaiTk = txtTenLoaiTk.Text };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_IloaiTKService.Add(GetDataFromDb()));
            LoadData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var loaiTk = GetDataFromDb();
            loaiTk.IdLoaiTK = _idWhenClick;
            MessageBox.Show(_IloaiTKService.Update(loaiTk));
            LoadData();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var loaiTk = GetDataFromDb();
            loaiTk.IdLoaiTK = _idWhenClick;
            MessageBox.Show(_IloaiTKService.Delete(loaiTk));
            LoadData();

        }

        private void dgridLoaiTk_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            if (rowindex == -1 || rowindex == _IloaiTKService.GetAll().Count) return;
            _idWhenClick = Guid.Parse(dgridLoaiTk.Rows[rowindex].Cells[0].Value.ToString());
            var loaiTK = _IloaiTKService.GetAll().FirstOrDefault(c => c.IdLoaiTK == _idWhenClick);
            txtTenLoaiTk.Text = loaiTK.TenLoaiTk;
        }
    }
}
