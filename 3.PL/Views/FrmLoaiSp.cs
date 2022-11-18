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
    public partial class FrmLoaiSp : Form
    {
        ILoaiSpService _IloaiSpService;
        Guid _idWhenClick;
        public FrmLoaiSp()
        {
            InitializeComponent();
            _IloaiSpService = new LoaiSpService();
            LoadData();
        }
        public void LoadData()
        {
            dgridLoaiSp.ColumnCount = 2;
            dgridLoaiSp.Columns[0].Name = "ID";
            dgridLoaiSp.Columns[0].Visible = false;
            dgridLoaiSp.Columns[1].Name = "TenLoaiSp";
            dgridLoaiSp.Rows.Clear();
            foreach (var x in _IloaiSpService.GetAll())
            {
                dgridLoaiSp.Rows.Add(x.IdLoaiSp, x.TenLoaiSp);
            }
        }
        public LoaiSp GetLoaiSp()
        {
            return new LoaiSp() { TenLoaiSp = txtTenLoaiSp.Text };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_IloaiSpService.Add(GetLoaiSp()));
            LoadData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var loaiSp = GetLoaiSp();
            loaiSp.IdLoaiSp = _idWhenClick;
            MessageBox.Show(_IloaiSpService.Update(loaiSp));
            LoadData();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var loaiSp = GetLoaiSp();
            loaiSp.IdLoaiSp = _idWhenClick;
            MessageBox.Show(_IloaiSpService.Delete(loaiSp));
            LoadData();

        }

        private void dgridLoaiSp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            if (rowindex == -1 || rowindex == _IloaiSpService.GetAll().Count) return;
            _idWhenClick = Guid.Parse(dgridLoaiSp.Rows[rowindex].Cells[0].Value.ToString());
            var loaiTK = _IloaiSpService.GetAll().FirstOrDefault(c => c.IdLoaiSp == _idWhenClick);
            txtTenLoaiSp.Text = loaiTK.TenLoaiSp;

        }
    }
}
