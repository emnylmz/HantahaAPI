using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace HantahaAPI.Data.Migrations
{
    /// <inheritdoc />
    public partial class sentenceVerb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Verb_Sentence_SentenceId",
                table: "Verb");

            migrationBuilder.DropIndex(
                name: "IX_Verb_SentenceId",
                table: "Verb");

            migrationBuilder.DropColumn(
                name: "SentenceId",
                table: "Verb");

            migrationBuilder.CreateTable(
                name: "SentenceVerb",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    SentenceId = table.Column<int>(type: "integer", nullable: false),
                    VerbId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SentenceVerb", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SentenceVerb_Sentence_SentenceId",
                        column: x => x.SentenceId,
                        principalTable: "Sentence",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SentenceVerb_Verb_VerbId",
                        column: x => x.VerbId,
                        principalTable: "Verb",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SentenceVerb_SentenceId",
                table: "SentenceVerb",
                column: "SentenceId");

            migrationBuilder.CreateIndex(
                name: "IX_SentenceVerb_VerbId",
                table: "SentenceVerb",
                column: "VerbId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SentenceVerb");

            migrationBuilder.AddColumn<int>(
                name: "SentenceId",
                table: "Verb",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Verb_SentenceId",
                table: "Verb",
                column: "SentenceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Verb_Sentence_SentenceId",
                table: "Verb",
                column: "SentenceId",
                principalTable: "Sentence",
                principalColumn: "Id");
        }
    }
}
