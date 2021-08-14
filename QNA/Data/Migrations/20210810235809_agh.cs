using Microsoft.EntityFrameworkCore.Migrations;

namespace QNA.Data.Migrations
{
    public partial class agh : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CategoryName",
                table: "Question");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CategoryName",
                table: "Question",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
