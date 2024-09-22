using MinhaAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace MinhaAPI.Data{

    public class AppDbContext : DbContext{

        public DbSet<Todo> Todos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            _ = optionsBuilder.UseSqlite(connectionString: "DataSource=app.db;Cache=Shared");
        }
    }
}