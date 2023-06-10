using Microsoft.EntityFrameworkCore.Migrations;

namespace CourtEndahAPI_v1.Migrations
{
    public partial class BookingDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ADMIN_Ts",
                columns: table => new
                {
                    admin_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    admin_username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    admin_password = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ADMIN_Ts", x => x.admin_id);
                });

            migrationBuilder.CreateTable(
                name: "BOOKING_Ts",
                columns: table => new
                {
                    book_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    book_date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    book_time = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    court_id = table.Column<int>(type: "int", nullable: false),
                    play_id = table.Column<int>(type: "int", nullable: false),
                    book_createdate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    book_active = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BOOKING_Ts", x => x.book_id);
                });

            migrationBuilder.CreateTable(
                name: "COURT_Ts",
                columns: table => new
                {
                    court_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    court_type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    court_active = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_COURT_Ts", x => x.court_id);
                });

            migrationBuilder.CreateTable(
                name: "PLAYER_Ts",
                columns: table => new
                {
                    play_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    play_username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    play_password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    play_fullname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    play_unitno = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    play_cardno = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    play_createdate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    play_active = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PLAYER_Ts", x => x.play_id);
                });

            migrationBuilder.InsertData(
                table: "ADMIN_Ts",
                columns: new[] { "admin_id", "admin_password", "admin_username" },
                values: new object[] { 1, "12345", "admin" });

            migrationBuilder.InsertData(
                table: "COURT_Ts",
                columns: new[] { "court_id", "court_active", "court_type" },
                values: new object[,]
                {
                    { 1, 1, "Court A" },
                    { 2, 1, "Court B" }
                });

            migrationBuilder.InsertData(
                table: "PLAYER_Ts",
                columns: new[] { "play_id", "play_active", "play_cardno", "play_createdate", "play_fullname", "play_password", "play_unitno", "play_username" },
                values: new object[,]
                {
                    { 1, 1, "D3517", "4/4/2023 11:54:41 PM", "lim", "12345", "D1006", "lim@gmail.com" },
                    { 2, 1, "D4059", "4/4/2023 11:54:41 PM", "choong", "12345", "C163A", "choong@gmail.com" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ADMIN_Ts");

            migrationBuilder.DropTable(
                name: "BOOKING_Ts");

            migrationBuilder.DropTable(
                name: "COURT_Ts");

            migrationBuilder.DropTable(
                name: "PLAYER_Ts");
        }
    }
}
