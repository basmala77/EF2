using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sequences
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\ProjectModels;Initial Catalog=EF-SEQ;Integrated Security=True;");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasSequence<int>("OrderNumber");
            modelBuilder.Entity<Order>()
                .Property(x => x.OrderNo)
                .HasDefaultValueSql("NEXT VALUE FOR OrderNumber");
        }
        public DbSet<Order> Orders { get; set; }

        public class Order
        {
            public int Id { get; set; }
            public long OrderNo
            { get; set; }   
            public double Amount { get; set; }  
        }
    }
}
