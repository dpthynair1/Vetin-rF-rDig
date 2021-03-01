using Microsoft.EntityFrameworkCore.Migrations;

namespace Docter_MVC_Miniproject3.Data.Migrations
{
    public partial class BookingPageItemAdded1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BookingPageId",
                table: "BookingPageItems",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BookingPageId",
                table: "BookingPageItems");
        }
    }
}
