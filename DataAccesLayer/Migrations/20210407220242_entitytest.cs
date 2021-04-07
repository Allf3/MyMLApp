using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccesLayer.Migrations
{
    public partial class entitytest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Yr_renovated",
                table: "Houses",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Yr_built",
                table: "Houses",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "ID",
                keyValue: 1,
                column: "PostedDate",
                value: new DateTime(2021, 4, 8, 0, 2, 42, 570, DateTimeKind.Local).AddTicks(2884));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "Yr_renovated",
                table: "Houses",
                type: "real",
                nullable: false,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<float>(
                name: "Yr_built",
                table: "Houses",
                type: "real",
                nullable: false,
                oldClrType: typeof(DateTime));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "ID",
                keyValue: 1,
                column: "PostedDate",
                value: new DateTime(2021, 4, 7, 10, 50, 9, 490, DateTimeKind.Local).AddTicks(4064));
        }
    }
}
