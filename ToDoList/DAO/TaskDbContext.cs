
using Microsoft.EntityFrameworkCore;
using ToDoList.Model;

namespace ToDoList.DAO
{
   public class TaskDbContext : DbContext
    {
        public DbSet<Task> Tasks { get; set; }

        public DbSet<Priority> Priorities { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)=> options.UseSqlite("DataSource=TaskDb.db");

    }
}
