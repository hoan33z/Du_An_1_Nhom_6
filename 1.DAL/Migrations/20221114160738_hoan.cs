using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace _1.DAL.Migrations
{
    public partial class hoan : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DanhMuc",
                columns: table => new
                {
                    IdDanhMuc = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenDanhMuc = table.Column<string>(type: "nvarchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DanhMuc", x => x.IdDanhMuc);
                });

            migrationBuilder.CreateTable(
                name: "LoaiSp",
                columns: table => new
                {
                    IdLoaiSp = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenLoaiSp = table.Column<string>(type: "nvarchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoaiSp", x => x.IdLoaiSp);
                });

            migrationBuilder.CreateTable(
                name: "LoaiTK",
                columns: table => new
                {
                    IdLoaiTK = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenLoaiTK = table.Column<string>(type: "nvarchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoaiTK", x => x.IdLoaiTK);
                });

            migrationBuilder.CreateTable(
                name: "NhaCungCap",
                columns: table => new
                {
                    IdNhaCungCap = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenNhaCC = table.Column<string>(type: "nvarchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhaCungCap", x => x.IdNhaCungCap);
                });

            migrationBuilder.CreateTable(
                name: "SanPham",
                columns: table => new
                {
                    IdSp = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenSanPham = table.Column<string>(type: "nvarchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SanPham", x => x.IdSp);
                });

            migrationBuilder.CreateTable(
                name: "TaiKhoan",
                columns: table => new
                {
                    TenTaiKhoan = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    MatKhau = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    IdLoaiTk = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaiKhoan", x => x.TenTaiKhoan);
                    table.ForeignKey(
                        name: "FK_TaiKhoan_LoaiTK_IdLoaiTk",
                        column: x => x.IdLoaiTk,
                        principalTable: "LoaiTK",
                        principalColumn: "IdLoaiTK",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ChiTietSanPham",
                columns: table => new
                {
                    IdChiTietSP = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdLoaiSp = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdNhaCungCap = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdSp = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdDanhMuc = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    HinhAnh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GiaNhap = table.Column<decimal>(type: "decimal", nullable: false),
                    GiaBan = table.Column<decimal>(type: "decimal", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietSanPham", x => x.IdChiTietSP);
                    table.ForeignKey(
                        name: "FK_ChiTietSanPham_DanhMuc_IdDanhMuc",
                        column: x => x.IdDanhMuc,
                        principalTable: "DanhMuc",
                        principalColumn: "IdDanhMuc",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChiTietSanPham_LoaiSp_IdLoaiSp",
                        column: x => x.IdLoaiSp,
                        principalTable: "LoaiSp",
                        principalColumn: "IdLoaiSp",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChiTietSanPham_NhaCungCap_IdNhaCungCap",
                        column: x => x.IdNhaCungCap,
                        principalTable: "NhaCungCap",
                        principalColumn: "IdNhaCungCap",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChiTietSanPham_SanPham_IdSp",
                        column: x => x.IdSp,
                        principalTable: "SanPham",
                        principalColumn: "IdSp",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KhachHang",
                columns: table => new
                {
                    IdKhachHang = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenKhachHang = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    ĐiaChi = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    SDT = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhachHang", x => x.IdKhachHang);
                    table.ForeignKey(
                        name: "FK_KhachHang_TaiKhoan_Email",
                        column: x => x.Email,
                        principalTable: "TaiKhoan",
                        principalColumn: "TenTaiKhoan",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NhanVien",
                columns: table => new
                {
                    IdNhanVien = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenNhanVien = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    NamSinh = table.Column<DateTime>(type: "datetime", nullable: false),
                    GioiTinh = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    ĐiaChi = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    SĐT = table.Column<string>(type: "nvarchar(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhanVien", x => x.IdNhanVien);
                    table.ForeignKey(
                        name: "FK_NhanVien_TaiKhoan_Email",
                        column: x => x.Email,
                        principalTable: "TaiKhoan",
                        principalColumn: "TenTaiKhoan",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GioHang",
                columns: table => new
                {
                    IdGioHang = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdKhachHang = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NgayThanhToan = table.Column<DateTime>(type: "datetime", nullable: false),
                    NgayMuaHang = table.Column<DateTime>(type: "datetime", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GioHang", x => x.IdGioHang);
                    table.ForeignKey(
                        name: "FK_GioHang_KhachHang_IdKhachHang",
                        column: x => x.IdKhachHang,
                        principalTable: "KhachHang",
                        principalColumn: "IdKhachHang",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HoaDon",
                columns: table => new
                {
                    IdHoaDon = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdKhachHang = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdNhanVien = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TongTien = table.Column<decimal>(type: "decimal", nullable: false),
                    NgayThanhToan = table.Column<DateTime>(type: "datetime", nullable: false),
                    NgayNhan = table.Column<DateTime>(type: "datetime", nullable: false),
                    NhanVienIdNhanVien = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDon", x => x.IdHoaDon);
                    table.ForeignKey(
                        name: "FK_HoaDon_KhachHang_IdKhachHang",
                        column: x => x.IdKhachHang,
                        principalTable: "KhachHang",
                        principalColumn: "IdKhachHang",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HoaDon_NhanVien_NhanVienIdNhanVien",
                        column: x => x.NhanVienIdNhanVien,
                        principalTable: "NhanVien",
                        principalColumn: "IdNhanVien",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ChiTietGioHang",
                columns: table => new
                {
                    IdGioHang = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdChiTietSp = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DonGia = table.Column<decimal>(type: "decimal", nullable: false),
                    SoLuongMua = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietGioHang", x => x.IdGioHang);
                    table.ForeignKey(
                        name: "FK_ChiTietGioHang_ChiTietSanPham_IdChiTietSp",
                        column: x => x.IdChiTietSp,
                        principalTable: "ChiTietSanPham",
                        principalColumn: "IdChiTietSP",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChiTietGioHang_GioHang_IdGioHang",
                        column: x => x.IdGioHang,
                        principalTable: "GioHang",
                        principalColumn: "IdGioHang",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ChiTietHoaDon",
                columns: table => new
                {
                    IdHoaDon = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdCTHoaDon = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdChiTietSP = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DonGia = table.Column<decimal>(type: "decimal", nullable: false),
                    SoLuongMua = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietHoaDon", x => x.IdHoaDon);
                    table.ForeignKey(
                        name: "FK_ChiTietHoaDon_ChiTietSanPham_IdChiTietSP",
                        column: x => x.IdChiTietSP,
                        principalTable: "ChiTietSanPham",
                        principalColumn: "IdChiTietSP",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChiTietHoaDon_HoaDon_IdHoaDon",
                        column: x => x.IdHoaDon,
                        principalTable: "HoaDon",
                        principalColumn: "IdHoaDon",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietGioHang_IdChiTietSp",
                table: "ChiTietGioHang",
                column: "IdChiTietSp");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietHoaDon_IdChiTietSP",
                table: "ChiTietHoaDon",
                column: "IdChiTietSP");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietSanPham_IdDanhMuc",
                table: "ChiTietSanPham",
                column: "IdDanhMuc");

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

            migrationBuilder.CreateIndex(
                name: "IX_GioHang_IdKhachHang",
                table: "GioHang",
                column: "IdKhachHang");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_IdKhachHang",
                table: "HoaDon",
                column: "IdKhachHang");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_NhanVienIdNhanVien",
                table: "HoaDon",
                column: "NhanVienIdNhanVien");

            migrationBuilder.CreateIndex(
                name: "IX_KhachHang_Email",
                table: "KhachHang",
                column: "Email");

            migrationBuilder.CreateIndex(
                name: "IX_NhanVien_Email",
                table: "NhanVien",
                column: "Email");

            migrationBuilder.CreateIndex(
                name: "IX_TaiKhoan_IdLoaiTk",
                table: "TaiKhoan",
                column: "IdLoaiTk");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChiTietGioHang");

            migrationBuilder.DropTable(
                name: "ChiTietHoaDon");

            migrationBuilder.DropTable(
                name: "GioHang");

            migrationBuilder.DropTable(
                name: "ChiTietSanPham");

            migrationBuilder.DropTable(
                name: "HoaDon");

            migrationBuilder.DropTable(
                name: "DanhMuc");

            migrationBuilder.DropTable(
                name: "LoaiSp");

            migrationBuilder.DropTable(
                name: "NhaCungCap");

            migrationBuilder.DropTable(
                name: "SanPham");

            migrationBuilder.DropTable(
                name: "KhachHang");

            migrationBuilder.DropTable(
                name: "NhanVien");

            migrationBuilder.DropTable(
                name: "TaiKhoan");

            migrationBuilder.DropTable(
                name: "LoaiTK");
        }
    }
}
