using gluschKt_42_20.Database.Helpers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using gluschKt_42_20.Model;

namespace gluschKt_42_20.Database.Configurations
{
    public class SubjectConfiguration : IEntityTypeConfiguration<Subject>
    {
        private const string TableName = "Subject";
        public void Configure(EntityTypeBuilder<Subject> builder)
        {
            builder
                .HasKey(p => p.SubjectId)
                .HasName($"pk_{TableName}_Subject_id");

            //для целочисленного первичного ключа задаем автогенерацию (к каждой новой записи будет добавлять +1)
            builder.Property(p => p.SubjectId)
                .ValueGeneratedOnAdd();

            builder.Property(p => p.SubjectId)
                .HasColumnName("Subject_id")
                .HasComment("Идентификатор предмета");

            builder.Property(p => p.SubjectName)
                .IsRequired()
                .HasColumnName("Subject_name")
                .HasColumnType(ColumnType.String).HasMaxLength(100)
                .HasComment("Предмет");


        }
    }
}
