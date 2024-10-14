using Microsoft.EntityFrameworkCore;
using ShoppingServerApi.Model;

namespace ShoppingServerApi.Data
{
    public class ShoppingCartDbContext : DbContext
    {
        public ShoppingCartDbContext(DbContextOptions<ShoppingCartDbContext> options) : base(options) { }

        public DbSet<Category> categories { get; set; }
        public DbSet<Product> products { get; set; }

    }
}
