using Microsoft.EntityFrameworkCore.Migrations;

namespace DotNETcapstone.Migrations
{
    public partial class madeNextIdinUserstatic : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NextId",
                table: "Users");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NextId",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
