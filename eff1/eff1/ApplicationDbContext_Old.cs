using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eff1
{
    public class ApplicationDbContext_Old : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=EFC;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>()
                .HasOne(o => o.Author)
                .WithMany(c => c.Books)
                .HasForeignKey(o => o.Authorid);

            modelBuilder.Entity<Author>()
                .HasOne(o => o.Nationality)
                .WithMany(c => c.Authors)
                .HasForeignKey(o => o.NationalityId);

            modelBuilder.Entity<Book>().HasQueryFilter(b => !b.IsDeleted);

         }
        public DbSet<Stocks> Stocks { get;  set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Author { get; set; }   
        public DbSet<Nationality> Nationality { get; set; }
    }
}
