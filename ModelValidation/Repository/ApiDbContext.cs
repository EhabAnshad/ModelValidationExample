using Microsoft.EntityFrameworkCore;
using ModelValidation.Models;

namespace ModelValidation.Repository
{
    public class ApiDbContext: DbContext
    {
        public ApiDbContext(DbContextOptions<ApiDbContext> options)
            : base(options)
        {
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Batch>()
        //        .HasOne(p => p.Order)
        //        .WithMany(b => b.CompletedPerBatch)
        //        .HasForeignKey(p => p.OrderId)
        //        .HasConstraintName("ForeignKey_Post_Blog");
        //}

        public DbSet<UserModel> Users { get; set; }
    }
}
