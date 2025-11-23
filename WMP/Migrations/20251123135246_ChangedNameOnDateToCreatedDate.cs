using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WMP.Migrations
{
    /// <inheritdoc />
    public partial class ChangedNameOnDateToCreatedDate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Date",
                table: "Recipes",
                newName: "CreatedDate");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Recipes",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "Recipes",
                newName: "Date");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Recipes",
                type: "longtext",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true);
        }
    }
}
