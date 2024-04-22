using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WebSitesi.Models;

/* Projenin son halinde DataBaseFirst yaklaşımını kullandım. Veritabanını form'da oluşturduğum için tekrardan oluşturmak istemedim. */

public partial class DataBaseFirstDbContext : DbContext
{
    public DataBaseFirstDbContext()
    {
    }

    public DataBaseFirstDbContext(DbContextOptions<DataBaseFirstDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Aidatlar> Aidatlars { get; set; }

    public virtual DbSet<Evler> Evlers { get; set; }

    public virtual DbSet<HarcamaDetay> HarcamaDetays { get; set; }

    public virtual DbSet<Harcamalar> Harcamalars { get; set; }

    public virtual DbSet<Kiracilar> Kiracilars { get; set; }

    public virtual DbSet<Kullanicilar> Kullanicilars { get; set; }

    public virtual DbSet<SiteSakinleri> SiteSakinleris { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=KUTAYMASAUSTUPC;Database=Golpinar_Sitesi;Trusted_Connection=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Aidatlar>(entity =>
        {
            entity.ToTable("Aidatlar");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Ev).HasColumnName("ev");
            entity.Property(e => e.OdemeTarihi)
                .HasColumnType("datetime")
                .HasColumnName("odeme_tarihi");
            entity.Property(e => e.OdenmemisAidat)
                .HasColumnType("money")
                .HasColumnName("odenmemis_aidat");

            entity.HasOne(d => d.EvNavigation).WithMany(p => p.Aidatlars)
                .HasForeignKey(d => d.Ev)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Aidatlar_Evler");
        });

        modelBuilder.Entity<Evler>(entity =>
        {
            entity.ToTable("Evler");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Kiracı).HasColumnName("kiracı");
            entity.Property(e => e.Numara).HasColumnName("numara");
            entity.Property(e => e.Sahibi).HasColumnName("sahibi");

            entity.HasOne(d => d.KiracıNavigation).WithMany(p => p.Evlers)
                .HasForeignKey(d => d.Kiracı)
                .HasConstraintName("FK_Evler_Kiracilar");

            entity.HasOne(d => d.SahibiNavigation).WithMany(p => p.Evlers)
                .HasForeignKey(d => d.Sahibi)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Evler_Site_Sakinleri");
        });

        modelBuilder.Entity<HarcamaDetay>(entity =>
        {
            entity.ToTable("Harcama_Detay");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(250)
                .HasColumnName("aciklama");
            entity.Property(e => e.Harcama)
                .HasColumnType("money")
                .HasColumnName("harcama");
            entity.Property(e => e.HarcamaId).HasColumnName("harcama_id");

            entity.HasOne(d => d.HarcamaNavigation).WithMany(p => p.HarcamaDetays)
                .HasForeignKey(d => d.HarcamaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Harcama_Detay_Harcamalar");
        });

        modelBuilder.Entity<Harcamalar>(entity =>
        {
            entity.ToTable("Harcamalar");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("tarih");
            entity.Property(e => e.ToplamHarcama)
                .HasColumnType("money")
                .HasColumnName("toplam_harcama");
        });

        modelBuilder.Entity<Kiracilar>(entity =>
        {
            entity.ToTable("Kiracilar");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AdSoyad)
                .HasMaxLength(250)
                .HasColumnName("ad_soyad");
            entity.Property(e => e.Gsm)
                .HasMaxLength(11)
                .IsFixedLength()
                .HasColumnName("gsm");
        });

        modelBuilder.Entity<Kullanicilar>(entity =>
        {
            entity.ToTable("Kullanicilar");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.KullaniciAdi)
                .HasMaxLength(50)
                .HasColumnName("kullanici_adi");
            entity.Property(e => e.Sifre)
                .HasMaxLength(50)
                .HasColumnName("sifre");
        });

        modelBuilder.Entity<SiteSakinleri>(entity =>
        {
            entity.ToTable("Site_Sakinleri");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AdSoyad)
                .HasMaxLength(250)
                .HasColumnName("ad_soyad");
            entity.Property(e => e.Telefon)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("telefon");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
