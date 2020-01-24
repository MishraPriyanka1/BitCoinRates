using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DisplayCurrencyRates.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "BitCoinIndexes",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 1, 23, 12, 27, 31, 975, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "BitCoinIndexes",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 1, 22, 12, 27, 31, 978, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "BitCoinIndexes",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 1, 21, 12, 27, 31, 978, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "BitCoinIndexes",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2020, 1, 20, 12, 27, 31, 978, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "BitCoinIndexes",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2020, 1, 19, 12, 27, 31, 978, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "BitCoinIndexes",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2020, 1, 18, 12, 27, 31, 978, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "BitCoinIndexes",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2020, 1, 17, 12, 27, 31, 978, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "BitCoinIndexes",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2020, 1, 16, 12, 27, 31, 978, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "BitCoinIndexes",
                keyColumn: "Id",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2020, 1, 15, 12, 27, 31, 978, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "BitCoinIndexes",
                keyColumn: "Id",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2020, 1, 14, 12, 27, 31, 978, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "BitCoinIndexes",
                keyColumn: "Id",
                keyValue: 11,
                column: "Date",
                value: new DateTime(2020, 1, 13, 12, 27, 31, 978, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "BitCoinIndexes",
                keyColumn: "Id",
                keyValue: 12,
                column: "Date",
                value: new DateTime(2020, 1, 12, 12, 27, 31, 978, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "BitCoinIndexes",
                keyColumn: "Id",
                keyValue: 13,
                column: "Date",
                value: new DateTime(2020, 1, 11, 12, 27, 31, 978, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "BitCoinIndexes",
                keyColumn: "Id",
                keyValue: 14,
                column: "Date",
                value: new DateTime(2020, 1, 10, 12, 27, 31, 978, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "BitCoinIndexes",
                keyColumn: "Id",
                keyValue: 15,
                column: "Date",
                value: new DateTime(2020, 1, 9, 12, 27, 31, 978, DateTimeKind.Local));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "BitCoinIndexes",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 1, 23, 12, 9, 12, 437, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "BitCoinIndexes",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 1, 22, 12, 9, 12, 440, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "BitCoinIndexes",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 1, 21, 12, 9, 12, 440, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "BitCoinIndexes",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2020, 1, 20, 12, 9, 12, 440, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "BitCoinIndexes",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2020, 1, 19, 12, 9, 12, 440, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "BitCoinIndexes",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2020, 1, 18, 12, 9, 12, 440, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "BitCoinIndexes",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2020, 1, 17, 12, 9, 12, 440, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "BitCoinIndexes",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2020, 1, 16, 12, 9, 12, 440, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "BitCoinIndexes",
                keyColumn: "Id",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2020, 1, 15, 12, 9, 12, 440, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "BitCoinIndexes",
                keyColumn: "Id",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2020, 1, 14, 12, 9, 12, 440, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "BitCoinIndexes",
                keyColumn: "Id",
                keyValue: 11,
                column: "Date",
                value: new DateTime(2020, 1, 13, 12, 9, 12, 440, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "BitCoinIndexes",
                keyColumn: "Id",
                keyValue: 12,
                column: "Date",
                value: new DateTime(2020, 1, 12, 12, 9, 12, 440, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "BitCoinIndexes",
                keyColumn: "Id",
                keyValue: 13,
                column: "Date",
                value: new DateTime(2020, 1, 11, 12, 9, 12, 440, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "BitCoinIndexes",
                keyColumn: "Id",
                keyValue: 14,
                column: "Date",
                value: new DateTime(2020, 1, 10, 12, 9, 12, 440, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "BitCoinIndexes",
                keyColumn: "Id",
                keyValue: 15,
                column: "Date",
                value: new DateTime(2020, 1, 9, 12, 9, 12, 440, DateTimeKind.Local));
        }
    }
}
