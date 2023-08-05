using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NutriBemKids.Migrations
{
    /// <inheritdoc />
    public partial class inicial2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NomeMae",
                table: "AssinaturaNutribem");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "NomeMae",
                table: "AssinaturaNutribem",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
