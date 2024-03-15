using Microsoft.EntityFrameworkCore.Migrations;
using NodaTime;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace HDNXUdemyData.Migrations
{
    /// <inheritdoc />
    public partial class UpdateCodeForCreateNewTableForEvaluation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CourseEvaluations",
                schema: "sche_dev_HDNXUdemy",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IdStudent = table.Column<int>(type: "integer", nullable: false),
                    IdCourse = table.Column<int>(type: "integer", nullable: false),
                    VoteStartNumber = table.Column<int>(type: "integer", nullable: false),
                    CommentEvaluation = table.Column<string>(type: "text", nullable: true),
                    Like = table.Column<int>(type: "integer", nullable: false),
                    DisLike = table.Column<int>(type: "integer", nullable: false),
                    CreateDate = table.Column<LocalDateTime>(type: "timestamp without time zone", nullable: false),
                    UpdateDate = table.Column<LocalDateTime>(type: "timestamp without time zone", nullable: false),
                    CreateBy = table.Column<int>(type: "integer", nullable: false),
                    UpdateBy = table.Column<int>(type: "integer", nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseEvaluations", x => x.Id);
                });

            migrationBuilder.UpdateData(
                schema: "sche_dev_HDNXUdemy",
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new NodaTime.LocalDateTime(2024, 3, 15, 8, 58, 44).PlusNanoseconds(915083800L), new NodaTime.LocalDateTime(2024, 3, 15, 8, 58, 44).PlusNanoseconds(915083800L) });

            migrationBuilder.UpdateData(
                schema: "sche_dev_HDNXUdemy",
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new NodaTime.LocalDateTime(2024, 3, 15, 8, 58, 44).PlusNanoseconds(915083800L), new NodaTime.LocalDateTime(2024, 3, 15, 8, 58, 44).PlusNanoseconds(915083800L) });

            migrationBuilder.UpdateData(
                schema: "sche_dev_HDNXUdemy",
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new NodaTime.LocalDateTime(2024, 3, 15, 8, 58, 44).PlusNanoseconds(915083800L), new NodaTime.LocalDateTime(2024, 3, 15, 8, 58, 44).PlusNanoseconds(915083800L) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CourseEvaluations",
                schema: "sche_dev_HDNXUdemy");

            migrationBuilder.UpdateData(
                schema: "sche_dev_HDNXUdemy",
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new NodaTime.LocalDateTime(2024, 3, 15, 8, 54, 56).PlusNanoseconds(916554000L), new NodaTime.LocalDateTime(2024, 3, 15, 8, 54, 56).PlusNanoseconds(916554000L) });

            migrationBuilder.UpdateData(
                schema: "sche_dev_HDNXUdemy",
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new NodaTime.LocalDateTime(2024, 3, 15, 8, 54, 56).PlusNanoseconds(916554000L), new NodaTime.LocalDateTime(2024, 3, 15, 8, 54, 56).PlusNanoseconds(916554000L) });

            migrationBuilder.UpdateData(
                schema: "sche_dev_HDNXUdemy",
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new NodaTime.LocalDateTime(2024, 3, 15, 8, 54, 56).PlusNanoseconds(916554000L), new NodaTime.LocalDateTime(2024, 3, 15, 8, 54, 56).PlusNanoseconds(916554000L) });
        }
    }
}
