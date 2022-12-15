using _2.BUS.IServices;
using _2.BUS.Service;
using _2_BUS_Layer.Utility;
using _3_GUI_Layer;
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
    public partial class FrmLogin : Form
    {
        private INhanVienService _taiKhoanServices;
        private Utility _Utility;
        public FrmLogin()
        {
            InitializeComponent();
            _taiKhoanServices = new NhanVienService();
            _Utility = new Utility();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var mail = txt_tk.Text;
            var password = txt_mk.Text;
            var _taikhoan = _taiKhoanServices.getlstNv().FirstOrDefault(c => c.Email == mail);

            if (_taikhoan == null)
            {
                MessageBox.Show("Sai Email , mời nhập lại Email!");
            }
            else if (_taikhoan != null)
            {
                if (_taikhoan.TrangThai == false)
                {
                    MessageBox.Show("Tài khoản đã ngừng hoạt động", "Thông báo");
                }
                else if (_taikhoan.MatKhau == password/*_Utility.EncodePass(password)*/)//password
                {
                    string title = txt_tk.Text;
                    this.Hide();
                    FrmMain frm_Start = new FrmMain(title);
                    frm_Start.Closed += (s, args) => this.Close();
                    frm_Start.Show();
                }
                else
                {
                    MessageBox.Show("Sai mật khẩu , mời bạn nhập lại!");
                }
            }
            else
            {
                MessageBox.Show("Đăng nhập lại .");
            }
        }
        private void cbHienMK_CheckedChanged(object sender, EventArgs e)
        {
            if (cbHienMK.Checked == true)
            {
                txt_mk.PasswordChar = '\0';
            }
            if (cbHienMK.Checked == false)
            {
                txt_mk.PasswordChar = '*';
            }
        }

        private void txt_tk_MouseClick(object sender, MouseEventArgs e)
        {
            txt_tk.Text = "";
        }

        private void txt_mk_MouseClick(object sender, MouseEventArgs e)
        {
            txt_mk.Text = "";
        }

        private void txt_mk_TextChanged(object sender, EventArgs e)
        {
            txt_mk.PasswordChar = '*';
        }
    }
}
