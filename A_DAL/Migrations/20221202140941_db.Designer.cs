﻿// <auto-generated />
using System;
using A_DAL.DomaninClass;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace A_DAL.Migrations
{
    [DbContext(typeof(XeMayDbConText))]
    [Migration("20221202140941_db")]
    partial class db
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("A_DAL.DomaninClass.Anh", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Link")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasColumnName("link");

                    b.Property<string>("Ma")
                        .IsRequired()
                        .HasColumnType("Nvarchar(100)")
                        .HasColumnName("Ma");

                    b.Property<string>("Ten")
                        .IsRequired()
                        .HasColumnType("Nvarchar(100)")
                        .HasColumnName("Ten");

                    b.HasKey("id");

                    b.HasAlternateKey("Ma");

                    b.ToTable("Anh");
                });

            modelBuilder.Entity("A_DAL.DomaninClass.ChiTietXe", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("DongCoID")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("idDongCo");

                    b.Property<Guid?>("LoaiXeID")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("idLoaiXe");

                    b.Property<Guid?>("NSXID")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("isNSX");

                    b.Property<DateTime?>("NgayNhap")
                        .HasColumnType("datetime");

                    b.Property<Guid?>("SanPhamID")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("idSanPham");

                    b.Property<decimal?>("SoLuongTon")
                        .HasColumnType("decimal(20,0)");

                    b.Property<int?>("TrangThai")
                        .HasColumnType("int");

                    b.Property<Guid?>("anhID")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("IdAnh");

                    b.Property<string>("binhXang")
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal?>("giaBan")
                        .HasColumnType("decimal(20,0)");

                    b.Property<decimal?>("giaNhap")
                        .HasColumnType("decimal(20,0)");

                    b.Property<Guid?>("khoiDongID")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("idKhoiDong");

                    b.Property<Guid?>("mauSacID")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("idMauSac");

                    b.Property<string>("moTa")
                        .HasColumnType("Nvarchar(100)");

                    b.Property<double?>("namBh")
                        .HasColumnType("float");

                    b.Property<string>("soKhung")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("soMay")
                        .HasColumnType("varchar(100)");

                    b.HasKey("id");

                    b.HasIndex("DongCoID");

                    b.HasIndex("LoaiXeID");

                    b.HasIndex("NSXID");

                    b.HasIndex("SanPhamID");

                    b.HasIndex("anhID");

                    b.HasIndex("khoiDongID");

                    b.HasIndex("mauSacID");

                    b.ToTable("ChiTietXe");
                });

            modelBuilder.Entity("A_DAL.DomaninClass.ChucVu", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Ma")
                        .IsRequired()
                        .HasColumnType("Varchar(100)");

                    b.Property<string>("Ten")
                        .HasColumnType("NVarchar(100)");

                    b.HasKey("id");

                    b.HasAlternateKey("Ma");

                    b.ToTable("ChucVus");
                });

            modelBuilder.Entity("A_DAL.DomaninClass.HoaDon", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DiaChi")
                        .HasColumnType("Nvarchar(100)");

                    b.Property<string>("MA")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<DateTime?>("NgayMongMuon")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("NgayNhan")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("NgayShip")
                        .HasColumnType("datetime");

                    b.Property<string>("SDT")
                        .HasColumnType("Nvarchar(100)");

                    b.Property<string>("TenNguoiNhan")
                        .HasColumnType("Nvarchar(100)");

                    b.Property<Guid?>("khachHangID")
                        .IsRequired()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("ngayTao")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("ngayThanhToan")
                        .HasColumnType("datetime");

                    b.Property<Guid?>("nhanVienID")
                        .IsRequired()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("trangthai")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasAlternateKey("MA");

                    b.HasIndex("khachHangID");

                    b.HasIndex("nhanVienID");

                    b.ToTable("HoaDons");
                });

            modelBuilder.Entity("A_DAL.DomaninClass.HoaDonChitiet", b =>
                {
                    b.Property<Guid?>("ChiTietXeId")
                        .IsRequired()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal?>("DonGia")
                        .HasColumnType("Decimal");

                    b.Property<Guid?>("HoaDonId")
                        .IsRequired()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("KhuyenMaiID")
                        .IsRequired()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal?>("ThanhTien")
                        .HasColumnType("Decimal");

                    b.Property<int?>("soLuong")
                        .HasColumnType("int");

                    b.Property<int?>("trangthai")
                        .HasColumnType("int");

                    b.HasIndex("ChiTietXeId");

                    b.HasIndex("HoaDonId");

                    b.HasIndex("KhuyenMaiID");

                    b.ToTable("HoaDonChitiets");
                });

            modelBuilder.Entity("A_DAL.DomaninClass.KhachHang", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DiaChi")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Ho")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Ma")
                        .IsRequired()
                        .HasColumnType("varchar(30)");

                    b.Property<DateTime?>("NgaySinh")
                        .HasColumnType("datetime");

                    b.Property<string>("QuocGia")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Ten")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("TenDem")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("ThanhPho")
                        .HasColumnType("varchar(100)");

                    b.Property<int?>("gioitinh")
                        .HasColumnType("int");

                    b.Property<string>("sdt")
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("trangthai")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasAlternateKey("Ma");

                    b.ToTable("KhachHangs");
                });

            modelBuilder.Entity("A_DAL.DomaninClass.KhuyenMai", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Ma")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<DateTime?>("NgayketThuc")
                        .HasColumnType("datetime");

                    b.Property<double?>("SoLuongGiam")
                        .HasColumnType("float");

                    b.Property<string>("Ten")
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("TrangThai")
                        .HasColumnType("int");

                    b.Property<string>("mota")
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime?>("ngayTao")
                        .HasColumnType("datetime");

                    b.HasKey("id");

                    b.HasAlternateKey("Ma");

                    b.ToTable("KhuyenMais");
                });

            modelBuilder.Entity("A_DAL.DomaninClass.NSX", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Ma")
                        .IsRequired()
                        .HasColumnType("Varchar(100)");

                    b.Property<string>("Ten")
                        .HasColumnType("NVarchar(100)");

                    b.HasKey("id");

                    b.HasAlternateKey("Ma");

                    b.ToTable("NSXes");
                });

            modelBuilder.Entity("A_DAL.DomaninClass.NhanVien", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("Anhid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ChuVuId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DiaChi")
                        .HasColumnType("nvarchar(100)");

                    b.Property<Guid?>("GuiBcId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Ho")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Ma")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("MatKhau")
                        .HasColumnType("varchar(100)");

                    b.Property<DateTime?>("NgaySinh")
                        .HasColumnType("datetime");

                    b.Property<string>("Ten")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("TenDem")
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("Trangthai")
                        .HasColumnType("int");

                    b.Property<int?>("gioitinh")
                        .HasColumnType("int");

                    b.Property<string>("sdt")
                        .HasColumnType("varchar(100)");

                    b.HasKey("id");

                    b.HasAlternateKey("Ma");

                    b.HasIndex("Anhid");

                    b.HasIndex("ChuVuId");

                    b.HasIndex("GuiBcId");

                    b.ToTable("NhanViens");
                });

            modelBuilder.Entity("A_DAL.DomaninClass.dongCo", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Ma")
                        .IsRequired()
                        .HasColumnType("Varchar(100)");

                    b.Property<string>("Ten")
                        .HasColumnType("NVarchar(100)");

                    b.HasKey("id");

                    b.HasAlternateKey("Ma");

                    b.ToTable("DongCos");
                });

            modelBuilder.Entity("A_DAL.DomaninClass.khoiDong", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Ma")
                        .IsRequired()
                        .HasColumnType("Varchar(100)");

                    b.Property<string>("Ten")
                        .HasColumnType("NVarchar(100)");

                    b.HasKey("id");

                    b.HasAlternateKey("Ma");

                    b.ToTable("KhoiDongs");
                });

            modelBuilder.Entity("A_DAL.DomaninClass.loaiXe", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Ma")
                        .IsRequired()
                        .HasColumnType("Varchar(100)");

                    b.Property<string>("Ten")
                        .HasColumnType("NVarchar(100)");

                    b.HasKey("id");

                    b.HasAlternateKey("Ma");

                    b.ToTable("LoaiXes");
                });

            modelBuilder.Entity("A_DAL.DomaninClass.mauSac", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Ma")
                        .IsRequired()
                        .HasColumnType("Varchar(100)");

                    b.Property<string>("Ten")
                        .HasColumnType("NVarchar(100)");

                    b.HasKey("id");

                    b.HasAlternateKey("Ma");

                    b.ToTable("MauSacs");
                });

            modelBuilder.Entity("A_DAL.DomaninClass.sanPham", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Ma")
                        .IsRequired()
                        .HasColumnType("Varchar(100)");

                    b.Property<string>("Ten")
                        .HasColumnType("NVarchar(100)");

                    b.HasKey("id");

                    b.HasAlternateKey("Ma");

                    b.ToTable("SanPhams");
                });

            modelBuilder.Entity("A_DAL.DomaninClass.ChiTietXe", b =>
                {
                    b.HasOne("A_DAL.DomaninClass.dongCo", "DongCo")
                        .WithMany()
                        .HasForeignKey("DongCoID");

                    b.HasOne("A_DAL.DomaninClass.loaiXe", "LoaiXe")
                        .WithMany()
                        .HasForeignKey("LoaiXeID");

                    b.HasOne("A_DAL.DomaninClass.NSX", "NSX")
                        .WithMany()
                        .HasForeignKey("NSXID");

                    b.HasOne("A_DAL.DomaninClass.sanPham", "SanPham")
                        .WithMany()
                        .HasForeignKey("SanPhamID");

                    b.HasOne("A_DAL.DomaninClass.Anh", "Anh")
                        .WithMany()
                        .HasForeignKey("anhID");

                    b.HasOne("A_DAL.DomaninClass.khoiDong", "khoidong")
                        .WithMany()
                        .HasForeignKey("khoiDongID");

                    b.HasOne("A_DAL.DomaninClass.mauSac", "MauSac")
                        .WithMany()
                        .HasForeignKey("mauSacID");

                    b.Navigation("Anh");

                    b.Navigation("DongCo");

                    b.Navigation("khoidong");

                    b.Navigation("LoaiXe");

                    b.Navigation("MauSac");

                    b.Navigation("NSX");

                    b.Navigation("SanPham");
                });

            modelBuilder.Entity("A_DAL.DomaninClass.HoaDon", b =>
                {
                    b.HasOne("A_DAL.DomaninClass.KhachHang", "KhachHang")
                        .WithMany()
                        .HasForeignKey("khachHangID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("A_DAL.DomaninClass.NhanVien", "NhanVien")
                        .WithMany()
                        .HasForeignKey("nhanVienID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("KhachHang");

                    b.Navigation("NhanVien");
                });

            modelBuilder.Entity("A_DAL.DomaninClass.HoaDonChitiet", b =>
                {
                    b.HasOne("A_DAL.DomaninClass.ChiTietXe", "ChiTietXe")
                        .WithMany()
                        .HasForeignKey("ChiTietXeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("A_DAL.DomaninClass.HoaDon", "HoaDon")
                        .WithMany()
                        .HasForeignKey("HoaDonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("A_DAL.DomaninClass.KhuyenMai", "KhuyenMai")
                        .WithMany()
                        .HasForeignKey("KhuyenMaiID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ChiTietXe");

                    b.Navigation("HoaDon");

                    b.Navigation("KhuyenMai");
                });

            modelBuilder.Entity("A_DAL.DomaninClass.NhanVien", b =>
                {
                    b.HasOne("A_DAL.DomaninClass.Anh", "anh")
                        .WithMany()
                        .HasForeignKey("Anhid");

                    b.HasOne("A_DAL.DomaninClass.ChucVu", "ChucVu")
                        .WithMany()
                        .HasForeignKey("ChuVuId");

                    b.HasOne("A_DAL.DomaninClass.NhanVien", "Guibc")
                        .WithMany()
                        .HasForeignKey("GuiBcId");

                    b.Navigation("anh");

                    b.Navigation("ChucVu");

                    b.Navigation("Guibc");
                });
#pragma warning restore 612, 618
        }
    }
}
