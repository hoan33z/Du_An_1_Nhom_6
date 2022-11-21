using Microsoft.EntityFrameworkCore.Migrations;

namespace _1.DAL.Migrations
{
    public partial class hoan1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                name: "FK_HoaDons_KhachHangs_IdKhachHang",
                table: "HoaDons");

            migrationBuilder.DropForeignKey(
                name: "FK_HoaDons_NhanViens_IdNhanVien",
                table: "HoaDons");

            migrationBuilder.DropForeignKey(
                name: "FK_NhanViens_TaiKhoans_Email",
                table: "NhanViens");

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
                name: "PK_LoaiSps",
                table: "LoaiSps");

            migrationBuilder.DropPrimaryKey(
                name: "PK_KhachHangs",
                table: "KhachHangs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HoaDons",
                table: "HoaDons");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DonVis",
                table: "DonVis");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ChiTietSanPhams",
                table: "ChiTietSanPhams");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ChiTietHoaDons",
                table: "ChiTietHoaDons");

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
                name: "LoaiSps",
                newName: "LoaiSanPham");

            migrationBuilder.RenameTable(
                name: "KhachHangs",
                newName: "KhachHang");

            migrationBuilder.RenameTable(
                name: "HoaDons",
                newName: "HoaDon");

            migrationBuilder.RenameTable(
                name: "DonVis",
                newName: "DonVi");

            migrationBuilder.RenameTable(
                name: "ChiTietSanPhams",
                newName: "ChiTietSP");

            migrationBuilder.RenameTable(
                name: "ChiTietHoaDons",
                newName: "ChiTietHoaDon");

            migrationBuilder.RenameIndex(
                name: "IX_NhanViens_Email",
                table: "NhanVien",
                newName: "IX_NhanVien_Email");

            migrationBuilder.RenameIndex(
                name: "IX_HoaDons_IdNhanVien",
                table: "HoaDon",
                newName: "IX_HoaDon_IdNhanVien");

            migrationBuilder.RenameIndex(
                name: "IX_HoaDons_IdKhachHang",
                table: "HoaDon",
                newName: "IX_HoaDon_IdKhachHang");

            migrationBuilder.RenameIndex(
                name: "IX_ChiTietSanPhams_IdSp",
                table: "ChiTietSP",
                newName: "IX_ChiTietSP_IdSp");

            migrationBuilder.RenameIndex(
                name: "IX_ChiTietSanPhams_IdNhaCungCap",
                table: "ChiTietSP",
                newName: "IX_ChiTietSP_IdNhaCungCap");

            migrationBuilder.RenameIndex(
                name: "IX_ChiTietSanPhams_IdLoaiSp",
                table: "ChiTietSP",
                newName: "IX_ChiTietSP_IdLoaiSp");

            migrationBuilder.RenameIndex(
                name: "IX_ChiTietSanPhams_IdDonVi",
                table: "ChiTietSP",
                newName: "IX_ChiTietSP_IdDonVi");

            migrationBuilder.RenameIndex(
                name: "IX_ChiTietSanPhams_IdDanhMuc",
                table: "ChiTietSP",
                newName: "IX_ChiTietSP_IdDanhMuc");

            migrationBuilder.RenameIndex(
                name: "IX_ChiTietHoaDons_IdChiTietSP",
                table: "ChiTietHoaDon",
                newName: "IX_ChiTietHoaDon_IdChiTietSP");

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
                name: "PK_LoaiSanPham",
                table: "LoaiSanPham",
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
                name: "PK_DonVi",
                table: "DonVi",
                column: "IdDonVi");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ChiTietSP",
                table: "ChiTietSP",
                column: "IdChiTietSP");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ChiTietHoaDon",
                table: "ChiTietHoaDon",
                column: "IdHoaDon");

            migrationBuilder.AddForeignKey(
                name: "FK_ChiTietHoaDon_ChiTietSP_IdChiTietSP",
                table: "ChiTietHoaDon",
                column: "IdChiTietSP",
                principalTable: "ChiTietSP",
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
                name: "FK_ChiTietSP_DanhMuc_IdDanhMuc",
                table: "ChiTietSP",
                column: "IdDanhMuc",
                principalTable: "DanhMuc",
                principalColumn: "IdDanhMuc",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ChiTietSP_DonVi_IdDonVi",
                table: "ChiTietSP",
                column: "IdDonVi",
                principalTable: "DonVi",
                principalColumn: "IdDonVi",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ChiTietSP_LoaiSanPham_IdLoaiSp",
                table: "ChiTietSP",
                column: "IdLoaiSp",
                principalTable: "LoaiSanPham",
                principalColumn: "IdLoaiSp",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ChiTietSP_NhaCungCap_IdNhaCungCap",
                table: "ChiTietSP",
                column: "IdNhaCungCap",
                principalTable: "NhaCungCap",
                principalColumn: "IdNhaCungCap",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ChiTietSP_SanPham_IdSp",
                table: "ChiTietSP",
                column: "IdSp",
                principalTable: "SanPham",
                principalColumn: "IdSp",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HoaDon_KhachHang_IdKhachHang",
                table: "HoaDon",
                column: "IdKhachHang",
                principalTable: "KhachHang",
                principalColumn: "IdKhachHang",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HoaDon_NhanVien_IdNhanVien",
                table: "HoaDon",
                column: "IdNhanVien",
                principalTable: "NhanVien",
                principalColumn: "IdNhanVien",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_NhanVien_TaiKhoan_Email",
                table: "NhanVien",
                column: "Email",
                principalTable: "TaiKhoan",
                principalColumn: "TenTaiKhoan",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChiTietHoaDon_ChiTietSP_IdChiTietSP",
                table: "ChiTietHoaDon");

            migrationBuilder.DropForeignKey(
                name: "FK_ChiTietHoaDon_HoaDon_IdHoaDon",
                table: "ChiTietHoaDon");

            migrationBuilder.DropForeignKey(
                name: "FK_ChiTietSP_DanhMuc_IdDanhMuc",
                table: "ChiTietSP");

            migrationBuilder.DropForeignKey(
                name: "FK_ChiTietSP_DonVi_IdDonVi",
                table: "ChiTietSP");

            migrationBuilder.DropForeignKey(
                name: "FK_ChiTietSP_LoaiSanPham_IdLoaiSp",
                table: "ChiTietSP");

            migrationBuilder.DropForeignKey(
                name: "FK_ChiTietSP_NhaCungCap_IdNhaCungCap",
                table: "ChiTietSP");

            migrationBuilder.DropForeignKey(
                name: "FK_ChiTietSP_SanPham_IdSp",
                table: "ChiTietSP");

            migrationBuilder.DropForeignKey(
                name: "FK_HoaDon_KhachHang_IdKhachHang",
                table: "HoaDon");

            migrationBuilder.DropForeignKey(
                name: "FK_HoaDon_NhanVien_IdNhanVien",
                table: "HoaDon");

            migrationBuilder.DropForeignKey(
                name: "FK_NhanVien_TaiKhoan_Email",
                table: "NhanVien");

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
                name: "PK_LoaiSanPham",
                table: "LoaiSanPham");

            migrationBuilder.DropPrimaryKey(
                name: "PK_KhachHang",
                table: "KhachHang");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HoaDon",
                table: "HoaDon");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DonVi",
                table: "DonVi");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ChiTietSP",
                table: "ChiTietSP");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ChiTietHoaDon",
                table: "ChiTietHoaDon");

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
                name: "LoaiSanPham",
                newName: "LoaiSps");

            migrationBuilder.RenameTable(
                name: "KhachHang",
                newName: "KhachHangs");

            migrationBuilder.RenameTable(
                name: "HoaDon",
                newName: "HoaDons");

            migrationBuilder.RenameTable(
                name: "DonVi",
                newName: "DonVis");

            migrationBuilder.RenameTable(
                name: "ChiTietSP",
                newName: "ChiTietSanPhams");

            migrationBuilder.RenameTable(
                name: "ChiTietHoaDon",
                newName: "ChiTietHoaDons");

            migrationBuilder.RenameIndex(
                name: "IX_NhanVien_Email",
                table: "NhanViens",
                newName: "IX_NhanViens_Email");

            migrationBuilder.RenameIndex(
                name: "IX_HoaDon_IdNhanVien",
                table: "HoaDons",
                newName: "IX_HoaDons_IdNhanVien");

            migrationBuilder.RenameIndex(
                name: "IX_HoaDon_IdKhachHang",
                table: "HoaDons",
                newName: "IX_HoaDons_IdKhachHang");

            migrationBuilder.RenameIndex(
                name: "IX_ChiTietSP_IdSp",
                table: "ChiTietSanPhams",
                newName: "IX_ChiTietSanPhams_IdSp");

            migrationBuilder.RenameIndex(
                name: "IX_ChiTietSP_IdNhaCungCap",
                table: "ChiTietSanPhams",
                newName: "IX_ChiTietSanPhams_IdNhaCungCap");

            migrationBuilder.RenameIndex(
                name: "IX_ChiTietSP_IdLoaiSp",
                table: "ChiTietSanPhams",
                newName: "IX_ChiTietSanPhams_IdLoaiSp");

            migrationBuilder.RenameIndex(
                name: "IX_ChiTietSP_IdDonVi",
                table: "ChiTietSanPhams",
                newName: "IX_ChiTietSanPhams_IdDonVi");

            migrationBuilder.RenameIndex(
                name: "IX_ChiTietSP_IdDanhMuc",
                table: "ChiTietSanPhams",
                newName: "IX_ChiTietSanPhams_IdDanhMuc");

            migrationBuilder.RenameIndex(
                name: "IX_ChiTietHoaDon_IdChiTietSP",
                table: "ChiTietHoaDons",
                newName: "IX_ChiTietHoaDons_IdChiTietSP");

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
                name: "PK_DonVis",
                table: "DonVis",
                column: "IdDonVi");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ChiTietSanPhams",
                table: "ChiTietSanPhams",
                column: "IdChiTietSP");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ChiTietHoaDons",
                table: "ChiTietHoaDons",
                column: "IdHoaDon");

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
                name: "FK_HoaDons_KhachHangs_IdKhachHang",
                table: "HoaDons",
                column: "IdKhachHang",
                principalTable: "KhachHangs",
                principalColumn: "IdKhachHang",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HoaDons_NhanViens_IdNhanVien",
                table: "HoaDons",
                column: "IdNhanVien",
                principalTable: "NhanViens",
                principalColumn: "IdNhanVien",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_NhanViens_TaiKhoans_Email",
                table: "NhanViens",
                column: "Email",
                principalTable: "TaiKhoans",
                principalColumn: "TenTaiKhoan",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
