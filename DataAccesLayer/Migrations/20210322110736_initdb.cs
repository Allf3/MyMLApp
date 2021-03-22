using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccesLayer.Migrations
{
    public partial class initdb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(nullable: true),
                    PostedDate = table.Column<DateTime>(nullable: false),
                    Toxic = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "ID", "PostedDate", "Text", "Toxic" },
                values: new object[] { 1, new DateTime(2021, 3, 22, 12, 7, 36, 4, DateTimeKind.Local).AddTicks(5421), "You are just a degenerate retard", true });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comments");
        }
    }
}
