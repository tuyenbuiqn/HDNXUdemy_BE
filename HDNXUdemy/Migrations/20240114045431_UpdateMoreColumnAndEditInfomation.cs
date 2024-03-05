using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HDNXUdemyData.Migrations
{
    /// <inheritdoc />
    public partial class UpdateMoreColumnAndEditInfomation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Icon",
                schema: "sche_dev_HDNXUdemy",
                table: "FileManagers",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "KeyOfFile",
                schema: "sche_dev_HDNXUdemy",
                table: "FileManagers",
                type: "text",
                nullable: true);

            migrationBuilder.UpdateData(
                schema: "sche_dev_HDNXUdemy",
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new NodaTime.LocalDateTime(2024, 1, 14, 4, 54, 31).PlusNanoseconds(782134400L), new NodaTime.LocalDateTime(2024, 1, 14, 4, 54, 31).PlusNanoseconds(782134400L) });

            migrationBuilder.UpdateData(
                schema: "sche_dev_HDNXUdemy",
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new NodaTime.LocalDateTime(2024, 1, 14, 4, 54, 31).PlusNanoseconds(782134400L), new NodaTime.LocalDateTime(2024, 1, 14, 4, 54, 31).PlusNanoseconds(782134400L) });

            migrationBuilder.UpdateData(
                schema: "sche_dev_HDNXUdemy",
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new NodaTime.LocalDateTime(2024, 1, 14, 4, 54, 31).PlusNanoseconds(782134400L), new NodaTime.LocalDateTime(2024, 1, 14, 4, 54, 31).PlusNanoseconds(782134400L) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Icon",
                schema: "sche_dev_HDNXUdemy",
                table: "FileManagers");

            migrationBuilder.DropColumn(
                name: "KeyOfFile",
                schema: "sche_dev_HDNXUdemy",
                table: "FileManagers");

            migrationBuilder.UpdateData(
                schema: "sche_dev_HDNXUdemy",
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new NodaTime.LocalDateTime(2024, 1, 13, 17, 32, 41).PlusNanoseconds(805419400L), new NodaTime.LocalDateTime(2024, 1, 13, 17, 32, 41).PlusNanoseconds(805419400L) });

            migrationBuilder.UpdateData(
                schema: "sche_dev_HDNXUdemy",
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new NodaTime.LocalDateTime(2024, 1, 13, 17, 32, 41).PlusNanoseconds(805419400L), new NodaTime.LocalDateTime(2024, 1, 13, 17, 32, 41).PlusNanoseconds(805419400L) });

            migrationBuilder.UpdateData(
                schema: "sche_dev_HDNXUdemy",
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new NodaTime.LocalDateTime(2024, 1, 13, 17, 32, 41).PlusNanoseconds(805419400L), new NodaTime.LocalDateTime(2024, 1, 13, 17, 32, 41).PlusNanoseconds(805419400L) });
        }
    }
}