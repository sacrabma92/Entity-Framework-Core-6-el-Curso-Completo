using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CursoEntityCore.Migrations
{
    /// <inheritdoc />
    public partial class RelacionCategoriaArticuloBD : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Categoria",
                newName: "Categoria_Id");

            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "Articulo",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "Categoria_Id",
                table: "Articulo",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Articulo_Categoria_Id",
                table: "Articulo",
                column: "Categoria_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Articulo_Categoria_Categoria_Id",
                table: "Articulo",
                column: "Categoria_Id",
                principalTable: "Categoria",
                principalColumn: "Categoria_Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articulo_Categoria_Categoria_Id",
                table: "Articulo");

            migrationBuilder.DropIndex(
                name: "IX_Articulo_Categoria_Id",
                table: "Articulo");

            migrationBuilder.DropColumn(
                name: "Categoria_Id",
                table: "Articulo");

            migrationBuilder.RenameColumn(
                name: "Categoria_Id",
                table: "Categoria",
                newName: "Id");

            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "Articulo",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);
        }
    }
}
