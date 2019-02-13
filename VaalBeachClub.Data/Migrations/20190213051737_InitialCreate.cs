using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VaalBeachClub.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BeachClubMembers",
                columns: table => new
                {
                    BeachClubMemberID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BeachClubMembers", x => x.BeachClubMemberID);
                });

            migrationBuilder.CreateTable(
                name: "BeachClubRoles",
                columns: table => new
                {
                    BeachClubRoleID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BeachClubRoles", x => x.BeachClubRoleID);
                });

            migrationBuilder.CreateTable(
                name: "BoatHouseSize",
                columns: table => new
                {
                    BoatHouseSizeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Size = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BoatHouseSize", x => x.BoatHouseSizeID);
                });

            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    AddressID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    City = table.Column<string>(nullable: true),
                    Suburb = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    AreaCode = table.Column<string>(nullable: true),
                    BeachClubMemberID = table.Column<int>(nullable: false),
                    AddressType = table.Column<int>(nullable: false),
                    ComplexName = table.Column<string>(nullable: true),
                    ComplexUnitNumber = table.Column<string>(nullable: true),
                    POBoxNumber = table.Column<string>(nullable: true),
                    StreetNumber = table.Column<string>(nullable: true),
                    StreetName = table.Column<string>(type: "varchar(250)", maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.AddressID);
                    table.ForeignKey(
                        name: "FK_Addresses_BeachClubMembers_BeachClubMemberID",
                        column: x => x.BeachClubMemberID,
                        principalTable: "BeachClubMembers",
                        principalColumn: "BeachClubMemberID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AffiliatedMembers",
                columns: table => new
                {
                    AffiliatedMemberID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(maxLength: 75, nullable: true),
                    LastName = table.Column<string>(maxLength: 75, nullable: true),
                    BeachClubMemberID = table.Column<int>(nullable: false),
                    MemberAffiliation = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AffiliatedMembers", x => x.AffiliatedMemberID);
                    table.ForeignKey(
                        name: "FK_AffiliatedMembers_BeachClubMembers_BeachClubMemberID",
                        column: x => x.BeachClubMemberID,
                        principalTable: "BeachClubMembers",
                        principalColumn: "BeachClubMemberID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BeachClubMemberClaims",
                columns: table => new
                {
                    BeachClubMemberClaimID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BeachClubMemberID = table.Column<int>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BeachClubMemberClaims", x => x.BeachClubMemberClaimID);
                    table.ForeignKey(
                        name: "FK_BeachClubMemberClaims_BeachClubMembers_BeachClubMemberID",
                        column: x => x.BeachClubMemberID,
                        principalTable: "BeachClubMembers",
                        principalColumn: "BeachClubMemberID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BeachClubMemberLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    BeachClubMemberID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BeachClubMemberLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_BeachClubMemberLogins_BeachClubMembers_BeachClubMemberID",
                        column: x => x.BeachClubMemberID,
                        principalTable: "BeachClubMembers",
                        principalColumn: "BeachClubMemberID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BeachClubMemberTokens",
                columns: table => new
                {
                    BeachClubMemberID = table.Column<int>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BeachClubMemberTokens", x => new { x.BeachClubMemberID, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_BeachClubMemberTokens_BeachClubMembers_BeachClubMemberID",
                        column: x => x.BeachClubMemberID,
                        principalTable: "BeachClubMembers",
                        principalColumn: "BeachClubMemberID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BeachClubMemberRoles",
                columns: table => new
                {
                    BeachClubMemberID = table.Column<int>(nullable: false),
                    BeachClubRoleID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BeachClubMemberRoles", x => new { x.BeachClubMemberID, x.BeachClubRoleID });
                    table.ForeignKey(
                        name: "FK_BeachClubMemberRoles_BeachClubRoles_BeachClubRoleID",
                        column: x => x.BeachClubRoleID,
                        principalTable: "BeachClubRoles",
                        principalColumn: "BeachClubRoleID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BeachClubMemberRoles_BeachClubMembers_BeachClubMemberID",
                        column: x => x.BeachClubMemberID,
                        principalTable: "BeachClubMembers",
                        principalColumn: "BeachClubMemberID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BeachClubRoleClaims",
                columns: table => new
                {
                    BeachClubRoleClaimID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BeachClubRoleID = table.Column<int>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BeachClubRoleClaims", x => x.BeachClubRoleClaimID);
                    table.ForeignKey(
                        name: "FK_BeachClubRoleClaims_BeachClubRoles_BeachClubRoleID",
                        column: x => x.BeachClubRoleID,
                        principalTable: "BeachClubRoles",
                        principalColumn: "BeachClubRoleID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BoatHouses",
                columns: table => new
                {
                    BoatHouseID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BoatHouseNumber = table.Column<string>(maxLength: 250, nullable: true),
                    BoatHouseSizeID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BoatHouses", x => x.BoatHouseID);
                    table.ForeignKey(
                        name: "FK_BoatHouses_BoatHouseSize_BoatHouseSizeID",
                        column: x => x.BoatHouseSizeID,
                        principalTable: "BoatHouseSize",
                        principalColumn: "BoatHouseSizeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BoatHouseRentals",
                columns: table => new
                {
                    BoatHouseRentalID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false),
                    HasBeenPaid = table.Column<bool>(nullable: false),
                    BeachClubMemberID = table.Column<int>(nullable: false),
                    BoatHouseID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BoatHouseRentals", x => x.BoatHouseRentalID);
                    table.ForeignKey(
                        name: "FK_BoatHouseRentals_BeachClubMembers_BeachClubMemberID",
                        column: x => x.BeachClubMemberID,
                        principalTable: "BeachClubMembers",
                        principalColumn: "BeachClubMemberID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BoatHouseRentals_BoatHouses_BoatHouseID",
                        column: x => x.BoatHouseID,
                        principalTable: "BoatHouses",
                        principalColumn: "BoatHouseID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_BeachClubMemberID",
                table: "Addresses",
                column: "BeachClubMemberID");

            migrationBuilder.CreateIndex(
                name: "IX_AffiliatedMembers_BeachClubMemberID",
                table: "AffiliatedMembers",
                column: "BeachClubMemberID");

            migrationBuilder.CreateIndex(
                name: "IX_BeachClubMemberClaims_BeachClubMemberID",
                table: "BeachClubMemberClaims",
                column: "BeachClubMemberID");

            migrationBuilder.CreateIndex(
                name: "IX_BeachClubMemberLogins_BeachClubMemberID",
                table: "BeachClubMemberLogins",
                column: "BeachClubMemberID");

            migrationBuilder.CreateIndex(
                name: "IX_BeachClubMemberRoles_BeachClubRoleID",
                table: "BeachClubMemberRoles",
                column: "BeachClubRoleID");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "BeachClubMembers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "BeachClubMembers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_BeachClubRoleClaims_BeachClubRoleID",
                table: "BeachClubRoleClaims",
                column: "BeachClubRoleID");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "BeachClubRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_BoatHouseRentals_BeachClubMemberID",
                table: "BoatHouseRentals",
                column: "BeachClubMemberID");

            migrationBuilder.CreateIndex(
                name: "IX_BoatHouseRentals_BoatHouseID",
                table: "BoatHouseRentals",
                column: "BoatHouseID");

            migrationBuilder.CreateIndex(
                name: "IX_BoatHouses_BoatHouseSizeID",
                table: "BoatHouses",
                column: "BoatHouseSizeID",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "AffiliatedMembers");

            migrationBuilder.DropTable(
                name: "BeachClubMemberClaims");

            migrationBuilder.DropTable(
                name: "BeachClubMemberLogins");

            migrationBuilder.DropTable(
                name: "BeachClubMemberRoles");

            migrationBuilder.DropTable(
                name: "BeachClubMemberTokens");

            migrationBuilder.DropTable(
                name: "BeachClubRoleClaims");

            migrationBuilder.DropTable(
                name: "BoatHouseRentals");

            migrationBuilder.DropTable(
                name: "BeachClubRoles");

            migrationBuilder.DropTable(
                name: "BeachClubMembers");

            migrationBuilder.DropTable(
                name: "BoatHouses");

            migrationBuilder.DropTable(
                name: "BoatHouseSize");
        }
    }
}
