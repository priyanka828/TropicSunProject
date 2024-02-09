using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TropicSun.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Location",
                columns: table => new
                {
                    LocationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Location", x => x.LocationId);
                });

            migrationBuilder.CreateTable(
                name: "Yacht",
                columns: table => new
                {
                    YachtId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yacht", x => x.YachtId);
                });

            migrationBuilder.CreateTable(
                name: "Reservation",
                columns: table => new
                {
                    ReservationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    YachtId = table.Column<int>(type: "int", nullable: true),
                    ReservationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StartLocationLocationId = table.Column<int>(type: "int", nullable: true),
                    EndLocationLocationId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservation", x => x.ReservationId);
                    table.ForeignKey(
                        name: "FK_Reservation_Location_EndLocationLocationId",
                        column: x => x.EndLocationLocationId,
                        principalTable: "Location",
                        principalColumn: "LocationId");
                    table.ForeignKey(
                        name: "FK_Reservation_Location_StartLocationLocationId",
                        column: x => x.StartLocationLocationId,
                        principalTable: "Location",
                        principalColumn: "LocationId");
                    table.ForeignKey(
                        name: "FK_Reservation_Yacht_YachtId",
                        column: x => x.YachtId,
                        principalTable: "Yacht",
                        principalColumn: "YachtId");
                });

            migrationBuilder.InsertData(
                table: "Yacht",
                column: "YachtId",
                value: 1);

            migrationBuilder.InsertData(
                table: "Reservation",
                columns: new[] { "ReservationId", "EndDate", "EndLocationLocationId", "ReservationDate", "StartDate", "StartLocationLocationId", "YachtId" },
                values: new object[] { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 2, 8, 17, 14, 51, 109, DateTimeKind.Local).AddTicks(248), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1 });

            migrationBuilder.CreateIndex(
                name: "IX_Reservation_EndLocationLocationId",
                table: "Reservation",
                column: "EndLocationLocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservation_StartLocationLocationId",
                table: "Reservation",
                column: "StartLocationLocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservation_YachtId",
                table: "Reservation",
                column: "YachtId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reservation");

            migrationBuilder.DropTable(
                name: "Location");

            migrationBuilder.DropTable(
                name: "Yacht");
        }
    }
}
