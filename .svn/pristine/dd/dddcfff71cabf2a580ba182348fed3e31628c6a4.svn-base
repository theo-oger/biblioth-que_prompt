using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PromptLibrary_DAL.Migrations
{
    /// <inheritdoc />
    public partial class AddContenuToFramework : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Contenu",
                table: "Framework",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Contenu",
                table: "Framework");
        }
    }
}
