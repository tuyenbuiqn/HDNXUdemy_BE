using Microsoft.EntityFrameworkCore.Migrations;
using NodaTime;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace HDNXUdemyData.Migrations
{
    /// <inheritdoc />
    public partial class UpdateEditColumnPurchase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdCourse",
                schema: "sche_dev_HDNXUdemy",
                table: "PurcharseCourses");

            migrationBuilder.DropColumn(
                name: "PriceOfCourse",
                schema: "sche_dev_HDNXUdemy",
                table: "PurcharseCourses");

            migrationBuilder.AddColumn<decimal>(
                name: "DiscountAmount",
                schema: "sche_dev_HDNXUdemy",
                table: "PurcharseCourses",
                type: "numeric",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "TotalPrice",
                schema: "sche_dev_HDNXUdemy",
                table: "PurcharseCourses",
                type: "numeric",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "PurcharseCourseDetails",
                schema: "sche_dev_HDNXUdemy",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IdCourse = table.Column<int>(type: "integer", nullable: false),
                    PriceOfCourse = table.Column<decimal>(type: "numeric", nullable: true),
                    PriceOfDiscount = table.Column<decimal>(type: "numeric", nullable: true),
                    IdPurchaseOrder = table.Column<int>(type: "integer", nullable: false),
                    CreateDate = table.Column<LocalDateTime>(type: "timestamp without time zone", nullable: false),
                    UpdateDate = table.Column<LocalDateTime>(type: "timestamp without time zone", nullable: false),
                    CreateBy = table.Column<int>(type: "integer", nullable: false),
                    UpdateBy = table.Column<int>(type: "integer", nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurcharseCourseDetails", x => x.Id);
                });

            migrationBuilder.UpdateData(
                schema: "sche_dev_HDNXUdemy",
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new NodaTime.LocalDateTime(2024, 3, 5, 17, 15, 54).PlusNanoseconds(271369400L), new NodaTime.LocalDateTime(2024, 3, 5, 17, 15, 54).PlusNanoseconds(271369400L) });

            migrationBuilder.UpdateData(
                schema: "sche_dev_HDNXUdemy",
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new NodaTime.LocalDateTime(2024, 3, 5, 17, 15, 54).PlusNanoseconds(271369400L), new NodaTime.LocalDateTime(2024, 3, 5, 17, 15, 54).PlusNanoseconds(271369400L) });

            migrationBuilder.UpdateData(
                schema: "sche_dev_HDNXUdemy",
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new NodaTime.LocalDateTime(2024, 3, 5, 17, 15, 54).PlusNanoseconds(271369400L), new NodaTime.LocalDateTime(2024, 3, 5, 17, 15, 54).PlusNanoseconds(271369400L) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PurcharseCourseDetails",
                schema: "sche_dev_HDNXUdemy");

            migrationBuilder.DropColumn(
                name: "DiscountAmount",
                schema: "sche_dev_HDNXUdemy",
                table: "PurcharseCourses");

            migrationBuilder.DropColumn(
                name: "TotalPrice",
                schema: "sche_dev_HDNXUdemy",
                table: "PurcharseCourses");

            migrationBuilder.AddColumn<int>(
                name: "IdCourse",
                schema: "sche_dev_HDNXUdemy",
                table: "PurcharseCourses",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "PriceOfCourse",
                schema: "sche_dev_HDNXUdemy",
                table: "PurcharseCourses",
                type: "text",
                nullable: true);

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
    }
}
