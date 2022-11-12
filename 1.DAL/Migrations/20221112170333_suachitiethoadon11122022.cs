using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace _1.DAL.Migrations
{
    public partial class suachitiethoadon11122022 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "IdHoaDon",
                table: "ChiTietHoaDon",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietHoaDon_IdHoaDon",
                table: "ChiTietHoaDon",
                column: "IdHoaDon");

            migrationBuilder.AddForeignKey(
                name: "FK_ChiTietHoaDon_HoaDon_IdHoaDon",
                table: "ChiTietHoaDon",
                column: "IdHoaDon",
                principalTable: "HoaDon",
                principalColumn: "IdHoaDon",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChiTietHoaDon_HoaDon_IdHoaDon",
                table: "ChiTietHoaDon");

            migrationBuilder.DropIndex(
                name: "IX_ChiTietHoaDon_IdHoaDon",
                table: "ChiTietHoaDon");

            migrationBuilder.DropColumn(
                name: "IdHoaDon",
                table: "ChiTietHoaDon");
        }
    }
}
