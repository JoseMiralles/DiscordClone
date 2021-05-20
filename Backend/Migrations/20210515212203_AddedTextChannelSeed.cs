using Microsoft.EntityFrameworkCore.Migrations;

namespace Intalk.Migrations
{
    public partial class AddedTextChannelSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TextChannels_Server_ServerId",
                table: "TextChannels");

            migrationBuilder.AlterColumn<long>(
                name: "ServerId",
                table: "TextChannels",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "migrationuserId0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "517c9546-837b-47ce-b536-1d6f65d59b03", "AQAAAAEAACcQAAAAEPMVeI2Q9VBo4fBturgQehmY9yEHi7PAa/rt+DJKyej92IZLUUqy2JiY7tKs6y/gag==", "1f08f503-7156-4f07-9cd9-37ac8ed4bba2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "migrationuserId1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "29d69510-115d-4c20-8e8b-626201d4228c", "AQAAAAEAACcQAAAAED7rHmu3Xt0GdZ7JlrvMz8kOraNv3gYmsEHTrCAQ0BcQfjjeIXuhuajJlCVFXuwYzA==", "3aea965f-88a9-457f-b4bd-8810fcbe3ddc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "migrationuserId2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1d78600e-a8ee-4316-b34d-00500374670a", "AQAAAAEAACcQAAAAED16qmjfR2mbgbS6Kct6LZXNl9zvQQ1HwrcbHfcvdmFiUzIiCs5l1qWC6oB6vtrykQ==", "d2768f44-8a46-4379-900b-77bf703ca28f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "migrationuserId3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9b106124-7c7c-4350-ba27-0570a31f318a", "AQAAAAEAACcQAAAAEACfJr2Wcm38cPr1mAJ1zhoHXw58/8k5B+IGMe5SjI/nQCqlpq6XO6Xp7jt4TYnqsA==", "c2c32030-f730-402a-a5de-309bd43438b5" });

            migrationBuilder.InsertData(
                table: "TextChannels",
                columns: new[] { "Id", "ServerId", "Title" },
                values: new object[,]
                {
                    { -16, -4L, "Text Channel #15" },
                    { -15, -4L, "Text Channel #14" },
                    { -14, -4L, "Text Channel #13" },
                    { -13, -4L, "Text Channel #12" },
                    { -12, -3L, "Text Channel #11" },
                    { -11, -3L, "Text Channel #10" },
                    { -10, -3L, "Text Channel #9" },
                    { -8, -2L, "Text Channel #7" },
                    { -7, -2L, "Text Channel #6" },
                    { -6, -2L, "Text Channel #5" },
                    { -5, -2L, "Text Channel #4" },
                    { -4, -1L, "Text Channel #3" },
                    { -3, -1L, "Text Channel #2" },
                    { -2, -1L, "Text Channel #1" },
                    { -9, -3L, "Text Channel #8" },
                    { -1, -1L, "Text Channel #0" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_TextChannels_Server_ServerId",
                table: "TextChannels",
                column: "ServerId",
                principalTable: "Server",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TextChannels_Server_ServerId",
                table: "TextChannels");

            migrationBuilder.DeleteData(
                table: "TextChannels",
                keyColumn: "Id",
                keyValue: -16);

            migrationBuilder.DeleteData(
                table: "TextChannels",
                keyColumn: "Id",
                keyValue: -15);

            migrationBuilder.DeleteData(
                table: "TextChannels",
                keyColumn: "Id",
                keyValue: -14);

            migrationBuilder.DeleteData(
                table: "TextChannels",
                keyColumn: "Id",
                keyValue: -13);

            migrationBuilder.DeleteData(
                table: "TextChannels",
                keyColumn: "Id",
                keyValue: -12);

            migrationBuilder.DeleteData(
                table: "TextChannels",
                keyColumn: "Id",
                keyValue: -11);

            migrationBuilder.DeleteData(
                table: "TextChannels",
                keyColumn: "Id",
                keyValue: -10);

            migrationBuilder.DeleteData(
                table: "TextChannels",
                keyColumn: "Id",
                keyValue: -9);

            migrationBuilder.DeleteData(
                table: "TextChannels",
                keyColumn: "Id",
                keyValue: -8);

            migrationBuilder.DeleteData(
                table: "TextChannels",
                keyColumn: "Id",
                keyValue: -7);

            migrationBuilder.DeleteData(
                table: "TextChannels",
                keyColumn: "Id",
                keyValue: -6);

            migrationBuilder.DeleteData(
                table: "TextChannels",
                keyColumn: "Id",
                keyValue: -5);

            migrationBuilder.DeleteData(
                table: "TextChannels",
                keyColumn: "Id",
                keyValue: -4);

            migrationBuilder.DeleteData(
                table: "TextChannels",
                keyColumn: "Id",
                keyValue: -3);

            migrationBuilder.DeleteData(
                table: "TextChannels",
                keyColumn: "Id",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "TextChannels",
                keyColumn: "Id",
                keyValue: -1);

            migrationBuilder.AlterColumn<long>(
                name: "ServerId",
                table: "TextChannels",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "migrationuserId0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2f677a56-21a2-406a-b153-8d28d160981b", "AQAAAAEAACcQAAAAEPqVuZNC2oZ8CbzQuDSwEIc5K2Gm89BPj2rkmMsSutXGOGtDgF6yyyRzYHlkNqpi4w==", "7166cbf9-8cfa-40d3-93a7-3e70390b8f86" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "migrationuserId1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7e4626ae-c32b-4607-b769-18de48fcdf18", "AQAAAAEAACcQAAAAEIbCeyX5mhZV3d5+nQRTavl1TpOCVVjw7KEJnpj23O82LdCFIE0P/bTCb8YjFfsrEg==", "587fbd68-ea3d-4554-abe5-83a5a7522e4c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "migrationuserId2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0a739aab-e3df-42ee-bf0d-cae9b4eb85d5", "AQAAAAEAACcQAAAAEFCopoVButNzKuMZlfRAzGYF8duFHMt2ls0ZGeerqSlNvHzUw2KT51lCGTZZG1v+ZA==", "5c9a2c12-d479-4ec5-b9b6-07ffc19f7dae" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "migrationuserId3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5001b8a5-cb62-4235-9377-5b3873096894", "AQAAAAEAACcQAAAAEFKpQh6Yy54ECtVtO+2rJ60RvqsHBMrq5K+uRxBcnWS5/V+WB0PeyDOYwaGGjrliPQ==", "1a35d21a-1775-4b5c-9edb-2f6eb48d5e4f" });

            migrationBuilder.AddForeignKey(
                name: "FK_TextChannels_Server_ServerId",
                table: "TextChannels",
                column: "ServerId",
                principalTable: "Server",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
