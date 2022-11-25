using _2.BUS.IServices;
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
                else if (_taikhoan.MatKhau == _Utility.EncodePass(password))//password
                {
                    if (_taikhoan.TrangThaiPass == false)
                    {
                        MessageBox.Show("Bạn hãy đổi mật khẩu để sử dụng phần mềm", "Thông báo");
                        this.Hide();
                        string title = txt_tk.Text;
                        FrmChangePassword frm = new FrmChangePassword(title);
                        frm.ShowDialog();

                    }
                    else
                    {
                        string title = txt_tk.Text;
                        MessageBox.Show("Đăng nhập thành công", "Thông báo");
                        this.Hide();
                        FrmMain frm_Start = new FrmMain(title);
                        frm_Start.ShowDialog();

                    }


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
    }
}
