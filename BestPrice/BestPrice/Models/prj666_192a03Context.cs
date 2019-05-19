using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BestPrice.Models
{
    public partial class prj666_192a03Context : DbContext
    {
        public prj666_192a03Context()
        {
        }

        public prj666_192a03Context(DbContextOptions<prj666_192a03Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Faqs> Faqs { get; set; }
        public virtual DbSet<Locations> Locations { get; set; }
        public virtual DbSet<Notifications> Notifications { get; set; }
        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<Reviews> Reviews { get; set; }
        public virtual DbSet<SearchHistories> SearchHistories { get; set; }
        public virtual DbSet<Sellers> Sellers { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<WishlistProduct> WishlistProduct { get; set; }
        public virtual DbSet<Wishlists> Wishlists { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySQL("Server=mymysql.senecacollege.ca;Uid=prj666_192a03;Pwd=fnML@8473;Database=prj666_192a03;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity<Faqs>(entity =>
            {
                entity.ToTable("FAQs", "prj666_192a03");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Answer)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Question)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Locations>(entity =>
            {
                entity.ToTable("Locations", "prj666_192a03");

                entity.HasIndex(e => e.Address)
                    .HasName("Address")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("int(10)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Province)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Notifications>(entity =>
            {
                entity.ToTable("Notifications", "prj666_192a03");

                entity.HasIndex(e => e.UserId)
                    .HasName("Notification_UserId_FK");

                entity.HasIndex(e => new { e.ProductId, e.UserId })
                    .HasName("ProductId");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10)")
                    .ValueGeneratedNever();

                entity.Property(e => e.ProductId).HasColumnType("int(10)");

                entity.Property(e => e.TimeStamp).HasDefaultValueSql("1970-01-01 00:00:01");

                entity.Property(e => e.UserId).HasColumnType("int(10)");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.Notifications)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Notification_ProductId_FK");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Notifications)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Notification_UserId_FK");
            });

            modelBuilder.Entity<Products>(entity =>
            {
                entity.ToTable("Products", "prj666_192a03");

                entity.HasIndex(e => e.SellerId)
                    .HasName("SellerId");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10)")
                    .ValueGeneratedNever();

                entity.Property(e => e.BeforePrice).HasColumnType("decimal(10,0)");

                entity.Property(e => e.CurrentPrice).HasColumnType("decimal(10,0)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.SellerId).HasColumnType("int(10)");

                entity.HasOne(d => d.Seller)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.SellerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Product_SellerId_FK");
            });

            modelBuilder.Entity<Reviews>(entity =>
            {
                entity.ToTable("Reviews", "prj666_192a03");

                entity.HasIndex(e => e.ProductId)
                    .HasName("ProductId");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(1500)
                    .IsUnicode(false);

                entity.Property(e => e.ProductId).HasColumnType("int(10)");

                entity.Property(e => e.Rating).HasColumnType("enum('1','2','3','4','5')");

                entity.Property(e => e.Subject)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.Reviews)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Review_ProductId_FK");
            });

            modelBuilder.Entity<SearchHistories>(entity =>
            {
                entity.ToTable("SearchHistories", "prj666_192a03");

                entity.HasIndex(e => e.UserId)
                    .HasName("UserId");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasColumnType("int(10)");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.SearchHistories)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SearchHistory_UserId_FK");
            });

            modelBuilder.Entity<Sellers>(entity =>
            {
                entity.ToTable("Sellers", "prj666_192a03");

                entity.HasIndex(e => e.Name)
                    .HasName("Name")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("int(10)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Link)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.ToTable("Users", "prj666_192a03");

                entity.HasIndex(e => e.Email)
                    .HasName("Email")
                    .IsUnique();

                entity.HasIndex(e => e.LocationId)
                    .HasName("NotificationId");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.LocationId).HasColumnType("int(10)");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.HasOne(d => d.Location)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.LocationId)
                    .HasConstraintName("User_LocationId_FK");
            });

            modelBuilder.Entity<WishlistProduct>(entity =>
            {
                entity.HasKey(e => new { e.WishlistId, e.ProductId });

                entity.ToTable("WishlistProduct", "prj666_192a03");

                entity.HasIndex(e => e.WishlistId)
                    .HasName("WishlistProduct_WishlistId_FK");

                entity.HasIndex(e => new { e.ProductId, e.WishlistId })
                    .HasName("ProductId");

                entity.Property(e => e.WishlistId).HasColumnType("int(10)");

                entity.Property(e => e.ProductId).HasColumnType("int(10)");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.WishlistProduct)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("WishlistProduct_ProductId_FK");

                entity.HasOne(d => d.Wishlist)
                    .WithMany(p => p.WishlistProduct)
                    .HasForeignKey(d => d.WishlistId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("WishlistProduct_WishlistId_FK");
            });

            modelBuilder.Entity<Wishlists>(entity =>
            {
                entity.ToTable("Wishlists", "prj666_192a03");

                entity.HasIndex(e => e.UserId)
                    .HasName("UserId");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10)")
                    .ValueGeneratedNever();

                entity.Property(e => e.UserId).HasColumnType("int(10)");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Wishlists)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Wishlist_UserId_FK");
            });
        }
    }
}
