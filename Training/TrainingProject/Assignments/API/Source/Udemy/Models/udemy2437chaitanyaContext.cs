using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Udemy.Models
{
    public partial class udemy2437chaitanyaContext : DbContext
    {
        public udemy2437chaitanyaContext()
        {
        }

        public udemy2437chaitanyaContext(DbContextOptions<udemy2437chaitanyaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ApplicationObject> ApplicationObjects { get; set; }
        public virtual DbSet<ApplicationObjectType> ApplicationObjectTypes { get; set; }
        public virtual DbSet<Cart> Carts { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Purchase> Purchases { get; set; }
        public virtual DbSet<PurchaseWiseCourse> PurchaseWiseCourses { get; set; }
        public virtual DbSet<Resource> Resources { get; set; }
        public virtual DbSet<Topic> Topics { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=43.204.134.14;Database=udemy-2437-chaitanya;User Id=udemy-2437-chaitanya;Password=LySjY6IDGFUTXpi;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ApplicationObject>(entity =>
            {
                entity.ToTable("ApplicationObject");

                entity.Property(e => e.ApplicationObjectId).HasColumnName("ApplicationObjectID");

                entity.Property(e => e.ApplicationObjectName)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.TypeId).HasColumnName("TypeID");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.ApplicationObjects)
                    .HasForeignKey(d => d.TypeId)
                    .HasConstraintName("FK__Applicati__TypeI__267ABA7A");
            });

            modelBuilder.Entity<ApplicationObjectType>(entity =>
            {
                entity.HasKey(e => e.TypeId)
                    .HasName("PK__Applicat__516F0395296B95A1");

                entity.ToTable("ApplicationObjectType");

                entity.Property(e => e.TypeId).HasColumnName("TypeID");

                entity.Property(e => e.TypeName)
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Cart>(entity =>
            {
                entity.ToTable("Cart");

                entity.Property(e => e.CartId).HasColumnName("CartID");

                entity.Property(e => e.CourseId).HasColumnName("CourseID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.Carts)
                    .HasForeignKey(d => d.CourseId)
                    .HasConstraintName("FK__Cart__CourseID__440B1D61");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Carts)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__Cart__UserID__4316F928");
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.ToTable("Category");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.CategoryName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ParentCategoryId).HasColumnName("ParentCategoryID");

                entity.HasOne(d => d.ParentCategory)
                    .WithMany(p => p.InverseParentCategory)
                    .HasForeignKey(d => d.ParentCategoryId)
                    .HasConstraintName("FK__Category__Parent__29572725");

                entity.HasOne(d => d.StatusNavigation)
                    .WithMany(p => p.Categories)
                    .HasForeignKey(d => d.Status)
                    .HasConstraintName("FK__Category__Status__2A4B4B5E");
            });

            modelBuilder.Entity<Course>(entity =>
            {
                entity.ToTable("Course");

                entity.Property(e => e.CourseId).HasColumnName("CourseID");

                entity.Property(e => e.CourseName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.SubCategoryId).HasColumnName("SubCategoryID");

                entity.Property(e => e.TutorId).HasColumnName("TutorID");

                entity.HasOne(d => d.StatusNavigation)
                    .WithMany(p => p.Courses)
                    .HasForeignKey(d => d.Status)
                    .HasConstraintName("FK__Course__Status__32E0915F");

                entity.HasOne(d => d.SubCategory)
                    .WithMany(p => p.Courses)
                    .HasForeignKey(d => d.SubCategoryId)
                    .HasConstraintName("FK__Course__SubCateg__30F848ED");

                entity.HasOne(d => d.Tutor)
                    .WithMany(p => p.Courses)
                    .HasForeignKey(d => d.TutorId)
                    .HasConstraintName("FK__Course__TutorID__31EC6D26");
            });

            modelBuilder.Entity<Purchase>(entity =>
            {
                entity.ToTable("Purchase");

                entity.Property(e => e.PurchaseId).HasColumnName("PurchaseID");

                entity.Property(e => e.PurchaseDate).HasColumnType("date");

                entity.Property(e => e.Total).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Purchases)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__Purchase__UserID__3B75D760");
            });

            modelBuilder.Entity<PurchaseWiseCourse>(entity =>
            {
                entity.HasKey(e => e.ListingId)
                    .HasName("PK__Purchase__BF3EBEF0DE3A4084");

                entity.Property(e => e.ListingId).HasColumnName("ListingID");

                entity.Property(e => e.CourseId).HasColumnName("CourseID");

                entity.Property(e => e.PurchaseId).HasColumnName("PurchaseID");

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.PurchaseWiseCourses)
                    .HasForeignKey(d => d.CourseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PurchaseW__Cours__403A8C7D");

                entity.HasOne(d => d.Purchase)
                    .WithMany(p => p.PurchaseWiseCourses)
                    .HasForeignKey(d => d.PurchaseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PurchaseW__Purch__3F466844");
            });

            modelBuilder.Entity<Resource>(entity =>
            {
                entity.ToTable("Resource");

                entity.Property(e => e.ResourceId).HasColumnName("ResourceID");

                entity.Property(e => e.ResourceName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ResourceUrl)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("ResourceURL");

                entity.Property(e => e.TopicId).HasColumnName("TopicID");

                entity.HasOne(d => d.Topic)
                    .WithMany(p => p.Resources)
                    .HasForeignKey(d => d.TopicId)
                    .HasConstraintName("FK__Resource__TopicI__38996AB5");
            });

            modelBuilder.Entity<Topic>(entity =>
            {
                entity.ToTable("Topic");

                entity.Property(e => e.TopicId).HasColumnName("TopicID");

                entity.Property(e => e.CourseId).HasColumnName("CourseID");

                entity.Property(e => e.TopicName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.Topics)
                    .HasForeignKey(d => d.CourseId)
                    .HasConstraintName("FK__Topic__CourseID__35BCFE0A");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.StatusNavigation)
                    .WithMany(p => p.UserStatusNavigations)
                    .HasForeignKey(d => d.Status)
                    .HasConstraintName("FK__Users__Status__2E1BDC42");

                entity.HasOne(d => d.UserTypeNavigation)
                    .WithMany(p => p.UserUserTypeNavigations)
                    .HasForeignKey(d => d.UserType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Users__UserType__2D27B809");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
