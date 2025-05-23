using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.Collections.Generic;
using System.Data;
using System.Reflection;
using System.Reflection.Emit;
using static ShopDbContext;

public class Compability
{
    public int ReportID { get; set; }
    public int ModuleVersionID { get; set; }
    public int UserID { get; set; }
    public string DeviceModel { get; set; }
    public string AndroidVersion { get; set; }
    public string WorkStatus { get; set; }
    public string UserNotes { get; set; }
    public string ReportDate { get; set; }

    // Навигационное свойство
    public virtual ModuleVersion ModuleVersion { get; set; }
    public virtual User User { get; set; }
}

public class DeveloperProfile
{
    public int UserID { get; set; }
    public string Bio { get; set; }
    public decimal WebsiteUrl { get; set; }

    public virtual User User { get; set; }
}

public class ModuleCategory
{
    public int Id { get; set; }
    public string Date { get; set; }
    public int CustomerId { get; set; }
    public string Status { get; set; }

    // Навигационное свойство к Customer
    public Customer Customer { get; set; }

    // Навигационное свойство к OrderDetails (заказ может иметь много деталей)
    public List<OrderDetail> OrderDetails { get; set; }
}

public class OrderDetail
{
    public int Id { get; set; }
    public int OrderId { get; set; }     // Внешний ключ
    public int ProductId { get; set; }   // Внешний ключ
    public int Quantity { get; set; }

    // Навигационное свойство к заказу
    public Order Order { get; set; }

    // Навигационное свойство к продукту
    public Product Product { get; set; }

}

public class Customer
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }

    // Навигационное свойство к заказам этого клиента
    public List<Order> Orders { get; set; }


}

public class ShopDbContext : DbContext
{
    public DbSet<Compability> Compability { get; set; }
    public DbSet<DeveloperProfile> DeveloperProfiles { get; set; }
    public DbSet<ModuleTag> ModuleTags { get; set; }
    public DbSet<ModuleVersion> ModuleVersions { get; set; }
    public DbSet<Module> Modules { get; set; }
    public DbSet<Review> Reviews { get; set; }
    public DbSet<Role> Roles { get; set; }
    public DbSet<Tag> Tags { get; set; }
    public DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Host=localhost;Database=Magisk;Username=postgres;Password=1234");
    }

    public class ApplicationDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Customer> Customers { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // --- Связь: Category (1) - Product (M) ---
            // У одной Категории много Продуктов.
            // У одного Продукта одна Категория.
            modelBuilder.Entity<Product>()
                .HasOne(p => p.Category)          // У Product есть одна Category
                .WithMany(c => c.Products2)        // У Category есть много Products
                .HasForeignKey(p => p.CategoryId); // Внешний ключ в Product - это CategoryId

            // --- Связь: Customer (1) - Order (M) ---
            // У одного Клиента много Заказов.
            // У одного Заказа один Клиент.
            modelBuilder.Entity<Order>()
                .HasOne(o => o.Customer)          // У Order есть один Customer
                .WithMany(c => c.Orders)          // У Customer есть много Orders
                .HasForeignKey(o => o.CustomerId); // Внешний ключ в Order - это CustomerId

            // --- Связь: Order (1) - OrderDetail (M) ---
            // У одного Заказа много Деталей Заказа.
            // У одной Детали Заказа один Заказ.
            modelBuilder.Entity<OrderDetail>()
                .HasOne(od => od.Order)           // У OrderDetail есть один Order
                .WithMany(o => o.OrderDetails)    // У Order есть много OrderDetails
                .HasForeignKey(od => od.OrderId);  // Внешний ключ в OrderDetail - это OrderId

            // --- Связь: Product (1) - OrderDetail (M) ---
            // Один Продукт может быть во многих Деталях Заказа.
            // Одна Деталь Заказа ссылается на один Продукт.
            modelBuilder.Entity<OrderDetail>()
                .HasOne(od => od.Product)         // У OrderDetail есть один Product
                .WithMany(p => p.OrderDetails)    // У Product есть много OrderDetails
                .HasForeignKey(od => od.ProductId); // Внешний ключ в OrderDetail - это ProductId
        }
    }
}