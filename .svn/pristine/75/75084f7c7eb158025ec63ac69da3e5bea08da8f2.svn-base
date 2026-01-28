using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PromptLibrary_DAL.Migrations
{
    /// <inheritdoc />
    public partial class SuppressionCascade : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Prompt_Framework_FrameworkId",
                table: "Prompt");

            migrationBuilder.AddForeignKey(
                name: "FK_Prompt_Framework_FrameworkId",
                table: "Prompt",
                column: "FrameworkId",
                principalTable: "Framework",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Prompt_Framework_FrameworkId",
                table: "Prompt");

            migrationBuilder.AddForeignKey(
                name: "FK_Prompt_Framework_FrameworkId",
                table: "Prompt",
                column: "FrameworkId",
                principalTable: "Framework",
                principalColumn: "Id");
        }
    }
}
