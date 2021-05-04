using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.TypeConfigurations
{
    public class AuthorTypeConfiguration : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.ToTable("authors");
            builder.HasKey("id");
            builder.Property("name").IsRequired();
            builder.HasMany("books").WithOne().HasForeignKey("author_id");
        }
    }
}