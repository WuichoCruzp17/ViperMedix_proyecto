using Microsoft.EntityFrameworkCore.Migrations;

namespace ViperMedix.WebAPI.Migrations
{
    public partial class Remove_Field_LotNumber_Product : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LotNumber",
                table: "Product");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "LotNumber",
                table: "Product",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);
        }
    }
}
