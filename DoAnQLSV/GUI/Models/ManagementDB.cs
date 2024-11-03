using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace GUI.Models
{
    public partial class ManagementDB : DbContext
    {
        public ManagementDB()
            : base("name=ManagementDB")
        {
        }

        public virtual DbSet<Diem> Diems { get; set; }
        public virtual DbSet<GiangVien> GiangViens { get; set; }
        public virtual DbSet<Khoa> Khoas { get; set; }
        public virtual DbSet<Lop> Lops { get; set; }
        public virtual DbSet<MonHoc> MonHocs { get; set; }
        public virtual DbSet<SinhVien> SinhViens { get; set; }
        public virtual DbSet<TaiKhoan> TaiKhoans { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Diem>()
                .Property(e => e.SinhVienID)
                .IsUnicode(false);

            modelBuilder.Entity<Diem>()
                .Property(e => e.MonHocID)
                .IsUnicode(false);

            modelBuilder.Entity<Diem>()
                .Property(e => e.DiemChu)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<GiangVien>()
                .Property(e => e.GiangVienID)
                .IsUnicode(false);

            modelBuilder.Entity<GiangVien>()
                .Property(e => e.SoDienThoai)
                .IsUnicode(false);

            modelBuilder.Entity<GiangVien>()
                .HasMany(e => e.TaiKhoans)
                .WithRequired(e => e.GiangVien)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Khoa>()
                .Property(e => e.KhoaID)
                .IsUnicode(false);

            modelBuilder.Entity<Khoa>()
                .HasMany(e => e.Lops)
                .WithRequired(e => e.Khoa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Khoa>()
                .HasMany(e => e.MonHocs)
                .WithRequired(e => e.Khoa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Khoa>()
                .HasMany(e => e.SinhViens)
                .WithRequired(e => e.Khoa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Lop>()
                .Property(e => e.LopID)
                .IsUnicode(false);

            modelBuilder.Entity<Lop>()
                .Property(e => e.KhoaID)
                .IsUnicode(false);

            modelBuilder.Entity<Lop>()
                .HasMany(e => e.SinhViens)
                .WithRequired(e => e.Lop)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MonHoc>()
                .Property(e => e.MonHocID)
                .IsUnicode(false);

            modelBuilder.Entity<MonHoc>()
                .Property(e => e.KhoaID)
                .IsUnicode(false);

            modelBuilder.Entity<MonHoc>()
                .HasMany(e => e.Diems)
                .WithRequired(e => e.MonHoc)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SinhVien>()
                .Property(e => e.SinhVienID)
                .IsUnicode(false);

            modelBuilder.Entity<SinhVien>()
                .Property(e => e.SoDienThoai)
                .IsUnicode(false);

            modelBuilder.Entity<SinhVien>()
                .Property(e => e.LopID)
                .IsUnicode(false);

            modelBuilder.Entity<SinhVien>()
                .Property(e => e.KhoaID)
                .IsUnicode(false);

            modelBuilder.Entity<SinhVien>()
                .HasMany(e => e.Diems)
                .WithRequired(e => e.SinhVien)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TaiKhoan>()
                .Property(e => e.TaiKhoanID)
                .IsUnicode(false);

            modelBuilder.Entity<TaiKhoan>()
                .Property(e => e.Username)
                .IsUnicode(false);

            modelBuilder.Entity<TaiKhoan>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<TaiKhoan>()
                .Property(e => e.GiangVienID)
                .IsUnicode(false);
        }
    }
}
