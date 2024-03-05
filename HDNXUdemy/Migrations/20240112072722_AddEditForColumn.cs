using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HDNXUdemyData.Migrations
{
    /// <inheritdoc />
    public partial class AddEditForColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "sche_dev_HDNXUdemy",
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new NodaTime.LocalDateTime(2024, 1, 12, 7, 27, 21).PlusNanoseconds(961479400L), new NodaTime.LocalDateTime(2024, 1, 12, 7, 27, 21).PlusNanoseconds(961479400L) });

            migrationBuilder.UpdateData(
                schema: "sche_dev_HDNXUdemy",
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new NodaTime.LocalDateTime(2024, 1, 12, 7, 27, 21).PlusNanoseconds(961479400L), new NodaTime.LocalDateTime(2024, 1, 12, 7, 27, 21).PlusNanoseconds(961479400L) });

            migrationBuilder.UpdateData(
                schema: "sche_dev_HDNXUdemy",
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new NodaTime.LocalDateTime(2024, 1, 12, 7, 27, 21).PlusNanoseconds(961479400L), new NodaTime.LocalDateTime(2024, 1, 12, 7, 27, 21).PlusNanoseconds(961479400L) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "sche_dev_HDNXUdemy",
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new NodaTime.LocalDateTime(2024, 1, 10, 18, 28, 1).PlusNanoseconds(159156600L), new NodaTime.LocalDateTime(2024, 1, 10, 18, 28, 1).PlusNanoseconds(159156600L) });

            migrationBuilder.UpdateData(
                schema: "sche_dev_HDNXUdemy",
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new NodaTime.LocalDateTime(2024, 1, 10, 18, 28, 1).PlusNanoseconds(159156600L), new NodaTime.LocalDateTime(2024, 1, 10, 18, 28, 1).PlusNanoseconds(159156600L) });

            migrationBuilder.UpdateData(
                schema: "sche_dev_HDNXUdemy",
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new NodaTime.LocalDateTime(2024, 1, 10, 18, 28, 1).PlusNanoseconds(159156600L), new NodaTime.LocalDateTime(2024, 1, 10, 18, 28, 1).PlusNanoseconds(159156600L) });
        }
    }
}