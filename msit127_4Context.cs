using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace test0831
{
    public partial class msit127_4Context : DbContext
    {
        public msit127_4Context()
        {
        }

        public msit127_4Context(DbContextOptions<msit127_4Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Tuser> Tuser { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=tcp:projectmsit127.database.windows.net,1433;Initial Catalog=msit127_4;Persist Security Info=False;User ;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tuser>(entity =>
            {
                entity.HasKey(e => e.Uid);

                entity.Property(e => e.Uid).HasColumnName("uid");

                entity.Property(e => e.Uage).HasColumnName("uage");

                entity.Property(e => e.Umale)
                    .HasColumnName("umale")
                    .HasMaxLength(50);

                entity.Property(e => e.Uname)
                    .HasColumnName("uname")
                    .HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
