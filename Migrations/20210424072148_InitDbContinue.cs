using Microsoft.EntityFrameworkCore.Migrations;

namespace TechWiz.WinHurricane.Migrations
{
    public partial class InitDbContinue : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "id_proof",
                table: "AspNetUsers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "id_proof",
                table: "AspNetUsers");
        }
    }
}
