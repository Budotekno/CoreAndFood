using Microsoft.EntityFrameworkCore.Migrations;

namespace CoreAndFood.Migrations
{
    public partial class addservice : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    ServicesId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServicesHeadding = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ServicesHeaddingDepCommet = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ServicesHeaddingPicture1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ServicesHeaddingPicture2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ServicesHeaddingPicture3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ServicesMatterPicture = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ServicesMatter1Number = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ServicesMatter1Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ServicesMatter2Number = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ServicesMatter2Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ServicesMatter3Number = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ServicesMatter3Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ServicesWriting1Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ServicesWriting1Commet = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ServicesWriting2Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ServicesWriting2Commet = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ServicesWriting3Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ServicesWriting3Commet = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.ServicesId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Services");
        }
    }
}
