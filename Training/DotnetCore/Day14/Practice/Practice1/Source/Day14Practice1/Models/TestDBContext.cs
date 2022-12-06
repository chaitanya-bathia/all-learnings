using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Day14Practice1.Models
{
    public partial class TestDBContext : DbContext
    {
        public TestDBContext()
        {
        }

        public TestDBContext(DbContextOptions<TestDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Borrow> Borrows { get; set; }
        public virtual DbSet<Branch> Branches { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Deposit> Deposits { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Job> Jobs { get; set; }
        public virtual DbSet<JobHistory> JobHistories { get; set; }
        public virtual DbSet<Mark> Marks { get; set; }
        public virtual DbSet<NewEmployee> NewEmployees { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Student1> Students1 { get; set; }
        public virtual DbSet<StudentDetail> StudentDetails { get; set; }
        public virtual DbSet<StudentHour> StudentHours { get; set; }
        public virtual DbSet<StudentPresent> StudentPresents { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=PC0352\\MSSQL2019;Database=TestDB;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Borrow>(entity =>
            {
                entity.HasKey(e => e.Loanno)
                    .HasName("PK__Borrow__D98B45134D06C268");

                entity.ToTable("BORROW");

                entity.Property(e => e.Loanno)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("LOANNO");

                entity.Property(e => e.Amount).HasColumnName("AMOUNT");

                entity.Property(e => e.Bname)
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .HasColumnName("BNAME");

                entity.Property(e => e.Cname)
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .HasColumnName("CNAME");

                entity.HasOne(d => d.BnameNavigation)
                    .WithMany(p => p.Borrows)
                    .HasForeignKey(d => d.Bname)
                    .HasConstraintName("FK_BORROW_Branch");

                entity.HasOne(d => d.CnameNavigation)
                    .WithMany(p => p.Borrows)
                    .HasForeignKey(d => d.Cname)
                    .HasConstraintName("FK_BORROW_CUSTOMER");
            });

            modelBuilder.Entity<Branch>(entity =>
            {
                entity.HasKey(e => e.Bname)
                    .HasName("PK__Branch__C670A8F9CC376BFE");

                entity.ToTable("BRANCH");

                entity.Property(e => e.Bname)
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .HasColumnName("BNAME");

                entity.Property(e => e.City)
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .HasColumnName("CITY");
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.CountryName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RegionId).HasColumnName("RegionID");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasKey(e => e.Cname)
                    .HasName("PK__CUSTOMER__C38B56B9FBC81066");

                entity.ToTable("CUSTOMER");

                entity.Property(e => e.Cname)
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .HasColumnName("CNAME");

                entity.Property(e => e.City)
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .HasColumnName("CITY");
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.ToTable("Department");

                entity.Property(e => e.DepartmentId)
                    .ValueGeneratedNever()
                    .HasColumnName("DepartmentID");

                entity.Property(e => e.DepartmentName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Deposit>(entity =>
            {
                entity.HasKey(e => e.Actno)
                    .HasName("PK__DEPOSIT__CA96F958F925C597");

                entity.ToTable("DEPOSIT");

                entity.Property(e => e.Actno)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ACTNO");

                entity.Property(e => e.Adate).HasColumnType("date");

                entity.Property(e => e.Bname)
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .HasColumnName("BNAME");

                entity.Property(e => e.Cname)
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .HasColumnName("CNAME");

                entity.HasOne(d => d.BnameNavigation)
                    .WithMany(p => p.Deposits)
                    .HasForeignKey(d => d.Bname)
                    .HasConstraintName("FK_DEPOSIT_Branch");

                entity.HasOne(d => d.CnameNavigation)
                    .WithMany(p => p.Deposits)
                    .HasForeignKey(d => d.Cname)
                    .HasConstraintName("FK_DEPOSIT_CUSTOMER");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.Property(e => e.EmployeeId)
                    .ValueGeneratedNever()
                    .HasColumnName("EmployeeID");

                entity.Property(e => e.Commission).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DateOfBirth)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HireDate).HasColumnType("date");

                entity.Property(e => e.JobId).HasColumnName("Job_ID");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ManagerId).HasColumnName("ManagerID");

                entity.Property(e => e.PhoneNumber)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.DepartmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Employees_Department");

                entity.HasOne(d => d.Job)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.JobId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Employees_Jobs");
            });

            modelBuilder.Entity<Job>(entity =>
            {
                entity.Property(e => e.JobId)
                    .ValueGeneratedNever()
                    .HasColumnName("JobID");

                entity.Property(e => e.JobTitle)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MinSalary).HasDefaultValueSql("((8000))");
            });

            modelBuilder.Entity<JobHistory>(entity =>
            {
                entity.HasKey(e => e.EmployeeId)
                    .HasName("PK__JobHisto__7AD04FF10B25C4CF");

                entity.ToTable("JobHistory");

                entity.Property(e => e.EmployeeId)
                    .ValueGeneratedNever()
                    .HasColumnName("EmployeeID");

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.EndDate)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.JobId).HasColumnName("JobID");

                entity.Property(e => e.Location)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StartDate)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Mark>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Average).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Grade)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("GRADE");

                entity.Property(e => e.StudentId).HasColumnName("StudentID");

                entity.HasOne(d => d.Student)
                    .WithMany()
                    .HasForeignKey(d => d.StudentId)
                    .HasConstraintName("FK_Marks_Student");
            });

            modelBuilder.Entity<NewEmployee>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.FirstName).IsUnicode(false);

                entity.Property(e => e.LastName).IsUnicode(false);
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.ToTable("Student");

                entity.Property(e => e.StudentId)
                    .ValueGeneratedNever()
                    .HasColumnName("StudentID");

                entity.Property(e => e.Address)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Board)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Student1>(entity =>
            {
                entity.HasKey(e => e.Studentid)
                    .HasName("PK__STUDENTS__495196F099D76976");

                entity.ToTable("STUDENTS");

                entity.Property(e => e.Studentid)
                    .ValueGeneratedNever()
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Name)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("NAME");
            });

            modelBuilder.Entity<StudentDetail>(entity =>
            {
                entity.ToTable("STUDENT_DETAIL");

                entity.Property(e => e.StudentDetailId)
                    .ValueGeneratedNever()
                    .HasColumnName("STUDENT_DETAIL_ID");

                entity.Property(e => e.Gender)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("GENDER");

                entity.Property(e => e.Standard).HasColumnName("STANDARD");

                entity.Property(e => e.StudentId).HasColumnName("STUDENT_ID");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.StudentDetails)
                    .HasForeignKey(d => d.StudentId)
                    .HasConstraintName("FK__STUDENT_D__STUDE__04E4BC85");
            });

            modelBuilder.Entity<StudentHour>(entity =>
            {
                entity.HasKey(e => e.StudentHoursId)
                    .HasName("PK__STUDENT___FF222756B1579F32");

                entity.ToTable("STUDENT_HOURS");

                entity.Property(e => e.StudentHoursId)
                    .ValueGeneratedNever()
                    .HasColumnName("STUDENT_HOURS_ID");

                entity.Property(e => e.Datex)
                    .HasColumnType("date")
                    .HasColumnName("DATEX");

                entity.Property(e => e.Hours).HasColumnName("HOURS");

                entity.Property(e => e.StudentId).HasColumnName("STUDENT_ID");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.StudentHours)
                    .HasForeignKey(d => d.StudentId)
                    .HasConstraintName("FK__STUDENT_H__STUDE__0A9D95DB");
            });

            modelBuilder.Entity<StudentPresent>(entity =>
            {
                entity.ToTable("STUDENT_PRESENT");

                entity.Property(e => e.StudentPresentId)
                    .ValueGeneratedNever()
                    .HasColumnName("STUDENT_PRESENT_ID");

                entity.Property(e => e.Month).HasColumnName("MONTH");

                entity.Property(e => e.Present).HasColumnName("PRESENT");

                entity.Property(e => e.StudentId).HasColumnName("STUDENT_ID");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.StudentPresents)
                    .HasForeignKey(d => d.StudentId)
                    .HasConstraintName("FK__STUDENT_P__STUDE__07C12930");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
