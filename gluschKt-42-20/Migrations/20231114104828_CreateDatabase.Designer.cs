﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using gluschKt_42_20.Database;

#nullable disable

namespace gluschKt_42_20.Migrations
{
    [DbContext(typeof(StudentDbContext))]
    [Migration("20231114104828_CreateDatabase")]
    partial class CreateDatabase
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("gluschKt_42_20.Model.Group", b =>
                {
                    b.Property<int>("GroupId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("group_id")
                        .HasComment("Идентификатор записи студента");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GroupId"));

                    b.Property<string>("GroupName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar")
                        .HasColumnName("group_name")
                        .HasComment("Номер группы");

                    b.HasKey("GroupId")
                        .HasName("pk_Group_group_id");

                    b.ToTable("Group");
                });

            modelBuilder.Entity("gluschKt_42_20.Model.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("student_id")
                        .HasComment("Идентификатор записи студента");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StudentId"));

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar")
                        .HasColumnName("first_name")
                        .HasComment("Имя студента");

                    b.Property<int>("GroupId")
                        .HasColumnType("int")
                        .HasColumnName("group_id")
                        .HasComment("Идентификатор группы");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar")
                        .HasColumnName("last_name")
                        .HasComment("Фамилия");

                    b.Property<string>("MiddleName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar")
                        .HasColumnName("middle_name")
                        .HasComment("Отчество");

                    b.HasKey("StudentId")
                        .HasName("pk_Student_student_id");

                    b.HasIndex(new[] { "GroupId" }, "idx_Student_fk_f_group_id");

                    b.ToTable("Student", (string)null);
                });

            modelBuilder.Entity("gluschKt_42_20.Model.Subject", b =>
                {
                    b.Property<int>("SubjectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Subject_id")
                        .HasComment("Идентификатор предмета");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SubjectId"));

                    b.Property<string>("SubjectName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar")
                        .HasColumnName("Subject_name")
                        .HasComment("Предмет");

                    b.HasKey("SubjectId")
                        .HasName("pk_Subject_Subject_id");

                    b.ToTable("Subject");
                });

            modelBuilder.Entity("gluschKt_42_20.Model.Student", b =>
                {
                    b.HasOne("gluschKt_42_20.Model.Group", "Group")
                        .WithMany()
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_f_group_id");

                    b.Navigation("Group");
                });
#pragma warning restore 612, 618
        }
    }
}
