using Microsoft.EntityFrameworkCore;

namespace razor.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions options) : base(options) { }
        public virtual DbSet<Product> Products { get; set; }
    }
}
