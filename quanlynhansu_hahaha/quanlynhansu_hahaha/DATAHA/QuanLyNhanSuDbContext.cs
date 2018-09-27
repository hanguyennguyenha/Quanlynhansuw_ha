namespace quanlynhansu_hahaha.DAO
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class QuanLyNhanSuDbContext : DbContext
    {
        public QuanLyNhanSuDbContext()
            : base("name=QuanLyNhanSuDbContext")
        {
        }

        public virtual DbSet<CHUCVU> CHUCVUs { get; set; }
        public virtual DbSet<DANTOC> DANTOCs { get; set; }
        public virtual DbSet<NGOAINGU> NGOAINGUs { get; set; }
        public virtual DbSet<NHANVIEN> NHANVIENs { get; set; }
        public virtual DbSet<PHONGBAN> PHONGBANs { get; set; }
   
        public virtual DbSet<THANNHAN> THANNHANs { get; set; }
        public virtual DbSet<TONGIAO> TONGIAOs { get; set; }
        public virtual DbSet<TRINHDOHOCVAN> TRINHDOHOCVANs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CHUCVU>()
                .Property(e => e.KIHIEUCHUCVU)
                .IsUnicode(false);

            modelBuilder.Entity<NHANVIEN>()
                .Property(e => e.MANV)
                .IsUnicode(false);

            modelBuilder.Entity<NHANVIEN>()
                .Property(e => e.MATKHAU)
                .IsUnicode(false);

            modelBuilder.Entity<NHANVIEN>()
                .Property(e => e.TAIKHOAN)
                .IsUnicode(false);

            modelBuilder.Entity<PHONGBAN>()
                .Property(e => e.KIHIEUPHONG)
                .IsUnicode(false);

            modelBuilder.Entity<THANNHAN>()
                .Property(e => e.MATN)
                .IsUnicode(false);
        }
    }
}
