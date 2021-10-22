using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiBlog.Entities;

namespace ApiBlog.Services
{
    public class AppDbContext : DbContext
	{
		public AppDbContext(DbContextOptions options) : base(options) {}
		public DbSet<User> Users { get; set; }
		public DbSet<Articule> Posts { get; set; }
		public DbSet<Comment> Comments { get; set; }

    }
}
