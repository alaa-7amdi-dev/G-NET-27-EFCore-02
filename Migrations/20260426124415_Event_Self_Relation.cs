using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCore02.Migrations
{
    /// <inheritdoc />
    public partial class Event_Self_Relation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ParentId",
                table: "Event",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Event_ParentId",
                table: "Event",
                column: "ParentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Event_Event_ParentId",
                table: "Event",
                column: "ParentId",
                principalTable: "Event",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Event_Event_ParentId",
                table: "Event");

            migrationBuilder.DropIndex(
                name: "IX_Event_ParentId",
                table: "Event");

            migrationBuilder.DropColumn(
                name: "ParentId",
                table: "Event");
        }
    }
}
