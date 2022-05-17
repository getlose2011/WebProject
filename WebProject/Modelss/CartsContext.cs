using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebProject.Modelss
{
    public partial class CartsContext : DbContext
    {
        public CartsContext()
        {
        }

        public CartsContext(DbContextOptions<CartsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Category> Categories { get; set; } = null!;
        public virtual DbSet<Foobar> Foobars { get; set; } = null!;
        public virtual DbSet<ListEndpointsByPlatformApplication> ListEndpointsByPlatformApplications { get; set; } = null!;
        public virtual DbSet<Order> Orders { get; set; } = null!;
        public virtual DbSet<OrdersDetail> OrdersDetails { get; set; } = null!;
        public virtual DbSet<Product> Products { get; set; } = null!;
        public virtual DbSet<ProductsCommet> ProductsCommets { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                //optionsBuilder.UseSqlServer("Server=.;Database=Carts;Trusted_Connection=True;MultipleActiveResultSets=true;User ID=sa;Password=123456");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>(entity =>
            {
                entity.HasKey(e => new { e.CategoryId, e.CategoryName });

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.CategoryName).HasMaxLength(15);
            });

            modelBuilder.Entity<Foobar>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<ListEndpointsByPlatformApplication>(entity =>
            {
                entity.ToTable("listEndpointsByPlatformApplication");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Enabled).HasMaxLength(50);

                entity.Property(e => e.EndpointArn).HasMaxLength(255);

                entity.Property(e => e.Token).HasMaxLength(255);
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.UserId).HasMaxLength(128);
            });

            modelBuilder.Entity<OrdersDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OrdersDetail");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Price).HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.Property(e => e.DefaultImageUrl).HasColumnName("DefaultImageURL");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.Path).HasMaxLength(200);

                entity.Property(e => e.Price).HasColumnType("decimal(28, 3)");

                entity.Property(e => e.PublishDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<ProductsCommet>(entity =>
            {
                entity.Property(e => e.Content).IsUnicode(false);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.UserId).HasMaxLength(100);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
