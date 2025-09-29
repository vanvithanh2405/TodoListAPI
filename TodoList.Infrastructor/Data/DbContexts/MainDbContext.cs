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

        public virtual DbSet<TodoItems> TodoItem { get; set; }
        public virtual DbSet<Categories> Categories { get; set; }
        public virtual DbSet<References> References { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Categories>(entity =>
            {
                entity.ToTable("Categories");
                entity.HasKey(e => e.Id);
            });

            modelBuilder.Entity<References>(entity =>
            {
                entity.ToTable("References");
                entity.HasKey(e => e.Id);
            });

            modelBuilder.Entity<TodoItems>(entity =>
            {
                entity.ToTable("TodoItems");
                entity.HasKey(e => e.Id);

                entity.HasOne(d => d.References)
                      .WithMany(p => p.TodoItems)
                      .HasForeignKey(d => d.StatusRefId)
                      .HasConstraintName("FK_TodoItems_References");

                entity.HasOne(d => d.Categories)
                      .WithMany(p => p.TodoItems)
                      .HasForeignKey(d => d.CategoryId)
                      .OnDelete(DeleteBehavior.Cascade)
                      .HasConstraintName("FK_TodoItems_Categories");
            });
        }
    }
}
