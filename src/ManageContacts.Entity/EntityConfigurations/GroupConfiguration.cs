using ManageContacts.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ManageContacts.Entity.EntityConfigurations;

public class GroupConfiguration : IEntityTypeConfiguration<Group>
{
    public void Configure(EntityTypeBuilder<Group> builder)
    {
        builder.HasQueryFilter(x => !x.Deleted);
                    
        builder.Property(u => u.CreatedTime)
            .HasConversion(v => v, v => DateTime.SpecifyKind(v, DateTimeKind.Utc));
        
        
        builder.HasOne(u => u.User)
            .WithMany(u => u.Groups)
            .HasForeignKey(u => u.UserId)
            .IsRequired(false);

    }
}