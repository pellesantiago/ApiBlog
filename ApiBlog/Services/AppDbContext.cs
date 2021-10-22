using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiBlog.Entities;
using ApiBlog.EntityConfigurations;

namespace ApiBlog.Services
{
    public class AppDbContext : DbContext
	{
		public AppDbContext(DbContextOptions options) : base(options) {}
		public DbSet<User> Users { get; set; }
		public DbSet<Articule> Articules { get; set; }
		public DbSet<Comment> Comments { get; set; }


        #region FluentApi
        protected override void OnModelCreating(ModelBuilder builder) {

            #region Comment
            builder.Entity<Comment>().HasKey(_ => _.CommentId);
            builder.Entity<Comment>()
                .HasOne(_ => _.Articule)
                .WithMany(_ => _.Comments)
                .HasForeignKey(_ => _.ArticuleId);

            builder.Entity<Comment>().Property(_ => _.Content).IsRequired();
            builder.Entity<Comment>().Property(_ => _.Articule).IsRequired();
            #endregion
        }
        #endregion
    }

}
