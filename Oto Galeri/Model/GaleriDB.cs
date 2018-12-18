namespace Oto_Galeri.Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class GaleriDB : DbContext
    {
        public GaleriDB()
            : base("name=GaleriDB")
        {
        }

        public virtual DbSet<Adres> Adres { get; set; }
        public virtual DbSet<Arac> Arac { get; set; }
        public virtual DbSet<AracKategori> AracKategori { get; set; }
        public virtual DbSet<AracOzellikler> AracOzellikler { get; set; }
        public virtual DbSet<AracRenk> AracRenk { get; set; }
        public virtual DbSet<Kullanicilar> Kullanicilar { get; set; }
        public virtual DbSet<Marka> Marka { get; set; }
        public virtual DbSet<Model> Model { get; set; }
        public virtual DbSet<Musteri> Musteri { get; set; }
        public virtual DbSet<Satis> Satis { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Arac>()
                .HasMany(e => e.AracOzellikler)
                .WithMany(e => e.Arac)
                .Map(m => m.ToTable("Arac_AracOzellik").MapLeftKey("AracId").MapRightKey("AracOzellikId"));

            modelBuilder.Entity<AracKategori>()
                .Property(e => e.Ad)
                .IsFixedLength();

            modelBuilder.Entity<AracKategori>()
                .HasMany(e => e.Arac)
                .WithOptional(e => e.AracKategori)
                .HasForeignKey(e => e.Kategoriıd);

            modelBuilder.Entity<AracRenk>()
                .Property(e => e.Renk)
                .IsFixedLength();

            modelBuilder.Entity<AracRenk>()
                .HasMany(e => e.Arac)
                .WithRequired(e => e.AracRenk)
                .HasForeignKey(e => e.RenkId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Musteri>()
                .Property(e => e.TcNo)
                .HasPrecision(11, 0);

            modelBuilder.Entity<Musteri>()
                .Property(e => e.Tel)
                .HasPrecision(11, 0);

            modelBuilder.Entity<Musteri>()
                .Property(e => e.Tel2)
                .HasPrecision(11, 0);

            modelBuilder.Entity<Musteri>()
                .Property(e => e.BabaAdı)
                .IsFixedLength();

            modelBuilder.Entity<Musteri>()
                .Property(e => e.AnneAdı)
                .IsFixedLength();

            modelBuilder.Entity<Musteri>()
                .HasMany(e => e.Adres1)
                .WithRequired(e => e.Musteri)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Musteri>()
                .HasMany(e => e.Satis)
                .WithRequired(e => e.Musteri)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Satis>()
                .Property(e => e.Fiyat)
                .HasPrecision(8, 3);

            modelBuilder.Entity<Satis>()
                .HasMany(e => e.Arac)
                .WithOptional(e => e.Satis)
                .HasForeignKey(e => e.SatısId);
        }
    }
}
