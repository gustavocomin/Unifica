using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Unifica.Repository.Contexto;

namespace Unifica.Repository.Configuration
{
    internal class DbFactoryDbContext : IDesignTimeDbContextFactory<ContextoBanco>
    {
        public ContextoBanco CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ContextoBanco>();
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-KRVH88J;Database=TCC;user=sa;password=123;Trusted_Connection=True",
            options => options.EnableRetryOnFailure());
            ContextoBanco dbContext = new(optionsBuilder.Options);
            return dbContext;
        }
    }
}