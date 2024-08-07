using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RpgApi.Migrations
{
    /// <inheritdoc />
    public partial class MigracaoMuitosParaMuitos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Derrotas",
                table: "TB_PERSONAGENS",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Disputas",
                table: "TB_PERSONAGENS",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Vitorias",
                table: "TB_PERSONAGENS",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "TB_HABILIDADES",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "Varchar(200)", maxLength: 200, nullable: false),
                    Dano = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_HABILIDADES", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TB_PERSONAGENS_HABILIDADES",
                columns: table => new
                {
                    PersonagemId = table.Column<int>(type: "int", nullable: false),
                    HabilidadeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_PERSONAGENS_HABILIDADES", x => new { x.PersonagemId, x.HabilidadeId });
                    table.ForeignKey(
                        name: "FK_TB_PERSONAGENS_HABILIDADES_TB_HABILIDADES_HabilidadeId",
                        column: x => x.HabilidadeId,
                        principalTable: "TB_HABILIDADES",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TB_PERSONAGENS_HABILIDADES_TB_PERSONAGENS_PersonagemId",
                        column: x => x.PersonagemId,
                        principalTable: "TB_PERSONAGENS",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "TB_HABILIDADES",
                columns: new[] { "Id", "Dano", "Nome" },
                values: new object[,]
                {
                    { 1, 39, "Adormecer" },
                    { 2, 41, "Congelar" },
                    { 3, 37, "Hipnotizar" }
                });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 9, 238, 56, 68, 157, 95, 62, 130, 167, 223, 227, 46, 51, 212, 19, 150, 120, 159, 64, 240, 106, 240, 219, 71, 9, 193, 251, 33, 114, 17, 40, 2, 110, 9, 18, 31, 245, 252, 79, 178, 246, 172, 180, 168, 122, 234, 242, 177, 52, 116, 169, 148, 185, 217, 151, 166, 157, 80, 31, 250, 27, 58, 121, 54 }, new byte[] { 187, 22, 32, 98, 214, 63, 34, 150, 90, 154, 192, 28, 176, 76, 131, 176, 27, 114, 71, 161, 99, 166, 77, 236, 122, 44, 94, 9, 229, 167, 89, 81, 25, 208, 91, 0, 230, 61, 22, 229, 58, 236, 39, 90, 220, 108, 74, 50, 34, 3, 191, 188, 74, 64, 30, 129, 66, 234, 110, 39, 59, 231, 79, 253, 18, 161, 216, 173, 116, 163, 8, 216, 151, 214, 12, 245, 164, 110, 32, 46, 25, 229, 153, 169, 34, 133, 29, 92, 21, 189, 174, 234, 25, 113, 109, 143, 210, 71, 128, 143, 236, 135, 27, 198, 16, 107, 143, 182, 246, 99, 24, 14, 188, 222, 203, 49, 110, 105, 111, 136, 78, 48, 207, 169, 32, 151, 178, 244 } });

            migrationBuilder.InsertData(
                table: "TB_PERSONAGENS_HABILIDADES",
                columns: new[] { "HabilidadeId", "PersonagemId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 2, 2 },
                    { 2, 3 },
                    { 3, 3 },
                    { 3, 4 },
                    { 1, 5 },
                    { 2, 6 },
                    { 3, 7 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_TB_PERSONAGENS_HABILIDADES_HabilidadeId",
                table: "TB_PERSONAGENS_HABILIDADES",
                column: "HabilidadeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TB_PERSONAGENS_HABILIDADES");

            migrationBuilder.DropTable(
                name: "TB_HABILIDADES");

            migrationBuilder.DropColumn(
                name: "Derrotas",
                table: "TB_PERSONAGENS");

            migrationBuilder.DropColumn(
                name: "Disputas",
                table: "TB_PERSONAGENS");

            migrationBuilder.DropColumn(
                name: "Vitorias",
                table: "TB_PERSONAGENS");

            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 227, 19, 222, 202, 120, 187, 110, 19, 176, 241, 190, 213, 54, 76, 157, 69, 60, 41, 131, 4, 118, 25, 50, 129, 116, 78, 227, 210, 213, 31, 250, 160, 0, 176, 72, 84, 255, 77, 123, 115, 74, 139, 94, 4, 8, 249, 180, 104, 25, 197, 199, 106, 169, 213, 224, 120, 232, 51, 230, 119, 142, 208, 64, 45 }, new byte[] { 96, 121, 105, 15, 239, 75, 232, 122, 59, 118, 15, 175, 48, 93, 85, 83, 183, 61, 109, 33, 88, 2, 213, 222, 117, 251, 97, 169, 138, 122, 8, 139, 63, 150, 250, 61, 28, 161, 79, 150, 6, 106, 185, 61, 237, 188, 56, 197, 44, 115, 90, 212, 117, 153, 23, 234, 116, 17, 129, 148, 36, 49, 93, 193, 215, 134, 3, 212, 166, 225, 239, 150, 152, 50, 23, 30, 47, 79, 128, 248, 219, 162, 240, 92, 182, 233, 135, 150, 228, 18, 33, 165, 98, 171, 225, 183, 121, 71, 158, 186, 97, 2, 145, 48, 35, 160, 253, 96, 128, 15, 95, 20, 229, 171, 8, 39, 243, 4, 201, 78, 122, 7, 183, 203, 72, 166, 24, 159 } });
        }
    }
}
