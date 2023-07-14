using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExamProjectASP.Migrations
{
    public partial class FriendChanging : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Friends_AspNetUsers_FirstUserId1",
                table: "Friends");

            migrationBuilder.DropForeignKey(
                name: "FK_Friends_AspNetUsers_SecondUserId1",
                table: "Friends");

            migrationBuilder.DropIndex(
                name: "IX_Friends_FirstUserId1",
                table: "Friends");

            migrationBuilder.DropIndex(
                name: "IX_Friends_SecondUserId1",
                table: "Friends");

            migrationBuilder.DropColumn(
                name: "FirstUserId1",
                table: "Friends");

            migrationBuilder.DropColumn(
                name: "SecondUserId1",
                table: "Friends");

            migrationBuilder.AlterColumn<string>(
                name: "SecondUserId",
                table: "Friends",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "FirstUserId",
                table: "Friends",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Friends_FirstUserId",
                table: "Friends",
                column: "FirstUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Friends_SecondUserId",
                table: "Friends",
                column: "SecondUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Friends_AspNetUsers_FirstUserId",
                table: "Friends",
                column: "FirstUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id"
                );

            migrationBuilder.AddForeignKey(
                name: "FK_Friends_AspNetUsers_SecondUserId",
                table: "Friends",
                column: "SecondUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id"
               );
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Friends_AspNetUsers_FirstUserId",
                table: "Friends");

            migrationBuilder.DropForeignKey(
                name: "FK_Friends_AspNetUsers_SecondUserId",
                table: "Friends");

            migrationBuilder.DropIndex(
                name: "IX_Friends_FirstUserId",
                table: "Friends");

            migrationBuilder.DropIndex(
                name: "IX_Friends_SecondUserId",
                table: "Friends");

            migrationBuilder.AlterColumn<int>(
                name: "SecondUserId",
                table: "Friends",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<int>(
                name: "FirstUserId",
                table: "Friends",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "FirstUserId1",
                table: "Friends",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SecondUserId1",
                table: "Friends",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Friends_FirstUserId1",
                table: "Friends",
                column: "FirstUserId1");

            migrationBuilder.CreateIndex(
                name: "IX_Friends_SecondUserId1",
                table: "Friends",
                column: "SecondUserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Friends_AspNetUsers_FirstUserId1",
                table: "Friends",
                column: "FirstUserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Friends_AspNetUsers_SecondUserId1",
                table: "Friends",
                column: "SecondUserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
