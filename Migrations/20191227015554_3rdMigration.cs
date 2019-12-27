using Microsoft.EntityFrameworkCore.Migrations;

namespace LanzhouBeefNoodles.Migrations
{
    public partial class _3rdMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CreateDateUTC",
                table: "Feedbacks",
                newName: "CreateDateUtc");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CreateDateUtc",
                table: "Feedbacks",
                newName: "CreateDateUTC");
        }
    }
}
