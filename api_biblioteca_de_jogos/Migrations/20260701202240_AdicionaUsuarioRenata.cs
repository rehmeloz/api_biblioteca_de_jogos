using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace api_biblioteca_de_jogos.Migrations
{
    /// <inheritdoc />
    public partial class AdicionaUsuarioRenata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "Id", "PasswordHash", "Role", "Username" },
                values: new object[] { 2, "$2a$11$7SCjPf6mrUIIBLvepgBVhulhAcbZRhCDD9B21EXAvukR06EXHpL6S", "Dev", "Renata" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
