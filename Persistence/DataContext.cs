using System.Diagnostics;
using Microsoft.EntityFrameworkCore;
using Domain;

namespace Persistence
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DataContext() : base() { }
        public DbSet<Domain.Activity> Activities { get; set; }

    }
}