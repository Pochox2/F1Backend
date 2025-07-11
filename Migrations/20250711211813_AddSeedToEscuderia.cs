using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Formula1Backend.Migrations
{
    /// <inheritdoc />
    public partial class AddSeedToEscuderia : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Seed",
                table: "Escuderias",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Seed",
                table: "Escuderias");
        }
    }
}
