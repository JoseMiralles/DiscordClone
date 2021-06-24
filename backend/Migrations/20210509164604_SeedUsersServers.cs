using Microsoft.EntityFrameworkCore.Migrations;

namespace Intalk.Migrations
{
    public partial class SeedUsersServers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "AspNetUsers",
                type: "character varying(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(256)",
                oldMaxLength: 256);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "migrationuserId0", 0, "c608676f-86a6-49ff-867d-a99b495a3195", "test0@test.com", false, false, null, "TEST0@TEST.COM", "TESTUSER0", "AQAAAAEAACcQAAAAEGoPyayiYwMQAzQCRGY8r7pFNuiKd++DZ2hRDwPbSAgnahuCEmrX0QRNsjF9xa9SHQ==", null, false, "7b34bb54-0232-46b4-872e-b12ce8d58934", false, "TestUser0" },
                    { "migrationuserId1", 0, "0f8cd75d-0921-4dc9-8e23-6b9278cf6a1b", "test1@test.com", false, false, null, "TEST1@TEST.COM", "TESTUSER1", "AQAAAAEAACcQAAAAEAuBWZTLWUlbhm5CC0ZqXewrRWXssS34dl3rGzy0bzyeYG8Ro93A806S3kELnWnH4Q==", null, false, "a23f4101-b5ab-4847-8ae7-df0fd12d8416", false, "TestUser1" },
                    { "migrationuserId2", 0, "8dd597a4-075d-4f59-8164-fed735cef7d1", "test2@test.com", false, false, null, "TEST2@TEST.COM", "TESTUSER2", "AQAAAAEAACcQAAAAEF1P2xZc7lYlSIT9Z7VA90qBBYDvJTq3eHH1MyllFPrfPIzLuyONnhiyXpgSQ+fIbA==", null, false, "755f7247-8381-4e3b-8709-4f4cdddde430", false, "TestUser2" },
                    { "migrationuserId3", 0, "cefbb381-e2ad-4973-9c3a-8c863bab5886", "test3@test.com", false, false, null, "TEST3@TEST.COM", "TESTUSER3", "AQAAAAEAACcQAAAAEMRDAB0ptoUWBLdV1bJn/tAho+R2gUbtAPOI3B6AjAPAHs8bFNDiV9h5w9SLLnaS9g==", null, false, "8f82718b-e767-4d00-8394-ed7491fa2e72", false, "TestUser3" }
                });

            migrationBuilder.InsertData(
                table: "Server",
                columns: new[] { "Id", "Title" },
                values: new object[,]
                {
                    { -1L, "Server#0" },
                    { -2L, "Server#1" },
                    { -3L, "Server#2" },
                    { -4L, "Server#3" }
                });

            migrationBuilder.InsertData(
                table: "UserServers",
                columns: new[] { "Id", "Role", "ServerId", "UserId" },
                values: new object[,]
                {
                    { -1L, 1, -1L, "migrationuserId0" },
                    { -2L, 0, -1L, "migrationuserId1" },
                    { -3L, 0, -1L, "migrationuserId2" },
                    { -4L, 0, -1L, "migrationuserId3" },
                    { -5L, 0, -2L, "migrationuserId0" },
                    { -6L, 1, -2L, "migrationuserId1" },
                    { -7L, 0, -2L, "migrationuserId2" },
                    { -8L, 0, -2L, "migrationuserId3" },
                    { -9L, 0, -3L, "migrationuserId0" },
                    { -10L, 0, -3L, "migrationuserId1" },
                    { -11L, 1, -3L, "migrationuserId2" },
                    { -12L, 0, -3L, "migrationuserId3" },
                    { -13L, 0, -4L, "migrationuserId0" },
                    { -14L, 0, -4L, "migrationuserId1" },
                    { -15L, 0, -4L, "migrationuserId2" },
                    { -16L, 1, -4L, "migrationuserId3" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserServers",
                keyColumn: "Id",
                keyValue: -16L);

            migrationBuilder.DeleteData(
                table: "UserServers",
                keyColumn: "Id",
                keyValue: -15L);

            migrationBuilder.DeleteData(
                table: "UserServers",
                keyColumn: "Id",
                keyValue: -14L);

            migrationBuilder.DeleteData(
                table: "UserServers",
                keyColumn: "Id",
                keyValue: -13L);

            migrationBuilder.DeleteData(
                table: "UserServers",
                keyColumn: "Id",
                keyValue: -12L);

            migrationBuilder.DeleteData(
                table: "UserServers",
                keyColumn: "Id",
                keyValue: -11L);

            migrationBuilder.DeleteData(
                table: "UserServers",
                keyColumn: "Id",
                keyValue: -10L);

            migrationBuilder.DeleteData(
                table: "UserServers",
                keyColumn: "Id",
                keyValue: -9L);

            migrationBuilder.DeleteData(
                table: "UserServers",
                keyColumn: "Id",
                keyValue: -8L);

            migrationBuilder.DeleteData(
                table: "UserServers",
                keyColumn: "Id",
                keyValue: -7L);

            migrationBuilder.DeleteData(
                table: "UserServers",
                keyColumn: "Id",
                keyValue: -6L);

            migrationBuilder.DeleteData(
                table: "UserServers",
                keyColumn: "Id",
                keyValue: -5L);

            migrationBuilder.DeleteData(
                table: "UserServers",
                keyColumn: "Id",
                keyValue: -4L);

            migrationBuilder.DeleteData(
                table: "UserServers",
                keyColumn: "Id",
                keyValue: -3L);

            migrationBuilder.DeleteData(
                table: "UserServers",
                keyColumn: "Id",
                keyValue: -2L);

            migrationBuilder.DeleteData(
                table: "UserServers",
                keyColumn: "Id",
                keyValue: -1L);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "migrationuserId0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "migrationuserId1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "migrationuserId2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "migrationuserId3");

            migrationBuilder.DeleteData(
                table: "Server",
                keyColumn: "Id",
                keyValue: -4L);

            migrationBuilder.DeleteData(
                table: "Server",
                keyColumn: "Id",
                keyValue: -3L);

            migrationBuilder.DeleteData(
                table: "Server",
                keyColumn: "Id",
                keyValue: -2L);

            migrationBuilder.DeleteData(
                table: "Server",
                keyColumn: "Id",
                keyValue: -1L);

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "AspNetUsers",
                type: "character varying(256)",
                maxLength: 256,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "character varying(256)",
                oldMaxLength: 256,
                oldNullable: true);
        }
    }
}
