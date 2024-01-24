using Microsoft.EntityFrameworkCore.Migrations;
using NodaTime;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace HDNXUdemyData.Migrations
{
    /// <inheritdoc />
    public partial class UpdateNameOfColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Authors",
                schema: "sche_dev_HDNXUdemy");

            migrationBuilder.DropTable(
                name: "Students",
                schema: "sche_dev_HDNXUdemy");

            migrationBuilder.DropTable(
                name: "Teachers",
                schema: "sche_dev_HDNXUdemy");

            migrationBuilder.AddColumn<int>(
                name: "IdCategory",
                schema: "sche_dev_HDNXUdemy",
                table: "Courses",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NumberStartVote",
                schema: "sche_dev_HDNXUdemy",
                table: "CourseComments",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "IsFinishConvert",
                schema: "sche_dev_HDNXUdemy",
                table: "ContentCourseDetails",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "PictureUrl",
                schema: "sche_dev_HDNXUdemy",
                table: "Categories",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PublicId",
                schema: "sche_dev_HDNXUdemy",
                table: "Categories",
                type: "text",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Users",
                schema: "sche_dev_HDNXUdemy",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Email = table.Column<string>(type: "text", nullable: true),
                    Password = table.Column<string>(type: "text", nullable: true),
                    Phone = table.Column<string>(type: "text", nullable: true),
                    Genaral = table.Column<int>(type: "integer", nullable: false),
                    PictureUrl = table.Column<string>(type: "text", nullable: true),
                    KeyImages = table.Column<string>(type: "text", nullable: true),
                    RoleId = table.Column<int>(type: "integer", nullable: false),
                    TypeLogin = table.Column<int>(type: "integer", nullable: false),
                    IsRequestTeacher = table.Column<bool>(type: "boolean", nullable: false),
                    CreateDate = table.Column<LocalDateTime>(type: "timestamp without time zone", nullable: false),
                    UpdateDate = table.Column<LocalDateTime>(type: "timestamp without time zone", nullable: false),
                    CreateBy = table.Column<int>(type: "integer", nullable: false),
                    UpdateBy = table.Column<int>(type: "integer", nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.UpdateData(
                schema: "sche_dev_HDNXUdemy",
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "PictureUrl", "PublicId", "UpdateDate" },
                values: new object[] { new NodaTime.LocalDateTime(2024, 1, 10, 18, 28, 1).PlusNanoseconds(159156600L), null, null, new NodaTime.LocalDateTime(2024, 1, 10, 18, 28, 1).PlusNanoseconds(159156600L) });

            migrationBuilder.UpdateData(
                schema: "sche_dev_HDNXUdemy",
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "PictureUrl", "PublicId", "UpdateDate" },
                values: new object[] { new NodaTime.LocalDateTime(2024, 1, 10, 18, 28, 1).PlusNanoseconds(159156600L), null, null, new NodaTime.LocalDateTime(2024, 1, 10, 18, 28, 1).PlusNanoseconds(159156600L) });

            migrationBuilder.UpdateData(
                schema: "sche_dev_HDNXUdemy",
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "PictureUrl", "PublicId", "UpdateDate" },
                values: new object[] { new NodaTime.LocalDateTime(2024, 1, 10, 18, 28, 1).PlusNanoseconds(159156600L), null, null, new NodaTime.LocalDateTime(2024, 1, 10, 18, 28, 1).PlusNanoseconds(159156600L) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users",
                schema: "sche_dev_HDNXUdemy");

            migrationBuilder.DropColumn(
                name: "IdCategory",
                schema: "sche_dev_HDNXUdemy",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "NumberStartVote",
                schema: "sche_dev_HDNXUdemy",
                table: "CourseComments");

            migrationBuilder.DropColumn(
                name: "IsFinishConvert",
                schema: "sche_dev_HDNXUdemy",
                table: "ContentCourseDetails");

            migrationBuilder.DropColumn(
                name: "PictureUrl",
                schema: "sche_dev_HDNXUdemy",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "PublicId",
                schema: "sche_dev_HDNXUdemy",
                table: "Categories");

            migrationBuilder.CreateTable(
                name: "Authors",
                schema: "sche_dev_HDNXUdemy",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CreateBy = table.Column<int>(type: "integer", nullable: false),
                    CreateDate = table.Column<LocalDateTime>(type: "timestamp without time zone", nullable: false),
                    IdTeacher = table.Column<int>(type: "integer", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    UpdateBy = table.Column<int>(type: "integer", nullable: false),
                    UpdateDate = table.Column<LocalDateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                schema: "sche_dev_HDNXUdemy",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CreateBy = table.Column<int>(type: "integer", nullable: false),
                    CreateDate = table.Column<LocalDateTime>(type: "timestamp without time zone", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: true),
                    Genaral = table.Column<int>(type: "integer", nullable: false),
                    KeyImages = table.Column<string>(type: "text", nullable: true),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Password = table.Column<string>(type: "text", nullable: true),
                    Phone = table.Column<string>(type: "text", nullable: true),
                    PictureUrl = table.Column<string>(type: "text", nullable: true),
                    RoleId = table.Column<int>(type: "integer", nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    UpdateBy = table.Column<int>(type: "integer", nullable: false),
                    UpdateDate = table.Column<LocalDateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Teachers",
                schema: "sche_dev_HDNXUdemy",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CreateBy = table.Column<int>(type: "integer", nullable: false),
                    CreateDate = table.Column<LocalDateTime>(type: "timestamp without time zone", nullable: false),
                    IdStudent = table.Column<int>(type: "integer", nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    UpdateBy = table.Column<int>(type: "integer", nullable: false),
                    UpdateDate = table.Column<LocalDateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.Id);
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
    }
}
