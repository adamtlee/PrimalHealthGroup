using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PrimalHealthGroup.Migrations
{
    public partial class TestAppointments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AppointmentId",
                table: "Patient",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AppointmentId",
                table: "Doctor",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Appointment",
                columns: table => new
                {
                    AppointmentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateTime = table.Column<DateTime>(nullable: false),
                    Location = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointment", x => x.AppointmentId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Patient_AppointmentId",
                table: "Patient",
                column: "AppointmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Doctor_AppointmentId",
                table: "Doctor",
                column: "AppointmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Doctor_Appointment_AppointmentId",
                table: "Doctor",
                column: "AppointmentId",
                principalTable: "Appointment",
                principalColumn: "AppointmentId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Patient_Appointment_AppointmentId",
                table: "Patient",
                column: "AppointmentId",
                principalTable: "Appointment",
                principalColumn: "AppointmentId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Doctor_Appointment_AppointmentId",
                table: "Doctor");

            migrationBuilder.DropForeignKey(
                name: "FK_Patient_Appointment_AppointmentId",
                table: "Patient");

            migrationBuilder.DropTable(
                name: "Appointment");

            migrationBuilder.DropIndex(
                name: "IX_Patient_AppointmentId",
                table: "Patient");

            migrationBuilder.DropIndex(
                name: "IX_Doctor_AppointmentId",
                table: "Doctor");

            migrationBuilder.DropColumn(
                name: "AppointmentId",
                table: "Patient");

            migrationBuilder.DropColumn(
                name: "AppointmentId",
                table: "Doctor");
        }
    }
}
