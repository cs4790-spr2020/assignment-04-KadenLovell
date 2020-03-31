using BlabberApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlabberApp.DataStore.Entities {
    public class BlabMap : IEntityTypeConfiguration<Blab> {
        public void Configure(EntityTypeBuilder<Blab> entityBuilder) {
            // model
            entityBuilder.HasKey(x => x.Id);
            entityBuilder.Property(x => x.CreatedDate).IsRequired();
            entityBuilder.Property(x => x.CreatedBy).IsRequired();
            entityBuilder.Property(x => x.LastModifiedBy);
            entityBuilder.Property(x => x.LastModifiedDate);
            // blab
            entityBuilder.Property(x => x.Message).IsRequired();
            entityBuilder.Property(x => x.UserId).IsRequired();

            entityBuilder.HasOne(x => x.User)
                .WithMany(x => x.Blabs)
                .HasForeignKey(x => x.UserId)
                .IsRequired();
        }
    }
}