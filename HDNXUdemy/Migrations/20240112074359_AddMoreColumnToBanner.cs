using Microsoft.EntityFrameworkCore.Migrations;
using NodaTime;

#nullable disable

namespace HDNXUdemyData.Migrations
{
    /// <inheritdoc />
    public partial class AddMoreColumnToBanner : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                schema: "sche_dev_HDNXUdemy",
                table: "Banners",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                schema: "sche_dev_HDNXUdemy",
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new NodaTime.LocalDateTime(2024, 1, 12, 7, 43, 59).PlusNanoseconds(597636800L), new NodaTime.LocalDateTime(2024, 1, 12, 7, 43, 59).PlusNanoseconds(597636800L) });

            migrationBuilder.UpdateData(
                schema: "sche_dev_HDNXUdemy",
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new NodaTime.LocalDateTime(2024, 1, 12, 7, 43, 59).PlusNanoseconds(597636800L), new NodaTime.LocalDateTime(2024, 1, 12, 7, 43, 59).PlusNanoseconds(597636800L) });

            migrationBuilder.UpdateData(
                schema: "sche_dev_HDNXUdemy",
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new NodaTime.LocalDateTime(2024, 1, 12, 7, 43, 59).PlusNanoseconds(597636800L), new NodaTime.LocalDateTime(2024, 1, 12, 7, 43, 59).PlusNanoseconds(597636800L) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                schema: "sche_dev_HDNXUdemy",
                table: "Banners");

            migrationBuilder.UpdateData(
                schema: "sche_dev_HDNXUdemy",
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new NodaTime.LocalDateTime(2024, 1, 12, 7, 31, 14).PlusNanoseconds(480053200L), new NodaTime.LocalDateTime(2024, 1, 12, 7, 31, 14).PlusNanoseconds(480053200L) });

            migrationBuilder.UpdateData(
                schema: "sche_dev_HDNXUdemy",
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new NodaTime.LocalDateTime(2024, 1, 12, 7, 31, 14).PlusNanoseconds(480053200L), new NodaTime.LocalDateTime(2024, 1, 12, 7, 31, 14).PlusNanoseconds(480053200L) });

            migrationBuilder.UpdateData(
                schema: "sche_dev_HDNXUdemy",
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new NodaTime.LocalDateTime(2024, 1, 12, 7, 31, 14).PlusNanoseconds(480053200L), new NodaTime.LocalDateTime(2024, 1, 12, 7, 31, 14).PlusNanoseconds(480053200L) });
        }
    }
}
