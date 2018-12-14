using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ProjectOne.DataAccess
{
    public partial class ItaDPizzaContext : DbContext
    {
        public ItaDPizzaContext()
        {
        }

        public ItaDPizzaContext(DbContextOptions<ItaDPizzaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Address> Address { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<Ingredient> Ingredient { get; set; }
        public virtual DbSet<Inventory> Inventory { get; set; }
        public virtual DbSet<OrderDetail> OrderDetail { get; set; }
        public virtual DbSet<OrderHeader> OrderHeader { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<ProductRecipe> ProductRecipe { get; set; }
        public virtual DbSet<Store> Store { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=tcp:hansen1811.database.windows.net,1433;Initial Catalog=ItaDPizza;Persist Security Info=False;User ID=beauadmin;Password=1404Sql!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.0-rtm-35687");

            modelBuilder.Entity<Address>(entity =>
            {
                entity.ToTable("Address", "PO");

                entity.Property(e => e.AddressId).HasColumnName("AddressID");

                entity.Property(e => e.AddressLine1)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.AddressLine2).HasMaxLength(100);

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.State)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Zip).HasColumnName("ZIP");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Address)
                    .HasForeignKey(d => d.CustomerId);
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.ToTable("Customer", "PO");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.DefaultAddressId).HasColumnName("DefaultAddressID");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Ingredient>(entity =>
            {
                entity.ToTable("Ingredient", "PO");

                entity.Property(e => e.IngredientId).HasColumnName("IngredientID");

                entity.Property(e => e.IngredientName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.IngredientPrice)
                    .HasColumnType("decimal(18, 0)")
                    .HasDefaultValueSql("((1.00))");
            });

            modelBuilder.Entity<Inventory>(entity =>
            {
                entity.ToTable("Inventory", "PO");

                entity.Property(e => e.InventoryId).HasColumnName("InventoryID");

                entity.Property(e => e.IngredientId).HasColumnName("IngredientID");

                entity.Property(e => e.StoreId).HasColumnName("StoreID");

                entity.HasOne(d => d.Ingredient)
                    .WithMany(p => p.Inventory)
                    .HasForeignKey(d => d.IngredientId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.Inventory)
                    .HasForeignKey(d => d.StoreId);
            });

            modelBuilder.Entity<OrderDetail>(entity =>
            {
                entity.ToTable("OrderDetail", "PO");

                entity.Property(e => e.OrderDetailId).HasColumnName("OrderDetailID");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.OrderDetail)
                    .HasForeignKey(d => d.OrderId);

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.OrderDetail)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<OrderHeader>(entity =>
            {
                entity.HasKey(e => e.OrderId)
                    .HasName("PK_OrderHeader_OrderID");

                entity.ToTable("OrderHeader", "PO");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.AddressId).HasColumnName("AddressID");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.StoreId).HasColumnName("StoreID");

                entity.Property(e => e.TotalCost).HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("Product", "PO");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('Custom Pizza')");

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<ProductRecipe>(entity =>
            {
                entity.ToTable("ProductRecipe", "PO");

                entity.Property(e => e.ProductRecipeId).HasColumnName("ProductRecipeID");

                entity.Property(e => e.IngredientId).HasColumnName("IngredientID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.HasOne(d => d.Ingredient)
                    .WithMany(p => p.ProductRecipe)
                    .HasForeignKey(d => d.IngredientId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductRecipe)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Store>(entity =>
            {
                entity.ToTable("Store", "PO");

                entity.Property(e => e.StoreId).HasColumnName("StoreID");

                entity.Property(e => e.AddressLine1)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.AddressLine2).HasMaxLength(100);

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.State)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Zip).HasColumnName("ZIP");
            });
        }
    }
}
