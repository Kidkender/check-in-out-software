﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CheckinManagementSystem.DAL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class CheckInEntities : DbContext
    {
        public CheckInEntities()
            : base("name=CheckInEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CheckExists> CheckExists { get; set; }
        public virtual DbSet<DanhMucRole> DanhMucRole { get; set; }
        public virtual DbSet<LoaiRecord> LoaiRecord { get; set; }
        public virtual DbSet<NhanSu> NhanSu { get; set; }
        public virtual DbSet<NhanSuNhomQuyen> NhanSuNhomQuyen { get; set; }
        public virtual DbSet<NhanSuPhanQuyen> NhanSuPhanQuyen { get; set; }
        public virtual DbSet<NhomPhanQuyen> NhomPhanQuyen { get; set; }
        public virtual DbSet<NhomQuyen> NhomQuyen { get; set; }
        public virtual DbSet<Phong> Phong { get; set; }
        public virtual DbSet<Quyen> Quyen { get; set; }
        public virtual DbSet<Record> Record { get; set; }
    }
}