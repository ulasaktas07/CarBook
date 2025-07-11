using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarBook.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig_add_location_reservation_relation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RentACarProcesses_Locations_DropOffLocation",
                table: "RentACarProcesses");

            migrationBuilder.DropForeignKey(
                name: "FK_RentACarProcesses_Locations_PickUpLocation",
                table: "RentACarProcesses");

            migrationBuilder.DropIndex(
                name: "IX_RentACarProcesses_DropOffLocation",
                table: "RentACarProcesses");

            migrationBuilder.DropIndex(
                name: "IX_RentACarProcesses_PickUpLocation",
                table: "RentACarProcesses");

            migrationBuilder.DropColumn(
                name: "DropOffLocation",
                table: "RentACarProcesses");

            migrationBuilder.DropColumn(
                name: "PickUpLocation",
                table: "RentACarProcesses");

            migrationBuilder.CreateTable(
                name: "Reservations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CarID = table.Column<int>(type: "int", nullable: false),
                    PickUpLocationID = table.Column<int>(type: "int", nullable: true),
                    DropOffLocationID = table.Column<int>(type: "int", nullable: true),
                    Age = table.Column<int>(type: "int", nullable: false),
                    DriverLicenseYear = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reservations_Locations_DropOffLocationID",
                        column: x => x.DropOffLocationID,
                        principalTable: "Locations",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Reservations_Locations_PickUpLocationID",
                        column: x => x.PickUpLocationID,
                        principalTable: "Locations",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_DropOffLocationID",
                table: "Reservations",
                column: "DropOffLocationID");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_PickUpLocationID",
                table: "Reservations",
                column: "PickUpLocationID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reservations");

            migrationBuilder.AddColumn<int>(
                name: "DropOffLocation",
                table: "RentACarProcesses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PickUpLocation",
                table: "RentACarProcesses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_RentACarProcesses_DropOffLocation",
                table: "RentACarProcesses",
                column: "DropOffLocation");

            migrationBuilder.CreateIndex(
                name: "IX_RentACarProcesses_PickUpLocation",
                table: "RentACarProcesses",
                column: "PickUpLocation");

            migrationBuilder.AddForeignKey(
                name: "FK_RentACarProcesses_Locations_DropOffLocation",
                table: "RentACarProcesses",
                column: "DropOffLocation",
                principalTable: "Locations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RentACarProcesses_Locations_PickUpLocation",
                table: "RentACarProcesses",
                column: "PickUpLocation",
                principalTable: "Locations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
