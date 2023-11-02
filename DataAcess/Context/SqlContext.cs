using Business.Models;
using Microsoft.EntityFrameworkCore;
using System.Data.Entity;

namespace DataAcess.Context
{
    public class SqlContext : System.Data.Entity.DbContext
    {
        public SqlContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Key> Transactions { get; set; }
        public DbSet<Receiver> Receivers { get; set; }
        public DbSet<Transaction> Transactions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(SqlContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }

    }
}
