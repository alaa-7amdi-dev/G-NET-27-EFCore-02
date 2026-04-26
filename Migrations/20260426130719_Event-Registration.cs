using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCore02.Migrations
{
    /// <inheritdoc />
    public partial class EventRegistration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EvientId",
                table: "Registrations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Registrations_EvientId",
                table: "Registrations",
                column: "EvientId");

            migrationBuilder.AddForeignKey(
                name: "FK_Registrations_Event_EvientId",
                table: "Registrations",
                column: "EvientId",
                principalTable: "Event",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Registrations_Event_EvientId",
                table: "Registrations");

            migrationBuilder.DropIndex(
                name: "IX_Registrations_EvientId",
                table: "Registrations");

            migrationBuilder.DropColumn(
                name: "EvientId",
                table: "Registrations");
        }
    }
}
