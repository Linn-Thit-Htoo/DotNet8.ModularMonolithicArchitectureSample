namespace Modules.Blog.Infrastructure.Db;

public class BlogDbContext : DbContext
{
    public BlogDbContext(DbContextOptions options)
        : base(options) { }

    public DbSet<Tbl_Blog> Tbl_Blogs { get; set; }
}
