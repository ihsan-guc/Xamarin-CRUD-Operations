using Microsoft.EntityFrameworkCore;
using XamarinSqliteCRUD.Model.Entity;

namespace SqliteOrnek2
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Users>  Users{ get; set; }
        public DbSet<Department> Departments{ get; set; }
        public DbSet<Personel>  Personels{ get; set; }
        private readonly string _databasePath;
        public DatabaseContext(string databasePath)
        {
            _databasePath = databasePath;
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Filename={_databasePath}");
        }
    }
}
