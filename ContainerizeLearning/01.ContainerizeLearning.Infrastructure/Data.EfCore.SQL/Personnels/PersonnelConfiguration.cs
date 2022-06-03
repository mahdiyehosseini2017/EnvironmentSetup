namespace ContainerizeLearning.Infrastructure.Data.EfCore.SQL
{
    using ContainerizeLearning.Core.Domain;
    using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class PersonnelConfiguration : IEntityTypeConfiguration<Personnel>
{
    public void Configure(EntityTypeBuilder<Personnel> builder)
    {
        builder.HasKey(c => c.Id);
        builder.Property(c => c.Name).HasMaxLength(200);
        builder.Property(c => c.Family).HasMaxLength(200);
        builder.Property(c => c.PersonnelNumber).HasMaxLength(10).IsRequired();
    }
}
}