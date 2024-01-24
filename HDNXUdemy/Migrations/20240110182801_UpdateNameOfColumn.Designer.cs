﻿// <auto-generated />
using HDNXUdemyData.EntitiesContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NodaTime;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace HDNXUdemyData.Migrations
{
    [DbContext(typeof(ProjectContext))]
    [Migration("20240110182801_UpdateNameOfColumn")]
    partial class UpdateNameOfColumn
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("sche_dev_HDNXUdemy")
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("DNXUdemyData.Entities.ContentCourseDetailEntities", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("Id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<int>("CreateBy")
                        .HasColumnType("integer")
                        .HasColumnName("CreateBy");

                    b.Property<LocalDateTime>("CreateDate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("CreateDate");

                    b.Property<string>("FileNameVideo")
                        .HasColumnType("text");

                    b.Property<int>("IdContent")
                        .HasColumnType("integer");

                    b.Property<string>("IdVideoUpload")
                        .HasColumnType("text");

                    b.Property<bool>("IsFinishConvert")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsLearningFree")
                        .HasColumnType("boolean");

                    b.Property<string>("NameSubContent")
                        .HasColumnType("text");

                    b.Property<int>("Status")
                        .HasColumnType("integer")
                        .HasColumnName("Status");

                    b.Property<string>("TimeOfContent")
                        .HasColumnType("text");

                    b.Property<int>("UpdateBy")
                        .HasColumnType("integer")
                        .HasColumnName("UpdateBy");

                    b.Property<LocalDateTime>("UpdateDate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("UpdateDate");

                    b.HasKey("Id");

                    b.ToTable("ContentCourseDetails", "sche_dev_HDNXUdemy");
                });

            modelBuilder.Entity("HDNXUdemyData.Entities.AdminNotificationEntities", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("Id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<int>("CreateBy")
                        .HasColumnType("integer")
                        .HasColumnName("CreateBy");

                    b.Property<LocalDateTime>("CreateDate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("CreateDate");

                    b.Property<int>("IdComment")
                        .HasColumnType("integer");

                    b.Property<int>("IdCourse")
                        .HasColumnType("integer");

                    b.Property<int>("IdTypeComment")
                        .HasColumnType("integer");

                    b.Property<string>("ShortComment")
                        .HasColumnType("text");

                    b.Property<int>("Status")
                        .HasColumnType("integer")
                        .HasColumnName("Status");

                    b.Property<int>("UpdateBy")
                        .HasColumnType("integer")
                        .HasColumnName("UpdateBy");

                    b.Property<LocalDateTime>("UpdateDate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("UpdateDate");

                    b.HasKey("Id");

                    b.ToTable("AdminNotifications", "sche_dev_HDNXUdemy");
                });

            modelBuilder.Entity("HDNXUdemyData.Entities.BookmarkCourseEntities", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("Id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<int>("CreateBy")
                        .HasColumnType("integer")
                        .HasColumnName("CreateBy");

                    b.Property<LocalDateTime>("CreateDate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("CreateDate");

                    b.Property<int>("IdCourse")
                        .HasColumnType("integer");

                    b.Property<int>("IdStudent")
                        .HasColumnType("integer");

                    b.Property<int>("Status")
                        .HasColumnType("integer")
                        .HasColumnName("Status");

                    b.Property<int>("UpdateBy")
                        .HasColumnType("integer")
                        .HasColumnName("UpdateBy");

                    b.Property<LocalDateTime>("UpdateDate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("UpdateDate");

                    b.HasKey("Id");

                    b.ToTable("BookmarkCourses", "sche_dev_HDNXUdemy");
                });

            modelBuilder.Entity("HDNXUdemyData.Entities.CategoryEntities", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("Id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<int>("CreateBy")
                        .HasColumnType("integer")
                        .HasColumnName("CreateBy");

                    b.Property<LocalDateTime>("CreateDate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("CreateDate");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("PictureUrl")
                        .HasColumnType("text");

                    b.Property<string>("PublicId")
                        .HasColumnType("text");

                    b.Property<int>("Status")
                        .HasColumnType("integer")
                        .HasColumnName("Status");

                    b.Property<int>("UpdateBy")
                        .HasColumnType("integer")
                        .HasColumnName("UpdateBy");

                    b.Property<LocalDateTime>("UpdateDate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("UpdateDate");

                    b.HasKey("Id");

                    b.ToTable("Categories", "sche_dev_HDNXUdemy");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            CreateBy = 1,
                            CreateDate = new NodaTime.LocalDateTime(2024, 1, 10, 18, 28, 1).PlusNanoseconds(159156600L),
                            Name = "Thiết kế cơ khí",
                            Status = 0,
                            UpdateBy = 1,
                            UpdateDate = new NodaTime.LocalDateTime(2024, 1, 10, 18, 28, 1).PlusNanoseconds(159156600L)
                        },
                        new
                        {
                            Id = 2L,
                            CreateBy = 1,
                            CreateDate = new NodaTime.LocalDateTime(2024, 1, 10, 18, 28, 1).PlusNanoseconds(159156600L),
                            Name = "Lập trình CNC",
                            Status = 0,
                            UpdateBy = 1,
                            UpdateDate = new NodaTime.LocalDateTime(2024, 1, 10, 18, 28, 1).PlusNanoseconds(159156600L)
                        },
                        new
                        {
                            Id = 3L,
                            CreateBy = 1,
                            CreateDate = new NodaTime.LocalDateTime(2024, 1, 10, 18, 28, 1).PlusNanoseconds(159156600L),
                            Name = "Vận hành máy CNC",
                            Status = 0,
                            UpdateBy = 1,
                            UpdateDate = new NodaTime.LocalDateTime(2024, 1, 10, 18, 28, 1).PlusNanoseconds(159156600L)
                        });
                });

            modelBuilder.Entity("HDNXUdemyData.Entities.ChapterCommentEntities", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("Id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("Comment")
                        .HasColumnType("text");

                    b.Property<int>("CreateBy")
                        .HasColumnType("integer")
                        .HasColumnName("CreateBy");

                    b.Property<LocalDateTime>("CreateDate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("CreateDate");

                    b.Property<int>("IdContentDetail")
                        .HasColumnType("integer");

                    b.Property<int>("IdCourse")
                        .HasColumnType("integer");

                    b.Property<int>("IdStudent")
                        .HasColumnType("integer");

                    b.Property<int>("Status")
                        .HasColumnType("integer")
                        .HasColumnName("Status");

                    b.Property<int>("UpdateBy")
                        .HasColumnType("integer")
                        .HasColumnName("UpdateBy");

                    b.Property<LocalDateTime>("UpdateDate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("UpdateDate");

                    b.HasKey("Id");

                    b.ToTable("ChapterComments", "sche_dev_HDNXUdemy");
                });

            modelBuilder.Entity("HDNXUdemyData.Entities.ContentCourseEntities", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("Id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<int>("CreateBy")
                        .HasColumnType("integer")
                        .HasColumnName("CreateBy");

                    b.Property<LocalDateTime>("CreateDate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("CreateDate");

                    b.Property<int>("IdCourse")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int>("Status")
                        .HasColumnType("integer")
                        .HasColumnName("Status");

                    b.Property<int>("UpdateBy")
                        .HasColumnType("integer")
                        .HasColumnName("UpdateBy");

                    b.Property<LocalDateTime>("UpdateDate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("UpdateDate");

                    b.HasKey("Id");

                    b.ToTable("ContentCourses", "sche_dev_HDNXUdemy");
                });

            modelBuilder.Entity("HDNXUdemyData.Entities.CourseCommentEntities", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("Id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("Comment")
                        .HasColumnType("text");

                    b.Property<int>("CreateBy")
                        .HasColumnType("integer")
                        .HasColumnName("CreateBy");

                    b.Property<LocalDateTime>("CreateDate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("CreateDate");

                    b.Property<int>("IdCourse")
                        .HasColumnType("integer");

                    b.Property<int>("IdStudent")
                        .HasColumnType("integer");

                    b.Property<int>("NumberStartVote")
                        .HasColumnType("integer");

                    b.Property<int>("Status")
                        .HasColumnType("integer")
                        .HasColumnName("Status");

                    b.Property<int>("UpdateBy")
                        .HasColumnType("integer")
                        .HasColumnName("UpdateBy");

                    b.Property<LocalDateTime>("UpdateDate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("UpdateDate");

                    b.HasKey("Id");

                    b.ToTable("CourseComments", "sche_dev_HDNXUdemy");
                });

            modelBuilder.Entity("HDNXUdemyData.Entities.CourseEntities", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("Id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<int>("CreateBy")
                        .HasColumnType("integer")
                        .HasColumnName("CreateBy");

                    b.Property<LocalDateTime>("CreateDate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("CreateDate");

                    b.Property<int>("Hours")
                        .HasColumnType("integer");

                    b.Property<int>("IdAuthor")
                        .HasColumnType("integer");

                    b.Property<int>("IdCategory")
                        .HasColumnType("integer");

                    b.Property<string>("Introdue")
                        .HasColumnType("text");

                    b.Property<bool>("IsDiscount")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsSubscription")
                        .HasColumnType("boolean");

                    b.Property<int>("Minutes")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int>("PercentDiscount")
                        .HasColumnType("integer");

                    b.Property<int>("PriceOfCourse")
                        .HasColumnType("integer");

                    b.Property<string>("ShortDescription")
                        .HasColumnType("text");

                    b.Property<int>("Status")
                        .HasColumnType("integer")
                        .HasColumnName("Status");

                    b.Property<int>("TotalChapter")
                        .HasColumnType("integer");

                    b.Property<int>("TotalStudentRegister")
                        .HasColumnType("integer");

                    b.Property<int>("TypeOfCourse")
                        .HasColumnType("integer");

                    b.Property<int>("UpdateBy")
                        .HasColumnType("integer")
                        .HasColumnName("UpdateBy");

                    b.Property<LocalDateTime>("UpdateDate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("UpdateDate");

                    b.Property<int>("Vote1Star")
                        .HasColumnType("integer");

                    b.Property<int>("Vote2Star")
                        .HasColumnType("integer");

                    b.Property<int>("Vote3Star")
                        .HasColumnType("integer");

                    b.Property<int>("Vote4Star")
                        .HasColumnType("integer");

                    b.Property<int>("Vote5Star")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Courses", "sche_dev_HDNXUdemy");
                });

            modelBuilder.Entity("HDNXUdemyData.Entities.InformationManualBankingEntities", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("Id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("AccountName")
                        .HasColumnType("text");

                    b.Property<int>("CreateBy")
                        .HasColumnType("integer")
                        .HasColumnName("CreateBy");

                    b.Property<LocalDateTime>("CreateDate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("CreateDate");

                    b.Property<string>("NameBanking")
                        .HasColumnType("text");

                    b.Property<string>("Notes")
                        .HasColumnType("text");

                    b.Property<string>("NumberBanking")
                        .HasColumnType("text");

                    b.Property<int>("Status")
                        .HasColumnType("integer")
                        .HasColumnName("Status");

                    b.Property<int>("UpdateBy")
                        .HasColumnType("integer")
                        .HasColumnName("UpdateBy");

                    b.Property<LocalDateTime>("UpdateDate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("UpdateDate");

                    b.HasKey("Id");

                    b.ToTable("InformationManualBankings", "sche_dev_HDNXUdemy");
                });

            modelBuilder.Entity("HDNXUdemyData.Entities.PromotionEntities", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("Id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("CodePromotion")
                        .HasColumnType("text");

                    b.Property<int>("CreateBy")
                        .HasColumnType("integer")
                        .HasColumnName("CreateBy");

                    b.Property<LocalDateTime>("CreateDate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("CreateDate");

                    b.Property<LocalDateTime>("EndTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("IsApplyMultiple")
                        .HasColumnType("boolean");

                    b.Property<LocalDateTime>("StartTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("Status")
                        .HasColumnType("integer")
                        .HasColumnName("Status");

                    b.Property<int>("UpdateBy")
                        .HasColumnType("integer")
                        .HasColumnName("UpdateBy");

                    b.Property<LocalDateTime>("UpdateDate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("UpdateDate");

                    b.Property<int>("ValuePromotion")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Promotions", "sche_dev_HDNXUdemy");
                });

            modelBuilder.Entity("HDNXUdemyData.Entities.PurcharseCourseEntities", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("Id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("ContentTranferBanking")
                        .HasColumnType("text");

                    b.Property<int>("CreateBy")
                        .HasColumnType("integer")
                        .HasColumnName("CreateBy");

                    b.Property<LocalDateTime>("CreateDate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("CreateDate");

                    b.Property<int>("IdCourse")
                        .HasColumnType("integer");

                    b.Property<int>("IdStudent")
                        .HasColumnType("integer");

                    b.Property<string>("PriceOfCourse")
                        .HasColumnType("text");

                    b.Property<int>("PurcharseStatus")
                        .HasColumnType("integer");

                    b.Property<int>("Status")
                        .HasColumnType("integer")
                        .HasColumnName("Status");

                    b.Property<int>("UpdateBy")
                        .HasColumnType("integer")
                        .HasColumnName("UpdateBy");

                    b.Property<LocalDateTime>("UpdateDate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("UpdateDate");

                    b.HasKey("Id");

                    b.ToTable("PurcharseCourses", "sche_dev_HDNXUdemy");
                });

            modelBuilder.Entity("HDNXUdemyData.Entities.StudentProcessEntities", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("Id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<int>("CreateBy")
                        .HasColumnType("integer")
                        .HasColumnName("CreateBy");

                    b.Property<LocalDateTime>("CreateDate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("CreateDate");

                    b.Property<int>("IdCourse")
                        .HasColumnType("integer");

                    b.Property<int>("LastContentOfContent")
                        .HasColumnType("integer");

                    b.Property<int>("NumberContentOfCourse")
                        .HasColumnType("integer");

                    b.Property<int>("Status")
                        .HasColumnType("integer")
                        .HasColumnName("Status");

                    b.Property<int>("UpdateBy")
                        .HasColumnType("integer")
                        .HasColumnName("UpdateBy");

                    b.Property<LocalDateTime>("UpdateDate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("UpdateDate");

                    b.HasKey("Id");

                    b.ToTable("StudentProcess", "sche_dev_HDNXUdemy");
                });

            modelBuilder.Entity("HDNXUdemyData.Entities.StudentPromotionEntities", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("Id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("CodePromotion")
                        .HasColumnType("text");

                    b.Property<int>("CreateBy")
                        .HasColumnType("integer")
                        .HasColumnName("CreateBy");

                    b.Property<LocalDateTime>("CreateDate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("CreateDate");

                    b.Property<int>("IdCourse")
                        .HasColumnType("integer");

                    b.Property<int>("IdPromotion")
                        .HasColumnType("integer");

                    b.Property<int>("IdStudent")
                        .HasColumnType("integer");

                    b.Property<int>("Status")
                        .HasColumnType("integer")
                        .HasColumnName("Status");

                    b.Property<int>("UpdateBy")
                        .HasColumnType("integer")
                        .HasColumnName("UpdateBy");

                    b.Property<LocalDateTime>("UpdateDate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("UpdateDate");

                    b.Property<int>("ValuePromotion")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("StudentPromotions", "sche_dev_HDNXUdemy");
                });

            modelBuilder.Entity("HDNXUdemyData.Entities.SubCategoryEntities", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("Id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<int>("CreateBy")
                        .HasColumnType("integer")
                        .HasColumnName("CreateBy");

                    b.Property<LocalDateTime>("CreateDate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("CreateDate");

                    b.Property<int>("IdCategory")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int>("Status")
                        .HasColumnType("integer")
                        .HasColumnName("Status");

                    b.Property<int>("UpdateBy")
                        .HasColumnType("integer")
                        .HasColumnName("UpdateBy");

                    b.Property<LocalDateTime>("UpdateDate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("UpdateDate");

                    b.HasKey("Id");

                    b.ToTable("SubCategories", "sche_dev_HDNXUdemy");
                });

            modelBuilder.Entity("HDNXUdemyData.Entities.UserEntities", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("Id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<int>("CreateBy")
                        .HasColumnType("integer")
                        .HasColumnName("CreateBy");

                    b.Property<LocalDateTime>("CreateDate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("CreateDate");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<int>("Genaral")
                        .HasColumnType("integer");

                    b.Property<bool>("IsRequestTeacher")
                        .HasColumnType("boolean");

                    b.Property<string>("KeyImages")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .HasColumnType("text");

                    b.Property<string>("Phone")
                        .HasColumnType("text");

                    b.Property<string>("PictureUrl")
                        .HasColumnType("text");

                    b.Property<int>("RoleId")
                        .HasColumnType("integer");

                    b.Property<int>("Status")
                        .HasColumnType("integer")
                        .HasColumnName("Status");

                    b.Property<int>("TypeLogin")
                        .HasColumnType("integer");

                    b.Property<int>("UpdateBy")
                        .HasColumnType("integer")
                        .HasColumnName("UpdateBy");

                    b.Property<LocalDateTime>("UpdateDate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("UpdateDate");

                    b.HasKey("Id");

                    b.ToTable("Users", "sche_dev_HDNXUdemy");
                });
#pragma warning restore 612, 618
        }
    }
}
