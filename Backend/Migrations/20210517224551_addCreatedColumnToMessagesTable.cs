using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Intalk.Migrations
{
    public partial class addCreatedColumnToMessagesTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "Messages",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "migrationuserId0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4e4cd5fa-b652-4ee0-ad24-a69cec3a4603", "AQAAAAEAACcQAAAAEKEca9j5pWdV/AcZFas4Kb4Y4QBXqbr8PSatX6UedBjIUgdfKK4VSCaJI/fiz2o7Yg==", "2a55d7d4-b1ff-4b8c-bab9-31975a0b1ec3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "migrationuserId1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c3612500-8e78-4c23-b83f-15ad0f2a9fa2", "AQAAAAEAACcQAAAAECA7x7js/JQ0+xQ0+a/jzK9LOSeang0sZ4PpwLe5dL8uVMr4lvfDZYbpFwGvrNaDJQ==", "8f260dbd-6821-4dac-a5e3-ce979638ebc4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "migrationuserId2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "487e125e-a5ad-47fe-a5d3-410d736e010b", "AQAAAAEAACcQAAAAED/jSLRyGjsfqF5gE+K1PSFEhRAnU45fLR2cUPh7nK0AxscnwFAaPr1hsobcYFdViQ==", "feb9bf98-9385-4233-a11a-5abe1111a70b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "migrationuserId3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "511e367f-54a3-4e1c-bc31-5ca14b052b65", "AQAAAAEAACcQAAAAEN+Ghov6+Qq4GYFXheEwq5aIM2/jYT26LELXz4O3/JIKgzLFYpvHmj3geVb24IMDTA==", "d67d2ddf-bba1-4bb3-a717-f5e4b58ca2d4" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -640L,
                column: "Created",
                value: new DateTime(1998, 1, 16, 13, 57, 50, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -639L,
                column: "Created",
                value: new DateTime(1998, 2, 12, 5, 8, 29, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -638L,
                column: "Created",
                value: new DateTime(1998, 3, 10, 19, 19, 7, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -637L,
                column: "Created",
                value: new DateTime(1998, 4, 6, 8, 29, 44, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -636L,
                column: "Created",
                value: new DateTime(1998, 5, 2, 20, 40, 20, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -635L,
                column: "Created",
                value: new DateTime(1998, 5, 29, 7, 50, 55, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -634L,
                column: "Created",
                value: new DateTime(1998, 6, 24, 18, 1, 29, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -633L,
                column: "Created",
                value: new DateTime(1998, 7, 21, 3, 12, 2, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -632L,
                column: "Created",
                value: new DateTime(1998, 8, 16, 11, 22, 34, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -631L,
                column: "Created",
                value: new DateTime(1998, 9, 11, 18, 33, 5, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -630L,
                column: "Created",
                value: new DateTime(1998, 10, 8, 0, 43, 35, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -629L,
                column: "Created",
                value: new DateTime(1998, 11, 3, 5, 54, 4, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -628L,
                column: "Created",
                value: new DateTime(1998, 11, 29, 10, 4, 32, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -627L,
                column: "Created",
                value: new DateTime(1998, 12, 25, 13, 14, 59, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -626L,
                column: "Created",
                value: new DateTime(1999, 1, 20, 15, 25, 25, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -625L,
                column: "Created",
                value: new DateTime(1999, 2, 15, 16, 35, 50, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -624L,
                column: "Created",
                value: new DateTime(1999, 3, 13, 16, 46, 14, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -623L,
                column: "Created",
                value: new DateTime(1999, 4, 8, 15, 56, 37, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -622L,
                column: "Created",
                value: new DateTime(1999, 5, 4, 14, 6, 59, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -621L,
                column: "Created",
                value: new DateTime(1999, 5, 30, 11, 17, 20, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -620L,
                column: "Created",
                value: new DateTime(1999, 6, 25, 7, 27, 40, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -619L,
                column: "Created",
                value: new DateTime(1999, 7, 21, 2, 37, 59, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -618L,
                column: "Created",
                value: new DateTime(1999, 8, 15, 20, 48, 17, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -617L,
                column: "Created",
                value: new DateTime(1999, 9, 10, 13, 58, 34, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -616L,
                column: "Created",
                value: new DateTime(1999, 10, 6, 6, 8, 50, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -615L,
                column: "Created",
                value: new DateTime(1999, 10, 31, 21, 19, 5, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -614L,
                column: "Created",
                value: new DateTime(1999, 11, 26, 11, 29, 19, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -613L,
                column: "Created",
                value: new DateTime(1999, 12, 22, 0, 39, 32, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -612L,
                column: "Created",
                value: new DateTime(2000, 1, 16, 12, 49, 44, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -611L,
                column: "Created",
                value: new DateTime(2000, 2, 10, 23, 59, 55, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -610L,
                column: "Created",
                value: new DateTime(2000, 3, 7, 10, 10, 5, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -609L,
                column: "Created",
                value: new DateTime(2000, 4, 1, 19, 20, 14, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -608L,
                column: "Created",
                value: new DateTime(2000, 4, 27, 3, 30, 22, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -607L,
                column: "Created",
                value: new DateTime(2000, 5, 22, 10, 40, 29, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -606L,
                column: "Created",
                value: new DateTime(2000, 6, 16, 16, 50, 35, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -605L,
                column: "Created",
                value: new DateTime(2000, 7, 11, 22, 0, 40, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -604L,
                column: "Created",
                value: new DateTime(2000, 8, 6, 2, 10, 44, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -603L,
                column: "Created",
                value: new DateTime(2000, 8, 31, 5, 20, 47, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -602L,
                column: "Created",
                value: new DateTime(2000, 9, 25, 7, 30, 49, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -601L,
                column: "Created",
                value: new DateTime(2000, 10, 20, 8, 40, 50, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -600L,
                column: "Created",
                value: new DateTime(2000, 11, 14, 8, 50, 50, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -599L,
                column: "Created",
                value: new DateTime(2000, 12, 9, 8, 0, 49, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -598L,
                column: "Created",
                value: new DateTime(2001, 1, 3, 6, 10, 47, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -597L,
                column: "Created",
                value: new DateTime(2001, 1, 28, 3, 20, 44, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -596L,
                column: "Created",
                value: new DateTime(2001, 2, 21, 23, 30, 40, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -595L,
                column: "Created",
                value: new DateTime(2001, 3, 18, 18, 40, 35, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -594L,
                column: "Created",
                value: new DateTime(2001, 4, 12, 12, 50, 29, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -593L,
                column: "Created",
                value: new DateTime(2001, 5, 7, 6, 0, 22, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -592L,
                column: "Created",
                value: new DateTime(2001, 5, 31, 22, 10, 14, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -591L,
                column: "Created",
                value: new DateTime(2001, 6, 25, 13, 20, 5, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -590L,
                column: "Created",
                value: new DateTime(2001, 7, 20, 3, 29, 55, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -589L,
                column: "Created",
                value: new DateTime(2001, 8, 13, 16, 39, 44, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -588L,
                column: "Created",
                value: new DateTime(2001, 9, 7, 4, 49, 32, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -587L,
                column: "Created",
                value: new DateTime(2001, 10, 1, 15, 59, 19, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -586L,
                column: "Created",
                value: new DateTime(2001, 10, 26, 2, 9, 5, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -585L,
                column: "Created",
                value: new DateTime(2001, 11, 19, 11, 18, 50, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -584L,
                column: "Created",
                value: new DateTime(2001, 12, 13, 19, 28, 34, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -583L,
                column: "Created",
                value: new DateTime(2002, 1, 7, 2, 38, 17, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -582L,
                column: "Created",
                value: new DateTime(2002, 1, 31, 8, 47, 59, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -581L,
                column: "Created",
                value: new DateTime(2002, 2, 24, 13, 57, 40, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -580L,
                column: "Created",
                value: new DateTime(2002, 3, 20, 18, 7, 20, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -579L,
                column: "Created",
                value: new DateTime(2002, 4, 13, 21, 16, 59, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -578L,
                column: "Created",
                value: new DateTime(2002, 5, 7, 23, 26, 37, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -577L,
                column: "Created",
                value: new DateTime(2002, 6, 1, 0, 36, 14, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -576L,
                column: "Created",
                value: new DateTime(2002, 6, 25, 0, 45, 50, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -575L,
                column: "Created",
                value: new DateTime(2002, 7, 18, 23, 55, 25, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -574L,
                column: "Created",
                value: new DateTime(2002, 8, 11, 22, 4, 59, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -573L,
                column: "Created",
                value: new DateTime(2002, 9, 4, 19, 14, 32, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -572L,
                column: "Created",
                value: new DateTime(2002, 9, 28, 15, 24, 4, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -571L,
                column: "Created",
                value: new DateTime(2002, 10, 22, 10, 33, 35, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -570L,
                column: "Created",
                value: new DateTime(2002, 11, 15, 4, 43, 5, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -569L,
                column: "Created",
                value: new DateTime(2002, 12, 8, 21, 52, 34, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -568L,
                column: "Created",
                value: new DateTime(2003, 1, 1, 14, 2, 2, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -567L,
                column: "Created",
                value: new DateTime(2003, 1, 25, 5, 11, 29, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -566L,
                column: "Created",
                value: new DateTime(2003, 2, 17, 19, 20, 55, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -565L,
                column: "Created",
                value: new DateTime(2003, 3, 13, 8, 30, 20, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -564L,
                column: "Created",
                value: new DateTime(2003, 4, 5, 20, 39, 44, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -563L,
                column: "Created",
                value: new DateTime(2003, 4, 29, 7, 49, 7, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -562L,
                column: "Created",
                value: new DateTime(2003, 5, 22, 17, 58, 29, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -561L,
                column: "Created",
                value: new DateTime(2003, 6, 15, 3, 7, 50, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -560L,
                column: "Created",
                value: new DateTime(2003, 7, 8, 11, 17, 10, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -559L,
                column: "Created",
                value: new DateTime(2003, 7, 31, 18, 26, 29, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -558L,
                column: "Created",
                value: new DateTime(2003, 8, 24, 0, 35, 47, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -557L,
                column: "Created",
                value: new DateTime(2003, 9, 16, 5, 45, 4, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -556L,
                column: "Created",
                value: new DateTime(2003, 10, 9, 9, 54, 20, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -555L,
                column: "Created",
                value: new DateTime(2003, 11, 1, 13, 3, 35, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -554L,
                column: "Created",
                value: new DateTime(2003, 11, 24, 15, 12, 49, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -553L,
                column: "Created",
                value: new DateTime(2003, 12, 17, 16, 22, 2, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -552L,
                column: "Created",
                value: new DateTime(2004, 1, 9, 16, 31, 14, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -551L,
                column: "Created",
                value: new DateTime(2004, 2, 1, 15, 40, 25, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -550L,
                column: "Created",
                value: new DateTime(2004, 2, 24, 13, 49, 35, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -549L,
                column: "Created",
                value: new DateTime(2004, 3, 18, 10, 58, 44, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -548L,
                column: "Created",
                value: new DateTime(2004, 4, 10, 7, 7, 52, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -547L,
                column: "Created",
                value: new DateTime(2004, 5, 3, 2, 16, 59, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -546L,
                column: "Created",
                value: new DateTime(2004, 5, 25, 20, 26, 5, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -545L,
                column: "Created",
                value: new DateTime(2004, 6, 17, 13, 35, 10, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -544L,
                column: "Created",
                value: new DateTime(2004, 7, 10, 5, 44, 14, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -543L,
                column: "Created",
                value: new DateTime(2004, 8, 1, 20, 53, 17, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -542L,
                column: "Created",
                value: new DateTime(2004, 8, 24, 11, 2, 19, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -541L,
                column: "Created",
                value: new DateTime(2004, 9, 16, 0, 11, 20, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -540L,
                column: "Created",
                value: new DateTime(2004, 10, 8, 12, 20, 20, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -539L,
                column: "Created",
                value: new DateTime(2004, 10, 30, 23, 29, 19, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -538L,
                column: "Created",
                value: new DateTime(2004, 11, 22, 9, 38, 17, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -537L,
                column: "Created",
                value: new DateTime(2004, 12, 14, 18, 47, 14, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -536L,
                column: "Created",
                value: new DateTime(2005, 1, 6, 2, 56, 10, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -535L,
                column: "Created",
                value: new DateTime(2005, 1, 28, 10, 5, 5, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -534L,
                column: "Created",
                value: new DateTime(2005, 2, 19, 16, 13, 59, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -533L,
                column: "Created",
                value: new DateTime(2005, 3, 13, 21, 22, 52, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -532L,
                column: "Created",
                value: new DateTime(2005, 4, 5, 1, 31, 44, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -531L,
                column: "Created",
                value: new DateTime(2005, 4, 27, 4, 40, 35, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -530L,
                column: "Created",
                value: new DateTime(2005, 5, 19, 6, 49, 25, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -529L,
                column: "Created",
                value: new DateTime(2005, 6, 10, 7, 58, 14, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -528L,
                column: "Created",
                value: new DateTime(2005, 7, 2, 8, 7, 2, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -527L,
                column: "Created",
                value: new DateTime(2005, 7, 24, 7, 15, 49, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -526L,
                column: "Created",
                value: new DateTime(2005, 8, 15, 5, 24, 35, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -525L,
                column: "Created",
                value: new DateTime(2005, 9, 6, 2, 33, 20, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -524L,
                column: "Created",
                value: new DateTime(2005, 9, 27, 22, 42, 4, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -523L,
                column: "Created",
                value: new DateTime(2005, 10, 19, 17, 50, 47, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -522L,
                column: "Created",
                value: new DateTime(2005, 11, 10, 11, 59, 29, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -521L,
                column: "Created",
                value: new DateTime(2005, 12, 2, 5, 8, 10, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -520L,
                column: "Created",
                value: new DateTime(2005, 12, 23, 21, 16, 50, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -519L,
                column: "Created",
                value: new DateTime(2006, 1, 14, 12, 25, 29, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -518L,
                column: "Created",
                value: new DateTime(2006, 2, 5, 2, 34, 7, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -517L,
                column: "Created",
                value: new DateTime(2006, 2, 26, 15, 42, 44, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -516L,
                column: "Created",
                value: new DateTime(2006, 3, 20, 3, 51, 20, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -515L,
                column: "Created",
                value: new DateTime(2006, 4, 10, 14, 59, 55, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -514L,
                column: "Created",
                value: new DateTime(2006, 5, 2, 1, 8, 29, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -513L,
                column: "Created",
                value: new DateTime(2006, 5, 23, 10, 17, 2, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -512L,
                column: "Created",
                value: new DateTime(2006, 6, 13, 18, 25, 34, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -511L,
                column: "Created",
                value: new DateTime(2006, 7, 5, 1, 34, 5, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -510L,
                column: "Created",
                value: new DateTime(2006, 7, 26, 7, 42, 35, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -509L,
                column: "Created",
                value: new DateTime(2006, 8, 16, 12, 51, 4, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -508L,
                column: "Created",
                value: new DateTime(2006, 9, 6, 16, 59, 32, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -507L,
                column: "Created",
                value: new DateTime(2006, 9, 27, 20, 7, 59, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -506L,
                column: "Created",
                value: new DateTime(2006, 10, 18, 22, 16, 25, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -505L,
                column: "Created",
                value: new DateTime(2006, 11, 8, 23, 24, 50, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -504L,
                column: "Created",
                value: new DateTime(2006, 11, 29, 23, 33, 14, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -503L,
                column: "Created",
                value: new DateTime(2006, 12, 20, 22, 41, 37, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -502L,
                column: "Created",
                value: new DateTime(2007, 1, 10, 20, 49, 59, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -501L,
                column: "Created",
                value: new DateTime(2007, 1, 31, 17, 58, 20, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -500L,
                column: "Created",
                value: new DateTime(2007, 2, 21, 14, 6, 40, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -499L,
                column: "Created",
                value: new DateTime(2007, 3, 14, 9, 14, 59, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -498L,
                column: "Created",
                value: new DateTime(2007, 4, 4, 3, 23, 17, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -497L,
                column: "Created",
                value: new DateTime(2007, 4, 24, 20, 31, 34, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -496L,
                column: "Created",
                value: new DateTime(2007, 5, 15, 12, 39, 50, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -495L,
                column: "Created",
                value: new DateTime(2007, 6, 5, 3, 48, 5, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -494L,
                column: "Created",
                value: new DateTime(2007, 6, 25, 17, 56, 19, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -493L,
                column: "Created",
                value: new DateTime(2007, 7, 16, 7, 4, 32, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -492L,
                column: "Created",
                value: new DateTime(2007, 8, 5, 19, 12, 44, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -491L,
                column: "Created",
                value: new DateTime(2007, 8, 26, 6, 20, 55, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -490L,
                column: "Created",
                value: new DateTime(2007, 9, 15, 16, 29, 5, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -489L,
                column: "Created",
                value: new DateTime(2007, 10, 6, 1, 37, 14, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -488L,
                column: "Created",
                value: new DateTime(2007, 10, 26, 9, 45, 22, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -487L,
                column: "Created",
                value: new DateTime(2007, 11, 15, 16, 53, 29, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -486L,
                column: "Created",
                value: new DateTime(2007, 12, 5, 23, 1, 35, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -485L,
                column: "Created",
                value: new DateTime(2007, 12, 26, 4, 9, 40, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -484L,
                column: "Created",
                value: new DateTime(2008, 1, 15, 8, 17, 44, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -483L,
                column: "Created",
                value: new DateTime(2008, 2, 4, 11, 25, 47, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -482L,
                column: "Created",
                value: new DateTime(2008, 2, 24, 13, 33, 49, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -481L,
                column: "Created",
                value: new DateTime(2008, 3, 15, 14, 41, 50, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -480L,
                column: "Created",
                value: new DateTime(2008, 4, 4, 14, 49, 50, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -479L,
                column: "Created",
                value: new DateTime(2008, 4, 24, 13, 57, 49, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -478L,
                column: "Created",
                value: new DateTime(2008, 5, 14, 12, 5, 47, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -477L,
                column: "Created",
                value: new DateTime(2008, 6, 3, 9, 13, 44, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -476L,
                column: "Created",
                value: new DateTime(2008, 6, 23, 5, 21, 40, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -475L,
                column: "Created",
                value: new DateTime(2008, 7, 13, 0, 29, 35, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -474L,
                column: "Created",
                value: new DateTime(2008, 8, 1, 18, 37, 29, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -473L,
                column: "Created",
                value: new DateTime(2008, 8, 21, 11, 45, 22, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -472L,
                column: "Created",
                value: new DateTime(2008, 9, 10, 3, 53, 14, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -471L,
                column: "Created",
                value: new DateTime(2008, 9, 29, 19, 1, 5, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -470L,
                column: "Created",
                value: new DateTime(2008, 10, 19, 9, 8, 55, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -469L,
                column: "Created",
                value: new DateTime(2008, 11, 7, 22, 16, 44, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -468L,
                column: "Created",
                value: new DateTime(2008, 11, 27, 10, 24, 32, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -467L,
                column: "Created",
                value: new DateTime(2008, 12, 16, 21, 32, 19, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -466L,
                column: "Created",
                value: new DateTime(2009, 1, 5, 7, 40, 5, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -465L,
                column: "Created",
                value: new DateTime(2009, 1, 24, 16, 47, 50, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -464L,
                column: "Created",
                value: new DateTime(2009, 2, 13, 0, 55, 34, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -463L,
                column: "Created",
                value: new DateTime(2009, 3, 4, 8, 3, 17, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -462L,
                column: "Created",
                value: new DateTime(2009, 3, 23, 14, 10, 59, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -461L,
                column: "Created",
                value: new DateTime(2009, 4, 11, 19, 18, 40, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -460L,
                column: "Created",
                value: new DateTime(2009, 4, 30, 23, 26, 20, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -459L,
                column: "Created",
                value: new DateTime(2009, 5, 20, 2, 33, 59, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -458L,
                column: "Created",
                value: new DateTime(2009, 6, 8, 4, 41, 37, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -457L,
                column: "Created",
                value: new DateTime(2009, 6, 27, 5, 49, 14, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -456L,
                column: "Created",
                value: new DateTime(2009, 7, 16, 5, 56, 50, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -455L,
                column: "Created",
                value: new DateTime(2009, 8, 4, 5, 4, 25, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -454L,
                column: "Created",
                value: new DateTime(2009, 8, 23, 3, 11, 59, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -453L,
                column: "Created",
                value: new DateTime(2009, 9, 11, 0, 19, 32, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -452L,
                column: "Created",
                value: new DateTime(2009, 9, 29, 20, 27, 4, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -451L,
                column: "Created",
                value: new DateTime(2009, 10, 18, 15, 34, 35, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -450L,
                column: "Created",
                value: new DateTime(2009, 11, 6, 9, 42, 5, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -449L,
                column: "Created",
                value: new DateTime(2009, 11, 25, 2, 49, 34, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -448L,
                column: "Created",
                value: new DateTime(2009, 12, 13, 18, 57, 2, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -447L,
                column: "Created",
                value: new DateTime(2010, 1, 1, 10, 4, 29, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -446L,
                column: "Created",
                value: new DateTime(2010, 1, 20, 0, 11, 55, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -445L,
                column: "Created",
                value: new DateTime(2010, 2, 7, 13, 19, 20, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -444L,
                column: "Created",
                value: new DateTime(2010, 2, 26, 1, 26, 44, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -443L,
                column: "Created",
                value: new DateTime(2010, 3, 16, 12, 34, 7, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -442L,
                column: "Created",
                value: new DateTime(2010, 4, 3, 22, 41, 29, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -441L,
                column: "Created",
                value: new DateTime(2010, 4, 22, 7, 48, 50, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -440L,
                column: "Created",
                value: new DateTime(2010, 5, 10, 15, 56, 10, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -439L,
                column: "Created",
                value: new DateTime(2010, 5, 28, 23, 3, 29, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -438L,
                column: "Created",
                value: new DateTime(2010, 6, 16, 5, 10, 47, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -437L,
                column: "Created",
                value: new DateTime(2010, 7, 4, 10, 18, 4, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -436L,
                column: "Created",
                value: new DateTime(2010, 7, 22, 14, 25, 20, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -435L,
                column: "Created",
                value: new DateTime(2010, 8, 9, 17, 32, 35, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -434L,
                column: "Created",
                value: new DateTime(2010, 8, 27, 19, 39, 49, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -433L,
                column: "Created",
                value: new DateTime(2010, 9, 14, 20, 47, 2, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -432L,
                column: "Created",
                value: new DateTime(2010, 10, 2, 20, 54, 14, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -431L,
                column: "Created",
                value: new DateTime(2010, 10, 20, 20, 1, 25, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -430L,
                column: "Created",
                value: new DateTime(2010, 11, 7, 18, 8, 35, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -429L,
                column: "Created",
                value: new DateTime(2010, 11, 25, 15, 15, 44, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -428L,
                column: "Created",
                value: new DateTime(2010, 12, 13, 11, 22, 52, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -427L,
                column: "Created",
                value: new DateTime(2010, 12, 31, 6, 29, 59, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -426L,
                column: "Created",
                value: new DateTime(2011, 1, 18, 0, 37, 5, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -425L,
                column: "Created",
                value: new DateTime(2011, 2, 4, 17, 44, 10, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -424L,
                column: "Created",
                value: new DateTime(2011, 2, 22, 9, 51, 14, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -423L,
                column: "Created",
                value: new DateTime(2011, 3, 12, 0, 58, 17, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -422L,
                column: "Created",
                value: new DateTime(2011, 3, 29, 15, 5, 19, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -421L,
                column: "Created",
                value: new DateTime(2011, 4, 16, 4, 12, 20, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -420L,
                column: "Created",
                value: new DateTime(2011, 5, 3, 16, 19, 20, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -419L,
                column: "Created",
                value: new DateTime(2011, 5, 21, 3, 26, 19, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -418L,
                column: "Created",
                value: new DateTime(2011, 6, 7, 13, 33, 17, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -417L,
                column: "Created",
                value: new DateTime(2011, 6, 24, 22, 40, 14, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -416L,
                column: "Created",
                value: new DateTime(2011, 7, 12, 6, 47, 10, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -415L,
                column: "Created",
                value: new DateTime(2011, 7, 29, 13, 54, 5, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -414L,
                column: "Created",
                value: new DateTime(2011, 8, 15, 20, 0, 59, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -413L,
                column: "Created",
                value: new DateTime(2011, 9, 2, 1, 7, 52, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -412L,
                column: "Created",
                value: new DateTime(2011, 9, 19, 5, 14, 44, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -411L,
                column: "Created",
                value: new DateTime(2011, 10, 6, 8, 21, 35, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -410L,
                column: "Created",
                value: new DateTime(2011, 10, 23, 10, 28, 25, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -409L,
                column: "Created",
                value: new DateTime(2011, 11, 9, 11, 35, 14, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -408L,
                column: "Created",
                value: new DateTime(2011, 11, 26, 11, 42, 2, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -407L,
                column: "Created",
                value: new DateTime(2011, 12, 13, 10, 48, 49, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -406L,
                column: "Created",
                value: new DateTime(2011, 12, 30, 8, 55, 35, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -405L,
                column: "Created",
                value: new DateTime(2012, 1, 16, 6, 2, 20, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -404L,
                column: "Created",
                value: new DateTime(2012, 2, 2, 2, 9, 4, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -403L,
                column: "Created",
                value: new DateTime(2012, 2, 18, 21, 15, 47, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -402L,
                column: "Created",
                value: new DateTime(2012, 3, 6, 15, 22, 29, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -401L,
                column: "Created",
                value: new DateTime(2012, 3, 23, 8, 29, 10, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -400L,
                column: "Created",
                value: new DateTime(2012, 4, 9, 0, 35, 50, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -399L,
                column: "Created",
                value: new DateTime(2012, 4, 25, 15, 42, 29, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -398L,
                column: "Created",
                value: new DateTime(2012, 5, 12, 5, 49, 7, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -397L,
                column: "Created",
                value: new DateTime(2012, 5, 28, 18, 55, 44, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -396L,
                column: "Created",
                value: new DateTime(2012, 6, 14, 7, 2, 20, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -395L,
                column: "Created",
                value: new DateTime(2012, 6, 30, 18, 8, 55, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -394L,
                column: "Created",
                value: new DateTime(2012, 7, 17, 4, 15, 29, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -393L,
                column: "Created",
                value: new DateTime(2012, 8, 2, 13, 22, 2, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -392L,
                column: "Created",
                value: new DateTime(2012, 8, 18, 21, 28, 34, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -391L,
                column: "Created",
                value: new DateTime(2012, 9, 4, 4, 35, 5, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -390L,
                column: "Created",
                value: new DateTime(2012, 9, 20, 10, 41, 35, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -389L,
                column: "Created",
                value: new DateTime(2012, 10, 6, 15, 48, 4, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -388L,
                column: "Created",
                value: new DateTime(2012, 10, 22, 19, 54, 32, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -387L,
                column: "Created",
                value: new DateTime(2012, 11, 7, 23, 0, 59, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -386L,
                column: "Created",
                value: new DateTime(2012, 11, 24, 1, 7, 25, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -385L,
                column: "Created",
                value: new DateTime(2012, 12, 10, 2, 13, 50, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -384L,
                column: "Created",
                value: new DateTime(2012, 12, 26, 2, 20, 14, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -383L,
                column: "Created",
                value: new DateTime(2013, 1, 11, 1, 26, 37, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -382L,
                column: "Created",
                value: new DateTime(2013, 1, 26, 23, 32, 59, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -381L,
                column: "Created",
                value: new DateTime(2013, 2, 11, 20, 39, 20, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -380L,
                column: "Created",
                value: new DateTime(2013, 2, 27, 16, 45, 40, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -379L,
                column: "Created",
                value: new DateTime(2013, 3, 15, 11, 51, 59, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -378L,
                column: "Created",
                value: new DateTime(2013, 3, 31, 5, 58, 17, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -377L,
                column: "Created",
                value: new DateTime(2013, 4, 15, 23, 4, 34, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -376L,
                column: "Created",
                value: new DateTime(2013, 5, 1, 15, 10, 50, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -375L,
                column: "Created",
                value: new DateTime(2013, 5, 17, 6, 17, 5, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -374L,
                column: "Created",
                value: new DateTime(2013, 6, 1, 20, 23, 19, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -373L,
                column: "Created",
                value: new DateTime(2013, 6, 17, 9, 29, 32, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -372L,
                column: "Created",
                value: new DateTime(2013, 7, 2, 21, 35, 44, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -371L,
                column: "Created",
                value: new DateTime(2013, 7, 18, 8, 41, 55, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -370L,
                column: "Created",
                value: new DateTime(2013, 8, 2, 18, 48, 5, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -369L,
                column: "Created",
                value: new DateTime(2013, 8, 18, 3, 54, 14, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -368L,
                column: "Created",
                value: new DateTime(2013, 9, 2, 12, 0, 22, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -367L,
                column: "Created",
                value: new DateTime(2013, 9, 17, 19, 6, 29, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -366L,
                column: "Created",
                value: new DateTime(2013, 10, 3, 1, 12, 35, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -365L,
                column: "Created",
                value: new DateTime(2013, 10, 18, 6, 18, 40, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -364L,
                column: "Created",
                value: new DateTime(2013, 11, 2, 10, 24, 44, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -363L,
                column: "Created",
                value: new DateTime(2013, 11, 17, 13, 30, 47, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -362L,
                column: "Created",
                value: new DateTime(2013, 12, 2, 15, 36, 49, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -361L,
                column: "Created",
                value: new DateTime(2013, 12, 17, 16, 42, 50, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -360L,
                column: "Created",
                value: new DateTime(2014, 1, 1, 16, 48, 50, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -359L,
                column: "Created",
                value: new DateTime(2014, 1, 16, 15, 54, 49, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -358L,
                column: "Created",
                value: new DateTime(2014, 1, 31, 14, 0, 47, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -357L,
                column: "Created",
                value: new DateTime(2014, 2, 15, 11, 6, 44, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -356L,
                column: "Created",
                value: new DateTime(2014, 3, 2, 7, 12, 40, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -355L,
                column: "Created",
                value: new DateTime(2014, 3, 17, 2, 18, 35, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -354L,
                column: "Created",
                value: new DateTime(2014, 3, 31, 20, 24, 29, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -353L,
                column: "Created",
                value: new DateTime(2014, 4, 15, 13, 30, 22, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -352L,
                column: "Created",
                value: new DateTime(2014, 4, 30, 5, 36, 14, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -351L,
                column: "Created",
                value: new DateTime(2014, 5, 14, 20, 42, 5, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -350L,
                column: "Created",
                value: new DateTime(2014, 5, 29, 10, 47, 55, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -349L,
                column: "Created",
                value: new DateTime(2014, 6, 12, 23, 53, 44, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -348L,
                column: "Created",
                value: new DateTime(2014, 6, 27, 11, 59, 32, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -347L,
                column: "Created",
                value: new DateTime(2014, 7, 11, 23, 5, 19, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -346L,
                column: "Created",
                value: new DateTime(2014, 7, 26, 9, 11, 5, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -345L,
                column: "Created",
                value: new DateTime(2014, 8, 9, 18, 16, 50, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -344L,
                column: "Created",
                value: new DateTime(2014, 8, 24, 2, 22, 34, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -343L,
                column: "Created",
                value: new DateTime(2014, 9, 7, 9, 28, 17, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -342L,
                column: "Created",
                value: new DateTime(2014, 9, 21, 15, 33, 59, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -341L,
                column: "Created",
                value: new DateTime(2014, 10, 5, 20, 39, 40, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -340L,
                column: "Created",
                value: new DateTime(2014, 10, 20, 0, 45, 20, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -339L,
                column: "Created",
                value: new DateTime(2014, 11, 3, 3, 50, 59, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -338L,
                column: "Created",
                value: new DateTime(2014, 11, 17, 5, 56, 37, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -337L,
                column: "Created",
                value: new DateTime(2014, 12, 1, 7, 2, 14, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -336L,
                column: "Created",
                value: new DateTime(2014, 12, 15, 7, 7, 50, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -335L,
                column: "Created",
                value: new DateTime(2014, 12, 29, 6, 13, 25, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -334L,
                column: "Created",
                value: new DateTime(2015, 1, 12, 4, 18, 59, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -333L,
                column: "Created",
                value: new DateTime(2015, 1, 26, 1, 24, 32, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -332L,
                column: "Created",
                value: new DateTime(2015, 2, 8, 21, 30, 4, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -331L,
                column: "Created",
                value: new DateTime(2015, 2, 22, 16, 35, 35, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -330L,
                column: "Created",
                value: new DateTime(2015, 3, 8, 10, 41, 5, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -329L,
                column: "Created",
                value: new DateTime(2015, 3, 22, 3, 46, 34, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -328L,
                column: "Created",
                value: new DateTime(2015, 4, 4, 19, 52, 2, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -327L,
                column: "Created",
                value: new DateTime(2015, 4, 18, 10, 57, 29, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -326L,
                column: "Created",
                value: new DateTime(2015, 5, 2, 1, 2, 55, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -325L,
                column: "Created",
                value: new DateTime(2015, 5, 15, 14, 8, 20, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -324L,
                column: "Created",
                value: new DateTime(2015, 5, 29, 2, 13, 44, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -323L,
                column: "Created",
                value: new DateTime(2015, 6, 11, 13, 19, 7, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -322L,
                column: "Created",
                value: new DateTime(2015, 6, 24, 23, 24, 29, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -321L,
                column: "Created",
                value: new DateTime(2015, 7, 8, 8, 29, 50, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -320L,
                column: "Created",
                value: new DateTime(2015, 7, 21, 16, 35, 10, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -319L,
                column: "Created",
                value: new DateTime(2015, 8, 3, 23, 40, 29, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -318L,
                column: "Created",
                value: new DateTime(2015, 8, 17, 5, 45, 47, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -317L,
                column: "Created",
                value: new DateTime(2015, 8, 30, 10, 51, 4, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -316L,
                column: "Created",
                value: new DateTime(2015, 9, 12, 14, 56, 20, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -315L,
                column: "Created",
                value: new DateTime(2015, 9, 25, 18, 1, 35, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -314L,
                column: "Created",
                value: new DateTime(2015, 10, 8, 20, 6, 49, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -313L,
                column: "Created",
                value: new DateTime(2015, 10, 21, 21, 12, 2, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -312L,
                column: "Created",
                value: new DateTime(2015, 11, 3, 21, 17, 14, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -311L,
                column: "Created",
                value: new DateTime(2015, 11, 16, 20, 22, 25, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -310L,
                column: "Created",
                value: new DateTime(2015, 11, 29, 18, 27, 35, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -309L,
                column: "Created",
                value: new DateTime(2015, 12, 12, 15, 32, 44, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -308L,
                column: "Created",
                value: new DateTime(2015, 12, 25, 11, 37, 52, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -307L,
                column: "Created",
                value: new DateTime(2016, 1, 7, 6, 42, 59, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -306L,
                column: "Created",
                value: new DateTime(2016, 1, 20, 0, 48, 5, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -305L,
                column: "Created",
                value: new DateTime(2016, 2, 1, 17, 53, 10, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -304L,
                column: "Created",
                value: new DateTime(2016, 2, 14, 9, 58, 14, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -303L,
                column: "Created",
                value: new DateTime(2016, 2, 27, 1, 3, 17, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -302L,
                column: "Created",
                value: new DateTime(2016, 3, 10, 15, 8, 19, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -301L,
                column: "Created",
                value: new DateTime(2016, 3, 23, 4, 13, 20, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -300L,
                column: "Created",
                value: new DateTime(2016, 4, 4, 16, 18, 20, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -299L,
                column: "Created",
                value: new DateTime(2016, 4, 17, 3, 23, 19, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -298L,
                column: "Created",
                value: new DateTime(2016, 4, 29, 13, 28, 17, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -297L,
                column: "Created",
                value: new DateTime(2016, 5, 11, 22, 33, 14, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -296L,
                column: "Created",
                value: new DateTime(2016, 5, 24, 6, 38, 10, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -295L,
                column: "Created",
                value: new DateTime(2016, 6, 5, 13, 43, 5, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -294L,
                column: "Created",
                value: new DateTime(2016, 6, 17, 19, 47, 59, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -293L,
                column: "Created",
                value: new DateTime(2016, 6, 30, 0, 52, 52, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -292L,
                column: "Created",
                value: new DateTime(2016, 7, 12, 4, 57, 44, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -291L,
                column: "Created",
                value: new DateTime(2016, 7, 24, 8, 2, 35, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -290L,
                column: "Created",
                value: new DateTime(2016, 8, 5, 10, 7, 25, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -289L,
                column: "Created",
                value: new DateTime(2016, 8, 17, 11, 12, 14, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -288L,
                column: "Created",
                value: new DateTime(2016, 8, 29, 11, 17, 2, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -287L,
                column: "Created",
                value: new DateTime(2016, 9, 10, 10, 21, 49, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -286L,
                column: "Created",
                value: new DateTime(2016, 9, 22, 8, 26, 35, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -285L,
                column: "Created",
                value: new DateTime(2016, 10, 4, 5, 31, 20, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -284L,
                column: "Created",
                value: new DateTime(2016, 10, 16, 1, 36, 4, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -283L,
                column: "Created",
                value: new DateTime(2016, 10, 27, 20, 40, 47, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -282L,
                column: "Created",
                value: new DateTime(2016, 11, 8, 14, 45, 29, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -281L,
                column: "Created",
                value: new DateTime(2016, 11, 20, 7, 50, 10, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -280L,
                column: "Created",
                value: new DateTime(2016, 12, 1, 23, 54, 50, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -279L,
                column: "Created",
                value: new DateTime(2016, 12, 13, 14, 59, 29, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -278L,
                column: "Created",
                value: new DateTime(2016, 12, 25, 5, 4, 7, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -277L,
                column: "Created",
                value: new DateTime(2017, 1, 5, 18, 8, 44, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -276L,
                column: "Created",
                value: new DateTime(2017, 1, 17, 6, 13, 20, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -275L,
                column: "Created",
                value: new DateTime(2017, 1, 28, 17, 17, 55, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -274L,
                column: "Created",
                value: new DateTime(2017, 2, 9, 3, 22, 29, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -273L,
                column: "Created",
                value: new DateTime(2017, 2, 20, 12, 27, 2, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -272L,
                column: "Created",
                value: new DateTime(2017, 3, 3, 20, 31, 34, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -271L,
                column: "Created",
                value: new DateTime(2017, 3, 15, 3, 36, 5, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -270L,
                column: "Created",
                value: new DateTime(2017, 3, 26, 9, 40, 35, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -269L,
                column: "Created",
                value: new DateTime(2017, 4, 6, 14, 45, 4, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -268L,
                column: "Created",
                value: new DateTime(2017, 4, 17, 18, 49, 32, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -267L,
                column: "Created",
                value: new DateTime(2017, 4, 28, 21, 53, 59, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -266L,
                column: "Created",
                value: new DateTime(2017, 5, 9, 23, 58, 25, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -265L,
                column: "Created",
                value: new DateTime(2017, 5, 21, 1, 2, 50, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -264L,
                column: "Created",
                value: new DateTime(2017, 6, 1, 1, 7, 14, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -263L,
                column: "Created",
                value: new DateTime(2017, 6, 12, 0, 11, 37, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -262L,
                column: "Created",
                value: new DateTime(2017, 6, 22, 22, 15, 59, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -261L,
                column: "Created",
                value: new DateTime(2017, 7, 3, 19, 20, 20, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -260L,
                column: "Created",
                value: new DateTime(2017, 7, 14, 15, 24, 40, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -259L,
                column: "Created",
                value: new DateTime(2017, 7, 25, 10, 28, 59, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -258L,
                column: "Created",
                value: new DateTime(2017, 8, 5, 4, 33, 17, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -257L,
                column: "Created",
                value: new DateTime(2017, 8, 15, 21, 37, 34, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -256L,
                column: "Created",
                value: new DateTime(2017, 8, 26, 13, 41, 50, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -255L,
                column: "Created",
                value: new DateTime(2017, 9, 6, 4, 46, 5, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -254L,
                column: "Created",
                value: new DateTime(2017, 9, 16, 18, 50, 19, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -253L,
                column: "Created",
                value: new DateTime(2017, 9, 27, 7, 54, 32, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -252L,
                column: "Created",
                value: new DateTime(2017, 10, 7, 19, 58, 44, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -251L,
                column: "Created",
                value: new DateTime(2017, 10, 18, 7, 2, 55, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -250L,
                column: "Created",
                value: new DateTime(2017, 10, 28, 17, 7, 5, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -249L,
                column: "Created",
                value: new DateTime(2017, 11, 8, 2, 11, 14, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -248L,
                column: "Created",
                value: new DateTime(2017, 11, 18, 10, 15, 22, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -247L,
                column: "Created",
                value: new DateTime(2017, 11, 28, 17, 19, 29, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -246L,
                column: "Created",
                value: new DateTime(2017, 12, 8, 23, 23, 35, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -245L,
                column: "Created",
                value: new DateTime(2017, 12, 19, 4, 27, 40, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -244L,
                column: "Created",
                value: new DateTime(2017, 12, 29, 8, 31, 44, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -243L,
                column: "Created",
                value: new DateTime(2018, 1, 8, 11, 35, 47, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -242L,
                column: "Created",
                value: new DateTime(2018, 1, 18, 13, 39, 49, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -241L,
                column: "Created",
                value: new DateTime(2018, 1, 28, 14, 43, 50, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -240L,
                column: "Created",
                value: new DateTime(2018, 2, 7, 14, 47, 50, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -239L,
                column: "Created",
                value: new DateTime(2018, 2, 17, 13, 51, 49, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -238L,
                column: "Created",
                value: new DateTime(2018, 2, 27, 11, 55, 47, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -237L,
                column: "Created",
                value: new DateTime(2018, 3, 9, 8, 59, 44, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -236L,
                column: "Created",
                value: new DateTime(2018, 3, 19, 5, 3, 40, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -235L,
                column: "Created",
                value: new DateTime(2018, 3, 29, 0, 7, 35, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -234L,
                column: "Created",
                value: new DateTime(2018, 4, 7, 18, 11, 29, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -233L,
                column: "Created",
                value: new DateTime(2018, 4, 17, 11, 15, 22, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -232L,
                column: "Created",
                value: new DateTime(2018, 4, 27, 3, 19, 14, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -231L,
                column: "Created",
                value: new DateTime(2018, 5, 6, 18, 23, 5, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -230L,
                column: "Created",
                value: new DateTime(2018, 5, 16, 8, 26, 55, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -229L,
                column: "Created",
                value: new DateTime(2018, 5, 25, 21, 30, 44, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -228L,
                column: "Created",
                value: new DateTime(2018, 6, 4, 9, 34, 32, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -227L,
                column: "Created",
                value: new DateTime(2018, 6, 13, 20, 38, 19, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -226L,
                column: "Created",
                value: new DateTime(2018, 6, 23, 6, 42, 5, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -225L,
                column: "Created",
                value: new DateTime(2018, 7, 2, 15, 45, 50, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -224L,
                column: "Created",
                value: new DateTime(2018, 7, 11, 23, 49, 34, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -223L,
                column: "Created",
                value: new DateTime(2018, 7, 21, 6, 53, 17, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -222L,
                column: "Created",
                value: new DateTime(2018, 7, 30, 12, 56, 59, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -221L,
                column: "Created",
                value: new DateTime(2018, 8, 8, 18, 0, 40, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -220L,
                column: "Created",
                value: new DateTime(2018, 8, 17, 22, 4, 20, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -219L,
                column: "Created",
                value: new DateTime(2018, 8, 27, 1, 7, 59, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -218L,
                column: "Created",
                value: new DateTime(2018, 9, 5, 3, 11, 37, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -217L,
                column: "Created",
                value: new DateTime(2018, 9, 14, 4, 15, 14, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -216L,
                column: "Created",
                value: new DateTime(2018, 9, 23, 4, 18, 50, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -215L,
                column: "Created",
                value: new DateTime(2018, 10, 2, 3, 22, 25, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -214L,
                column: "Created",
                value: new DateTime(2018, 10, 11, 1, 25, 59, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -213L,
                column: "Created",
                value: new DateTime(2018, 10, 19, 22, 29, 32, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -212L,
                column: "Created",
                value: new DateTime(2018, 10, 28, 18, 33, 4, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -211L,
                column: "Created",
                value: new DateTime(2018, 11, 6, 13, 36, 35, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -210L,
                column: "Created",
                value: new DateTime(2018, 11, 15, 7, 40, 5, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -209L,
                column: "Created",
                value: new DateTime(2018, 11, 24, 0, 43, 34, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -208L,
                column: "Created",
                value: new DateTime(2018, 12, 2, 16, 47, 2, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -207L,
                column: "Created",
                value: new DateTime(2018, 12, 11, 7, 50, 29, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -206L,
                column: "Created",
                value: new DateTime(2018, 12, 19, 21, 53, 55, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -205L,
                column: "Created",
                value: new DateTime(2018, 12, 28, 10, 57, 20, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -204L,
                column: "Created",
                value: new DateTime(2019, 1, 5, 23, 0, 44, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -203L,
                column: "Created",
                value: new DateTime(2019, 1, 14, 10, 4, 7, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -202L,
                column: "Created",
                value: new DateTime(2019, 1, 22, 20, 7, 29, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -201L,
                column: "Created",
                value: new DateTime(2019, 1, 31, 5, 10, 50, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -200L,
                column: "Created",
                value: new DateTime(2019, 2, 8, 13, 14, 10, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -199L,
                column: "Created",
                value: new DateTime(2019, 2, 16, 20, 17, 29, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -198L,
                column: "Created",
                value: new DateTime(2019, 2, 25, 2, 20, 47, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -197L,
                column: "Created",
                value: new DateTime(2019, 3, 5, 7, 24, 4, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -196L,
                column: "Created",
                value: new DateTime(2019, 3, 13, 11, 27, 20, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -195L,
                column: "Created",
                value: new DateTime(2019, 3, 21, 14, 30, 35, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -194L,
                column: "Created",
                value: new DateTime(2019, 3, 29, 16, 33, 49, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -193L,
                column: "Created",
                value: new DateTime(2019, 4, 6, 17, 37, 2, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -192L,
                column: "Created",
                value: new DateTime(2019, 4, 14, 17, 40, 14, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -191L,
                column: "Created",
                value: new DateTime(2019, 4, 22, 16, 43, 25, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -190L,
                column: "Created",
                value: new DateTime(2019, 4, 30, 14, 46, 35, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -189L,
                column: "Created",
                value: new DateTime(2019, 5, 8, 11, 49, 44, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -188L,
                column: "Created",
                value: new DateTime(2019, 5, 16, 7, 52, 52, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -187L,
                column: "Created",
                value: new DateTime(2019, 5, 24, 2, 55, 59, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -186L,
                column: "Created",
                value: new DateTime(2019, 5, 31, 20, 59, 5, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -185L,
                column: "Created",
                value: new DateTime(2019, 6, 8, 14, 2, 10, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -184L,
                column: "Created",
                value: new DateTime(2019, 6, 16, 6, 5, 14, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -183L,
                column: "Created",
                value: new DateTime(2019, 6, 23, 21, 8, 17, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -182L,
                column: "Created",
                value: new DateTime(2019, 7, 1, 11, 11, 19, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -181L,
                column: "Created",
                value: new DateTime(2019, 7, 9, 0, 14, 20, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -180L,
                column: "Created",
                value: new DateTime(2019, 7, 16, 12, 17, 20, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -179L,
                column: "Created",
                value: new DateTime(2019, 7, 23, 23, 20, 19, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -178L,
                column: "Created",
                value: new DateTime(2019, 7, 31, 9, 23, 17, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -177L,
                column: "Created",
                value: new DateTime(2019, 8, 7, 18, 26, 14, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -176L,
                column: "Created",
                value: new DateTime(2019, 8, 15, 2, 29, 10, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -175L,
                column: "Created",
                value: new DateTime(2019, 8, 22, 9, 32, 5, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -174L,
                column: "Created",
                value: new DateTime(2019, 8, 29, 15, 34, 59, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -173L,
                column: "Created",
                value: new DateTime(2019, 9, 5, 20, 37, 52, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -172L,
                column: "Created",
                value: new DateTime(2019, 9, 13, 0, 40, 44, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -171L,
                column: "Created",
                value: new DateTime(2019, 9, 20, 3, 43, 35, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -170L,
                column: "Created",
                value: new DateTime(2019, 9, 27, 5, 46, 25, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -169L,
                column: "Created",
                value: new DateTime(2019, 10, 4, 6, 49, 14, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -168L,
                column: "Created",
                value: new DateTime(2019, 10, 11, 6, 52, 2, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -167L,
                column: "Created",
                value: new DateTime(2019, 10, 18, 5, 54, 49, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -166L,
                column: "Created",
                value: new DateTime(2019, 10, 25, 3, 57, 35, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -165L,
                column: "Created",
                value: new DateTime(2019, 11, 1, 1, 0, 20, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -164L,
                column: "Created",
                value: new DateTime(2019, 11, 7, 21, 3, 4, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -163L,
                column: "Created",
                value: new DateTime(2019, 11, 14, 16, 5, 47, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -162L,
                column: "Created",
                value: new DateTime(2019, 11, 21, 10, 8, 29, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -161L,
                column: "Created",
                value: new DateTime(2019, 11, 28, 3, 11, 10, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -160L,
                column: "Created",
                value: new DateTime(2019, 12, 4, 19, 13, 50, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -159L,
                column: "Created",
                value: new DateTime(2019, 12, 11, 10, 16, 29, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -158L,
                column: "Created",
                value: new DateTime(2019, 12, 18, 0, 19, 7, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -157L,
                column: "Created",
                value: new DateTime(2019, 12, 24, 13, 21, 44, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -156L,
                column: "Created",
                value: new DateTime(2019, 12, 31, 1, 24, 20, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -155L,
                column: "Created",
                value: new DateTime(2020, 1, 6, 12, 26, 55, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -154L,
                column: "Created",
                value: new DateTime(2020, 1, 12, 22, 29, 29, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -153L,
                column: "Created",
                value: new DateTime(2020, 1, 19, 7, 32, 2, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -152L,
                column: "Created",
                value: new DateTime(2020, 1, 25, 15, 34, 34, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -151L,
                column: "Created",
                value: new DateTime(2020, 1, 31, 22, 37, 5, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -150L,
                column: "Created",
                value: new DateTime(2020, 2, 7, 4, 39, 35, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -149L,
                column: "Created",
                value: new DateTime(2020, 2, 13, 9, 42, 4, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -148L,
                column: "Created",
                value: new DateTime(2020, 2, 19, 13, 44, 32, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -147L,
                column: "Created",
                value: new DateTime(2020, 2, 25, 16, 46, 59, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -146L,
                column: "Created",
                value: new DateTime(2020, 3, 2, 18, 49, 25, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -145L,
                column: "Created",
                value: new DateTime(2020, 3, 8, 19, 51, 50, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -144L,
                column: "Created",
                value: new DateTime(2020, 3, 14, 19, 54, 14, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -143L,
                column: "Created",
                value: new DateTime(2020, 3, 20, 18, 56, 37, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -142L,
                column: "Created",
                value: new DateTime(2020, 3, 26, 16, 58, 59, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -141L,
                column: "Created",
                value: new DateTime(2020, 4, 1, 14, 1, 20, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -140L,
                column: "Created",
                value: new DateTime(2020, 4, 7, 10, 3, 40, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -139L,
                column: "Created",
                value: new DateTime(2020, 4, 13, 5, 5, 59, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -138L,
                column: "Created",
                value: new DateTime(2020, 4, 18, 23, 8, 17, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -137L,
                column: "Created",
                value: new DateTime(2020, 4, 24, 16, 10, 34, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -136L,
                column: "Created",
                value: new DateTime(2020, 4, 30, 8, 12, 50, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -135L,
                column: "Created",
                value: new DateTime(2020, 5, 5, 23, 15, 5, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -134L,
                column: "Created",
                value: new DateTime(2020, 5, 11, 13, 17, 19, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -133L,
                column: "Created",
                value: new DateTime(2020, 5, 17, 2, 19, 32, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -132L,
                column: "Created",
                value: new DateTime(2020, 5, 22, 14, 21, 44, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -131L,
                column: "Created",
                value: new DateTime(2020, 5, 28, 1, 23, 55, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -130L,
                column: "Created",
                value: new DateTime(2020, 6, 2, 11, 26, 5, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -129L,
                column: "Created",
                value: new DateTime(2020, 6, 7, 20, 28, 14, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -128L,
                column: "Created",
                value: new DateTime(2020, 6, 13, 4, 30, 22, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -127L,
                column: "Created",
                value: new DateTime(2020, 6, 18, 11, 32, 29, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -126L,
                column: "Created",
                value: new DateTime(2020, 6, 23, 17, 34, 35, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -125L,
                column: "Created",
                value: new DateTime(2020, 6, 28, 22, 36, 40, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -124L,
                column: "Created",
                value: new DateTime(2020, 7, 4, 2, 38, 44, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -123L,
                column: "Created",
                value: new DateTime(2020, 7, 9, 5, 40, 47, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -122L,
                column: "Created",
                value: new DateTime(2020, 7, 14, 7, 42, 49, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -121L,
                column: "Created",
                value: new DateTime(2020, 7, 19, 8, 44, 50, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -120L,
                column: "Created",
                value: new DateTime(2020, 7, 24, 8, 46, 50, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -119L,
                column: "Created",
                value: new DateTime(2020, 7, 29, 7, 48, 49, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -118L,
                column: "Created",
                value: new DateTime(2020, 8, 3, 5, 50, 47, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -117L,
                column: "Created",
                value: new DateTime(2020, 8, 8, 2, 52, 44, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -116L,
                column: "Created",
                value: new DateTime(2020, 8, 12, 22, 54, 40, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -115L,
                column: "Created",
                value: new DateTime(2020, 8, 17, 17, 56, 35, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -114L,
                column: "Created",
                value: new DateTime(2020, 8, 22, 11, 58, 29, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -113L,
                column: "Created",
                value: new DateTime(2020, 8, 27, 5, 0, 22, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -112L,
                column: "Created",
                value: new DateTime(2020, 8, 31, 21, 2, 14, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -111L,
                column: "Created",
                value: new DateTime(2020, 9, 5, 12, 4, 5, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -110L,
                column: "Created",
                value: new DateTime(2020, 9, 10, 2, 5, 55, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -109L,
                column: "Created",
                value: new DateTime(2020, 9, 14, 15, 7, 44, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -108L,
                column: "Created",
                value: new DateTime(2020, 9, 19, 3, 9, 32, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -107L,
                column: "Created",
                value: new DateTime(2020, 9, 23, 14, 11, 19, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -106L,
                column: "Created",
                value: new DateTime(2020, 9, 28, 0, 13, 5, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -105L,
                column: "Created",
                value: new DateTime(2020, 10, 2, 9, 14, 50, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -104L,
                column: "Created",
                value: new DateTime(2020, 10, 6, 17, 16, 34, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -103L,
                column: "Created",
                value: new DateTime(2020, 10, 11, 0, 18, 17, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -102L,
                column: "Created",
                value: new DateTime(2020, 10, 15, 6, 19, 59, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -101L,
                column: "Created",
                value: new DateTime(2020, 10, 19, 11, 21, 40, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -100L,
                column: "Created",
                value: new DateTime(2020, 10, 23, 15, 23, 20, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -99L,
                column: "Created",
                value: new DateTime(2020, 10, 27, 18, 24, 59, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -98L,
                column: "Created",
                value: new DateTime(2020, 10, 31, 20, 26, 37, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -97L,
                column: "Created",
                value: new DateTime(2020, 11, 4, 21, 28, 14, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -96L,
                column: "Created",
                value: new DateTime(2020, 11, 8, 21, 29, 50, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -95L,
                column: "Created",
                value: new DateTime(2020, 11, 12, 20, 31, 25, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -94L,
                column: "Created",
                value: new DateTime(2020, 11, 16, 18, 32, 59, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -93L,
                column: "Created",
                value: new DateTime(2020, 11, 20, 15, 34, 32, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -92L,
                column: "Created",
                value: new DateTime(2020, 11, 24, 11, 36, 4, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -91L,
                column: "Created",
                value: new DateTime(2020, 11, 28, 6, 37, 35, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -90L,
                column: "Created",
                value: new DateTime(2020, 12, 2, 0, 39, 5, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -89L,
                column: "Created",
                value: new DateTime(2020, 12, 5, 17, 40, 34, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -88L,
                column: "Created",
                value: new DateTime(2020, 12, 9, 9, 42, 2, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -87L,
                column: "Created",
                value: new DateTime(2020, 12, 13, 0, 43, 29, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -86L,
                column: "Created",
                value: new DateTime(2020, 12, 16, 14, 44, 55, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -85L,
                column: "Created",
                value: new DateTime(2020, 12, 20, 3, 46, 20, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -84L,
                column: "Created",
                value: new DateTime(2020, 12, 23, 15, 47, 44, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -83L,
                column: "Created",
                value: new DateTime(2020, 12, 27, 2, 49, 7, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -82L,
                column: "Created",
                value: new DateTime(2020, 12, 30, 12, 50, 29, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -81L,
                column: "Created",
                value: new DateTime(2021, 1, 2, 21, 51, 50, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -80L,
                column: "Created",
                value: new DateTime(2021, 1, 6, 5, 53, 10, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -79L,
                column: "Created",
                value: new DateTime(2021, 1, 9, 12, 54, 29, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -78L,
                column: "Created",
                value: new DateTime(2021, 1, 12, 18, 55, 47, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -77L,
                column: "Created",
                value: new DateTime(2021, 1, 15, 23, 57, 4, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -76L,
                column: "Created",
                value: new DateTime(2021, 1, 19, 3, 58, 20, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -75L,
                column: "Created",
                value: new DateTime(2021, 1, 22, 6, 59, 35, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -74L,
                column: "Created",
                value: new DateTime(2021, 1, 25, 9, 0, 49, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -73L,
                column: "Created",
                value: new DateTime(2021, 1, 28, 10, 2, 2, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -72L,
                column: "Created",
                value: new DateTime(2021, 1, 31, 10, 3, 14, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -71L,
                column: "Created",
                value: new DateTime(2021, 2, 3, 9, 4, 25, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -70L,
                column: "Created",
                value: new DateTime(2021, 2, 6, 7, 5, 35, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -69L,
                column: "Created",
                value: new DateTime(2021, 2, 9, 4, 6, 44, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -68L,
                column: "Created",
                value: new DateTime(2021, 2, 12, 0, 7, 52, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -67L,
                column: "Created",
                value: new DateTime(2021, 2, 14, 19, 8, 59, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -66L,
                column: "Created",
                value: new DateTime(2021, 2, 17, 13, 10, 5, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -65L,
                column: "Created",
                value: new DateTime(2021, 2, 20, 6, 11, 10, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -64L,
                column: "Created",
                value: new DateTime(2021, 2, 22, 22, 12, 14, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -63L,
                column: "Created",
                value: new DateTime(2021, 2, 25, 13, 13, 17, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -62L,
                column: "Created",
                value: new DateTime(2021, 2, 28, 3, 14, 19, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -61L,
                column: "Created",
                value: new DateTime(2021, 3, 2, 16, 15, 20, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -60L,
                column: "Created",
                value: new DateTime(2021, 3, 5, 4, 16, 20, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -59L,
                column: "Created",
                value: new DateTime(2021, 3, 7, 15, 17, 19, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -58L,
                column: "Created",
                value: new DateTime(2021, 3, 10, 1, 18, 17, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -57L,
                column: "Created",
                value: new DateTime(2021, 3, 12, 10, 19, 14, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -56L,
                column: "Created",
                value: new DateTime(2021, 3, 14, 18, 20, 10, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -55L,
                column: "Created",
                value: new DateTime(2021, 3, 17, 1, 21, 5, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -54L,
                column: "Created",
                value: new DateTime(2021, 3, 19, 7, 21, 59, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -53L,
                column: "Created",
                value: new DateTime(2021, 3, 21, 12, 22, 52, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -52L,
                column: "Created",
                value: new DateTime(2021, 3, 23, 16, 23, 44, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -51L,
                column: "Created",
                value: new DateTime(2021, 3, 25, 19, 24, 35, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -50L,
                column: "Created",
                value: new DateTime(2021, 3, 27, 21, 25, 25, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -49L,
                column: "Created",
                value: new DateTime(2021, 3, 29, 22, 26, 14, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -48L,
                column: "Created",
                value: new DateTime(2021, 3, 31, 22, 27, 2, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -47L,
                column: "Created",
                value: new DateTime(2021, 4, 2, 21, 27, 49, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -46L,
                column: "Created",
                value: new DateTime(2021, 4, 4, 19, 28, 35, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -45L,
                column: "Created",
                value: new DateTime(2021, 4, 6, 16, 29, 20, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -44L,
                column: "Created",
                value: new DateTime(2021, 4, 8, 12, 30, 4, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -43L,
                column: "Created",
                value: new DateTime(2021, 4, 10, 7, 30, 47, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -42L,
                column: "Created",
                value: new DateTime(2021, 4, 12, 1, 31, 29, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -41L,
                column: "Created",
                value: new DateTime(2021, 4, 13, 18, 32, 10, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -40L,
                column: "Created",
                value: new DateTime(2021, 4, 15, 10, 32, 50, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -39L,
                column: "Created",
                value: new DateTime(2021, 4, 17, 1, 33, 29, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -38L,
                column: "Created",
                value: new DateTime(2021, 4, 18, 15, 34, 7, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -37L,
                column: "Created",
                value: new DateTime(2021, 4, 20, 4, 34, 44, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -36L,
                column: "Created",
                value: new DateTime(2021, 4, 21, 16, 35, 20, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -35L,
                column: "Created",
                value: new DateTime(2021, 4, 23, 3, 35, 55, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -34L,
                column: "Created",
                value: new DateTime(2021, 4, 24, 13, 36, 29, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -33L,
                column: "Created",
                value: new DateTime(2021, 4, 25, 22, 37, 2, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -32L,
                column: "Created",
                value: new DateTime(2021, 4, 27, 6, 37, 34, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -31L,
                column: "Created",
                value: new DateTime(2021, 4, 28, 13, 38, 5, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -30L,
                column: "Created",
                value: new DateTime(2021, 4, 29, 19, 38, 35, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -29L,
                column: "Created",
                value: new DateTime(2021, 5, 1, 0, 39, 4, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -28L,
                column: "Created",
                value: new DateTime(2021, 5, 2, 4, 39, 32, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -27L,
                column: "Created",
                value: new DateTime(2021, 5, 3, 7, 39, 59, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -26L,
                column: "Created",
                value: new DateTime(2021, 5, 4, 9, 40, 25, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -25L,
                column: "Created",
                value: new DateTime(2021, 5, 5, 10, 40, 50, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -24L,
                column: "Created",
                value: new DateTime(2021, 5, 6, 10, 41, 14, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -23L,
                column: "Created",
                value: new DateTime(2021, 5, 7, 9, 41, 37, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -22L,
                column: "Created",
                value: new DateTime(2021, 5, 8, 7, 41, 59, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -21L,
                column: "Created",
                value: new DateTime(2021, 5, 9, 4, 42, 20, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -20L,
                column: "Created",
                value: new DateTime(2021, 5, 10, 0, 42, 40, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -19L,
                column: "Created",
                value: new DateTime(2021, 5, 10, 19, 42, 59, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -18L,
                column: "Created",
                value: new DateTime(2021, 5, 11, 13, 43, 17, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -17L,
                column: "Created",
                value: new DateTime(2021, 5, 12, 6, 43, 34, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -16L,
                column: "Created",
                value: new DateTime(2021, 5, 12, 22, 43, 50, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -15L,
                column: "Created",
                value: new DateTime(2021, 5, 13, 13, 44, 5, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -14L,
                column: "Created",
                value: new DateTime(2021, 5, 14, 3, 44, 19, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -13L,
                column: "Created",
                value: new DateTime(2021, 5, 14, 16, 44, 32, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -12L,
                column: "Created",
                value: new DateTime(2021, 5, 15, 4, 44, 44, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -11L,
                column: "Created",
                value: new DateTime(2021, 5, 15, 15, 44, 55, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -10L,
                column: "Created",
                value: new DateTime(2021, 5, 16, 1, 45, 5, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -9L,
                column: "Created",
                value: new DateTime(2021, 5, 16, 10, 45, 14, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -8L,
                column: "Created",
                value: new DateTime(2021, 5, 16, 18, 45, 22, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -7L,
                column: "Created",
                value: new DateTime(2021, 5, 17, 1, 45, 29, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -6L,
                column: "Created",
                value: new DateTime(2021, 5, 17, 7, 45, 35, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -5L,
                column: "Created",
                value: new DateTime(2021, 5, 17, 12, 45, 40, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -4L,
                column: "Created",
                value: new DateTime(2021, 5, 17, 16, 45, 44, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -3L,
                column: "Created",
                value: new DateTime(2021, 5, 17, 19, 45, 47, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -2L,
                column: "Created",
                value: new DateTime(2021, 5, 17, 21, 45, 49, 920, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: -1L,
                column: "Created",
                value: new DateTime(2021, 5, 17, 22, 45, 50, 920, DateTimeKind.Utc).AddTicks(3977));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Created",
                table: "Messages");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "migrationuserId0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9dfee321-be7d-4faa-8f15-5693b90109fa", "AQAAAAEAACcQAAAAELcyMGGVEkGBAnj6+/4vvVuoZzSScasW/SHf3dNdYsx1PlFnYriZydmqzCIi6tAp/Q==", "91af06c6-ab25-421b-b37c-3220bb2d42b2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "migrationuserId1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2ea25e2e-daa9-4e73-acc4-fb3428959a28", "AQAAAAEAACcQAAAAEAMSDjzEhN31d70KLnOq6P5ndxIgPC7kNQ1/rAFnFMimQJ9PdtnlSTYeEhsdJBRECA==", "f6fa9d2b-52b3-40b2-b96e-ac45ec20206f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "migrationuserId2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cb8795be-a7ab-4766-93a6-768cc3e83077", "AQAAAAEAACcQAAAAELNWl15Qi07nDAzkyGJNTCV89u/PmJTlMLXGhuOagvyHd+Kyj0UJ1dS5vUBOduCGXg==", "4a4b02a4-e382-4a70-bc1f-d6629f80fd06" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "migrationuserId3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5d4d2d0e-4617-448d-a658-7d94b081a4eb", "AQAAAAEAACcQAAAAEBRbA0wKUP1zfL/G/o1MM6x8W8EEUSvxWYcwy9BhDqVbag3OBCHZMaQJkQ/95XrEww==", "444cac34-9e7b-4530-9348-f19e1148f6aa" });
        }
    }
}
