using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace HantahaAPI.Data.Migrations
{
    /// <inheritdoc />
    public partial class tokenTracker : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BlackListToken");

            migrationBuilder.CreateTable(
                name: "TokenTrackers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Token = table.Column<string>(type: "text", nullable: false),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    ExpirationDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TokenTrackers", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SystemLog_UserId",
                table: "SystemLog",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_SystemLog_User_UserId",
                table: "SystemLog",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SystemLog_User_UserId",
                table: "SystemLog");

            migrationBuilder.DropTable(
                name: "TokenTrackers");

            migrationBuilder.DropIndex(
                name: "IX_SystemLog_UserId",
                table: "SystemLog");

            migrationBuilder.CreateTable(
                name: "BlackListToken",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ExpirationDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    Token = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlackListToken", x => x.Id);
                });
        }
    }
}
