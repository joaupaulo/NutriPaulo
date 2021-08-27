using Microsoft.EntityFrameworkCore.Migrations;

namespace NutriPaulo.Migrations
{
    public partial class Alteraçõesnaviewenamodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Idade",
                table: "CaracteristicasFisicas",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Idade",
                table: "CaracteristicasFisicas");
        }
    }
}
