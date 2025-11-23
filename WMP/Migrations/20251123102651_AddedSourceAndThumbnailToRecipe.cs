using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WMP.Migrations
{
    /// <inheritdoc />
    public partial class AddedSourceAndThumbnailToRecipe : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Source",
                table: "Recipes",
                type: "longtext",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ThumbnailUrl",
                table: "Recipes",
                type: "longtext",
                nullable: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Source",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "ThumbnailUrl",
                table: "Recipes");
        }
    }
}
