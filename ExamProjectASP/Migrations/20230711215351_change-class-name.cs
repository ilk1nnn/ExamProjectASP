using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExamProjectASP.Migrations
{
    public partial class changeclassname : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "message",
                table: "Messages",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "message",
                table: "Messages");
        }
    }
}
