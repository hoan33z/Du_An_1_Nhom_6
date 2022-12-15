using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using _2.BUS.IServices;
using _2.BUS.Service;
using _2_BUS_Layer;
using _2_BUS_Layer.Utility;
using _3.PL.Views;

namespace _3_GUI_Layer
{
    public partial class FrmChangePassword : Form
    {
        private INhanVienService _iTaiKhoan;
        private Utility _Utility = new Utility();
        private string _PassRandom;
       
        public FrmChangePassword(string title)
        {
            InitializeComponent();
            txtMail.Enabled = false;
            txtMail.Text = title;
            _iTaiKhoan = new NhanVienService();                                 
        }

        private void cbHienMK_CheckedChanged(object sender, EventArgs e)
        {
            if (cbHienMK.Checked == true)
            {
                txtPass.PasswordChar = '\0';
                txtPassNew.PasswordChar = '\0';
                txtPassNew2.PasswordChar = '\0';
            }
            else
            {
                txtPass.PasswordChar = '*';
                txtPassNew.PasswordChar = '*';
                txtPassNew2.PasswordChar = '*';
            }
        }
        private void ClearForm()
        {
            txtPass.Text = "";
            txtPassNew.Text = "";
            txtPassNew2.Text = "";

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            var acc = _iTaiKhoan.getlstNv().FirstOrDefault(c => c.Email == txtMail.Text);
            if (acc.TrangThaiPass == false)
            {
                MessageBox.Show("Bạn phải đổi mật khẩu lần đầu truy cập !", "Thông báo");
            }
            else
            {
                this.Close();
                string title = txtMail.Text;
                FrmMain frm = new FrmMain(title);
                frm.ShowDialog();
            }
           
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            var acc = _iTaiKhoan.getlstNv().FirstOrDefault(c => c.Email == txtMail.Text);
            if (txtPass.Text.Length==0|| txtPassNew.Text.Length==0|| txtPassNew2.Text.Length==0)
            {
                MessageBox.Show("Không được để trống!!","Thông báo");
                return;
            }
            if (acc.MatKhau != acc.MatKhau/*_Utility.EncodePass(txtPass.Text)*/)
            {
                MessageBox.Show("Mật khẩu không chính xác!", "Thông báo");
                return;
            }
            if (txtPassNew.Text==txtPass.Text)
            {
                MessageBox.Show("Mật khẩu mới không được trùng với mật khẩu cũ", "Thông báo");
                return;
            }
            if (txtPassNew.Text != txtPassNew2.Text)
            {
                MessageBox.Show("Xác nhận mật khẩu không đúng !!", "Thông báo");
                return;
            }
            else
            {
                DialogResult lkResult = MessageBox.Show("Xác nhận đổi?", "Cảnh báo", MessageBoxButtons.YesNo);
                if (lkResult==DialogResult.Yes)
                {
                    acc.MatKhau = txtPassNew.Text/*_Utility.EncodePass(txtPassNew.Text)*/;
                    acc.TrangThaiPass = true;
                    MessageBox.Show(_iTaiKhoan.UpdateNV(acc));
                }
                else { return; }
            }
            ClearForm();
        }
    }
}
