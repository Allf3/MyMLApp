using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccesLayer.Migrations
{
    public partial class entityupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "ID",
                keyValue: 1,
                column: "PostedDate",
                value: new DateTime(2021, 4, 8, 0, 4, 6, 894, DateTimeKind.Local).AddTicks(4975));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "ID",
                keyValue: 1,
                column: "PostedDate",
                value: new DateTime(2021, 4, 8, 0, 2, 42, 570, DateTimeKind.Local).AddTicks(2884));
        }
    }
}
