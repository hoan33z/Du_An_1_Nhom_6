using _1.DAL.Models;
using _2.BUS.IServices;
using _2.BUS.Service;
using _2_BUS_Layer.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.PL.Views
{
    public partial class FrmNhanVien : Form
    {
        INhanVienService _iNhanVien;

        Utility _utility;
        string _passRandom;
        NhanVien _nv;
        public FrmNhanVien()
        {
            InitializeComponent();
            _iNhanVien = new NhanVienService();
            _utility = new Utility();
            _nv = new NhanVien();
            loadData();
        }
        public void loadData()
        {
            dgr_nhanVien.ColumnCount = 8;
            dgr_nhanVien.Columns[0].Name = "Tên Nhân Viên";
            dgr_nhanVien.Columns[1].Name = "Năm sinh";
            dgr_nhanVien.Columns[2].Name = "Giới tính";
            dgr_nhanVien.Columns[3].Name = "Email";
            dgr_nhanVien.Columns[4].Name = "SDT";
            dgr_nhanVien.Columns[5].Name = "Địa Chỉ";
            dgr_nhanVien.Columns[6].Name = "Chức Vụ";
            dgr_nhanVien.Columns[7].Name = "Tình trạng tài khoản";
            dgr_nhanVien.Rows.Clear();
            foreach (var x in _iNhanVien.getlstNv())
            {
                dgr_nhanVien.Rows.Add(x.TenNv, x.NamSinh, x.GioiTinh == true ? "Nam" : "Nữ", x.Email, x.SDT, x.DiaChi, x.IdLoaiTk == true ? "Admin" : "Nhân Viên", x.TrangThai == true ? "Họat động" : "Ngừng Hoạt Động");
            }
        }
        public void loadDataTimKiem()
        {
            dgr_nhanVien.ColumnCount = 8;
            dgr_nhanVien.Columns[0].Name = "Tên Nhân Viên";
            dgr_nhanVien.Columns[1].Name = "Năm sinh";
            dgr_nhanVien.Columns[2].Name = "Giới tính";
            dgr_nhanVien.Columns[3].Name = "Email";
            dgr_nhanVien.Columns[4].Name = "SDT";
            dgr_nhanVien.Columns[5].Name = "Địa Chỉ";
            dgr_nhanVien.Columns[6].Name = "Chức Vụ";
            dgr_nhanVien.Columns[7].Name = "Tình trạng tài khoản";
            dgr_nhanVien.Rows.Clear();
            foreach (var x in _iNhanVien.getlstNv())
            {
                dgr_nhanVien.Rows.Add(x.TenNv, x.NamSinh, x.GioiTinh == true ? "Nam" : "Nữ", x.Email, x.SDT, x.DiaChi, x.IdLoaiTk == true ? "Admin" : "Nhân Viên", x.TrangThai == true ? "Họat động" : "Ngừng Hoạt Động");
            }
        }
        private void ClearForm()
        {
            txt_Name.Text = "";
            txt_DiaChi.Text = "";
            txt_Email.Text = "";
            txt_SDT.Text = "";
            cbx_chucVu.Text = "";
            cbx_gioiTinh.Text = "";
            cbx_trangThaiTk.Text = "";
            txt_Email.Enabled = true;
            btn_them.Enabled = true;

        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            DialogResult hoi;
            string strRegex = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
            Regex regex = new Regex(strRegex);
            hoi = MessageBox.Show("Bạn có muốn thêm không", "Thông báo", MessageBoxButtons.YesNo);
            if (hoi == DialogResult.Yes)
            {
                if (regex.IsMatch(txt_Email.Text))
                {
                    if (txt_Email.Text == "" || txt_Name.Text == "" || txt_DiaChi.Text == "" || txt_SDT.Text == "")
                    {
                        MessageBox.Show("Không được để trống thông tin!!", "Thông báo");
                        return;
                    }
                    if (_iNhanVien.getlstNv().FirstOrDefault(c => c.Email == txt_Email.Text) != null)
                    {
                        MessageBox.Show("Email nhân viên đã tồn tại");
                        return;
                    }
                    if (_iNhanVien.getlstNv().FirstOrDefault(c => c.SDT == txt_SDT.Text) != null)
                    {
                        MessageBox.Show("SDT đã tồn tại");
                        return;
                    }
                    else
                    {
                        _nv.SDT = txt_SDT.Text;
                        _nv.Email = txt_Email.Text;
                        _nv.DiaChi = txt_DiaChi.Text;
                        _nv.NamSinh = dateTimePicker1.Value.Date;
                        _nv.TenNv = txt_Name.Text;
                        _nv.GioiTinh = cbx_gioiTinh.Text == "Nam" ? true : false;
                        _passRandom = _utility.PassRandom(6);
                        _nv.MatKhau = _utility.EncodePass(_passRandom);
                        _nv.IdLoaiTk = cbx_chucVu.Text == "Admin" ? true : false;
                        _nv.TrangThaiPass = false;
                        _nv.TrangThai = cbx_trangThaiTk.Text == "Hoạt Động" ? true : false;
                        MessageBox.Show(_iNhanVien.AddNV(_nv), "Thông báo");
                        MessageBox.Show(_utility.SenderMail(txt_Email.Text, _passRandom, "Thông báo"));
                        ClearForm();
                        loadData();
                    }

                }
                else
                {
                    MessageBox.Show("Email không hợp lệ!!!", "Thông báo");
                    return;
                }
            }
        }

        private void dgr_nhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow = e.RowIndex;
            if (indexRow < 0) return;
            var row = dgr_nhanVien.Rows[indexRow];
            var acc = _iNhanVien.getlstNv().FirstOrDefault(c => c.Email == txt_Email.Text);
            txt_Name.Text = row.Cells[0].Value + "";
            dateTimePicker1.Text = row.Cells[1].Value + "";
            cbx_gioiTinh.Text = row.Cells[2].Value + "";
            txt_Email.Text = row.Cells[3].Value + "";
            txt_SDT.Text = row.Cells[4].Value + "";
            txt_DiaChi.Text = row.Cells[5].Value + "";
            cbx_chucVu.Text = row.Cells[6].Value + "";
            cbx_trangThaiTk.Text = row.Cells[7].Value + "";
            btn_them.Enabled = false;
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            DialogResult hoi;
            hoi = MessageBox.Show("Bạn có muốn sửa không", "Thông báo", MessageBoxButtons.YesNo);
            if (hoi == DialogResult.Yes)
            {
                if (txt_Email.Text == "" || txt_Name.Text == "" || txt_DiaChi.Text == "" || txt_SDT.Text == "")
                {
                    MessageBox.Show("Không được để trống thông tin!!", "Thông báo");
                    return;
                }
                var nv = _iNhanVien.getlstNv().FirstOrDefault(c => c.Email == txt_Email.Text);
                nv.SDT = txt_SDT.Text;
                nv.Email = txt_Email.Text;
                nv.DiaChi = txt_DiaChi.Text;
                nv.NamSinh = dateTimePicker1.Value.Date;
                nv.TenNv = txt_Name.Text;
                nv.GioiTinh = cbx_gioiTinh.Text == "Nam" ? true : false;
                nv.TrangThai = cbx_trangThaiTk.Text == "Hoạt Động" ? true : false;
                nv.IdLoaiTk = cbx_chucVu.Text == "Admin" ? true : false;



                MessageBox.Show(_iNhanVien.UpdateNV(nv).ToString());
                loadData();
                ClearForm();
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DialogResult hoi;
            hoi = MessageBox.Show("Bạn có muốn xóa không", "Thông báo", MessageBoxButtons.YesNo);
            if (hoi == DialogResult.Yes)
            {
                var nv = _iNhanVien.getlstNv().FirstOrDefault(c => c.Email == txt_Email.Text);
                nv.TrangThai = false;
                MessageBox.Show(_iNhanVien.DeleteNV(nv).ToString(), "thông báo");
                ClearForm();
                loadData();
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void btn_timKiem_Click(object sender, EventArgs e)
        {
            loadDataTimKiem();
        }
    }
}
