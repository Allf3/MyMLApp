using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccesLayer.Migrations
{
    public partial class housepricing : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Houses",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<string>(nullable: true),
                    Price = table.Column<float>(nullable: false),
                    Bedrooms = table.Column<float>(nullable: false),
                    Bathrooms = table.Column<float>(nullable: false),
                    Sqft_living = table.Column<float>(nullable: false),
                    Sqft_lot = table.Column<float>(nullable: false),
                    Floors = table.Column<float>(nullable: false),
                    Waterfront = table.Column<float>(nullable: false),
                    View = table.Column<float>(nullable: false),
                    Condition = table.Column<float>(nullable: false),
                    Sqft_above = table.Column<float>(nullable: false),
                    Sqft_basement = table.Column<float>(nullable: false),
                    Yr_built = table.Column<float>(nullable: false),
                    Yr_renovated = table.Column<float>(nullable: false),
                    Street = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    Statezip = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    PredictedScore = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Houses", x => x.ID);
                });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "ID",
                keyValue: 1,
                column: "PostedDate",
                value: new DateTime(2021, 4, 7, 10, 50, 9, 490, DateTimeKind.Local).AddTicks(4064));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Houses");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "ID",
                keyValue: 1,
                column: "PostedDate",
                value: new DateTime(2021, 3, 22, 12, 57, 45, 285, DateTimeKind.Local).AddTicks(7149));
        }
    }
}
