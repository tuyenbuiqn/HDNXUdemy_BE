using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HDNXUdemyData.Migrations
{
    /// <inheritdoc />
    public partial class UpdateCategoryName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "sche_dev_HDNXUdemy",
                table: "Categories",
                columns: new[] { "Id", "CreateBy", "CreateDate", "Name", "Status", "UpdateBy", "UpdateDate" },
                values: new object[,]
                {
                    { 1L, 1, new NodaTime.LocalDateTime(2023, 11, 26, 8, 46, 15).PlusNanoseconds(211834800L), "Thiết kế cơ khí", 0, 1, new NodaTime.LocalDateTime(2023, 11, 26, 8, 46, 15).PlusNanoseconds(211834800L) },
                    { 2L, 1, new NodaTime.LocalDateTime(2023, 11, 26, 8, 46, 15).PlusNanoseconds(211834800L), "Lập trình CNC", 0, 1, new NodaTime.LocalDateTime(2023, 11, 26, 8, 46, 15).PlusNanoseconds(211834800L) },
                    { 3L, 1, new NodaTime.LocalDateTime(2023, 11, 26, 8, 46, 15).PlusNanoseconds(211834800L), "Vận hành máy CNC", 0, 1, new NodaTime.LocalDateTime(2023, 11, 26, 8, 46, 15).PlusNanoseconds(211834800L) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "sche_dev_HDNXUdemy",
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                schema: "sche_dev_HDNXUdemy",
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                schema: "sche_dev_HDNXUdemy",
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3L);
        }
    }
}