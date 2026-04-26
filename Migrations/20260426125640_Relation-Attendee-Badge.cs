using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCore02.Migrations
{
    /// <inheritdoc />
    public partial class RelationAttendeeBadge : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "BadgeId",
                table: "Attendee",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "Badges",
                columns: table => new
                {
                    BadgeNum = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IssuedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    tier = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Badges", x => x.BadgeNum);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Attendee_BadgeId",
                table: "Attendee",
                column: "BadgeId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Attendee_Badges_BadgeId",
                table: "Attendee",
                column: "BadgeId",
                principalTable: "Badges",
                principalColumn: "BadgeNum",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Attendee_Badges_BadgeId",
                table: "Attendee");

            migrationBuilder.DropTable(
                name: "Badges");

            migrationBuilder.DropIndex(
                name: "IX_Attendee_BadgeId",
                table: "Attendee");

            migrationBuilder.DropColumn(
                name: "BadgeId",
                table: "Attendee");
        }
    }
}
