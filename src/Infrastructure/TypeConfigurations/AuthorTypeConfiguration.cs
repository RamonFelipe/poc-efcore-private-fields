using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.TypeConfigurations
{
    public class AuthorTypeConfiguration : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.ToTable("authors2");
            builder.HasKey("_id");
            builder.Property("_name").IsRequired();
            builder.HasMany("_books").WithOne().HasForeignKey("author_id");
        }
    }
}