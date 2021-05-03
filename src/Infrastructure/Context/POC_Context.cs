using Infrastructure.TypeConfigurations;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Context
{
    public class POC_Context : DbContext
    {
        public POC_Context(DbContextOptions<POC_Context> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // modelBuilder.UsePropertyAccessMode(PropertyAccessMode.Field);
            modelBuilder.ApplyConfiguration(new AuthorTypeConfiguration());
            modelBuilder.ApplyConfiguration(new BookTypeConfiguration());
        }
    }
}