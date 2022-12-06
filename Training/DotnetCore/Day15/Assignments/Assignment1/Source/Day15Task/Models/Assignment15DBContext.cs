using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Day15Task.Models
{
    public partial class Assignment15DBContext : DbContext
    {
        public Assignment15DBContext()
        {
        }

        public Assignment15DBContext(DbContextOptions<Assignment15DBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Assignment> Assignments { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=PC0352\\MSSQL2019;Database=Assignment15DB;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Assignment>(entity =>
            {
                entity.Property(e => e.AssignmentId).HasColumnName("AssignmentID");

                entity.Property(e => e.ActionCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.ActionReasonCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.ActualTerminationDate).HasColumnType("date");

                entity.Property(e => e.AssignmentCategory)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AssignmentName)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.AssignmentProjectEndDate).HasColumnType("date");

                entity.Property(e => e.AssignmentStatus)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.AssignmentTypeId).HasColumnName("AssignmentTypeID");

                entity.Property(e => e.BusinessUnitId).HasColumnName("BusinessUnitID");

                entity.Property(e => e.CreationDate).HasColumnType("date");

                entity.Property(e => e.DefaultExpenseAccount)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.EffectiveEndDate).HasColumnType("date");

                entity.Property(e => e.EffectiveStartDate).HasColumnType("date");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.EndTime)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.GradeId).HasColumnName("GradeID");

                entity.Property(e => e.GradeLadderId).HasColumnName("GradeLadderID");

                entity.Property(e => e.LegalEntityId).HasColumnName("LegalEntityID");

                entity.Property(e => e.LocationId).HasColumnName("LocationID");

                entity.Property(e => e.ManagerAssignmentId).HasColumnName("ManagerAssignmentID");

                entity.Property(e => e.ManagerId).HasColumnName("ManagerID");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.Assignments)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK__Assignmen__Emplo__38996AB5");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.ToTable("Employee");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.AddressLine1)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.AddressLine2)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CitizenShipId).HasColumnName("CitizenShipID");

                entity.Property(e => e.CitizenshipLegislationCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CitizenshipStatus)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CitizenshiptoDate).HasColumnType("date");

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CorrespondanceLanguage)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.DateOfBirth).HasColumnType("date");

                entity.Property(e => e.DisplayName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DriversLicenseExpiryDate).HasColumnType("date");

                entity.Property(e => e.DriversLicenseId).HasColumnName("DriversLicenseID");

                entity.Property(e => e.DriversLicenseIssuingCountry)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EffectiveStartDate).HasColumnType("date");

                entity.Property(e => e.Ethinicity)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Gender)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HomeFaxCountryCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.HomePhoneCountryCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.HomePhoneNumber)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Honors)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MaritialStatus)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MiddleName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MilitaryVetStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NationalId).HasColumnName("NationalID");

                entity.Property(e => e.NationalIdcountry)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("NationalIDCountry");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
