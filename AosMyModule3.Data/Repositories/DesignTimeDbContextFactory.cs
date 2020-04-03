using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace AosMyModule3.Data.Repositories
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<AosMyModule3DbContext>
    {
        public AosMyModule3DbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<AosMyModule3DbContext>();

            builder.UseSqlServer("Data Source=(local);Initial Catalog=VirtoCommerce3;Persist Security Info=True;User ID=virto;Password=virto;MultipleActiveResultSets=True;Connect Timeout=30");

            return new AosMyModule3DbContext(builder.Options);
        }
    }
}
