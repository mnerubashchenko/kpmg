using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace kpmg
{
    public partial class EmployersContext : DbContext
    {
        public EmployersContext()
        {
        }

        public EmployersContext(DbContextOptions<EmployersContext> options)
            : base(options)
        {
        }

        public virtual DbSet<People> People { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=DESKTOP-DRQFEK8\\SQLEXPRESS;Database=Employers;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<People>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.Birthday).HasColumnType("date");

                entity.Property(e => e.LastName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });
        }
    }
}
