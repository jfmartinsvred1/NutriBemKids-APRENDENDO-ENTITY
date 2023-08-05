using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NutriBemKids.Migrations
{
    /// <inheritdoc />
    public partial class QntdFilhos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Mensalidade",
                table: "Maes",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "QuantidadeFilhos",
                table: "Maes",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Mensalidade",
                table: "Maes");

            migrationBuilder.DropColumn(
                name: "QuantidadeFilhos",
                table: "Maes");
        }
    }
}
