using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HantahaAPI.Data.Migrations
{
    /// <inheritdoc />
    public partial class systemLog : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ExceptionType",
                table: "SystemLog");

            migrationBuilder.AddColumn<string>(
                name: "HeaderString",
                table: "SystemLog",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IpAddress",
                table: "SystemLog",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RequestQueryString",
                table: "SystemLog",
                type: "text",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HeaderString",
                table: "SystemLog");

            migrationBuilder.DropColumn(
                name: "IpAddress",
                table: "SystemLog");

            migrationBuilder.DropColumn(
                name: "RequestQueryString",
                table: "SystemLog");

            migrationBuilder.AddColumn<string>(
                name: "ExceptionType",
                table: "SystemLog",
                type: "character varying(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "");
        }
    }
}
