using Microsoft.EntityFrameworkCore.Migrations;

namespace NSCMovie.Migrations
{
    public partial class AddDays : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Days",
                table: "Movies",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Definition",
                table: "Movies",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Movies",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f7824019-e405-42ca-b368-bbc99655ce14", "987a432a-31ce-4d11-a71a-9def13021eb9", "Admin", null });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Avatar", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "6bc38dfa-6709-468c-a156-ff160d58578a", 0, null, "0ac324df-8f6f-403a-9d83-8fb966529302", "AdminWibu@admin.com", true, false, null, null, "ADMINWIBU@ADMIN.COM", "ADMINWIBU", "AQAAAAEAACcQAAAAEGXTlo1X6ob+kAgLPK/wZl4ENKcvp0m3YUWmooWwBUZHGaZvfoFUOsPqp3xkdlaMzw==", null, false, "590619f6-30ea-4d0f-8ba9-980a031d8856", false, "AdminWibu" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f7824019-e405-42ca-b368-bbc99655ce14");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6bc38dfa-6709-468c-a156-ff160d58578a");

            migrationBuilder.DropColumn(
                name: "Days",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "Definition",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "Movies");
        }
    }
}
