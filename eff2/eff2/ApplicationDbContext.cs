using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eff2
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=EF2;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;");
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Blog>()
                .HasMany(b => b.Posts)
                .WithOne(b => b.Blog)
                .OnDelete(DeleteBehavior.SetNull);
        }

        public DbSet<Blog> Blogs { get; set; }  
        public DbSet<Post> Posts { get; set; }  
    }
}
