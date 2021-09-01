using Microsoft.EntityFrameworkCore.Migrations;

namespace BartenderApp.Data.Migrations
{
    public partial class patronName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            

            migrationBuilder.AddColumn<string>(
                name: "PatronName",
                table: "Drink",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PatronName",
                table: "Drink");

            
        }
    }
}
