using System;
using System.Data.Entity;

namespace CommonModule.Services
{
    internal class DataBaseContext : DbContext
    {
        public DataBaseContext() : base("DbConnectionString")
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<DataBaseContext>());
        }
        public DbSet<Order> Orders { get; set; }
    }
}
