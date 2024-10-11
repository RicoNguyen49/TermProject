using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TermProject.Migrations
{
    public partial class LeaguesCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LeagueId",
                table: "Membership",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LeaguesLeagueId",
                table: "Membership",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
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

            migrationBuilder.InsertData(
                table: "Leagues",
                columns: new[] { "LeagueId", "Name" },
                values: new object[,]
                {
                    { 1, "English Premire League" },
                    { 2, "NFL" },
                    { 3, "MLB" }
                });

            migrationBuilder.UpdateData(
                table: "Membership",
                keyColumn: "ID",
                keyValue: 1,
                column: "LeagueId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Membership",
                keyColumn: "ID",
                keyValue: 2,
                column: "LeagueId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Membership",
                keyColumn: "ID",
                keyValue: 3,
                column: "LeagueId",
                value: 3);

            migrationBuilder.CreateIndex(
                name: "IX_Membership_LeaguesLeagueId",
                table: "Membership",
                column: "LeaguesLeagueId");

            migrationBuilder.AddForeignKey(
                name: "FK_Membership_Leagues_LeaguesLeagueId",
                table: "Membership",
                column: "LeaguesLeagueId",
                principalTable: "Leagues",
                principalColumn: "LeagueId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Membership_Leagues_LeaguesLeagueId",
                table: "Membership");

            migrationBuilder.DropTable(
                name: "Leagues");

            migrationBuilder.DropIndex(
                name: "IX_Membership_LeaguesLeagueId",
                table: "Membership");

            migrationBuilder.DropColumn(
                name: "LeagueId",
                table: "Membership");

            migrationBuilder.DropColumn(
                name: "LeaguesLeagueId",
                table: "Membership");
        }
    }
}
