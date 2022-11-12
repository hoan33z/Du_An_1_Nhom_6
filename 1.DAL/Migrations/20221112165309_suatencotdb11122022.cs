using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace _1.DAL.Migrations
{
    public partial class suatencotdb11122022 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChiTietSanPham_LoaiSp_LoaiSpIdLoaiSp",
                table: "ChiTietSanPham");

            migrationBuilder.DropForeignKey(
                name: "FK_ChiTietSanPham_NhaCungCap_NhaCungCapIdNhaCungCap",
                table: "ChiTietSanPham");

            migrationBuilder.DropForeignKey(
                name: "FK_ChiTietSanPham_SanPham_SanPhamIdSp",
                table: "ChiTietSanPham");

            migrationBuilder.DropIndex(
                name: "IX_ChiTietSanPham_LoaiSpIdLoaiSp",
                table: "ChiTietSanPham");

            migrationBuilder.DropIndex(
                name: "IX_ChiTietSanPham_NhaCungCapIdNhaCungCap",
                table: "ChiTietSanPham");

            migrationBuilder.DropIndex(
                name: "IX_ChiTietSanPham_SanPhamIdSp",
                table: "ChiTietSanPham");

            migrationBuilder.DropColumn(
                name: "LoaiSpIdLoaiSp",
                table: "ChiTietSanPham");

            migrationBuilder.DropColumn(
                name: "NhaCungCapIdNhaCungCap",
                table: "ChiTietSanPham");

            migrationBuilder.DropColumn(
                name: "SanPhamIdSp",
                table: "ChiTietSanPham");

            migrationBuilder.RenameColumn(
                name: "Tên Tài Khoản",
                table: "TaiKhoan",
                newName: "TenTaiKhoan");

            migrationBuilder.RenameColumn(
                name: "Trạng Thá",
                table: "TaiKhoan",
                newName: "TrangThai");

            migrationBuilder.RenameColumn(
                name: "Mật Khẩu",
                table: "TaiKhoan",
                newName: "MatKhau");

            migrationBuilder.RenameColumn(
                name: "Loại Tài Khoản",
                table: "TaiKhoan",
                newName: "LoaiTK");

            migrationBuilder.RenameColumn(
                name: "Tên Sản Phẩm",
                table: "SanPham",
                newName: "TenSanPham");

            migrationBuilder.RenameColumn(
                name: "Ngày Nhập",
                table: "SanPham",
                newName: "NgayNhap");

            migrationBuilder.RenameColumn(
                name: "Tên Nhà Cung Cấp",
                table: "NhaCungCap",
                newName: "TenNhaCC");

            migrationBuilder.RenameColumn(
                name: "Tên Loại Tài Khoản",
                table: "LoaiTK",
                newName: "TenLoaiTK");

            migrationBuilder.RenameColumn(
                name: "Tên Loại Sản Phẩm",
                table: "LoaiSp",
                newName: "TenLoaiSp");

            migrationBuilder.RenameColumn(
                name: "Địa Chỉ",
                table: "KhachHang",
                newName: "ĐiaChi");

            migrationBuilder.RenameColumn(
                name: "Tên Khách Hàng",
                table: "KhachHang",
                newName: "TenKhachHang");

            migrationBuilder.RenameColumn(
                name: "Số Điện Thoại",
                table: "KhachHang",
                newName: "SDT");

            migrationBuilder.RenameColumn(
                name: "Địa Chỉ",
                table: "HoaDon",
                newName: "ĐiaChi");

            migrationBuilder.RenameColumn(
                name: "Tổng Tiền",
                table: "HoaDon",
                newName: "TongTien");

            migrationBuilder.RenameColumn(
                name: "Số Điện Thoại",
                table: "HoaDon",
                newName: "SDT");

            migrationBuilder.RenameColumn(
                name: "Ngày Thanh Toán",
                table: "HoaDon",
                newName: "NgayThanhToan");

            migrationBuilder.RenameColumn(
                name: "Ngày Nhận",
                table: "HoaDon",
                newName: "NgayNhan");

            migrationBuilder.RenameColumn(
                name: "Địa Chỉ",
                table: "GioHang",
                newName: "DiaChi");

            migrationBuilder.RenameColumn(
                name: "Trạng Thái",
                table: "GioHang",
                newName: "TrangThai");

            migrationBuilder.RenameColumn(
                name: "Số Điện Thoại",
                table: "GioHang",
                newName: "SDT");

            migrationBuilder.RenameColumn(
                name: "Ngày Thanh Toán",
                table: "GioHang",
                newName: "NgayThanhToan");

            migrationBuilder.RenameColumn(
                name: "Tên",
                table: "DanhMuc",
                newName: "Ten");

            migrationBuilder.RenameColumn(
                name: "Tên",
                table: "ChiTietSanPham",
                newName: "Ten");

            migrationBuilder.RenameColumn(
                name: "Số Lượng",
                table: "ChiTietSanPham",
                newName: "SoLuong");

            migrationBuilder.RenameColumn(
                name: "Giá Nhập",
                table: "ChiTietSanPham",
                newName: "GiaNhap");

            migrationBuilder.RenameColumn(
                name: "Giá Bán",
                table: "ChiTietSanPham",
                newName: "GiaBan");

            migrationBuilder.RenameColumn(
                name: "Đơn Giá",
                table: "ChiTietHoaDon",
                newName: "DonGia");

            migrationBuilder.RenameColumn(
                name: "Số Lượng Mua",
                table: "ChiTietHoaDon",
                newName: "SoLuongMua");

            migrationBuilder.RenameColumn(
                name: "Đơn Giá",
                table: "ChiTietGioHang",
                newName: "DonGia");

            migrationBuilder.RenameColumn(
                name: "Số Lượng Mua",
                table: "ChiTietGioHang",
                newName: "SoLuongMua");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietSanPham_IdLoaiSp",
                table: "ChiTietSanPham",
                column: "IdLoaiSp");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietSanPham_IdNhaCungCap",
                table: "ChiTietSanPham",
                column: "IdNhaCungCap");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietSanPham_IdSp",
                table: "ChiTietSanPham",
                column: "IdSp");

            migrationBuilder.AddForeignKey(
                name: "FK_ChiTietSanPham_LoaiSp_IdLoaiSp",
                table: "ChiTietSanPham",
                column: "IdLoaiSp",
                principalTable: "LoaiSp",
                principalColumn: "IdLoaiSp",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ChiTietSanPham_NhaCungCap_IdNhaCungCap",
                table: "ChiTietSanPham",
                column: "IdNhaCungCap",
                principalTable: "NhaCungCap",
                principalColumn: "IdNhaCungCap",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ChiTietSanPham_SanPham_IdSp",
                table: "ChiTietSanPham",
                column: "IdSp",
                principalTable: "SanPham",
                principalColumn: "IdSp",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChiTietSanPham_LoaiSp_IdLoaiSp",
                table: "ChiTietSanPham");

            migrationBuilder.DropForeignKey(
                name: "FK_ChiTietSanPham_NhaCungCap_IdNhaCungCap",
                table: "ChiTietSanPham");

            migrationBuilder.DropForeignKey(
                name: "FK_ChiTietSanPham_SanPham_IdSp",
                table: "ChiTietSanPham");

            migrationBuilder.DropIndex(
                name: "IX_ChiTietSanPham_IdLoaiSp",
                table: "ChiTietSanPham");

            migrationBuilder.DropIndex(
                name: "IX_ChiTietSanPham_IdNhaCungCap",
                table: "ChiTietSanPham");

            migrationBuilder.DropIndex(
                name: "IX_ChiTietSanPham_IdSp",
                table: "ChiTietSanPham");

            migrationBuilder.RenameColumn(
                name: "TrangThai",
                table: "TaiKhoan",
                newName: "Trạng Thá");

            migrationBuilder.RenameColumn(
                name: "TenTaiKhoan",
                table: "TaiKhoan",
                newName: "Tên Tài Khoản");

            migrationBuilder.RenameColumn(
                name: "MatKhau",
                table: "TaiKhoan",
                newName: "Mật Khẩu");

            migrationBuilder.RenameColumn(
                name: "LoaiTK",
                table: "TaiKhoan",
                newName: "Loại Tài Khoản");

            migrationBuilder.RenameColumn(
                name: "TenSanPham",
                table: "SanPham",
                newName: "Tên Sản Phẩm");

            migrationBuilder.RenameColumn(
                name: "NgayNhap",
                table: "SanPham",
                newName: "Ngày Nhập");

            migrationBuilder.RenameColumn(
                name: "TenNhaCC",
                table: "NhaCungCap",
                newName: "Tên Nhà Cung Cấp");

            migrationBuilder.RenameColumn(
                name: "TenLoaiTK",
                table: "LoaiTK",
                newName: "Tên Loại Tài Khoản");

            migrationBuilder.RenameColumn(
                name: "TenLoaiSp",
                table: "LoaiSp",
                newName: "Tên Loại Sản Phẩm");

            migrationBuilder.RenameColumn(
                name: "ĐiaChi",
                table: "KhachHang",
                newName: "Địa Chỉ");

            migrationBuilder.RenameColumn(
                name: "TenKhachHang",
                table: "KhachHang",
                newName: "Tên Khách Hàng");

            migrationBuilder.RenameColumn(
                name: "SDT",
                table: "KhachHang",
                newName: "Số Điện Thoại");

            migrationBuilder.RenameColumn(
                name: "ĐiaChi",
                table: "HoaDon",
                newName: "Địa Chỉ");

            migrationBuilder.RenameColumn(
                name: "TongTien",
                table: "HoaDon",
                newName: "Tổng Tiền");

            migrationBuilder.RenameColumn(
                name: "SDT",
                table: "HoaDon",
                newName: "Số Điện Thoại");

            migrationBuilder.RenameColumn(
                name: "NgayThanhToan",
                table: "HoaDon",
                newName: "Ngày Thanh Toán");

            migrationBuilder.RenameColumn(
                name: "NgayNhan",
                table: "HoaDon",
                newName: "Ngày Nhận");

            migrationBuilder.RenameColumn(
                name: "TrangThai",
                table: "GioHang",
                newName: "Trạng Thái");

            migrationBuilder.RenameColumn(
                name: "SDT",
                table: "GioHang",
                newName: "Số Điện Thoại");

            migrationBuilder.RenameColumn(
                name: "NgayThanhToan",
                table: "GioHang",
                newName: "Ngày Thanh Toán");

            migrationBuilder.RenameColumn(
                name: "DiaChi",
                table: "GioHang",
                newName: "Địa Chỉ");

            migrationBuilder.RenameColumn(
                name: "Ten",
                table: "DanhMuc",
                newName: "Tên");

            migrationBuilder.RenameColumn(
                name: "Ten",
                table: "ChiTietSanPham",
                newName: "Tên");

            migrationBuilder.RenameColumn(
                name: "SoLuong",
                table: "ChiTietSanPham",
                newName: "Số Lượng");

            migrationBuilder.RenameColumn(
                name: "GiaNhap",
                table: "ChiTietSanPham",
                newName: "Giá Nhập");

            migrationBuilder.RenameColumn(
                name: "GiaBan",
                table: "ChiTietSanPham",
                newName: "Giá Bán");

            migrationBuilder.RenameColumn(
                name: "SoLuongMua",
                table: "ChiTietHoaDon",
                newName: "Số Lượng Mua");

            migrationBuilder.RenameColumn(
                name: "DonGia",
                table: "ChiTietHoaDon",
                newName: "Đơn Giá");

            migrationBuilder.RenameColumn(
                name: "SoLuongMua",
                table: "ChiTietGioHang",
                newName: "Số Lượng Mua");

            migrationBuilder.RenameColumn(
                name: "DonGia",
                table: "ChiTietGioHang",
                newName: "Đơn Giá");

            migrationBuilder.AddColumn<Guid>(
                name: "LoaiSpIdLoaiSp",
                table: "ChiTietSanPham",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "NhaCungCapIdNhaCungCap",
                table: "ChiTietSanPham",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "SanPhamIdSp",
                table: "ChiTietSanPham",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietSanPham_LoaiSpIdLoaiSp",
                table: "ChiTietSanPham",
                column: "LoaiSpIdLoaiSp");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietSanPham_NhaCungCapIdNhaCungCap",
                table: "ChiTietSanPham",
                column: "NhaCungCapIdNhaCungCap");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietSanPham_SanPhamIdSp",
                table: "ChiTietSanPham",
                column: "SanPhamIdSp");

            migrationBuilder.AddForeignKey(
                name: "FK_ChiTietSanPham_LoaiSp_LoaiSpIdLoaiSp",
                table: "ChiTietSanPham",
                column: "LoaiSpIdLoaiSp",
                principalTable: "LoaiSp",
                principalColumn: "IdLoaiSp",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ChiTietSanPham_NhaCungCap_NhaCungCapIdNhaCungCap",
                table: "ChiTietSanPham",
                column: "NhaCungCapIdNhaCungCap",
                principalTable: "NhaCungCap",
                principalColumn: "IdNhaCungCap",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ChiTietSanPham_SanPham_SanPhamIdSp",
                table: "ChiTietSanPham",
                column: "SanPhamIdSp",
                principalTable: "SanPham",
                principalColumn: "IdSp",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
