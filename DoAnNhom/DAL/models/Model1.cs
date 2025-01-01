using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DAL.models
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=MuayContext")
        {
        }

        public virtual DbSet<Administrator> Administrators { get; set; }
        public virtual DbSet<HocVien> HocViens { get; set; }
        public virtual DbSet<HuanLuyenVien> HuanLuyenViens { get; set; }
        public virtual DbSet<LopHoc> LopHocs { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<TheHocVien> TheHocViens { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Administrator>()
                .Property(e => e.ID_AD)
                .IsUnicode(false);

            modelBuilder.Entity<Administrator>()
                .Property(e => e.Username)
                .IsUnicode(false);

            modelBuilder.Entity<Administrator>()
                .Property(e => e.Pass)
                .IsUnicode(false);

            modelBuilder.Entity<HocVien>()
                .Property(e => e.ID_HocVien)
                .IsUnicode(false);

            modelBuilder.Entity<HocVien>()
                .Property(e => e.GioiTinh)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HocVien>()
                .Property(e => e.DiaChi)
                .IsUnicode(false);

            modelBuilder.Entity<HocVien>()
                .Property(e => e.SDT)
                .IsUnicode(false);

            modelBuilder.Entity<HocVien>()
                .Property(e => e.ID_Lop)
                .IsUnicode(false);

            modelBuilder.Entity<HuanLuyenVien>()
                .Property(e => e.ID_HLV)
                .IsUnicode(false);

            modelBuilder.Entity<HuanLuyenVien>()
                .Property(e => e.GioiTinh)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HuanLuyenVien>()
                .Property(e => e.SDT)
                .IsUnicode(false);

            modelBuilder.Entity<HuanLuyenVien>()
                .Property(e => e.ChuyenMon)
                .IsUnicode(false);

            modelBuilder.Entity<HuanLuyenVien>()
                .HasMany(e => e.LopHocs)
                .WithOptional(e => e.HuanLuyenVien)
                .WillCascadeOnDelete();

            modelBuilder.Entity<LopHoc>()
                .Property(e => e.ID_Lop)
                .IsUnicode(false);

            modelBuilder.Entity<LopHoc>()
                .Property(e => e.ID_HLV)
                .IsUnicode(false);

            modelBuilder.Entity<LopHoc>()
                .Property(e => e.ThoiGianHoc)
                .IsUnicode(false);

            modelBuilder.Entity<LopHoc>()
                .HasMany(e => e.HocViens)
                .WithOptional(e => e.LopHoc)
                .WillCascadeOnDelete();

            modelBuilder.Entity<TheHocVien>()
                .Property(e => e.ID_TheHV)
                .IsUnicode(false);

            modelBuilder.Entity<TheHocVien>()
                .Property(e => e.ID_HocVien)
                .IsUnicode(false);

            modelBuilder.Entity<TheHocVien>()
                .Property(e => e.ID_Lop)
                .IsUnicode(false);

            modelBuilder.Entity<TheHocVien>()
                .Property(e => e.ID_HLV)
                .IsUnicode(false);
        }
    }
}
