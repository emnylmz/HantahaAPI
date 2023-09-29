using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HantahaAPI.Data.Migrations
{
    /// <inheritdoc />
    public partial class uservisibility : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserVisibiltyType",
                table: "User",
                newName: "UserVisibilityType");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "User",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserVisibilityType",
                table: "User",
                newName: "UserVisibiltyType");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "User",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");
        }
    }
}
