namespace ContainerizeLearning.Infrastructure.Data.EfCore.SQL
{
    using ContainerizeLearning.Core.Domain;
    using Microsoft.EntityFrameworkCore;

public class HRDbContext: DbContext
{
        public HRDbContext(DbContextOptions options) : base(options)
        {
        }
        
        public DbSet<Personnel>? Personnels { get; set; }
  
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
  
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
        }
}
}