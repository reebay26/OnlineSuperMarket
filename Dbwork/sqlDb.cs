using Microsoft.EntityFrameworkCore;
using OnlineSuperMarket.Models;


namespace OnlineSuperMarket.Dbwork
{
    public class sqlDb:DbContext
    {
        public sqlDb(DbContextOptions<sqlDb> options) : base(options)
        {

        }

   
        public DbSet<Register_model> register { get; set; }

        public DbSet<Category> category { get; set; }
        public DbSet<Brand> tbl_brand { get; set; }
    public DbSet<Product_Model> tbl_product { get; set; }
        public DbSet<Contact> tbl_contact { get; set; }
        public DbSet<Cart_Model> Cart { get; set; }
        public DbSet<Order_Model> tbl_Order { get; set; }
    public DbSet<Order_Items> order_Items { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order_Model>()
                .HasMany(o => o.Order_Items)
                .WithOne(oi => oi.Order)
                .HasForeignKey(oi => oi.Order_id)
                .OnDelete(DeleteBehavior.Cascade); // ✅ Ensures deletion cascade

            base.OnModelCreating(modelBuilder);
        }

    }
}
