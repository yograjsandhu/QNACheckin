using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace QNA.Data.Migrations
{
    public partial class Sarb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Answer",
                table: "Question");

            migrationBuilder.DropColumn(
                name: "QuestionDateAndTime",
                table: "Question");

            migrationBuilder.DropColumn(
                name: "views",
                table: "Question");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Answer",
                table: "Question",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "QuestionDateAndTime",
                table: "Question",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "views",
                table: "Question",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
