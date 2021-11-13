using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NSCMovie.Migrations
{
    public partial class AddTimeSchedule : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bf6a095c-5427-4830-afab-35a0a656b8a3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0c52a3c3-5bf3-44c7-8ec8-45addbd80300");

            migrationBuilder.DropColumn(
                name: "Schedule",
                table: "Movies");

            migrationBuilder.AddColumn<int>(
                name: "TimeScheduleId",
                table: "Movies",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "TimeSchedules",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Time = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TimeSchedules", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e89d4c1e-65ea-4335-91c8-10ad4b413810", "0e06f72d-00a3-458c-9825-8adad6d295c4", "Admin", null });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Avatar", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "6b9d2afb-e2a4-49f6-be48-1a0a90e8ed14", 0, null, "f24a55f3-8717-4750-b9e8-c3f84f99dfa2", "AdminWibu@admin.com", true, false, null, null, "ADMINWIBU@ADMIN.COM", "ADMINWIBU", "AQAAAAEAACcQAAAAEOzaiPrw6366IwlNW4t1bHwcK2RcfLNHxIJO0ySjlJrnpCxc+ocApgvOP8jPqHfv+g==", null, false, "1743ad6c-4543-4c05-b4c1-d15e1d1c8f24", false, "AdminWibu" });

            migrationBuilder.CreateIndex(
                name: "IX_Movies_TimeScheduleId",
                table: "Movies",
                column: "TimeScheduleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_TimeSchedules_TimeScheduleId",
                table: "Movies",
                column: "TimeScheduleId",
                principalTable: "TimeSchedules",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movies_TimeSchedules_TimeScheduleId",
                table: "Movies");

            migrationBuilder.DropTable(
                name: "TimeSchedules");

            migrationBuilder.DropIndex(
                name: "IX_Movies_TimeScheduleId",
                table: "Movies");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e89d4c1e-65ea-4335-91c8-10ad4b413810");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6b9d2afb-e2a4-49f6-be48-1a0a90e8ed14");

            migrationBuilder.DropColumn(
                name: "TimeScheduleId",
                table: "Movies");

            migrationBuilder.AddColumn<DateTime>(
                name: "Schedule",
                table: "Movies",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "bf6a095c-5427-4830-afab-35a0a656b8a3", "17e2cfc0-292d-4a5e-be06-55d55357e50a", "Admin", null });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Avatar", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "0c52a3c3-5bf3-44c7-8ec8-45addbd80300", 0, null, "cc956dd1-aaba-4112-9121-5f1d0eeb5e3d", "AdminWibu@admin.com", true, false, null, null, "ADMINWIBU@ADMIN.COM", "ADMINWIBU", "AQAAAAEAACcQAAAAEIVeEAPRfZTwuvUZ9XUdu+jB2bsk8m032oZFVn232bZUXVowULHaGwxGuaJAYcncxg==", null, false, "c8412319-64d1-4d84-b271-03e9632270fc", false, "AdminWibu" });
        }
    }
}
