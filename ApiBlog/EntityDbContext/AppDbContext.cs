using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiBlog.Entities;
using ApiBlog.EntityConfigurations;

namespace ApiBlog.EntityDbContext
{
    public class AppDbContext : DbContext
	{
		public AppDbContext(DbContextOptions options) : base(options) {}
		public DbSet<User> Users { get; set; }
		public DbSet<Articule> Articules { get; set; }
		public DbSet<Comment> Comments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new ArticuleConfiguration());
            modelBuilder.ApplyConfiguration(new CommentConfiguration());
        }
    }

}
