using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Intalk.Migrations
{
    public partial class CreateTextChannels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TextChannels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: false),
                    ServerId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TextChannels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TextChannels_Server_ServerId",
                        column: x => x.ServerId,
                        principalTable: "Server",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_TextChannels_ServerId",
                table: "TextChannels",
                column: "ServerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TextChannels");

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
        }
    }
}
