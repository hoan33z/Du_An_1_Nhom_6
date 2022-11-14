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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnDatHang_Click(object sender, EventArgs e)
        {
            FrmDatHang datHang = new FrmDatHang();
            datHang.TopLevel = false;
            datHang.FormBorderStyle=System.Windows.Forms.FormBorderStyle.None;
            panelDatHang.Controls.Add(datHang);
            datHang.Show();
        }
    }
}
