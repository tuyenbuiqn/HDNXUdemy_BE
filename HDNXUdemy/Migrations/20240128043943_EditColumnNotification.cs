using Microsoft.EntityFrameworkCore.Migrations;
using NodaTime;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace HDNXUdemyData.Migrations
{
    /// <inheritdoc />
    public partial class EditColumnNotification : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdminNotifications",
                schema: "sche_dev_HDNXUdemy");

            migrationBuilder.RenameColumn(
                name: "PercentDiscount",
                schema: "sche_dev_HDNXUdemy",
                table: "Courses",
                newName: "PriceOfDiscount");

            migrationBuilder.AddColumn<string>(
                name: "PurcharseCode",
                schema: "sche_dev_HDNXUdemy",
                table: "PurcharseCourses",
                type: "text",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Notifications",
                schema: "sche_dev_HDNXUdemy",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IdComment = table.Column<int>(type: "integer", nullable: true),
                    TypeNotification = table.Column<int>(type: "integer", nullable: true),
                    IdCourse = table.Column<int>(type: "integer", nullable: false),
                    IdStudent = table.Column<int>(type: "integer", nullable: true),
                    ShortComment = table.Column<string>(type: "text", nullable: true),
                    IsRead = table.Column<bool>(type: "boolean", nullable: true),
                    CreateDate = table.Column<LocalDateTime>(type: "timestamp without time zone", nullable: false),
                    UpdateDate = table.Column<LocalDateTime>(type: "timestamp without time zone", nullable: false),
                    CreateBy = table.Column<int>(type: "integer", nullable: false),
                    UpdateBy = table.Column<int>(type: "integer", nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notifications", x => x.Id);
                });

            migrationBuilder.UpdateData(
                schema: "sche_dev_HDNXUdemy",
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new NodaTime.LocalDateTime(2024, 1, 28, 4, 39, 43).PlusNanoseconds(807884100L), new NodaTime.LocalDateTime(2024, 1, 28, 4, 39, 43).PlusNanoseconds(807884100L) });

            migrationBuilder.UpdateData(
                schema: "sche_dev_HDNXUdemy",
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new NodaTime.LocalDateTime(2024, 1, 28, 4, 39, 43).PlusNanoseconds(807884100L), new NodaTime.LocalDateTime(2024, 1, 28, 4, 39, 43).PlusNanoseconds(807884100L) });

            migrationBuilder.UpdateData(
                schema: "sche_dev_HDNXUdemy",
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new NodaTime.LocalDateTime(2024, 1, 28, 4, 39, 43).PlusNanoseconds(807884100L), new NodaTime.LocalDateTime(2024, 1, 28, 4, 39, 43).PlusNanoseconds(807884100L) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Notifications",
                schema: "sche_dev_HDNXUdemy");

            migrationBuilder.DropColumn(
                name: "PurcharseCode",
                schema: "sche_dev_HDNXUdemy",
                table: "PurcharseCourses");

            migrationBuilder.RenameColumn(
                name: "PriceOfDiscount",
                schema: "sche_dev_HDNXUdemy",
                table: "Courses",
                newName: "PercentDiscount");

            migrationBuilder.CreateTable(
                name: "AdminNotifications",
                schema: "sche_dev_HDNXUdemy",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CreateBy = table.Column<int>(type: "integer", nullable: false),
                    CreateDate = table.Column<LocalDateTime>(type: "timestamp without time zone", nullable: false),
                    IdComment = table.Column<int>(type: "integer", nullable: false),
                    IdCourse = table.Column<int>(type: "integer", nullable: false),
                    IdTypeComment = table.Column<int>(type: "integer", nullable: false),
                    ShortComment = table.Column<string>(type: "text", nullable: true),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    UpdateBy = table.Column<int>(type: "integer", nullable: false),
                    UpdateDate = table.Column<LocalDateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdminNotifications", x => x.Id);
                });

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
    }
}
