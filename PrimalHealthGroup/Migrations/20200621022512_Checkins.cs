using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PrimalHealthGroup.Migrations
{
    public partial class Checkins : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Checkin",
                columns: table => new
                {
                    CheckinId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Checkindt = table.Column<DateTime>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Temperature = table.Column<double>(nullable: false),
                    Question1 = table.Column<bool>(nullable: false),
                    Question2 = table.Column<bool>(nullable: false),
                    Question3 = table.Column<bool>(nullable: false),
                    Question4 = table.Column<bool>(nullable: false),
                    Question5 = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Checkin", x => x.CheckinId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Checkin");
        }
    }
}
