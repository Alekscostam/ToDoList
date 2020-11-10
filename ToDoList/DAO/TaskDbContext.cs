
using Microsoft.EntityFrameworkCore;
using ToDoList.Model;

namespace ToDoList.DAO
{
   public class TaskDbContext : DbContext
    {
        public DbSet<Task> Tasks { get; set; }

        public DbSet<Priority> Priorities { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder dataSourcePath)=> dataSourcePath.UseSqlite("DataSource=TaskDb.db");
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Task>()
             .HasOne<Priority>(s => s.Priority)
             .WithMany(g => g.Tasks)
             .HasForeignKey(s => s.IdPriority);
        }
    }
}

