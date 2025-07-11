using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Formula1Backend.Migrations
{
    /// <inheritdoc />
    public partial class AddSeeds : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Seed",
                table: "Pistas",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Seed",
                table: "Pilotos",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Seed",
                table: "Pistas");

            migrationBuilder.DropColumn(
                name: "Seed",
                table: "Pilotos");
        }
    }
}
