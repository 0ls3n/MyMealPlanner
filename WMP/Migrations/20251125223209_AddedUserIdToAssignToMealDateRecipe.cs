using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WMP.Migrations
{
    /// <inheritdoc />
    public partial class AddedUserIdToAssignToMealDateRecipe : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "MealDateRecipes",
                type: "longtext",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserId",
                table: "MealDateRecipes");
        }
    }
}
