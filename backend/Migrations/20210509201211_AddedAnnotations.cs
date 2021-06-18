using Microsoft.EntityFrameworkCore.Migrations;

namespace Intalk.Migrations
{
    public partial class AddedAnnotations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserServers_AspNetUsers_UserId",
                table: "UserServers");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "UserServers",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Server",
                type: "character varying(25)",
                maxLength: 25,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "migrationuserId0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "77c22b8e-473f-4bb2-8caf-ba5903a0f98c", "AQAAAAEAACcQAAAAELVLN3Xg/bCAKJaQ9nhdhwxBfBhd4C/qd8Odhnn5DjTlO4Hq7qCeVPkCgVd/oZcNAw==", "0d61e5fa-a3bc-4804-8305-3dc33499773e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "migrationuserId1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bdd678b4-3fde-47ad-8577-aae960c22d62", "AQAAAAEAACcQAAAAEGhlbi9zY033QXEFbG79MAopAN6JPU9EjCPaUyPMwTJ9yQ9C8Rsjiy4fNMhr9zabfQ==", "3b40d0b3-6869-4194-90bc-8b56da06238e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "migrationuserId2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f28de7b3-224a-4d3f-90d4-4dc4310a2888", "AQAAAAEAACcQAAAAEG6ArLGc331nyKUk0gZu/JNBpSPRCdzYiBo8IFEWpIUxdoEdCjHz59C8RUu2lbvp/A==", "08b54928-2dd1-44a9-bd13-1af114f42792" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "migrationuserId3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4cf8b35f-9705-40f5-a4d0-d5fcfb384234", "AQAAAAEAACcQAAAAEJIHoLa2D1MbUED123jRL6HXJSnWdCNi5AJNSz+BQ64K8z695HliMdQrCX3ECd23eA==", "f969d7b0-dbf7-447c-9f15-823bb330c9a8" });

            migrationBuilder.AddForeignKey(
                name: "FK_UserServers_AspNetUsers_UserId",
                table: "UserServers",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserServers_AspNetUsers_UserId",
                table: "UserServers");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "UserServers",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Server",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(25)",
                oldMaxLength: 25);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "migrationuserId0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c608676f-86a6-49ff-867d-a99b495a3195", "AQAAAAEAACcQAAAAEGoPyayiYwMQAzQCRGY8r7pFNuiKd++DZ2hRDwPbSAgnahuCEmrX0QRNsjF9xa9SHQ==", "7b34bb54-0232-46b4-872e-b12ce8d58934" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "migrationuserId1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0f8cd75d-0921-4dc9-8e23-6b9278cf6a1b", "AQAAAAEAACcQAAAAEAuBWZTLWUlbhm5CC0ZqXewrRWXssS34dl3rGzy0bzyeYG8Ro93A806S3kELnWnH4Q==", "a23f4101-b5ab-4847-8ae7-df0fd12d8416" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "migrationuserId2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8dd597a4-075d-4f59-8164-fed735cef7d1", "AQAAAAEAACcQAAAAEF1P2xZc7lYlSIT9Z7VA90qBBYDvJTq3eHH1MyllFPrfPIzLuyONnhiyXpgSQ+fIbA==", "755f7247-8381-4e3b-8709-4f4cdddde430" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "migrationuserId3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cefbb381-e2ad-4973-9c3a-8c863bab5886", "AQAAAAEAACcQAAAAEMRDAB0ptoUWBLdV1bJn/tAho+R2gUbtAPOI3B6AjAPAHs8bFNDiV9h5w9SLLnaS9g==", "8f82718b-e767-4d00-8394-ed7491fa2e72" });

            migrationBuilder.AddForeignKey(
                name: "FK_UserServers_AspNetUsers_UserId",
                table: "UserServers",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
