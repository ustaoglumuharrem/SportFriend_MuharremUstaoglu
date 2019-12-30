using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SportFriend.Migrations
{
    public partial class initialdb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Demands",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Creator = table.Column<string>(nullable: true),
                    Participator = table.Column<string>(nullable: true),
                    Content = table.Column<string>(nullable: true),
                    Location = table.Column<string>(nullable: true),
                    Time = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Demands", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EventCreator = table.Column<string>(maxLength: 50, nullable: false),
                    EventName = table.Column<string>(nullable: false),
                    EventType = table.Column<string>(maxLength: 50, nullable: false),
                    EventLocation = table.Column<string>(maxLength: 50, nullable: false),
                    EventDate = table.Column<DateTime>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FriendUser",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Surname = table.Column<string>(maxLength: 50, nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: false),
                    BirthDate = table.Column<DateTime>(nullable: false),
                    Password = table.Column<string>(nullable: true),
                    RoleId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FriendUser", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RoleIdentifications",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateEvent = table.Column<int>(nullable: false),
                    CreateDemand = table.Column<int>(nullable: false),
                    LookDemand = table.Column<int>(nullable: false),
                    LookEvent = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleIdentifications", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleContent = table.Column<string>(nullable: false),
                    RoleIdentification = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "EventCreator", "EventDate", "EventLocation", "EventName", "EventType" },
                values: new object[,]
                {
                    { 1, "Muharrem Ustaoğlu", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2016), "İstanbul", "İstanbul Marathon", "Running" },
                    { 2, "Muharrem Ustaoğlu", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2012), "Antalya", "Antalya Swimming", "Swimming" }
                });

            migrationBuilder.InsertData(
                table: "FriendUser",
                columns: new[] { "Id", "BirthDate", "Name", "Password", "RoleId", "Surname", "UserName" },
                values: new object[,]
                {
                    { 1, new DateTime(1995, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Muharrem", "7ed44ba2e34347320e794c9c897c26ba78c6e98ffeef5303715de062da2d0936", 1, "Ustaoglu", "Muharrem" },
                    { 2, new DateTime(1997, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Melike", "8eb1597386bef1052725a0b67a809818b3b3eb20c76d41c2390373d83ed0ffd3", 2, "Yılmaz", "Melike" },
                    { 3, new DateTime(1997, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kemal", "7f21551bb56b76e58e915fe896ff6e94e58fedd72ebeaa49b39d616f9262e9ac", 2, "Karahan", "Kemal" },
                    { 4, new DateTime(1997, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Yusuf Mert", "29b49c02d38c638f33a7b730298d90530298720314300a1558915363524a29be", 2, "Bal", "YMB" },
                    { 5, new DateTime(1990, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ferhat", "ca5197dac80d256f47799fa36ddeb63cf3ba392c7d9c4f0a0160d85406989dba", 2, "Ören", "Ferhat" }
                });

            migrationBuilder.InsertData(
                table: "RoleIdentifications",
                columns: new[] { "Id", "CreateDemand", "CreateEvent", "LookDemand", "LookEvent" },
                values: new object[,]
                {
                    { 1, 1, 1, 1, 1 },
                    { 2, 1, 0, 1, 1 }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "Id", "RoleContent", "RoleIdentification" },
                values: new object[,]
                {
                    { 1, "Admin", 1 },
                    { 2, "User", 2 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Demands");

            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "FriendUser");

            migrationBuilder.DropTable(
                name: "RoleIdentifications");

            migrationBuilder.DropTable(
                name: "UserRoles");
        }
    }
}
