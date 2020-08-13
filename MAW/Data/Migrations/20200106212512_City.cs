using Microsoft.EntityFrameworkCore.Migrations;

namespace MAW.Data.Migrations
{
    public partial class City : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "City",
                columns: table => new
                {
                    CityId = table.Column<string>(nullable: false),
                    ServerId = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false),
                    CityName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_City", x => x.CityId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "City");
        }
    }
}
