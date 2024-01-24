using Microsoft.EntityFrameworkCore.Migrations;
using NodaTime;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace HDNXUdemyData.Migrations
{
    /// <inheritdoc />
    public partial class UpdateValueNameForColumnOfDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ContentDetails",
                schema: "sche_dev_HDNXUdemy");

            migrationBuilder.DropTable(
                name: "Contents",
                schema: "sche_dev_HDNXUdemy");

            migrationBuilder.DropTable(
                name: "CourseDetails",
                schema: "sche_dev_HDNXUdemy");

            migrationBuilder.RenameColumn(
                name: "UserName",
                schema: "sche_dev_HDNXUdemy",
                table: "Students",
                newName: "Email");

            migrationBuilder.AddColumn<string>(
                name: "Introdue",
                schema: "sche_dev_HDNXUdemy",
                table: "Courses",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Vote1Star",
                schema: "sche_dev_HDNXUdemy",
                table: "Courses",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Vote2Star",
                schema: "sche_dev_HDNXUdemy",
                table: "Courses",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Vote3Star",
                schema: "sche_dev_HDNXUdemy",
                table: "Courses",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Vote4Star",
                schema: "sche_dev_HDNXUdemy",
                table: "Courses",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Vote5Star",
                schema: "sche_dev_HDNXUdemy",
                table: "Courses",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "ContentCourseDetails",
                schema: "sche_dev_HDNXUdemy",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IdContent = table.Column<int>(type: "integer", nullable: false),
                    NameSubContent = table.Column<string>(type: "text", nullable: true),
                    TimeOfContent = table.Column<string>(type: "text", nullable: true),
                    IsLearningFree = table.Column<bool>(type: "boolean", nullable: false),
                    IdVideoUpload = table.Column<string>(type: "text", nullable: true),
                    FileNameVideo = table.Column<string>(type: "text", nullable: true),
                    CreateDate = table.Column<LocalDateTime>(type: "timestamp without time zone", nullable: false),
                    UpdateDate = table.Column<LocalDateTime>(type: "timestamp without time zone", nullable: false),
                    CreateBy = table.Column<int>(type: "integer", nullable: false),
                    UpdateBy = table.Column<int>(type: "integer", nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContentCourseDetails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ContentCourses",
                schema: "sche_dev_HDNXUdemy",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IdCourse = table.Column<int>(type: "integer", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    CreateDate = table.Column<LocalDateTime>(type: "timestamp without time zone", nullable: false),
                    UpdateDate = table.Column<LocalDateTime>(type: "timestamp without time zone", nullable: false),
                    CreateBy = table.Column<int>(type: "integer", nullable: false),
                    UpdateBy = table.Column<int>(type: "integer", nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContentCourses", x => x.Id);
                });

            migrationBuilder.UpdateData(
                schema: "sche_dev_HDNXUdemy",
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new NodaTime.LocalDateTime(2024, 1, 9, 7, 34, 34).PlusNanoseconds(289747600L), new NodaTime.LocalDateTime(2024, 1, 9, 7, 34, 34).PlusNanoseconds(289747600L) });

            migrationBuilder.UpdateData(
                schema: "sche_dev_HDNXUdemy",
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new NodaTime.LocalDateTime(2024, 1, 9, 7, 34, 34).PlusNanoseconds(289747600L), new NodaTime.LocalDateTime(2024, 1, 9, 7, 34, 34).PlusNanoseconds(289747600L) });

            migrationBuilder.UpdateData(
                schema: "sche_dev_HDNXUdemy",
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new NodaTime.LocalDateTime(2024, 1, 9, 7, 34, 34).PlusNanoseconds(289747600L), new NodaTime.LocalDateTime(2024, 1, 9, 7, 34, 34).PlusNanoseconds(289747600L) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ContentCourseDetails",
                schema: "sche_dev_HDNXUdemy");

            migrationBuilder.DropTable(
                name: "ContentCourses",
                schema: "sche_dev_HDNXUdemy");

            migrationBuilder.DropColumn(
                name: "Introdue",
                schema: "sche_dev_HDNXUdemy",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "Vote1Star",
                schema: "sche_dev_HDNXUdemy",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "Vote2Star",
                schema: "sche_dev_HDNXUdemy",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "Vote3Star",
                schema: "sche_dev_HDNXUdemy",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "Vote4Star",
                schema: "sche_dev_HDNXUdemy",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "Vote5Star",
                schema: "sche_dev_HDNXUdemy",
                table: "Courses");

            migrationBuilder.RenameColumn(
                name: "Email",
                schema: "sche_dev_HDNXUdemy",
                table: "Students",
                newName: "UserName");

            migrationBuilder.CreateTable(
                name: "ContentDetails",
                schema: "sche_dev_HDNXUdemy",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CreateBy = table.Column<int>(type: "integer", nullable: false),
                    CreateDate = table.Column<LocalDateTime>(type: "timestamp without time zone", nullable: false),
                    IdContent = table.Column<int>(type: "integer", nullable: false),
                    IsLearningFree = table.Column<bool>(type: "boolean", nullable: false),
                    NameContent = table.Column<string>(type: "text", nullable: true),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    TimeOfContent = table.Column<string>(type: "text", nullable: true),
                    UpdateBy = table.Column<int>(type: "integer", nullable: false),
                    UpdateDate = table.Column<LocalDateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContentDetails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Contents",
                schema: "sche_dev_HDNXUdemy",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CreateBy = table.Column<int>(type: "integer", nullable: false),
                    CreateDate = table.Column<LocalDateTime>(type: "timestamp without time zone", nullable: false),
                    IdCourse = table.Column<int>(type: "integer", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    UpdateBy = table.Column<int>(type: "integer", nullable: false),
                    UpdateDate = table.Column<LocalDateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contents", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CourseDetails",
                schema: "sche_dev_HDNXUdemy",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CreateBy = table.Column<int>(type: "integer", nullable: false),
                    CreateDate = table.Column<LocalDateTime>(type: "timestamp without time zone", nullable: false),
                    IdCourse = table.Column<int>(type: "integer", nullable: false),
                    Introdue = table.Column<string>(type: "text", nullable: true),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    UpdateBy = table.Column<int>(type: "integer", nullable: false),
                    UpdateDate = table.Column<LocalDateTime>(type: "timestamp without time zone", nullable: false),
                    Vote1Star = table.Column<int>(type: "integer", nullable: false),
                    Vote2Star = table.Column<int>(type: "integer", nullable: false),
                    Vote3Star = table.Column<int>(type: "integer", nullable: false),
                    Vote4Star = table.Column<int>(type: "integer", nullable: false),
                    Vote5Star = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseDetails", x => x.Id);
                });

            migrationBuilder.UpdateData(
                schema: "sche_dev_HDNXUdemy",
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new NodaTime.LocalDateTime(2023, 11, 26, 8, 46, 15).PlusNanoseconds(211834800L), new NodaTime.LocalDateTime(2023, 11, 26, 8, 46, 15).PlusNanoseconds(211834800L) });

            migrationBuilder.UpdateData(
                schema: "sche_dev_HDNXUdemy",
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new NodaTime.LocalDateTime(2023, 11, 26, 8, 46, 15).PlusNanoseconds(211834800L), new NodaTime.LocalDateTime(2023, 11, 26, 8, 46, 15).PlusNanoseconds(211834800L) });

            migrationBuilder.UpdateData(
                schema: "sche_dev_HDNXUdemy",
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new NodaTime.LocalDateTime(2023, 11, 26, 8, 46, 15).PlusNanoseconds(211834800L), new NodaTime.LocalDateTime(2023, 11, 26, 8, 46, 15).PlusNanoseconds(211834800L) });
        }
    }
}