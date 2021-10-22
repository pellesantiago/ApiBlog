using Microsoft.EntityFrameworkCore;
using ApiBlog.Repository.Entities;

namespace ApiBlog.Repository.EntityDbContext
{
    public class AppDbContext : DbContext
	{
		public AppDbContext(DbContextOptions options) : base(options) {}
		public DbSet<User> Users { get; set; }
		public DbSet<Article> Articles { get; set; }
		public DbSet<Comment> Comments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.ApplyConfigurationsFromAssembly(this.GetType().Assembly);
        }
    }

}
