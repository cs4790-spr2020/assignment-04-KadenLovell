using BlabberApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlabberApp.DataStore.Entities {
    public class UserMap : IEntityTypeConfiguration<User> {
        public void Configure(EntityTypeBuilder<User> entityBuilder) {
            // model
            entityBuilder.HasKey(x => x.Id);
            entityBuilder.Property(x => x.CreatedDate).IsRequired();
            entityBuilder.Property(x => x.CreatedBy).IsRequired();
            entityBuilder.Property(x => x.LastModifiedBy);
            entityBuilder.Property(x => x.LastModifiedDate);
            // user
            entityBuilder.Property(x => x.Username).HasMaxLength(24).IsRequired();
            entityBuilder.Property(x => x.Email).IsRequired();
        }
    }
}