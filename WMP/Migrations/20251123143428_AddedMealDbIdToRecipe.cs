using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WMP.Migrations
{
    /// <inheritdoc />
    public partial class AddedMealDbIdToRecipe : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MealDbId",
                table: "Recipes",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MealDbId",
                table: "Recipes");
        }
    }
}
