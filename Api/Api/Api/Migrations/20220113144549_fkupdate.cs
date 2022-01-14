using Microsoft.EntityFrameworkCore.Migrations;

namespace Api.Migrations
{
    public partial class fkupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Location_CityID",
                table: "Location",
                column: "CityID");

            migrationBuilder.AddForeignKey(
                name: "FK_City",
                table: "Location",
                column: "CityID",
                principalTable: "City",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_City",
                table: "Location");

            migrationBuilder.DropIndex(
                name: "IX_Location_CityID",
                table: "Location");
        }
    }
}
