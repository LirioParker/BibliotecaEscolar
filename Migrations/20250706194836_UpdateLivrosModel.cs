using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BibliotecaEscolar.Migrations
{
    /// <inheritdoc />
    public partial class UpdateLivrosModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Alunos",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Username",
                table: "Alunos",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Password",
                table: "Alunos");

            migrationBuilder.DropColumn(
                name: "Username",
                table: "Alunos");
        }
    }
}
