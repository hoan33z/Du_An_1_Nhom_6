using Microsoft.EntityFrameworkCore.Migrations;

namespace _1.DAL.Migrations
{
    public partial class hoan1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChiTietGioHang_ChiTietSanPham_IdChiTietSp",
                table: "ChiTietGioHang");

            migrationBuilder.DropForeignKey(
                name: "FK_ChiTietGioHang_GioHang_IdGioHang",
                table: "ChiTietGioHang");

            migrationBuilder.DropForeignKey(
                name: "FK_ChiTietHoaDon_ChiTietSanPham_IdChiTietSP",
                table: "ChiTietHoaDon");

            migrationBuilder.DropForeignKey(
                name: "FK_ChiTietHoaDon_HoaDon_IdHoaDon",
                table: "ChiTietHoaDon");

            migrationBuilder.DropForeignKey(
                name: "FK_ChiTietSanPham_DanhMucs_IdDanhMuc",
                table: "ChiTietSanPham");

            migrationBuilder.DropForeignKey(
                name: "FK_ChiTietSanPham_DonVi_IdDonVi",
                table: "ChiTietSanPham");

            migrationBuilder.DropForeignKey(
                name: "FK_ChiTietSanPham_LoaiSp_IdLoaiSp",
                table: "ChiTietSanPham");

            migrationBuilder.DropForeignKey(
                name: "FK_ChiTietSanPham_NhaCungCap_IdNhaCungCap",
                table: "ChiTietSanPham");

            migrationBuilder.DropForeignKey(
                name: "FK_ChiTietSanPham_SanPham_IdSp",
                table: "ChiTietSanPham");

            migrationBuilder.DropForeignKey(
                name: "FK_GioHang_KhachHang_IdKhachHang",
                table: "GioHang");

            migrationBuilder.DropForeignKey(
                name: "FK_HoaDon_KhachHang_IdKhachHang",
                table: "HoaDon");

            migrationBuilder.DropForeignKey(
                name: "FK_HoaDon_NhanVien_NhanVienIdNhanVien",
                table: "HoaDon");

            migrationBuilder.DropForeignKey(
                name: "FK_NhanVien_TaiKhoan_Email",
                table: "NhanVien");

            migrationBuilder.DropForeignKey(
                name: "FK_TaiKhoan_LoaiTK_IdLoaiTk",
                table: "TaiKhoan");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TaiKhoan",
                table: "TaiKhoan");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SanPham",
                table: "SanPham");

            migrationBuilder.DropPrimaryKey(
                name: "PK_NhanVien",
                table: "NhanVien");

            migrationBuilder.DropPrimaryKey(
                name: "PK_NhaCungCap",
                table: "NhaCungCap");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LoaiTK",
                table: "LoaiTK");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LoaiSp",
                table: "LoaiSp");

            migrationBuilder.DropPrimaryKey(
                name: "PK_KhachHang",
                table: "KhachHang");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HoaDon",
                table: "HoaDon");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GioHang",
                table: "GioHang");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DonVi",
                table: "DonVi");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DanhMucs",
                table: "DanhMucs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ChiTietSanPham",
                table: "ChiTietSanPham");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ChiTietHoaDon",
                table: "ChiTietHoaDon");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ChiTietGioHang",
                table: "ChiTietGioHang");

            migrationBuilder.RenameTable(
                name: "TaiKhoan",
                newName: "TaiKhoans");

            migrationBuilder.RenameTable(
                name: "SanPham",
                newName: "SanPhams");

            migrationBuilder.RenameTable(
                name: "NhanVien",
                newName: "NhanViens");

            migrationBuilder.RenameTable(
                name: "NhaCungCap",
                newName: "NhaCungCaps");

            migrationBuilder.RenameTable(
                name: "LoaiTK",
                newName: "LoaiTKs");

            migrationBuilder.RenameTable(
                name: "LoaiSp",
                newName: "LoaiSps");

            migrationBuilder.RenameTable(
                name: "KhachHang",
                newName: "KhachHangs");

            migrationBuilder.RenameTable(
                name: "HoaDon",
                newName: "HoaDons");

            migrationBuilder.RenameTable(
                name: "GioHang",
                newName: "GioHangs");

            migrationBuilder.RenameTable(
                name: "DonVi",
                newName: "DonVis");

            migrationBuilder.RenameTable(
                name: "DanhMucs",
                newName: "DanhMuc");

            migrationBuilder.RenameTable(
                name: "ChiTietSanPham",
                newName: "ChiTietSanPhams");

            migrationBuilder.RenameTable(
                name: "ChiTietHoaDon",
                newName: "ChiTietHoaDons");

            migrationBuilder.RenameTable(
                name: "ChiTietGioHang",
                newName: "ChiTietGioHangs");

            migrationBuilder.RenameIndex(
                name: "IX_TaiKhoan_IdLoaiTk",
                table: "TaiKhoans",
                newName: "IX_TaiKhoans_IdLoaiTk");

            migrationBuilder.RenameIndex(
                name: "IX_NhanVien_Email",
                table: "NhanViens",
                newName: "IX_NhanViens_Email");

            migrationBuilder.RenameIndex(
                name: "IX_HoaDon_NhanVienIdNhanVien",
                table: "HoaDons",
                newName: "IX_HoaDons_NhanVienIdNhanVien");

            migrationBuilder.RenameIndex(
                name: "IX_HoaDon_IdKhachHang",
                table: "HoaDons",
                newName: "IX_HoaDons_IdKhachHang");

            migrationBuilder.RenameIndex(
                name: "IX_GioHang_IdKhachHang",
                table: "GioHangs",
                newName: "IX_GioHangs_IdKhachHang");

            migrationBuilder.RenameIndex(
                name: "IX_ChiTietSanPham_IdSp",
                table: "ChiTietSanPhams",
                newName: "IX_ChiTietSanPhams_IdSp");

            migrationBuilder.RenameIndex(
                name: "IX_ChiTietSanPham_IdNhaCungCap",
                table: "ChiTietSanPhams",
                newName: "IX_ChiTietSanPhams_IdNhaCungCap");

            migrationBuilder.RenameIndex(
                name: "IX_ChiTietSanPham_IdLoaiSp",
                table: "ChiTietSanPhams",
                newName: "IX_ChiTietSanPhams_IdLoaiSp");

            migrationBuilder.RenameIndex(
                name: "IX_ChiTietSanPham_IdDonVi",
                table: "ChiTietSanPhams",
                newName: "IX_ChiTietSanPhams_IdDonVi");

            migrationBuilder.RenameIndex(
                name: "IX_ChiTietSanPham_IdDanhMuc",
                table: "ChiTietSanPhams",
                newName: "IX_ChiTietSanPhams_IdDanhMuc");

            migrationBuilder.RenameIndex(
                name: "IX_ChiTietHoaDon_IdChiTietSP",
                table: "ChiTietHoaDons",
                newName: "IX_ChiTietHoaDons_IdChiTietSP");

            migrationBuilder.RenameIndex(
                name: "IX_ChiTietGioHang_IdChiTietSp",
                table: "ChiTietGioHangs",
                newName: "IX_ChiTietGioHangs_IdChiTietSp");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TaiKhoans",
                table: "TaiKhoans",
                column: "TenTaiKhoan");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SanPhams",
                table: "SanPhams",
                column: "IdSp");

            migrationBuilder.AddPrimaryKey(
                name: "PK_NhanViens",
                table: "NhanViens",
                column: "IdNhanVien");

            migrationBuilder.AddPrimaryKey(
                name: "PK_NhaCungCaps",
                table: "NhaCungCaps",
                column: "IdNhaCungCap");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LoaiTKs",
                table: "LoaiTKs",
                column: "IdLoaiTK");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LoaiSps",
                table: "LoaiSps",
                column: "IdLoaiSp");

            migrationBuilder.AddPrimaryKey(
                name: "PK_KhachHangs",
                table: "KhachHangs",
                column: "IdKhachHang");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HoaDons",
                table: "HoaDons",
                column: "IdHoaDon");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GioHangs",
                table: "GioHangs",
                column: "IdGioHang");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DonVis",
                table: "DonVis",
                column: "IdDonVi");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DanhMuc",
                table: "DanhMuc",
                column: "IdDanhMuc");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ChiTietSanPhams",
                table: "ChiTietSanPhams",
                column: "IdChiTietSP");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ChiTietHoaDons",
                table: "ChiTietHoaDons",
                column: "IdHoaDon");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ChiTietGioHangs",
                table: "ChiTietGioHangs",
                column: "IdGioHang");

            migrationBuilder.AddForeignKey(
                name: "FK_ChiTietGioHangs_ChiTietSanPhams_IdChiTietSp",
                table: "ChiTietGioHangs",
                column: "IdChiTietSp",
                principalTable: "ChiTietSanPhams",
                principalColumn: "IdChiTietSP",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ChiTietGioHangs_GioHangs_IdGioHang",
                table: "ChiTietGioHangs",
                column: "IdGioHang",
                principalTable: "GioHangs",
                principalColumn: "IdGioHang",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ChiTietHoaDons_ChiTietSanPhams_IdChiTietSP",
                table: "ChiTietHoaDons",
                column: "IdChiTietSP",
                principalTable: "ChiTietSanPhams",
                principalColumn: "IdChiTietSP",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ChiTietHoaDons_HoaDons_IdHoaDon",
                table: "ChiTietHoaDons",
                column: "IdHoaDon",
                principalTable: "HoaDons",
                principalColumn: "IdHoaDon",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ChiTietSanPhams_DanhMuc_IdDanhMuc",
                table: "ChiTietSanPhams",
                column: "IdDanhMuc",
                principalTable: "DanhMuc",
                principalColumn: "IdDanhMuc",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ChiTietSanPhams_DonVis_IdDonVi",
                table: "ChiTietSanPhams",
                column: "IdDonVi",
                principalTable: "DonVis",
                principalColumn: "IdDonVi",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ChiTietSanPhams_LoaiSps_IdLoaiSp",
                table: "ChiTietSanPhams",
                column: "IdLoaiSp",
                principalTable: "LoaiSps",
                principalColumn: "IdLoaiSp",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ChiTietSanPhams_NhaCungCaps_IdNhaCungCap",
                table: "ChiTietSanPhams",
                column: "IdNhaCungCap",
                principalTable: "NhaCungCaps",
                principalColumn: "IdNhaCungCap",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ChiTietSanPhams_SanPhams_IdSp",
                table: "ChiTietSanPhams",
                column: "IdSp",
                principalTable: "SanPhams",
                principalColumn: "IdSp",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GioHangs_KhachHangs_IdKhachHang",
                table: "GioHangs",
                column: "IdKhachHang",
                principalTable: "KhachHangs",
                principalColumn: "IdKhachHang",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HoaDons_KhachHangs_IdKhachHang",
                table: "HoaDons",
                column: "IdKhachHang",
                principalTable: "KhachHangs",
                principalColumn: "IdKhachHang",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HoaDons_NhanViens_NhanVienIdNhanVien",
                table: "HoaDons",
                column: "NhanVienIdNhanVien",
                principalTable: "NhanViens",
                principalColumn: "IdNhanVien",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_NhanViens_TaiKhoans_Email",
                table: "NhanViens",
                column: "Email",
                principalTable: "TaiKhoans",
                principalColumn: "TenTaiKhoan",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TaiKhoans_LoaiTKs_IdLoaiTk",
                table: "TaiKhoans",
                column: "IdLoaiTk",
                principalTable: "LoaiTKs",
                principalColumn: "IdLoaiTK",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChiTietGioHangs_ChiTietSanPhams_IdChiTietSp",
                table: "ChiTietGioHangs");

            migrationBuilder.DropForeignKey(
                name: "FK_ChiTietGioHangs_GioHangs_IdGioHang",
                table: "ChiTietGioHangs");

            migrationBuilder.DropForeignKey(
                name: "FK_ChiTietHoaDons_ChiTietSanPhams_IdChiTietSP",
                table: "ChiTietHoaDons");

            migrationBuilder.DropForeignKey(
                name: "FK_ChiTietHoaDons_HoaDons_IdHoaDon",
                table: "ChiTietHoaDons");

            migrationBuilder.DropForeignKey(
                name: "FK_ChiTietSanPhams_DanhMuc_IdDanhMuc",
                table: "ChiTietSanPhams");

            migrationBuilder.DropForeignKey(
                name: "FK_ChiTietSanPhams_DonVis_IdDonVi",
                table: "ChiTietSanPhams");

            migrationBuilder.DropForeignKey(
                name: "FK_ChiTietSanPhams_LoaiSps_IdLoaiSp",
                table: "ChiTietSanPhams");

            migrationBuilder.DropForeignKey(
                name: "FK_ChiTietSanPhams_NhaCungCaps_IdNhaCungCap",
                table: "ChiTietSanPhams");

            migrationBuilder.DropForeignKey(
                name: "FK_ChiTietSanPhams_SanPhams_IdSp",
                table: "ChiTietSanPhams");

            migrationBuilder.DropForeignKey(
                name: "FK_GioHangs_KhachHangs_IdKhachHang",
                table: "GioHangs");

            migrationBuilder.DropForeignKey(
                name: "FK_HoaDons_KhachHangs_IdKhachHang",
                table: "HoaDons");

            migrationBuilder.DropForeignKey(
                name: "FK_HoaDons_NhanViens_NhanVienIdNhanVien",
                table: "HoaDons");

            migrationBuilder.DropForeignKey(
                name: "FK_NhanViens_TaiKhoans_Email",
                table: "NhanViens");

            migrationBuilder.DropForeignKey(
                name: "FK_TaiKhoans_LoaiTKs_IdLoaiTk",
                table: "TaiKhoans");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TaiKhoans",
                table: "TaiKhoans");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SanPhams",
                table: "SanPhams");

            migrationBuilder.DropPrimaryKey(
                name: "PK_NhanViens",
                table: "NhanViens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_NhaCungCaps",
                table: "NhaCungCaps");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LoaiTKs",
                table: "LoaiTKs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LoaiSps",
                table: "LoaiSps");

            migrationBuilder.DropPrimaryKey(
                name: "PK_KhachHangs",
                table: "KhachHangs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HoaDons",
                table: "HoaDons");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GioHangs",
                table: "GioHangs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DonVis",
                table: "DonVis");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DanhMuc",
                table: "DanhMuc");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ChiTietSanPhams",
                table: "ChiTietSanPhams");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ChiTietHoaDons",
                table: "ChiTietHoaDons");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ChiTietGioHangs",
                table: "ChiTietGioHangs");

            migrationBuilder.RenameTable(
                name: "TaiKhoans",
                newName: "TaiKhoan");

            migrationBuilder.RenameTable(
                name: "SanPhams",
                newName: "SanPham");

            migrationBuilder.RenameTable(
                name: "NhanViens",
                newName: "NhanVien");

            migrationBuilder.RenameTable(
                name: "NhaCungCaps",
                newName: "NhaCungCap");

            migrationBuilder.RenameTable(
                name: "LoaiTKs",
                newName: "LoaiTK");

            migrationBuilder.RenameTable(
                name: "LoaiSps",
                newName: "LoaiSp");

            migrationBuilder.RenameTable(
                name: "KhachHangs",
                newName: "KhachHang");

            migrationBuilder.RenameTable(
                name: "HoaDons",
                newName: "HoaDon");

            migrationBuilder.RenameTable(
                name: "GioHangs",
                newName: "GioHang");

            migrationBuilder.RenameTable(
                name: "DonVis",
                newName: "DonVi");

            migrationBuilder.RenameTable(
                name: "DanhMuc",
                newName: "DanhMucs");

            migrationBuilder.RenameTable(
                name: "ChiTietSanPhams",
                newName: "ChiTietSanPham");

            migrationBuilder.RenameTable(
                name: "ChiTietHoaDons",
                newName: "ChiTietHoaDon");

            migrationBuilder.RenameTable(
                name: "ChiTietGioHangs",
                newName: "ChiTietGioHang");

            migrationBuilder.RenameIndex(
                name: "IX_TaiKhoans_IdLoaiTk",
                table: "TaiKhoan",
                newName: "IX_TaiKhoan_IdLoaiTk");

            migrationBuilder.RenameIndex(
                name: "IX_NhanViens_Email",
                table: "NhanVien",
                newName: "IX_NhanVien_Email");

            migrationBuilder.RenameIndex(
                name: "IX_HoaDons_NhanVienIdNhanVien",
                table: "HoaDon",
                newName: "IX_HoaDon_NhanVienIdNhanVien");

            migrationBuilder.RenameIndex(
                name: "IX_HoaDons_IdKhachHang",
                table: "HoaDon",
                newName: "IX_HoaDon_IdKhachHang");

            migrationBuilder.RenameIndex(
                name: "IX_GioHangs_IdKhachHang",
                table: "GioHang",
                newName: "IX_GioHang_IdKhachHang");

            migrationBuilder.RenameIndex(
                name: "IX_ChiTietSanPhams_IdSp",
                table: "ChiTietSanPham",
                newName: "IX_ChiTietSanPham_IdSp");

            migrationBuilder.RenameIndex(
                name: "IX_ChiTietSanPhams_IdNhaCungCap",
                table: "ChiTietSanPham",
                newName: "IX_ChiTietSanPham_IdNhaCungCap");

            migrationBuilder.RenameIndex(
                name: "IX_ChiTietSanPhams_IdLoaiSp",
                table: "ChiTietSanPham",
                newName: "IX_ChiTietSanPham_IdLoaiSp");

            migrationBuilder.RenameIndex(
                name: "IX_ChiTietSanPhams_IdDonVi",
                table: "ChiTietSanPham",
                newName: "IX_ChiTietSanPham_IdDonVi");

            migrationBuilder.RenameIndex(
                name: "IX_ChiTietSanPhams_IdDanhMuc",
                table: "ChiTietSanPham",
                newName: "IX_ChiTietSanPham_IdDanhMuc");

            migrationBuilder.RenameIndex(
                name: "IX_ChiTietHoaDons_IdChiTietSP",
                table: "ChiTietHoaDon",
                newName: "IX_ChiTietHoaDon_IdChiTietSP");

            migrationBuilder.RenameIndex(
                name: "IX_ChiTietGioHangs_IdChiTietSp",
                table: "ChiTietGioHang",
                newName: "IX_ChiTietGioHang_IdChiTietSp");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TaiKhoan",
                table: "TaiKhoan",
                column: "TenTaiKhoan");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SanPham",
                table: "SanPham",
                column: "IdSp");

            migrationBuilder.AddPrimaryKey(
                name: "PK_NhanVien",
                table: "NhanVien",
                column: "IdNhanVien");

            migrationBuilder.AddPrimaryKey(
                name: "PK_NhaCungCap",
                table: "NhaCungCap",
                column: "IdNhaCungCap");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LoaiTK",
                table: "LoaiTK",
                column: "IdLoaiTK");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LoaiSp",
                table: "LoaiSp",
                column: "IdLoaiSp");

            migrationBuilder.AddPrimaryKey(
                name: "PK_KhachHang",
                table: "KhachHang",
                column: "IdKhachHang");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HoaDon",
                table: "HoaDon",
                column: "IdHoaDon");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GioHang",
                table: "GioHang",
                column: "IdGioHang");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DonVi",
                table: "DonVi",
                column: "IdDonVi");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DanhMucs",
                table: "DanhMucs",
                column: "IdDanhMuc");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ChiTietSanPham",
                table: "ChiTietSanPham",
                column: "IdChiTietSP");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ChiTietHoaDon",
                table: "ChiTietHoaDon",
                column: "IdHoaDon");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ChiTietGioHang",
                table: "ChiTietGioHang",
                column: "IdGioHang");

            migrationBuilder.AddForeignKey(
                name: "FK_ChiTietGioHang_ChiTietSanPham_IdChiTietSp",
                table: "ChiTietGioHang",
                column: "IdChiTietSp",
                principalTable: "ChiTietSanPham",
                principalColumn: "IdChiTietSP",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ChiTietGioHang_GioHang_IdGioHang",
                table: "ChiTietGioHang",
                column: "IdGioHang",
                principalTable: "GioHang",
                principalColumn: "IdGioHang",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ChiTietHoaDon_ChiTietSanPham_IdChiTietSP",
                table: "ChiTietHoaDon",
                column: "IdChiTietSP",
                principalTable: "ChiTietSanPham",
                principalColumn: "IdChiTietSP",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ChiTietHoaDon_HoaDon_IdHoaDon",
                table: "ChiTietHoaDon",
                column: "IdHoaDon",
                principalTable: "HoaDon",
                principalColumn: "IdHoaDon",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ChiTietSanPham_DanhMucs_IdDanhMuc",
                table: "ChiTietSanPham",
                column: "IdDanhMuc",
                principalTable: "DanhMucs",
                principalColumn: "IdDanhMuc",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ChiTietSanPham_DonVi_IdDonVi",
                table: "ChiTietSanPham",
                column: "IdDonVi",
                principalTable: "DonVi",
                principalColumn: "IdDonVi",
                onDelete: ReferentialAction.Cascade);

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

            migrationBuilder.AddForeignKey(
                name: "FK_GioHang_KhachHang_IdKhachHang",
                table: "GioHang",
                column: "IdKhachHang",
                principalTable: "KhachHang",
                principalColumn: "IdKhachHang",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HoaDon_KhachHang_IdKhachHang",
                table: "HoaDon",
                column: "IdKhachHang",
                principalTable: "KhachHang",
                principalColumn: "IdKhachHang",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HoaDon_NhanVien_NhanVienIdNhanVien",
                table: "HoaDon",
                column: "NhanVienIdNhanVien",
                principalTable: "NhanVien",
                principalColumn: "IdNhanVien",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_NhanVien_TaiKhoan_Email",
                table: "NhanVien",
                column: "Email",
                principalTable: "TaiKhoan",
                principalColumn: "TenTaiKhoan",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TaiKhoan_LoaiTK_IdLoaiTk",
                table: "TaiKhoan",
                column: "IdLoaiTk",
                principalTable: "LoaiTK",
                principalColumn: "IdLoaiTK",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
