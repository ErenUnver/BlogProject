using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class add_BlogReyting : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BlogReytings",
                columns: table => new
                {
                    BlogReytingID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BlogID = table.Column<int>(type: "int", nullable: false),
                    BlogTotalScore = table.Column<int>(type: "int", nullable: false),
                    BlogReytingCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogReytings", x => x.BlogReytingID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BlogReytings");
        }
    }
}
