using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace DL.Entities
{
    public partial class kpopsnapshotdbContext : DbContext
    {
        public kpopsnapshotdbContext()
        {
        }

        public kpopsnapshotdbContext(DbContextOptions<kpopsnapshotdbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Album> Albums { get; set; }
        public virtual DbSet<Artist> Artists { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Idol> Idols { get; set; }
        public virtual DbSet<Photocard> Photocards { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Album>(entity =>
            {
                entity.ToTable("Album");

                entity.Property(e => e.AlbumName)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.ArtistId).HasColumnName("ArtistID");

                entity.HasOne(d => d.Artist)
                    .WithMany(p => p.Albums)
                    .HasForeignKey(d => d.ArtistId)
                    .HasConstraintName("FK__Album__ArtistID__797309D9");
            });

            modelBuilder.Entity<Artist>(entity =>
            {
                entity.ToTable("Artist");

                entity.Property(e => e.GroupName)
                    .IsRequired()
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.Property(e => e.Address)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Idol>(entity =>
            {
                entity.Property(e => e.GroupId).HasColumnName("GroupID");

                entity.Property(e => e.StageName)
                    .IsRequired()
                    .IsUnicode(false);

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.Idols)
                    .HasForeignKey(d => d.GroupId)
                    .HasConstraintName("FK__Idols__GroupID__76969D2E");
            });

            modelBuilder.Entity<Photocard>(entity =>
            {
                entity.ToTable("Photocard");

                entity.Property(e => e.AlbumId).HasColumnName("AlbumID");

                entity.Property(e => e.GroupNameId).HasColumnName("GroupNameID");

                entity.Property(e => e.Price).HasColumnType("decimal(38, 2)");

                entity.Property(e => e.SetId)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasColumnName("SetID");

                entity.Property(e => e.StageNameId).HasColumnName("StageNameID");

                entity.HasOne(d => d.Album)
                    .WithMany(p => p.Photocards)
                    .HasForeignKey(d => d.AlbumId)
                    .HasConstraintName("FK__Photocard__Album__7E37BEF6");

                entity.HasOne(d => d.GroupName)
                    .WithMany(p => p.Photocards)
                    .HasForeignKey(d => d.GroupNameId)
                    .HasConstraintName("FK__Photocard__Group__7D439ABD");

                entity.HasOne(d => d.StageName)
                    .WithMany(p => p.Photocards)
                    .HasForeignKey(d => d.StageNameId)
                    .HasConstraintName("FK__Photocard__Stage__7C4F7684");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
