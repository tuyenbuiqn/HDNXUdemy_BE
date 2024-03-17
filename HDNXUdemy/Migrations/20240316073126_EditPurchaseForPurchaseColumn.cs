using Microsoft.EntityFrameworkCore.Migrations;
using NodaTime;

#nullable disable

namespace HDNXUdemyData.Migrations
{
    /// <inheritdoc />
    public partial class EditPurchaseForPurchaseColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<LocalDateTime>(
                name: "PurchaseDate",
                schema: "sche_dev_HDNXUdemy",
                table: "PurcharseCourses",
                type: "timestamp without time zone",
                nullable: true);

            migrationBuilder.UpdateData(
                schema: "sche_dev_HDNXUdemy",
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new NodaTime.LocalDateTime(2024, 3, 16, 7, 31, 26).PlusNanoseconds(290842700L), new NodaTime.LocalDateTime(2024, 3, 16, 7, 31, 26).PlusNanoseconds(290842700L) });

            migrationBuilder.UpdateData(
                schema: "sche_dev_HDNXUdemy",
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new NodaTime.LocalDateTime(2024, 3, 16, 7, 31, 26).PlusNanoseconds(290842700L), new NodaTime.LocalDateTime(2024, 3, 16, 7, 31, 26).PlusNanoseconds(290842700L) });

            migrationBuilder.UpdateData(
                schema: "sche_dev_HDNXUdemy",
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new NodaTime.LocalDateTime(2024, 3, 16, 7, 31, 26).PlusNanoseconds(290842700L), new NodaTime.LocalDateTime(2024, 3, 16, 7, 31, 26).PlusNanoseconds(290842700L) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PurchaseDate",
                schema: "sche_dev_HDNXUdemy",
                table: "PurcharseCourses");

            migrationBuilder.UpdateData(
                schema: "sche_dev_HDNXUdemy",
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new NodaTime.LocalDateTime(2024, 3, 15, 18, 26, 26).PlusNanoseconds(524842500L), new NodaTime.LocalDateTime(2024, 3, 15, 18, 26, 26).PlusNanoseconds(524842500L) });

            migrationBuilder.UpdateData(
                schema: "sche_dev_HDNXUdemy",
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new NodaTime.LocalDateTime(2024, 3, 15, 18, 26, 26).PlusNanoseconds(524842500L), new NodaTime.LocalDateTime(2024, 3, 15, 18, 26, 26).PlusNanoseconds(524842500L) });

            migrationBuilder.UpdateData(
                schema: "sche_dev_HDNXUdemy",
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new NodaTime.LocalDateTime(2024, 3, 15, 18, 26, 26).PlusNanoseconds(524842500L), new NodaTime.LocalDateTime(2024, 3, 15, 18, 26, 26).PlusNanoseconds(524842500L) });
        }
    }
}
