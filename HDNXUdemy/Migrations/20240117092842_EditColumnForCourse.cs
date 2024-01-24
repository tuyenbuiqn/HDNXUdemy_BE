using Microsoft.EntityFrameworkCore.Migrations;
using NodaTime;

#nullable disable

namespace HDNXUdemyData.Migrations
{
    /// <inheritdoc />
    public partial class EditColumnForCourse : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProcessCourse",
                schema: "sche_dev_HDNXUdemy",
                table: "Courses",
                type: "integer",
                nullable: true);

            migrationBuilder.UpdateData(
                schema: "sche_dev_HDNXUdemy",
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new NodaTime.LocalDateTime(2024, 1, 17, 9, 28, 42).PlusNanoseconds(244352900L), new NodaTime.LocalDateTime(2024, 1, 17, 9, 28, 42).PlusNanoseconds(244352900L) });

            migrationBuilder.UpdateData(
                schema: "sche_dev_HDNXUdemy",
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new NodaTime.LocalDateTime(2024, 1, 17, 9, 28, 42).PlusNanoseconds(244352900L), new NodaTime.LocalDateTime(2024, 1, 17, 9, 28, 42).PlusNanoseconds(244352900L) });

            migrationBuilder.UpdateData(
                schema: "sche_dev_HDNXUdemy",
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new NodaTime.LocalDateTime(2024, 1, 17, 9, 28, 42).PlusNanoseconds(244352900L), new NodaTime.LocalDateTime(2024, 1, 17, 9, 28, 42).PlusNanoseconds(244352900L) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProcessCourse",
                schema: "sche_dev_HDNXUdemy",
                table: "Courses");

            migrationBuilder.UpdateData(
                schema: "sche_dev_HDNXUdemy",
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new NodaTime.LocalDateTime(2024, 1, 16, 16, 16, 32).PlusNanoseconds(663315300L), new NodaTime.LocalDateTime(2024, 1, 16, 16, 16, 32).PlusNanoseconds(663315300L) });

            migrationBuilder.UpdateData(
                schema: "sche_dev_HDNXUdemy",
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new NodaTime.LocalDateTime(2024, 1, 16, 16, 16, 32).PlusNanoseconds(663315300L), new NodaTime.LocalDateTime(2024, 1, 16, 16, 16, 32).PlusNanoseconds(663315300L) });

            migrationBuilder.UpdateData(
                schema: "sche_dev_HDNXUdemy",
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new NodaTime.LocalDateTime(2024, 1, 16, 16, 16, 32).PlusNanoseconds(663315300L), new NodaTime.LocalDateTime(2024, 1, 16, 16, 16, 32).PlusNanoseconds(663315300L) });
        }
    }
}
