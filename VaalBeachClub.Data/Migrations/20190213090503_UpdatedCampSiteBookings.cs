using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VaalBeachClub.Data.Migrations
{
    public partial class UpdatedCampSiteBookings : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfBirth",
                table: "BeachClubMembers",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfBirth",
                table: "AffiliatedMembers",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateTable(
                name: "CampSiteBookings",
                columns: table => new
                {
                    CampSiteBookingID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    StartDateTime = table.Column<DateTime>(nullable: false),
                    EndDateTime = table.Column<DateTime>(nullable: false),
                    BeachClubMemberID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CampSiteBookings", x => x.CampSiteBookingID);
                    table.ForeignKey(
                        name: "FK_CampSiteBookings_BeachClubMembers_BeachClubMemberID",
                        column: x => x.BeachClubMemberID,
                        principalTable: "BeachClubMembers",
                        principalColumn: "BeachClubMemberID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CampSiteBookings_BeachClubMemberID",
                table: "CampSiteBookings",
                column: "BeachClubMemberID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CampSiteBookings");

            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "BeachClubMembers");

            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "AffiliatedMembers");
        }
    }
}
