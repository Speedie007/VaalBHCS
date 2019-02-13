using Microsoft.EntityFrameworkCore.Migrations;

namespace VaalBeachClub.Data.Migrations
{
    public partial class UpdatedCAmpSiteBookingsRElationShips1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CampSiteBookings_CampSites_CampSiteId",
                table: "CampSiteBookings");

            migrationBuilder.DropColumn(
                name: "CampSiteID1",
                table: "CampSites");

            migrationBuilder.RenameColumn(
                name: "CampSiteId",
                table: "CampSiteBookings",
                newName: "CampSiteID");

            migrationBuilder.RenameIndex(
                name: "IX_CampSiteBookings_CampSiteId",
                table: "CampSiteBookings",
                newName: "IX_CampSiteBookings_CampSiteID");

            migrationBuilder.AlterColumn<int>(
                name: "CampSiteID",
                table: "CampSiteBookings",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_CampSiteBookings_CampSites_CampSiteID",
                table: "CampSiteBookings",
                column: "CampSiteID",
                principalTable: "CampSites",
                principalColumn: "CampSiteID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CampSiteBookings_CampSites_CampSiteID",
                table: "CampSiteBookings");

            migrationBuilder.RenameColumn(
                name: "CampSiteID",
                table: "CampSiteBookings",
                newName: "CampSiteId");

            migrationBuilder.RenameIndex(
                name: "IX_CampSiteBookings_CampSiteID",
                table: "CampSiteBookings",
                newName: "IX_CampSiteBookings_CampSiteId");

            migrationBuilder.AddColumn<int>(
                name: "CampSiteID1",
                table: "CampSites",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "CampSiteId",
                table: "CampSiteBookings",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_CampSiteBookings_CampSites_CampSiteId",
                table: "CampSiteBookings",
                column: "CampSiteId",
                principalTable: "CampSites",
                principalColumn: "CampSiteID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
