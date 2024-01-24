using Microsoft.EntityFrameworkCore.Migrations;
using NodaTime;

#nullable disable

namespace HDNXUdemyData.Migrations
{
    /// <inheritdoc />
    public partial class AddEditNameOfColumnForUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "KeyImages",
                schema: "sche_dev_HDNXUdemy",
                table: "Users",
                newName: "PublicId");

            migrationBuilder.RenameColumn(
                name: "Genaral",
                schema: "sche_dev_HDNXUdemy",
                table: "Users",
                newName: "General");

            migrationBuilder.UpdateData(
                schema: "sche_dev_HDNXUdemy",
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new NodaTime.LocalDateTime(2024, 1, 22, 5, 4, 46).PlusNanoseconds(936209500L), new NodaTime.LocalDateTime(2024, 1, 22, 5, 4, 46).PlusNanoseconds(936209500L) });

            migrationBuilder.UpdateData(
                schema: "sche_dev_HDNXUdemy",
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new NodaTime.LocalDateTime(2024, 1, 22, 5, 4, 46).PlusNanoseconds(936209500L), new NodaTime.LocalDateTime(2024, 1, 22, 5, 4, 46).PlusNanoseconds(936209500L) });

            migrationBuilder.UpdateData(
                schema: "sche_dev_HDNXUdemy",
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new NodaTime.LocalDateTime(2024, 1, 22, 5, 4, 46).PlusNanoseconds(936209500L), new NodaTime.LocalDateTime(2024, 1, 22, 5, 4, 46).PlusNanoseconds(936209500L) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PublicId",
                schema: "sche_dev_HDNXUdemy",
                table: "Users",
                newName: "KeyImages");

            migrationBuilder.RenameColumn(
                name: "General",
                schema: "sche_dev_HDNXUdemy",
                table: "Users",
                newName: "Genaral");

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
    }
}
