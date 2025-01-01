using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Exam.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class firstMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Assurances",
                columns: table => new
                {
                    AssuranceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateEffet = table.Column<DateTime>(type: "Date", nullable: false),
                    DateEcheance = table.Column<DateTime>(type: "Date", nullable: false),
                    typeAssurance = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assurances", x => x.AssuranceId);
                });

            migrationBuilder.CreateTable(
                name: "Experts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prenom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DomaineExpert = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TarifErr = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Experts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sinstres",
                columns: table => new
                {
                    SinstreId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Lieu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateDeclaration = table.Column<DateTime>(type: "Date", nullable: false),
                    AssuranceFk = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sinstres", x => x.SinstreId);
                    table.ForeignKey(
                        name: "FK_Sinstres_Assurances_AssuranceFk",
                        column: x => x.AssuranceFk,
                        principalTable: "Assurances",
                        principalColumn: "AssuranceId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Expertises",
                columns: table => new
                {
                    DateExpertise = table.Column<DateTime>(type: "Date", nullable: false),
                    SinstreKey = table.Column<int>(type: "int", nullable: false),
                    ExpertKey = table.Column<int>(type: "int", nullable: false),
                    AvisTechnique = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    MontantEstime = table.Column<double>(type: "float", nullable: false),
                    Duree = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Expertises", x => new { x.DateExpertise, x.SinstreKey, x.ExpertKey });
                    table.ForeignKey(
                        name: "FK_Expertises_Experts_ExpertKey",
                        column: x => x.ExpertKey,
                        principalTable: "Experts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Expertises_Sinstres_SinstreKey",
                        column: x => x.SinstreKey,
                        principalTable: "Sinstres",
                        principalColumn: "SinstreId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Expertises_ExpertKey",
                table: "Expertises",
                column: "ExpertKey");

            migrationBuilder.CreateIndex(
                name: "IX_Expertises_SinstreKey",
                table: "Expertises",
                column: "SinstreKey");

            migrationBuilder.CreateIndex(
                name: "IX_Sinstres_AssuranceFk",
                table: "Sinstres",
                column: "AssuranceFk");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Expertises");

            migrationBuilder.DropTable(
                name: "Experts");

            migrationBuilder.DropTable(
                name: "Sinstres");

            migrationBuilder.DropTable(
                name: "Assurances");
        }
    }
}
