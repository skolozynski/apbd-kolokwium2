using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Kolokwium2.Migrations
{
    /// <inheritdoc />
    public partial class AddDbSets : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "character_titles",
                keyColumns: new[] { "CharacterId", "TitleId" },
                keyValues: new object[] { 1, 1 },
                column: "AcquiredAt",
                value: new DateTime(2024, 6, 11, 12, 43, 42, 55, DateTimeKind.Local).AddTicks(3769));

            migrationBuilder.UpdateData(
                table: "character_titles",
                keyColumns: new[] { "CharacterId", "TitleId" },
                keyValues: new object[] { 1, 2 },
                column: "AcquiredAt",
                value: new DateTime(2024, 6, 11, 12, 43, 42, 55, DateTimeKind.Local).AddTicks(3810));

            migrationBuilder.UpdateData(
                table: "character_titles",
                keyColumns: new[] { "CharacterId", "TitleId" },
                keyValues: new object[] { 1, 3 },
                column: "AcquiredAt",
                value: new DateTime(2024, 6, 11, 12, 43, 42, 55, DateTimeKind.Local).AddTicks(3812));

            migrationBuilder.UpdateData(
                table: "character_titles",
                keyColumns: new[] { "CharacterId", "TitleId" },
                keyValues: new object[] { 2, 1 },
                column: "AcquiredAt",
                value: new DateTime(2024, 6, 11, 12, 43, 42, 55, DateTimeKind.Local).AddTicks(3814));

            migrationBuilder.UpdateData(
                table: "character_titles",
                keyColumns: new[] { "CharacterId", "TitleId" },
                keyValues: new object[] { 3, 2 },
                column: "AcquiredAt",
                value: new DateTime(2024, 6, 11, 12, 43, 42, 55, DateTimeKind.Local).AddTicks(3816));
        }
    }
}
