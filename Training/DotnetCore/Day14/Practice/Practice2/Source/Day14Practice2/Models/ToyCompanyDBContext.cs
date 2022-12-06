using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Day14Practice2.Models
{
    public partial class ToyCompanyDBContext : DbContext
    {
        public ToyCompanyDBContext()
        {
        }

        public ToyCompanyDBContext(DbContextOptions<ToyCompanyDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Address> Addresses { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<ManufacturePlant> ManufacturePlants { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderItem> OrderItems { get; set; }
        public virtual DbSet<PlantWiseToyManufacture> PlantWiseToyManufactures { get; set; }
        public virtual DbSet<Toy> Toys { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=PC0352\\MSSQL2019;Database=ToyCompanyDB;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Address>(entity =>
            {
                entity.ToTable("Address");

                entity.Property(e => e.AddressId).HasColumnName("AddressID");

                entity.Property(e => e.Address1)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Address");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Addresses)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK__Address__Custome__403A8C7D");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.ToTable("Customer");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Gender)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<ManufacturePlant>(entity =>
            {
                entity.HasKey(e => e.PlantId)
                    .HasName("PK__Manufact__98FE46BC347B5266");

                entity.ToTable("ManufacturePlant");

                entity.Property(e => e.PlantId).HasColumnName("PlantID");

                entity.Property(e => e.Location)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Pincode)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.PlantName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.OrderDate).HasColumnType("date");

                entity.Property(e => e.Total).HasColumnType("money");

                entity.HasOne(d => d.AddressNavigation)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.Address)
                    .HasConstraintName("FK__Orders__Address__440B1D61");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK__Orders__Customer__4316F928");
            });

            modelBuilder.Entity<OrderItem>(entity =>
            {
                entity.HasKey(e => e.ListingId)
                    .HasName("PK__OrderIte__BF3EBEF0AB51C49C");

                entity.Property(e => e.ListingId).HasColumnName("ListingID");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.ToyId).HasColumnName("ToyID");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.OrderItems)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("FK__OrderItem__Order__47DBAE45");

                entity.HasOne(d => d.Toy)
                    .WithMany(p => p.OrderItems)
                    .HasForeignKey(d => d.ToyId)
                    .HasConstraintName("FK__OrderItem__ToyID__48CFD27E");
            });

            modelBuilder.Entity<PlantWiseToyManufacture>(entity =>
            {
                entity.HasKey(e => e.ListingId)
                    .HasName("PK__PlantWis__BF3EBEF08995DB89");

                entity.ToTable("PlantWiseToyManufacture");

                entity.Property(e => e.ListingId).HasColumnName("ListingID");

                entity.Property(e => e.PlantId).HasColumnName("PlantID");

                entity.Property(e => e.ToyId).HasColumnName("ToyID");

                entity.HasOne(d => d.Plant)
                    .WithMany(p => p.PlantWiseToyManufactures)
                    .HasForeignKey(d => d.PlantId)
                    .HasConstraintName("FK__PlantWise__Plant__3C69FB99");

                entity.HasOne(d => d.Toy)
                    .WithMany(p => p.PlantWiseToyManufactures)
                    .HasForeignKey(d => d.ToyId)
                    .HasConstraintName("FK__PlantWise__ToyID__3D5E1FD2");
            });

            modelBuilder.Entity<Toy>(entity =>
            {
                entity.ToTable("Toy");

                entity.Property(e => e.ToyId).HasColumnName("ToyID");

                entity.Property(e => e.Price).HasColumnType("money");

                entity.Property(e => e.ToyName)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
