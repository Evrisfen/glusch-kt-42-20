using gluschKt_42_20.Database.Helpers;
using gluschKt_42_20.Model;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace gluschKt_42_20.Database.Configurations
{
    public class GroupConfiguration : IEntityTypeConfiguration<Group>
    {

        private const string TableName = "Group";
        public void Configure(EntityTypeBuilder<Group> builder)
        {
            builder
                .HasKey(p => p.GroupId)
                .HasName($"pk_{TableName}_group_id");

            //для целочисленного первичного ключа задаем автогенерацию (к каждой новой записи будет добавлять +1)
            builder.Property(p => p.GroupId)
                .ValueGeneratedOnAdd();

            builder.Property(p => p.GroupId)
                .HasColumnName("group_id")
                .HasComment("Идентификатор записи студента");

            builder.Property(p => p.GroupName)
                .IsRequired()
                .HasColumnName("group_name")
                .HasColumnType(ColumnType.String).HasMaxLength(100)
                .HasComment("Номер группы");

  
        }


    }
}
