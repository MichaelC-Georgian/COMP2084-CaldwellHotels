using Microsoft.EntityFrameworkCore.Migrations;

namespace CaldwellHotels.Migrations
{
    public partial class v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Rooms_PersonID",
                table: "Reservations");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_RoomID",
                table: "Reservations",
                column: "RoomID");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Persons_PersonID",
                table: "Reservations",
                column: "PersonID",
                principalTable: "Persons",
                principalColumn: "PersonID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Rooms_RoomID",
                table: "Reservations",
                column: "RoomID",
                principalTable: "Rooms",
                principalColumn: "RoomID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Persons_PersonID",
                table: "Reservations");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Rooms_RoomID",
                table: "Reservations");

            migrationBuilder.DropIndex(
                name: "IX_Reservations_RoomID",
                table: "Reservations");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Rooms_PersonID",
                table: "Reservations",
                column: "PersonID",
                principalTable: "Rooms",
                principalColumn: "RoomID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
