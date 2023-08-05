using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NutriBemKids.Migrations
{
    /// <inheritdoc />
    public partial class mae : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Maes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FilhoCodigoID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Maes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Maes_AssinaturaNutribem_FilhoCodigoID",
                        column: x => x.FilhoCodigoID,
                        principalTable: "AssinaturaNutribem",
                        principalColumn: "CodigoID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Maes_FilhoCodigoID",
                table: "Maes",
                column: "FilhoCodigoID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Maes");
        }
    }
}
