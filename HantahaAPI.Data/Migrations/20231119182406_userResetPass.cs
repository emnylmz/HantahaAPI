using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace HantahaAPI.Data.Migrations
{
    /// <inheritdoc />
    public partial class userResetPass : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserPasswordResetToken");

            migrationBuilder.DropColumn(
                name: "ForgotPasswordKey",
                table: "User");

            migrationBuilder.AddColumn<DateTime>(
                name: "LastCreationDateOfResetToken",
                table: "User",
                type: "timestamp without time zone",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ResetToken",
                table: "User",
                type: "uuid",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LastCreationDateOfResetToken",
                table: "User");

            migrationBuilder.DropColumn(
                name: "ResetToken",
                table: "User");

            migrationBuilder.AddColumn<Guid>(
                name: "ForgotPasswordKey",
                table: "User",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "UserPasswordResetToken",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    ExpirationTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserPasswordResetToken", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserPasswordResetToken_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserPasswordResetToken_UserId",
                table: "UserPasswordResetToken",
                column: "UserId");
        }
    }
}
