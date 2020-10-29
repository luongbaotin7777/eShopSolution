using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class examplesclass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 29, 15, 54, 39, 579, DateTimeKind.Local).AddTicks(4256),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 10, 29, 15, 52, 17, 384, DateTimeKind.Local).AddTicks(78));

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "c16367fe-fefd-4ac6-8050-3c059e501619");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3f8d8dbc-f990-4141-b24b-f44bcdfe1d42", "AQAAAAEAACcQAAAAEOGmcCCQ/t27fV3Ph6qrcraWuu7ls1w093/47vvBoTBu5XYuh7pvJRiXwzdl47vxsg==" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 10, 29, 15, 54, 39, 594, DateTimeKind.Local).AddTicks(9728));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2020, 10, 29, 15, 54, 39, 595, DateTimeKind.Local).AddTicks(1534));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 29, 15, 52, 17, 384, DateTimeKind.Local).AddTicks(78),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 10, 29, 15, 54, 39, 579, DateTimeKind.Local).AddTicks(4256));

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "3fd4b812-8333-4918-b82d-ee498e61aee6");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8945ef95-8002-4d4a-91ee-27b9de6a0e9c", "AQAAAAEAACcQAAAAEAPE7nwLJVPcZhLG9AWmwuMQy/eDkYhvFlihwatpjzUtcjN/mSsZzcoudZCKmhWmlQ==" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 10, 29, 15, 52, 17, 399, DateTimeKind.Local).AddTicks(5843));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2020, 10, 29, 15, 52, 17, 399, DateTimeKind.Local).AddTicks(7718));
        }
    }
}
