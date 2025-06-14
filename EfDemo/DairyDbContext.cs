
using EfDemo.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace EfDemo
{
    public class DairyDbContext : DbContext
    {
        public DairyDbContext(DbContextOptions<DairyDbContext> options) : base(options) { }

        public DbSet<ProductModel> Products { get; set; }
    }
}
