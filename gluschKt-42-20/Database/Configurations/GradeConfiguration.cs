using gluschKt_42_20.Database.Helpers;
using gluschKt_42_20.Model;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace gluschKt_42_20.Database.Configurations
{
    public class GradeConfiguration : IEntityTypeConfiguration<Grade>
    {

        private const string TableName = "Grade";
        public void Configure(EntityTypeBuilder<Grade> builder)
        {
            builder
                .HasKey(p => p.GradeId)
                .HasName($"pk_{TableName}_grade_id");

            //для целочисленного первичного ключа задаем автогенерацию (к каждой новой записи будет добавлять +1)
            builder.Property(p => p.GradeId)
                .ValueGeneratedOnAdd();

            builder.Property(p => p.GradeId)
                .HasColumnName("grade_id")
                .HasComment("Идентификатор записи студента");

            builder.Property(p => p.StudentGrade)
                .IsRequired()
                .HasColumnName("student_grade")
                .HasColumnType(ColumnType.String).HasMaxLength(100)
                .HasComment("Номер группы");


            //для предмета
            builder.Property(p => p.SubjectId)
               .HasColumnName("subject_id")
               .HasComment("Идентификатор группы");

            builder.ToTable(TableName)
               .HasOne(p => p.Subject)
               .WithMany()
               .HasForeignKey(p => p.SubjectId)
               .HasConstraintName("fk_f_subject_id")
               .OnDelete(DeleteBehavior.Cascade);

            builder.ToTable(TableName)
                .HasIndex(p => p.SubjectId, $"idx_{TableName}_fk_f_subject_id");

            builder.Navigation(p => p.Subject)
            .AutoInclude();


           

         

            //для студента

            builder.Property(p => p.StudentId)
                           .HasColumnName("student_id")
                           .HasComment("Идентификатор");

            builder.ToTable(TableName)
               .HasOne(p => p.Student)
               .WithMany()
               .HasForeignKey(p => p.StudentId)
               .HasConstraintName("fk_f_student_id")
               .OnDelete(DeleteBehavior.Cascade);

            builder.ToTable(TableName)
                .HasIndex(p => p.StudentId, $"idx_{TableName}_fk_f_student_id");

            builder.Navigation(p => p.Student)
            .AutoInclude();

        }

    }
}
