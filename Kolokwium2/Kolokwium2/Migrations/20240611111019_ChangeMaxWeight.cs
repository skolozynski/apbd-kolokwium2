using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Kolokwium2.Migrations
{
    /// <inheritdoc />
    public partial class ChangeMaxWeight : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "charachters",
                keyColumn: "Id",
                keyValue: 1,
                column: "MaxWeight",
                value: 200);

            migrationBuilder.UpdateData(
                table: "charachters",
                keyColumn: "Id",
                keyValue: 2,
                column: "MaxWeight",
                value: 320);

            migrationBuilder.UpdateData(
                table: "charachters",
                keyColumn: "Id",
                keyValue: 3,
                column: "MaxWeight",
                value: 180);

            migrationBuilder.UpdateData(
                table: "character_titles",
                keyColumns: new[] { "CharacterId", "TitleId" },
                keyValues: new object[] { 1, 1 },
                column: "AcquiredAt",
                value: new DateTime(2024, 6, 11, 13, 10, 18, 939, DateTimeKind.Local).AddTicks(2072));

            migrationBuilder.UpdateData(
                table: "character_titles",
                keyColumns: new[] { "CharacterId", "TitleId" },
                keyValues: new object[] { 1, 2 },
                column: "AcquiredAt",
                value: new DateTime(2024, 6, 11, 13, 10, 18, 939, DateTimeKind.Local).AddTicks(2114));

            migrationBuilder.UpdateData(
                table: "character_titles",
                keyColumns: new[] { "CharacterId", "TitleId" },
                keyValues: new object[] { 1, 3 },
                column: "AcquiredAt",
                value: new DateTime(2024, 6, 11, 13, 10, 18, 939, DateTimeKind.Local).AddTicks(2116));

            migrationBuilder.UpdateData(
                table: "character_titles",
                keyColumns: new[] { "CharacterId", "TitleId" },
                keyValues: new object[] { 2, 1 },
                column: "AcquiredAt",
                value: new DateTime(2024, 6, 11, 13, 10, 18, 939, DateTimeKind.Local).AddTicks(2118));

            migrationBuilder.UpdateData(
                table: "character_titles",
                keyColumns: new[] { "CharacterId", "TitleId" },
                keyValues: new object[] { 3, 2 },
                column: "AcquiredAt",
                value: new DateTime(2024, 6, 11, 13, 10, 18, 939, DateTimeKind.Local).AddTicks(2120));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "charachters",
                keyColumn: "Id",
                keyValue: 1,
                column: "MaxWeight",
                value: 20);

            migrationBuilder.UpdateData(
                table: "charachters",
                keyColumn: "Id",
                keyValue: 2,
                column: "MaxWeight",
                value: 32);

            migrationBuilder.UpdateData(
                table: "charachters",
                keyColumn: "Id",
                keyValue: 3,
                column: "MaxWeight",
                value: 18);

            migrationBuilder.UpdateData(
                table: "character_titles",
                keyColumns: new[] { "CharacterId", "TitleId" },
                keyValues: new object[] { 1, 1 },
                column: "AcquiredAt",
                value: new DateTime(2024, 6, 11, 12, 56, 57, 662, DateTimeKind.Local).AddTicks(3439));

            migrationBuilder.UpdateData(
                table: "character_titles",
                keyColumns: new[] { "CharacterId", "TitleId" },
                keyValues: new object[] { 1, 2 },
                column: "AcquiredAt",
                value: new DateTime(2024, 6, 11, 12, 56, 57, 662, DateTimeKind.Local).AddTicks(3483));

            migrationBuilder.UpdateData(
                table: "character_titles",
                keyColumns: new[] { "CharacterId", "TitleId" },
                keyValues: new object[] { 1, 3 },
                column: "AcquiredAt",
                value: new DateTime(2024, 6, 11, 12, 56, 57, 662, DateTimeKind.Local).AddTicks(3485));

            migrationBuilder.UpdateData(
                table: "character_titles",
                keyColumns: new[] { "CharacterId", "TitleId" },
                keyValues: new object[] { 2, 1 },
                column: "AcquiredAt",
                value: new DateTime(2024, 6, 11, 12, 56, 57, 662, DateTimeKind.Local).AddTicks(3487));

            migrationBuilder.UpdateData(
                table: "character_titles",
                keyColumns: new[] { "CharacterId", "TitleId" },
                keyValues: new object[] { 3, 2 },
                column: "AcquiredAt",
                value: new DateTime(2024, 6, 11, 12, 56, 57, 662, DateTimeKind.Local).AddTicks(3489));
        }
    }
}
