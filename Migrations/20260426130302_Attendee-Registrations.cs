using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCore02.Migrations
{
    /// <inheritdoc />
    public partial class AttendeeRegistrations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Attendee_Badges_BadgeId",
                table: "Attendee");

            migrationBuilder.DropForeignKey(
                name: "FK_Attendee_HomeAddress_AddressId",
                table: "Attendee");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HomeAddress",
                table: "HomeAddress");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Attendee",
                table: "Attendee");

            migrationBuilder.RenameTable(
                name: "HomeAddress",
                newName: "HomeAddresses");

            migrationBuilder.RenameTable(
                name: "Attendee",
                newName: "Attendees");

            migrationBuilder.RenameIndex(
                name: "IX_Attendee_BadgeId",
                table: "Attendees",
                newName: "IX_Attendees_BadgeId");

            migrationBuilder.RenameIndex(
                name: "IX_Attendee_AddressId",
                table: "Attendees",
                newName: "IX_Attendees_AddressId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HomeAddresses",
                table: "HomeAddresses",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Attendees",
                table: "Attendees",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Registrations",
                columns: table => new
                {
                    RegistrationsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AttendeeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Registrations", x => x.RegistrationsId);
                    table.ForeignKey(
                        name: "FK_Registrations_Attendees_AttendeeId",
                        column: x => x.AttendeeId,
                        principalTable: "Attendees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Registrations_AttendeeId",
                table: "Registrations",
                column: "AttendeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Attendees_Badges_BadgeId",
                table: "Attendees",
                column: "BadgeId",
                principalTable: "Badges",
                principalColumn: "BadgeNum",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Attendees_HomeAddresses_AddressId",
                table: "Attendees",
                column: "AddressId",
                principalTable: "HomeAddresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Attendees_Badges_BadgeId",
                table: "Attendees");

            migrationBuilder.DropForeignKey(
                name: "FK_Attendees_HomeAddresses_AddressId",
                table: "Attendees");

            migrationBuilder.DropTable(
                name: "Registrations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HomeAddresses",
                table: "HomeAddresses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Attendees",
                table: "Attendees");

            migrationBuilder.RenameTable(
                name: "HomeAddresses",
                newName: "HomeAddress");

            migrationBuilder.RenameTable(
                name: "Attendees",
                newName: "Attendee");

            migrationBuilder.RenameIndex(
                name: "IX_Attendees_BadgeId",
                table: "Attendee",
                newName: "IX_Attendee_BadgeId");

            migrationBuilder.RenameIndex(
                name: "IX_Attendees_AddressId",
                table: "Attendee",
                newName: "IX_Attendee_AddressId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HomeAddress",
                table: "HomeAddress",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Attendee",
                table: "Attendee",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Attendee_Badges_BadgeId",
                table: "Attendee",
                column: "BadgeId",
                principalTable: "Badges",
                principalColumn: "BadgeNum",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Attendee_HomeAddress_AddressId",
                table: "Attendee",
                column: "AddressId",
                principalTable: "HomeAddress",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
