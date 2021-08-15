using Microsoft.EntityFrameworkCore.Migrations;

namespace DbContextModelChange.Migrations.Schema1
{
    public partial class init1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Schema1");

            migrationBuilder.CreateTable(
                name: "Table1",
                schema: "Schema1",
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
                schema: "Schema1");
        }
    }
}
