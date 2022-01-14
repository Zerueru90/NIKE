using Microsoft.EntityFrameworkCore.Migrations;

namespace Api.Migrations
{
    public partial class _20220114_AddedForeignKeyToCountryCity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Location",
                table: "Location");

            migrationBuilder.RenameTable(
                name: "Location",
                newName: "POI");

            migrationBuilder.RenameColumn(
                name: "yCordinate",
                table: "POI",
                newName: "Latitude");

            migrationBuilder.RenameColumn(
                name: "xCordinate",
                table: "POI",
                newName: "Longitude");

            migrationBuilder.RenameIndex(
                name: "IX_Location_CityID",
                table: "POI",
                newName: "IX_POI_CityID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_POI",
                table: "POI",
                column: "ID");

            migrationBuilder.CreateIndex(
                name: "IX_City_CountryID",
                table: "City",
                column: "CountryID");

            migrationBuilder.AddForeignKey(
                name: "FK_Country",
                table: "City",
                column: "CountryID",
                principalTable: "Country",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Country",
                table: "City");

            migrationBuilder.DropIndex(
                name: "IX_City_CountryID",
                table: "City");

            migrationBuilder.DropPrimaryKey(
                name: "PK_POI",
                table: "POI");

            migrationBuilder.RenameTable(
                name: "POI",
                newName: "Location");

            migrationBuilder.RenameColumn(
                name: "Longitude",
                table: "Location",
                newName: "xCordinate");

            migrationBuilder.RenameColumn(
                name: "Latitude",
                table: "Location",
                newName: "yCordinate");

            migrationBuilder.RenameIndex(
                name: "IX_POI_CityID",
                table: "Location",
                newName: "IX_Location_CityID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Location",
                table: "Location",
                column: "ID");
        }
    }
}
