using BlogDemo.Configurations;
using Microsoft.EntityFrameworkCore;

namespace BlogDemo
{
    public class BlogDbContext : DbContext  
    {
        public BlogDbContext()
        {
            
        }

        public BlogDbContext(DbContextOptions<BlogDbContext> options)
        :base (options)
        {
            
        }

        public DbSet<Blog>? Blogs { get; set; }
        public DbSet<Author>? Authors { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Tag> Tags { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new BlogConfiguration());
            modelBuilder.ApplyConfiguration(new PostTagConfiguration());
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder.IsConfigured == false)
            {
                string connectionString = "Server=DESKTOP-IKUABEV\\SQLSOFTUNI;Database=BlogDb;Trusted_Connection=True;TrustServerCertificate=True";

                optionsBuilder.UseSqlServer(connectionString);
            }
        }
    }
}
        