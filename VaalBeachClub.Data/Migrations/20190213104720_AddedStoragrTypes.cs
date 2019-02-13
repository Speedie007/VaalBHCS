using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VaalBeachClub.Data.Migrations
{
    public partial class AddedStoragrTypes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StorageItems",
                columns: table => new
                {
                    StorageItemID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IsCurrentlyInStorage = table.Column<bool>(nullable: false),
                    StorageItemType = table.Column<int>(nullable: false),
                    Discriminator = table.Column<string>(nullable: false),
                    BoatModel = table.Column<string>(nullable: true),
                    BoatMake = table.Column<string>(nullable: true),
                    BoatRegistration = table.Column<string>(nullable: true),
                    JetSkiModel = table.Column<string>(nullable: true),
                    JetSkiMake = table.Column<string>(nullable: true),
                    JetSkiRegistration = table.Column<string>(nullable: true),
                    TrailerRegistration = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StorageItems", x => x.StorageItemID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StorageItems");
        }
    }
}
