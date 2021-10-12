using Microsoft.EntityFrameworkCore.Migrations;

namespace JinKeTang.Migrations
{
    public partial class modify_teacher : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Teachers",
                table: "Teachers");

            migrationBuilder.RenameTable(
                name: "Teachers",
                newName: "tb_teacher");

            migrationBuilder.RenameColumn(
                name: "XM",
                table: "tb_teacher",
                newName: "xm");

            migrationBuilder.RenameColumn(
                name: "XB",
                table: "tb_teacher",
                newName: "xb");

            migrationBuilder.RenameColumn(
                name: "MM",
                table: "tb_teacher",
                newName: "mm");

            migrationBuilder.RenameColumn(
                name: "GH",
                table: "tb_teacher",
                newName: "gh");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "tb_teacher",
                newName: "id");

            migrationBuilder.AlterColumn<string>(
                name: "xm",
                table: "tb_teacher",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "xb",
                table: "tb_teacher",
                type: "nvarchar(1)",
                maxLength: 1,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "mm",
                table: "tb_teacher",
                type: "nvarchar(32)",
                maxLength: 32,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "gh",
                table: "tb_teacher",
                type: "nvarchar(12)",
                maxLength: 12,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_tb_teacher",
                table: "tb_teacher",
                column: "id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_tb_teacher",
                table: "tb_teacher");

            migrationBuilder.RenameTable(
                name: "tb_teacher",
                newName: "Teachers");

            migrationBuilder.RenameColumn(
                name: "xm",
                table: "Teachers",
                newName: "XM");

            migrationBuilder.RenameColumn(
                name: "xb",
                table: "Teachers",
                newName: "XB");

            migrationBuilder.RenameColumn(
                name: "mm",
                table: "Teachers",
                newName: "MM");

            migrationBuilder.RenameColumn(
                name: "gh",
                table: "Teachers",
                newName: "GH");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Teachers",
                newName: "Id");

            migrationBuilder.AlterColumn<string>(
                name: "XM",
                table: "Teachers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "XB",
                table: "Teachers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1)",
                oldMaxLength: 1,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "MM",
                table: "Teachers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(32)",
                oldMaxLength: 32,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "GH",
                table: "Teachers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(12)",
                oldMaxLength: 12,
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Teachers",
                table: "Teachers",
                column: "Id");
        }
    }
}
