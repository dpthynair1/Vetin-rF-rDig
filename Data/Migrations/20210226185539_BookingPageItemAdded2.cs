using Microsoft.EntityFrameworkCore.Migrations;

namespace Docter_MVC_Miniproject3.Data.Migrations
{
    public partial class BookingPageItemAdded2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Amount",
                table: "BookingPageItems",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Amount",
                table: "BookingPageItems");
        }
    }
}
