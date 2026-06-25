using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace api_biblioteca_de_jogos.Migrations
{
    /// <inheritdoc />
    public partial class AdicionaMedia : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Media",
                table: "Jogos",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Media",
                table: "Jogos");
        }
    }
}
