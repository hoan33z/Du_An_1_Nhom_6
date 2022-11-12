using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace _1.DAL.Migrations
{
    public partial class oko11122022 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "IdChiTietSp",
                table: "ChiTietGioHang",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "IdGioHang",
                table: "ChiTietGioHang",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "DanhMuc",
                columns: table => new
                {
                    IdDanhMuc = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Tên = table.Column<string>(type: "nvarchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DanhMuc", x => x.IdDanhMuc);
                });

            migrationBuilder.CreateTable(
                name: "KhachHang",
                columns: table => new
                {
                    IdKhachHang = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TênKháchHàng = table.Column<string>(name: "Tên Khách Hàng", type: "nvarchar(100)", nullable: false),
                    ĐịaChỉ = table.Column<string>(name: "Địa Chỉ", type: "nvarchar(100)", nullable: false),
                    SốĐiệnThoại = table.Column<string>(name: "Số Điện Thoại", type: "nvarchar(10)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhachHang", x => x.IdKhachHang);
                });

            migrationBuilder.CreateTable(
                name: "LoaiSp",
                columns: table => new
                {
                    IdLoaiSp = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TênLoạiSảnPhẩm = table.Column<string>(name: "Tên Loại Sản Phẩm", type: "nvarchar(100)", nullable: false)
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
                    TênLoạiTàiKhoản = table.Column<int>(name: "Tên Loại Tài Khoản", type: "int", nullable: false)
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
                    TênNhàCungCấp = table.Column<string>(name: "Tên Nhà Cung Cấp", type: "nvarchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhaCungCap", x => x.IdNhaCungCap);
                });

            migrationBuilder.CreateTable(
                name: "NhanVien",
                columns: table => new
                {
                    IdNhanVien = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TênNhânViên = table.Column<string>(name: "Tên Nhân Viên", type: "nvarchar(100)", nullable: false),
                    NămSinh = table.Column<DateTime>(name: "Năm Sinh", type: "datetime", nullable: false),
                    GiớiTính = table.Column<int>(name: "Giới Tính", type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    ĐịaChỉ = table.Column<string>(name: "Địa Chỉ", type: "nvarchar(100)", nullable: false),
                    SốĐiệnThoại = table.Column<string>(name: "Số Điện Thoại", type: "nvarchar(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhanVien", x => x.IdNhanVien);
                });

            migrationBuilder.CreateTable(
                name: "SanPham",
                columns: table => new
                {
                    IdSp = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TênSảnPhẩm = table.Column<string>(name: "Tên Sản Phẩm", type: "nvarchar(100)", nullable: false),
                    NgàyNhập = table.Column<DateTime>(name: "Ngày Nhập", type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SanPham", x => x.IdSp);
                });

            migrationBuilder.CreateTable(
                name: "TaiKhoan",
                columns: table => new
                {
                    IdTaiKhoan = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TênTàiKhoản = table.Column<string>(name: "Tên Tài Khoản", type: "nvarchar(100)", nullable: false),
                    MậtKhẩu = table.Column<string>(name: "Mật Khẩu", type: "nvarchar(100)", nullable: false),
                    LoạiTàiKhoản = table.Column<int>(name: "Loại Tài Khoản", type: "int", nullable: false),
                    TrạngThá = table.Column<int>(name: "Trạng Thá", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaiKhoan", x => x.IdTaiKhoan);
                });

            migrationBuilder.CreateTable(
                name: "GioHang",
                columns: table => new
                {
                    IdGioHang = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdKhachHang = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ĐịaChỉ = table.Column<string>(name: "Địa Chỉ", type: "nvarchar(100)", nullable: false),
                    SốĐiệnThoại = table.Column<string>(name: "Số Điện Thoại", type: "nvarchar(10)", nullable: false),
                    NgàyThanhToán = table.Column<DateTime>(name: "Ngày Thanh Toán", type: "datetime", nullable: false),
                    TrạngThái = table.Column<int>(name: "Trạng Thái", type: "int", nullable: false)
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
                    IdNhanVien = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdKhachHang = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TổngTiền = table.Column<decimal>(name: "Tổng Tiền", type: "decimal", nullable: false),
                    NgàyThanhToán = table.Column<DateTime>(name: "Ngày Thanh Toán", type: "datetime", nullable: false),
                    NgàyNhận = table.Column<DateTime>(name: "Ngày Nhận", type: "datetime", nullable: false),
                    SốĐiệnThoại = table.Column<string>(name: "Số Điện Thoại", type: "nvarchar(10)", nullable: false),
                    ĐịaChỉ = table.Column<string>(name: "Địa Chỉ", type: "nvarchar(100)", nullable: false)
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
                        name: "FK_HoaDon_NhanVien_IdNhanVien",
                        column: x => x.IdNhanVien,
                        principalTable: "NhanVien",
                        principalColumn: "IdNhanVien",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ChiTietSanPham",
                columns: table => new
                {
                    IdChiTietSP = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdDanhMuc = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdLoaiSp = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdNhaCungCap = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdSp = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Tên = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    HinhAnh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GiáNhập = table.Column<decimal>(name: "Giá Nhập", type: "decimal", nullable: false),
                    GiáBán = table.Column<decimal>(name: "Giá Bán", type: "decimal", nullable: false),
                    SốLượng = table.Column<int>(name: "Số Lượng", type: "int", nullable: false),
                    LoaiSpIdLoaiSp = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    NhaCungCapIdNhaCungCap = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SanPhamIdSp = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
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
                        name: "FK_ChiTietSanPham_LoaiSp_LoaiSpIdLoaiSp",
                        column: x => x.LoaiSpIdLoaiSp,
                        principalTable: "LoaiSp",
                        principalColumn: "IdLoaiSp",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ChiTietSanPham_NhaCungCap_NhaCungCapIdNhaCungCap",
                        column: x => x.NhaCungCapIdNhaCungCap,
                        principalTable: "NhaCungCap",
                        principalColumn: "IdNhaCungCap",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ChiTietSanPham_SanPham_SanPhamIdSp",
                        column: x => x.SanPhamIdSp,
                        principalTable: "SanPham",
                        principalColumn: "IdSp",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ChiTietHoaDon",
                columns: table => new
                {
                    IdCTHoaDon = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdChiTietSP = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ĐơnGiá = table.Column<decimal>(name: "Đơn Giá", type: "decimal", nullable: false),
                    SốLượngMua = table.Column<int>(name: "Số Lượng Mua", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietHoaDon", x => x.IdCTHoaDon);
                    table.ForeignKey(
                        name: "FK_ChiTietHoaDon_ChiTietSanPham_IdChiTietSP",
                        column: x => x.IdChiTietSP,
                        principalTable: "ChiTietSanPham",
                        principalColumn: "IdChiTietSP",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietGioHang_IdChiTietSp",
                table: "ChiTietGioHang",
                column: "IdChiTietSp");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietGioHang_IdGioHang",
                table: "ChiTietGioHang",
                column: "IdGioHang");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietHoaDon_IdChiTietSP",
                table: "ChiTietHoaDon",
                column: "IdChiTietSP");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietSanPham_IdDanhMuc",
                table: "ChiTietSanPham",
                column: "IdDanhMuc");

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

            migrationBuilder.CreateIndex(
                name: "IX_GioHang_IdKhachHang",
                table: "GioHang",
                column: "IdKhachHang");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_IdKhachHang",
                table: "HoaDon",
                column: "IdKhachHang");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_IdNhanVien",
                table: "HoaDon",
                column: "IdNhanVien");

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChiTietGioHang_ChiTietSanPham_IdChiTietSp",
                table: "ChiTietGioHang");

            migrationBuilder.DropForeignKey(
                name: "FK_ChiTietGioHang_GioHang_IdGioHang",
                table: "ChiTietGioHang");

            migrationBuilder.DropTable(
                name: "ChiTietHoaDon");

            migrationBuilder.DropTable(
                name: "GioHang");

            migrationBuilder.DropTable(
                name: "HoaDon");

            migrationBuilder.DropTable(
                name: "LoaiTK");

            migrationBuilder.DropTable(
                name: "TaiKhoan");

            migrationBuilder.DropTable(
                name: "ChiTietSanPham");

            migrationBuilder.DropTable(
                name: "KhachHang");

            migrationBuilder.DropTable(
                name: "NhanVien");

            migrationBuilder.DropTable(
                name: "DanhMuc");

            migrationBuilder.DropTable(
                name: "LoaiSp");

            migrationBuilder.DropTable(
                name: "NhaCungCap");

            migrationBuilder.DropTable(
                name: "SanPham");

            migrationBuilder.DropIndex(
                name: "IX_ChiTietGioHang_IdChiTietSp",
                table: "ChiTietGioHang");

            migrationBuilder.DropIndex(
                name: "IX_ChiTietGioHang_IdGioHang",
                table: "ChiTietGioHang");

            migrationBuilder.DropColumn(
                name: "IdChiTietSp",
                table: "ChiTietGioHang");

            migrationBuilder.DropColumn(
                name: "IdGioHang",
                table: "ChiTietGioHang");
        }
    }
}
