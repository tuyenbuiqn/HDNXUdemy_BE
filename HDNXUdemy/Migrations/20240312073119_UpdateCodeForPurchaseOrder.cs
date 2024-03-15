using Microsoft.EntityFrameworkCore.Migrations;
using NodaTime;

#nullable disable

namespace HDNXUdemyData.Migrations
{
    /// <inheritdoc />
    public partial class UpdateCodeForPurchaseOrder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdStudent",
                schema: "sche_dev_HDNXUdemy",
                table: "PurcharseCourseDetails",
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdStudent",
                schema: "sche_dev_HDNXUdemy",
                table: "PurcharseCourseDetails");

            migrationBuilder.UpdateData(
                schema: "sche_dev_HDNXUdemy",
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new NodaTime.LocalDateTime(2024, 3, 5, 17, 15, 54).PlusNanoseconds(271369400L), new NodaTime.LocalDateTime(2024, 3, 5, 17, 15, 54).PlusNanoseconds(271369400L) });

            migrationBuilder.UpdateData(
                schema: "sche_dev_HDNXUdemy",
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new NodaTime.LocalDateTime(2024, 3, 5, 17, 15, 54).PlusNanoseconds(271369400L), new NodaTime.LocalDateTime(2024, 3, 5, 17, 15, 54).PlusNanoseconds(271369400L) });

            migrationBuilder.UpdateData(
                schema: "sche_dev_HDNXUdemy",
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new NodaTime.LocalDateTime(2024, 3, 5, 17, 15, 54).PlusNanoseconds(271369400L), new NodaTime.LocalDateTime(2024, 3, 5, 17, 15, 54).PlusNanoseconds(271369400L) });
        }
    }
}
