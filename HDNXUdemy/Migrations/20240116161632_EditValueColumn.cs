using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HDNXUdemyData.Migrations
{
    /// <inheritdoc />
    public partial class EditValueColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "LevelCourse",
                schema: "sche_dev_HDNXUdemy",
                table: "Courses",
                type: "text",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "LevelCourse",
                schema: "sche_dev_HDNXUdemy",
                table: "Courses",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.UpdateData(
                schema: "sche_dev_HDNXUdemy",
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new NodaTime.LocalDateTime(2024, 1, 16, 15, 59, 8).PlusNanoseconds(260229800L), new NodaTime.LocalDateTime(2024, 1, 16, 15, 59, 8).PlusNanoseconds(260229800L) });

            migrationBuilder.UpdateData(
                schema: "sche_dev_HDNXUdemy",
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new NodaTime.LocalDateTime(2024, 1, 16, 15, 59, 8).PlusNanoseconds(260229800L), new NodaTime.LocalDateTime(2024, 1, 16, 15, 59, 8).PlusNanoseconds(260229800L) });

            migrationBuilder.UpdateData(
                schema: "sche_dev_HDNXUdemy",
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new NodaTime.LocalDateTime(2024, 1, 16, 15, 59, 8).PlusNanoseconds(260229800L), new NodaTime.LocalDateTime(2024, 1, 16, 15, 59, 8).PlusNanoseconds(260229800L) });
        }
    }
}