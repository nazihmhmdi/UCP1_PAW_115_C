using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace PesanMakan.Models
{
    public partial class PesanMakanContext : DbContext
    {
        public PesanMakanContext()
        {
        }

        public PesanMakanContext(DbContextOptions<PesanMakanContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Menu> Menu { get; set; }
        public virtual DbSet<Pesanan> Pesanan { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Menu>(entity =>
            {
                entity.HasKey(e => e.IdMenu);

                entity.Property(e => e.IdMenu)
                    .HasColumnName("id_menu")
                    .ValueGeneratedNever();

                entity.Property(e => e.HargaMenu).HasColumnName("harga_menu");

                entity.Property(e => e.NamaMenu)
                    .HasColumnName("nama_menu")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Pesanan>(entity =>
            {
                entity.HasKey(e => e.IdPesanan);

                entity.Property(e => e.IdPesanan)
                    .HasColumnName("id_pesanan")
                    .ValueGeneratedNever();

                entity.Property(e => e.IdMenu).HasColumnName("id_menu");

                entity.Property(e => e.Jumlah).HasColumnName("jumlah");

                entity.Property(e => e.TotalHarga).HasColumnName("total_harga");

                entity.HasOne(d => d.IdMenuNavigation)
                    .WithMany(p => p.Pesanan)
                    .HasForeignKey(d => d.IdMenu)
                    .HasConstraintName("FK_Pesanan_Menu");
            });
        }
    }
}
