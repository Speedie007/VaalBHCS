using Microsoft.EntityFrameworkCore.Migrations;

namespace VaalBeachClub.Data.Migrations
{
    public partial class UpdatedCAmpSiteBookingsRElationShips : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CampSiteID1",
                table: "CampSites",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CampSiteId",
                table: "CampSiteBookings",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CampSiteBookings_CampSiteId",
                table: "CampSiteBookings",
                column: "CampSiteId");

            migrationBuilder.AddForeignKey(
                name: "FK_CampSiteBookings_CampSites_CampSiteId",
                table: "CampSiteBookings",
                column: "CampSiteId",
                principalTable: "CampSites",
                principalColumn: "CampSiteID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CampSiteBookings_CampSites_CampSiteId",
                table: "CampSiteBookings");

            migrationBuilder.DropIndex(
                name: "IX_CampSiteBookings_CampSiteId",
                table: "CampSiteBookings");

            migrationBuilder.DropColumn(
                name: "CampSiteID1",
                table: "CampSites");

            migrationBuilder.DropColumn(
                name: "CampSiteId",
                table: "CampSiteBookings");
        }
    }
}
