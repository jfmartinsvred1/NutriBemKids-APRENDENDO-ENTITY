using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NutriBemKids.Migrations
{
    /// <inheritdoc />
    public partial class tirandoPagamentoDeAlunos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Preco",
                table: "AssinaturaNutribem");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Preco",
                table: "AssinaturaNutribem",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
