using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccesLayer.Migrations
{
    public partial class usernameadded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Text",
                table: "Comments",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Comments",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Name", "PostedDate" },
                values: new object[] { "Allf3", new DateTime(2021, 3, 22, 12, 57, 45, 285, DateTimeKind.Local).AddTicks(7149) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Comments");

            migrationBuilder.AlterColumn<string>(
                name: "Text",
                table: "Comments",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "ID",
                keyValue: 1,
                column: "PostedDate",
                value: new DateTime(2021, 3, 22, 12, 7, 36, 4, DateTimeKind.Local).AddTicks(5421));
        }
    }
}
