using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HDNXUdemyData.Migrations
{
    /// <inheritdoc />
    public partial class AddMoreColumnForInactiveUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "IsRequestTeacher",
                schema: "sche_dev_HDNXUdemy",
                table: "Users",
                type: "boolean",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "boolean");

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                schema: "sche_dev_HDNXUdemy",
                table: "Users",
                type: "boolean",
                nullable: true);

            migrationBuilder.UpdateData(
                schema: "sche_dev_HDNXUdemy",
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new NodaTime.LocalDateTime(2024, 1, 26, 16, 48, 3).PlusNanoseconds(314302600L), new NodaTime.LocalDateTime(2024, 1, 26, 16, 48, 3).PlusNanoseconds(314302600L) });

            migrationBuilder.UpdateData(
                schema: "sche_dev_HDNXUdemy",
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new NodaTime.LocalDateTime(2024, 1, 26, 16, 48, 3).PlusNanoseconds(314302600L), new NodaTime.LocalDateTime(2024, 1, 26, 16, 48, 3).PlusNanoseconds(314302600L) });

            migrationBuilder.UpdateData(
                schema: "sche_dev_HDNXUdemy",
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new NodaTime.LocalDateTime(2024, 1, 26, 16, 48, 3).PlusNanoseconds(314302600L), new NodaTime.LocalDateTime(2024, 1, 26, 16, 48, 3).PlusNanoseconds(314302600L) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                schema: "sche_dev_HDNXUdemy",
                table: "Users");

            migrationBuilder.AlterColumn<bool>(
                name: "IsRequestTeacher",
                schema: "sche_dev_HDNXUdemy",
                table: "Users",
                type: "boolean",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "boolean",
                oldNullable: true);

            migrationBuilder.UpdateData(
                schema: "sche_dev_HDNXUdemy",
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new NodaTime.LocalDateTime(2024, 1, 23, 1, 55, 14).PlusNanoseconds(37874900L), new NodaTime.LocalDateTime(2024, 1, 23, 1, 55, 14).PlusNanoseconds(37874900L) });

            migrationBuilder.UpdateData(
                schema: "sche_dev_HDNXUdemy",
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new NodaTime.LocalDateTime(2024, 1, 23, 1, 55, 14).PlusNanoseconds(37874900L), new NodaTime.LocalDateTime(2024, 1, 23, 1, 55, 14).PlusNanoseconds(37874900L) });

            migrationBuilder.UpdateData(
                schema: "sche_dev_HDNXUdemy",
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new NodaTime.LocalDateTime(2024, 1, 23, 1, 55, 14).PlusNanoseconds(37874900L), new NodaTime.LocalDateTime(2024, 1, 23, 1, 55, 14).PlusNanoseconds(37874900L) });
        }
    }
}