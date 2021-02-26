using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Docter_MVC_Miniproject3.Data.Migrations
{
    public partial class InitialCreate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<TimeSpan>(
                name: "Duration",
                table: "Appointments",
                type: "time",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Duration",
                table: "Appointments");
        }
    }
}
