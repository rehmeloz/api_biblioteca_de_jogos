using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace api_biblioteca_de_jogos.Migrations
{
    /// <inheritdoc />
    public partial class AdicionaUsuarioAdmin : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "Id", "PasswordHash", "Role", "Username" },
                values: new object[] { 1, "$2a$11$T.M6IT9VsosMoQtDcGrTleUtydl8E5M.Jiyc7ZcAf4K5ahJBLJE3u", "Admin", "admin" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
