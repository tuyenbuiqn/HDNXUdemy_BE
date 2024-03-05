using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HDNXUdemyData.Migrations
{
    /// <inheritdoc />
    public partial class AddMoreColumnAndDetailsForCoursTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                schema: "sche_dev_HDNXUdemy",
                table: "Courses",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "Minutes",
                schema: "sche_dev_HDNXUdemy",
                table: "Courses",
                newName: "LevelCourse");

            migrationBuilder.RenameColumn(
                name: "Introdue",
                schema: "sche_dev_HDNXUdemy",
                table: "Courses",
                newName: "PublicId");

            migrationBuilder.RenameColumn(
                name: "Hours",
                schema: "sche_dev_HDNXUdemy",
                table: "Courses",
                newName: "Languages");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                schema: "sche_dev_HDNXUdemy",
                table: "Courses",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Duration",
                schema: "sche_dev_HDNXUdemy",
                table: "Courses",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Introduce",
                schema: "sche_dev_HDNXUdemy",
                table: "Courses",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PictureUrl",
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                schema: "sche_dev_HDNXUdemy",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "Duration",
                schema: "sche_dev_HDNXUdemy",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "Introduce",
                schema: "sche_dev_HDNXUdemy",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "PictureUrl",
                schema: "sche_dev_HDNXUdemy",
                table: "Courses");

            migrationBuilder.RenameColumn(
                name: "Title",
                schema: "sche_dev_HDNXUdemy",
                table: "Courses",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "PublicId",
                schema: "sche_dev_HDNXUdemy",
                table: "Courses",
                newName: "Introdue");

            migrationBuilder.RenameColumn(
                name: "LevelCourse",
                schema: "sche_dev_HDNXUdemy",
                table: "Courses",
                newName: "Minutes");

            migrationBuilder.RenameColumn(
                name: "Languages",
                schema: "sche_dev_HDNXUdemy",
                table: "Courses",
                newName: "Hours");

            migrationBuilder.UpdateData(
                schema: "sche_dev_HDNXUdemy",
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new NodaTime.LocalDateTime(2024, 1, 14, 8, 6, 26).PlusNanoseconds(893699200L), new NodaTime.LocalDateTime(2024, 1, 14, 8, 6, 26).PlusNanoseconds(893699200L) });

            migrationBuilder.UpdateData(
                schema: "sche_dev_HDNXUdemy",
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new NodaTime.LocalDateTime(2024, 1, 14, 8, 6, 26).PlusNanoseconds(893699200L), new NodaTime.LocalDateTime(2024, 1, 14, 8, 6, 26).PlusNanoseconds(893699200L) });

            migrationBuilder.UpdateData(
                schema: "sche_dev_HDNXUdemy",
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new NodaTime.LocalDateTime(2024, 1, 14, 8, 6, 26).PlusNanoseconds(893699200L), new NodaTime.LocalDateTime(2024, 1, 14, 8, 6, 26).PlusNanoseconds(893699200L) });
        }
    }
}