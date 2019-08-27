using Microsoft.EntityFrameworkCore.Migrations;

namespace Testapp2Api.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "complain",
                columns: table => new
                {
                    ComplainerName = table.Column<string>(nullable: false),
                    houseNo = table.Column<int>(nullable: false),
                    complain = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_complain", x => x.ComplainerName);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "complain");
        }
    }
}
