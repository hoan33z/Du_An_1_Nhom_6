using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace _1.DAL.Migrations
{
    public partial class ok11122022 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ChiTietGioHang",
                columns: table => new
                {
                    IdCTGioHang = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ĐơnGiá = table.Column<decimal>(name: "Đơn Giá", type: "decimal", nullable: false),
                    SốLượngMua = table.Column<int>(name: "Số Lượng Mua", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietGioHang", x => x.IdCTGioHang);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChiTietGioHang");
        }
    }
}
