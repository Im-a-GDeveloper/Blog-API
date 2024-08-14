using Microsoft.EntityFrameworkCore;

namespace Blog_API.Models{

    public class ApplicationDbContext : DbContext{

        public ApplicationDbContext(
            DbContextOptions<ApplicationDbContext> options
        ) : base(options)
        {

        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>()
            .HasMany(x => x.Post)
            .WithOne(y => y.User)
            .HasForeignKey(f => f.UserID)
            .IsRequired()
            .OnDelete(DeleteBehavior.Cascade);


        }

        public DbSet<User> Users => Set<User>();
        public DbSet<Post> Posts => Set<Post>();
    }
}