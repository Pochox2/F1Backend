using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Formula1Backend.Migrations
{
    /// <inheritdoc />
    public partial class errorescorregidos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AñoFundacion",
                table: "Escuderias",
                newName: "AnoFundacion");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AnoFundacion",
                table: "Escuderias",
                newName: "AñoFundacion");
        }
    }
}
