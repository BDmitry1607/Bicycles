using Microsoft.EntityFrameworkCore.Migrations;

namespace BicyclesDAL.Migrations
{
    public partial class AddingNameColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Bicycles",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Bicycles");
        }
    }
}
