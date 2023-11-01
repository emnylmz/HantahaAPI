using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace HantahaAPI.Data.Migrations
{
    /// <inheritdoc />
    public partial class sentence : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SentenceId",
                table: "Verb",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Sentence",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(300)", maxLength: 300, nullable: false),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreatedBy = table.Column<int>(type: "integer", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UpdatedBy = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sentence", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sentence_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Sentence_User_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SentenceItem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Context = table.Column<string>(type: "character varying(300)", maxLength: 300, nullable: false),
                    LanguageId = table.Column<int>(type: "integer", nullable: false),
                    SentenceId = table.Column<int>(type: "integer", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreatedBy = table.Column<int>(type: "integer", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UpdatedBy = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SentenceItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SentenceItem_Language_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Language",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SentenceItem_Sentence_SentenceId",
                        column: x => x.SentenceId,
                        principalTable: "Sentence",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SentenceItem_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SentenceItem_User_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Verb_SentenceId",
                table: "Verb",
                column: "SentenceId");

            migrationBuilder.CreateIndex(
                name: "IX_Sentence_CreatedBy",
                table: "Sentence",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Sentence_UpdatedBy",
                table: "Sentence",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SentenceItem_CreatedBy",
                table: "SentenceItem",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SentenceItem_LanguageId",
                table: "SentenceItem",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_SentenceItem_SentenceId",
                table: "SentenceItem",
                column: "SentenceId");

            migrationBuilder.CreateIndex(
                name: "IX_SentenceItem_UpdatedBy",
                table: "SentenceItem",
                column: "UpdatedBy");

            migrationBuilder.AddForeignKey(
                name: "FK_Verb_Sentence_SentenceId",
                table: "Verb",
                column: "SentenceId",
                principalTable: "Sentence",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Verb_Sentence_SentenceId",
                table: "Verb");

            migrationBuilder.DropTable(
                name: "SentenceItem");

            migrationBuilder.DropTable(
                name: "Sentence");

            migrationBuilder.DropIndex(
                name: "IX_Verb_SentenceId",
                table: "Verb");

            migrationBuilder.DropColumn(
                name: "SentenceId",
                table: "Verb");
        }
    }
}
