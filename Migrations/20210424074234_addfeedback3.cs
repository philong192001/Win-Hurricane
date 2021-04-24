using Microsoft.EntityFrameworkCore.Migrations;

namespace TechWiz.WinHurricane.Migrations
{
    public partial class addfeedback3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "user_id",
                table: "Feedbacks",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "user_id",
                table: "Feedbacks",
                type: "int",
                nullable: false,
                oldClrType: typeof(string));
        }
    }
}
