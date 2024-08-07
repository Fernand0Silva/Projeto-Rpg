using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RpgApi.Migrations
{
    /// <inheritdoc />
    public partial class MigracaoUmParaUm : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PersonagemId",
                table: "TB_ARMAS",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 1,
                column: "PersonagemId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 2,
                column: "PersonagemId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 3,
                column: "PersonagemId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 4,
                column: "PersonagemId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 5,
                column: "PersonagemId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 6,
                column: "PersonagemId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 7,
                column: "PersonagemId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 227, 19, 222, 202, 120, 187, 110, 19, 176, 241, 190, 213, 54, 76, 157, 69, 60, 41, 131, 4, 118, 25, 50, 129, 116, 78, 227, 210, 213, 31, 250, 160, 0, 176, 72, 84, 255, 77, 123, 115, 74, 139, 94, 4, 8, 249, 180, 104, 25, 197, 199, 106, 169, 213, 224, 120, 232, 51, 230, 119, 142, 208, 64, 45 }, new byte[] { 96, 121, 105, 15, 239, 75, 232, 122, 59, 118, 15, 175, 48, 93, 85, 83, 183, 61, 109, 33, 88, 2, 213, 222, 117, 251, 97, 169, 138, 122, 8, 139, 63, 150, 250, 61, 28, 161, 79, 150, 6, 106, 185, 61, 237, 188, 56, 197, 44, 115, 90, 212, 117, 153, 23, 234, 116, 17, 129, 148, 36, 49, 93, 193, 215, 134, 3, 212, 166, 225, 239, 150, 152, 50, 23, 30, 47, 79, 128, 248, 219, 162, 240, 92, 182, 233, 135, 150, 228, 18, 33, 165, 98, 171, 225, 183, 121, 71, 158, 186, 97, 2, 145, 48, 35, 160, 253, 96, 128, 15, 95, 20, 229, 171, 8, 39, 243, 4, 201, 78, 122, 7, 183, 203, 72, 166, 24, 159 } });

            migrationBuilder.CreateIndex(
                name: "IX_TB_ARMAS_PersonagemId",
                table: "TB_ARMAS",
                column: "PersonagemId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_TB_ARMAS_TB_PERSONAGENS_PersonagemId",
                table: "TB_ARMAS",
                column: "PersonagemId",
                principalTable: "TB_PERSONAGENS",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TB_ARMAS_TB_PERSONAGENS_PersonagemId",
                table: "TB_ARMAS");

            migrationBuilder.DropIndex(
                name: "IX_TB_ARMAS_PersonagemId",
                table: "TB_ARMAS");

            migrationBuilder.DropColumn(
                name: "PersonagemId",
                table: "TB_ARMAS");

            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 98, 67, 134, 224, 146, 244, 78, 124, 216, 121, 140, 116, 119, 23, 73, 234, 68, 243, 209, 243, 132, 157, 155, 241, 229, 206, 80, 130, 240, 9, 250, 126, 207, 92, 71, 41, 156, 25, 234, 168, 107, 129, 74, 142, 100, 225, 130, 11, 83, 44, 215, 17, 170, 221, 250, 174, 23, 92, 248, 33, 223, 231, 60, 91 }, new byte[] { 192, 17, 151, 221, 36, 165, 170, 31, 75, 1, 20, 58, 163, 151, 128, 204, 96, 141, 169, 66, 167, 65, 131, 36, 8, 7, 54, 137, 232, 174, 90, 36, 144, 109, 239, 197, 65, 0, 11, 151, 244, 173, 119, 7, 109, 179, 149, 200, 135, 30, 121, 135, 54, 83, 138, 151, 199, 113, 208, 16, 160, 22, 163, 80, 162, 132, 197, 100, 135, 175, 224, 25, 246, 113, 24, 239, 203, 253, 189, 106, 43, 177, 213, 177, 115, 135, 134, 202, 204, 236, 77, 13, 49, 146, 23, 66, 175, 6, 115, 62, 145, 38, 92, 225, 129, 110, 164, 85, 230, 50, 241, 200, 1, 134, 168, 174, 186, 121, 81, 105, 216, 59, 46, 39, 61, 208, 35, 79 } });
        }
    }
}
