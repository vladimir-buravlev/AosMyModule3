using EntityFrameworkCore.Triggers;
using Microsoft.EntityFrameworkCore;

namespace AosMyModule3.Data.Repositories
{
    public class AosMyModule3DbContext : DbContextWithTriggers
    {
        public AosMyModule3DbContext(DbContextOptions<AosMyModule3DbContext> options)
          : base(options)
        {
        }

        protected AosMyModule3DbContext(DbContextOptions options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //        modelBuilder.Entity<MyModuleEntity>().ToTable("MyModule").HasKey(x => x.Id);
            //        modelBuilder.Entity<MyModuleEntity>().Property(x => x.Id).HasMaxLength(128);
            //        base.OnModelCreating(modelBuilder);
        }
    }
}

