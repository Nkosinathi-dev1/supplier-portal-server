using Microsoft.EntityFrameworkCore;
using server.Models;
using System.Collections.Generic;

namespace server.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Supplier> Suppliers => Set<Supplier>();
    }
}
