using Microsoft.EntityFrameworkCore.Migrations;

namespace DbContextModelChange.Migrations.Schema2
{
    public partial class init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Schema2");

            migrationBuilder.CreateTable(
                name: "Table1",
                schema: "Schema2",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Table1", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Table1",
                schema: "Schema2");
        }
    }
}
