using Microsoft.EntityFrameworkCore.Migrations;
using NodaTime;

#nullable disable

namespace HDNXUdemyData.Migrations
{
    /// <inheritdoc />
    public partial class UpdateCodeForCreateNewTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Vote1Star",
                schema: "sche_dev_HDNXUdemy",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "Vote2Star",
                schema: "sche_dev_HDNXUdemy",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "Vote3Star",
                schema: "sche_dev_HDNXUdemy",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "Vote4Star",
                schema: "sche_dev_HDNXUdemy",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "Vote5Star",
                schema: "sche_dev_HDNXUdemy",
                table: "Courses");

            migrationBuilder.UpdateData(
                schema: "sche_dev_HDNXUdemy",
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new NodaTime.LocalDateTime(2024, 3, 15, 8, 54, 56).PlusNanoseconds(916554000L), new NodaTime.LocalDateTime(2024, 3, 15, 8, 54, 56).PlusNanoseconds(916554000L) });

            migrationBuilder.UpdateData(
                schema: "sche_dev_HDNXUdemy",
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new NodaTime.LocalDateTime(2024, 3, 15, 8, 54, 56).PlusNanoseconds(916554000L), new NodaTime.LocalDateTime(2024, 3, 15, 8, 54, 56).PlusNanoseconds(916554000L) });

            migrationBuilder.UpdateData(
                schema: "sche_dev_HDNXUdemy",
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new NodaTime.LocalDateTime(2024, 3, 15, 8, 54, 56).PlusNanoseconds(916554000L), new NodaTime.LocalDateTime(2024, 3, 15, 8, 54, 56).PlusNanoseconds(916554000L) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Vote1Star",
                schema: "sche_dev_HDNXUdemy",
                table: "Courses",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Vote2Star",
                schema: "sche_dev_HDNXUdemy",
                table: "Courses",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Vote3Star",
                schema: "sche_dev_HDNXUdemy",
                table: "Courses",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Vote4Star",
                schema: "sche_dev_HDNXUdemy",
                table: "Courses",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Vote5Star",
                schema: "sche_dev_HDNXUdemy",
                table: "Courses",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                schema: "sche_dev_HDNXUdemy",
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new NodaTime.LocalDateTime(2024, 3, 12, 7, 31, 19).PlusNanoseconds(145039400L), new NodaTime.LocalDateTime(2024, 3, 12, 7, 31, 19).PlusNanoseconds(145039400L) });

            migrationBuilder.UpdateData(
                schema: "sche_dev_HDNXUdemy",
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new NodaTime.LocalDateTime(2024, 3, 12, 7, 31, 19).PlusNanoseconds(145039400L), new NodaTime.LocalDateTime(2024, 3, 12, 7, 31, 19).PlusNanoseconds(145039400L) });

            migrationBuilder.UpdateData(
                schema: "sche_dev_HDNXUdemy",
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new NodaTime.LocalDateTime(2024, 3, 12, 7, 31, 19).PlusNanoseconds(145039400L), new NodaTime.LocalDateTime(2024, 3, 12, 7, 31, 19).PlusNanoseconds(145039400L) });
        }
    }
}
