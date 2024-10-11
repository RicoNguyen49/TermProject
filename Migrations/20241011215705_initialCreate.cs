using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TermProject.Migrations
{
    public partial class initialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)

        {   migrationBuilder.CreateTable(
                 name: "Leagues",
                columns: table => new
                {
                    LeagueId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Leagues", x => x.LeagueId);
                });

            migrationBuilder.CreateTable(
                name: "Membership",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LeagueId = table.Column<int>(type: "int", nullable: false),
                    LeagueName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Sport = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Country = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Division = table.Column<int>(type: "int", maxLength: 2, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cell = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Membership", x => x.ID);
                    
                    table.ForeignKey(
                    name: "FK_Membership_Leagues_LeagueId",
                    column: x => x.LeagueId,
                    principalTable: "Leagues",
                    principalColumn: "LeagueId",
                    onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Leagues",
                columns: new[] { "LeagueId", "Name" },
                values: new object[,]
                {
                   { 1, "English Premire League" },
                   { 2, "NFL" },
                   { 3, "MLB" }
                });

            migrationBuilder.InsertData(
                table: "Membership",
                columns: new[] { "ID", "Cell", "Country", "Division", "Email", "LeagueName", "Sport" },
                values: new object[] { 1, "981-123-4912", "England", 1, "EPL@eng.com", "English premire league", "Soccer" });

            migrationBuilder.InsertData(
                table: "Membership",
                columns: new[] { "ID", "Cell", "Country", "Division", "Email", "LeagueName", "Sport" },
                values: new object[] { 2, "192-371-4781", "USA", 1, "NFL@yahoo.com", "NFL", "FootBall" });

            migrationBuilder.InsertData(
                table: "Membership",
                columns: new[] { "ID", "Cell", "Country", "Division", "Email", "LeagueName", "Sport" },
                values: new object[] { 3, "491-728-1374", " USA", 1, "MLB@gmail.com", "MLB", "Baseball" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Membership");

            migrationBuilder.DropTable(
                name: "Leagues");   
        }
    }
}
