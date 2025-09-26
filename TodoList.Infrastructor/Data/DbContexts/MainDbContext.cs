using Microsoft.EntityFrameworkCore;
using TodoList.Infrastructure.Data.Entities;

namespace TodoList.Infrastructure.Data.DbContexts
{
    public partial class MainDbContext: DbContext
    {
        public MainDbContext() { }

        public MainDbContext(DbContextOptions<MainDbContext> options) : base(options)
        {
        }

        public virtual DbSet<TodoItem> TodoItem { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
