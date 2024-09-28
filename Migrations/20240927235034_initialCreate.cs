using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TermProject.Migrations
{
    public partial class initialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Membership",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LeagueName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Sport = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    CountryOrgin = table.Column<int>(type: "int", nullable: true),
                    HeadQuarters = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Division = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cell = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Membership", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "Membership",
                columns: new[] { "ID", "Cell", "CountryOrgin", "Division", "Email", "HeadQuarters", "LeagueName", "Sport" },
                values: new object[] { 1, "931-137-3123", "England", "1", "EPL@eng.com", "1099 way", "English premire league", "Soccer" });

            migrationBuilder.InsertData(
                table: "Membership",
                columns: new[] { "ID", "Cell", "CountryOrgin", "Division", "Email", "HeadQuarters", "LeagueName", "Sport" },
                values: new object[] { 2, "512-314-2512", "USA", "1", "NFL@yahoo.com", "1023 my drive", "NFL", "FootBall" });

            migrationBuilder.InsertData(
                table: "Membership",
                columns: new[] { "ID", "Cell", "CountryOrgin", "Division", "Email", "HeadQuarters", "LeagueName", "Sport" },
                values: new object[] { 3, "564-423-7262", "USA", "1", "MLB@gmail.com", "328 west hollywood", "MLB", "Baseball" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Membership");
        }
    }
}
