using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MyPieShop.Models
{
    public class MyPieShopDbContext : IdentityDbContext
    {
        public MyPieShopDbContext(DbContextOptions<MyPieShopDbContext> options) : base(options) { }

        public DbSet<Category> Categories { set; get; }
        public DbSet<Pie> Pies { set; get; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { set; get; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

    }
}
