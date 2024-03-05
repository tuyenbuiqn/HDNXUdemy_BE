using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HDNXUdemyData.Migrations
{
    /// <inheritdoc />
    public partial class AddMoreInfomationWithCourse : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsSubscription",
                schema: "sche_dev_HDNXUdemy",
                table: "Courses",
                newName: "IsFree");

            migrationBuilder.AddColumn<string>(
                name: "FileUrl",
                schema: "sche_dev_HDNXUdemy",
                table: "Courses",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "KeyVideoUpload",
                schema: "sche_dev_HDNXUdemy",
                table: "Courses",
                type: "text",
                nullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FileUrl",
                schema: "sche_dev_HDNXUdemy",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "KeyVideoUpload",
                schema: "sche_dev_HDNXUdemy",
                table: "Courses");

            migrationBuilder.RenameColumn(
                name: "IsFree",
                schema: "sche_dev_HDNXUdemy",
                table: "Courses",
                newName: "IsSubscription");

            migrationBuilder.UpdateData(
                schema: "sche_dev_HDNXUdemy",
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new NodaTime.LocalDateTime(2024, 1, 16, 9, 42, 0).PlusNanoseconds(690963400L), new NodaTime.LocalDateTime(2024, 1, 16, 9, 42, 0).PlusNanoseconds(690963400L) });

            migrationBuilder.UpdateData(
                schema: "sche_dev_HDNXUdemy",
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new NodaTime.LocalDateTime(2024, 1, 16, 9, 42, 0).PlusNanoseconds(690963400L), new NodaTime.LocalDateTime(2024, 1, 16, 9, 42, 0).PlusNanoseconds(690963400L) });

            migrationBuilder.UpdateData(
                schema: "sche_dev_HDNXUdemy",
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new NodaTime.LocalDateTime(2024, 1, 16, 9, 42, 0).PlusNanoseconds(690963400L), new NodaTime.LocalDateTime(2024, 1, 16, 9, 42, 0).PlusNanoseconds(690963400L) });
        }
    }
}