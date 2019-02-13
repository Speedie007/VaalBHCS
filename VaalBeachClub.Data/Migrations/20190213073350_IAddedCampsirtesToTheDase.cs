using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VaalBeachClub.Data.Migrations
{
    public partial class IAddedCampsirtesToTheDase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BoatHouses_BoatHouseSize_BoatHouseSizeID",
                table: "BoatHouses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BoatHouseSize",
                table: "BoatHouseSize");

            migrationBuilder.RenameTable(
                name: "BoatHouseSize",
                newName: "BoatHouseSizes");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BoatHouseSizes",
                table: "BoatHouseSizes",
                column: "BoatHouseSizeID");

            migrationBuilder.CreateTable(
                name: "CampSites",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CampSiteNumber = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CampSites", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_BoatHouses_BoatHouseSizes_BoatHouseSizeID",
                table: "BoatHouses",
                column: "BoatHouseSizeID",
                principalTable: "BoatHouseSizes",
                principalColumn: "BoatHouseSizeID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BoatHouses_BoatHouseSizes_BoatHouseSizeID",
                table: "BoatHouses");

            migrationBuilder.DropTable(
                name: "CampSites");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BoatHouseSizes",
                table: "BoatHouseSizes");

            migrationBuilder.RenameTable(
                name: "BoatHouseSizes",
                newName: "BoatHouseSize");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BoatHouseSize",
                table: "BoatHouseSize",
                column: "BoatHouseSizeID");

            migrationBuilder.AddForeignKey(
                name: "FK_BoatHouses_BoatHouseSize_BoatHouseSizeID",
                table: "BoatHouses",
                column: "BoatHouseSizeID",
                principalTable: "BoatHouseSize",
                principalColumn: "BoatHouseSizeID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
