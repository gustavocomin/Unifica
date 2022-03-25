using Microsoft.EntityFrameworkCore;

namespace Unifica.Repository.Contexto
{
    public class ContextoBanco : DbContext
    {
        protected ContextoBanco()
        {
        }

        public ContextoBanco(DbContextOptions options) : base(options)
        {
        }

        public ContextoBanco(DbContextOptions<ContextoBanco> options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer("Server=DESKTOP-KRVH88J;Database=TCC;user=sa;password=123;Trusted_Connection=True",
                options => options.EnableRetryOnFailure());
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.ApplyConfiguration(new CourseConfig());
            //modelBuilder.ApplyConfiguration(new UserConfig());
            base.OnModelCreating(modelBuilder);
        }

    }
}