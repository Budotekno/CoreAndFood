using Microsoft.EntityFrameworkCore.Migrations;

namespace CoreAndFood.Migrations
{
    public partial class addaboutservicedetay : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AboutLists",
                columns: table => new
                {
                    AboutListId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AboutListMadde = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AboutLists", x => x.AboutListId);
                });

            migrationBuilder.CreateTable(
                name: "Abouts",
                columns: table => new
                {
                    AboutId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AboutCommet = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AboutPicture = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Abouts", x => x.AboutId);
                });

            migrationBuilder.CreateTable(
                name: "AboutUsers",
                columns: table => new
                {
                    AboutUserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AboutUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AboutUserJob = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AboutUserPictureUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AboutUsers", x => x.AboutUserId);
                });

            migrationBuilder.CreateTable(
                name: "AboutYorums",
                columns: table => new
                {
                    AboutYorumId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AboutYorumCommet = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AboutYorumName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AboutYorums", x => x.AboutYorumId);
                });

            migrationBuilder.CreateTable(
                name: "ServiceLists",
                columns: table => new
                {
                    ServiceListId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServiceListMadde = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceLists", x => x.ServiceListId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AboutLists");

            migrationBuilder.DropTable(
                name: "Abouts");

            migrationBuilder.DropTable(
                name: "AboutUsers");

            migrationBuilder.DropTable(
                name: "AboutYorums");

            migrationBuilder.DropTable(
                name: "ServiceLists");
        }
    }
}
