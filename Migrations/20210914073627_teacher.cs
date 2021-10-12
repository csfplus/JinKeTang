using Microsoft.EntityFrameworkCore.Migrations;

namespace JinKeTang.Migrations
{
    public partial class teacher : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GH = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XM = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XB = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MM = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Teachers");
        }
    }
}
