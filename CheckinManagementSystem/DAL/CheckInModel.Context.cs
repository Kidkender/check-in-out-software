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
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
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
        //public virtual DbSet<NoiQuy> NoiQuy { get; set; }
    
        public virtual ObjectResult<SP_QuanLyCheckIn_Result> SP_QuanLyCheckIn(Nullable<int> iDNhanVien, Nullable<int> iDPhong, Nullable<System.DateTime> tuNgay, Nullable<System.DateTime> denNgay)
        {
            var iDNhanVienParameter = iDNhanVien.HasValue ?
                new ObjectParameter("IDNhanVien", iDNhanVien) :
                new ObjectParameter("IDNhanVien", typeof(int));
    
            var iDPhongParameter = iDPhong.HasValue ?
                new ObjectParameter("IDPhong", iDPhong) :
                new ObjectParameter("IDPhong", typeof(int));
    
            var tuNgayParameter = tuNgay.HasValue ?
                new ObjectParameter("TuNgay", tuNgay) :
                new ObjectParameter("TuNgay", typeof(System.DateTime));
    
            var denNgayParameter = denNgay.HasValue ?
                new ObjectParameter("DenNgay", denNgay) :
                new ObjectParameter("DenNgay", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_QuanLyCheckIn_Result>("SP_QuanLyCheckIn", iDNhanVienParameter, iDPhongParameter, tuNgayParameter, denNgayParameter);
        }
    
        public virtual ObjectResult<SP_GetAllDangKy_Result> SP_GetAllDangKy()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_GetAllDangKy_Result>("SP_GetAllDangKy");
        }
    
        public virtual ObjectResult<GetAllNhanSu_Result> GetAllNhanSu()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetAllNhanSu_Result>("GetAllNhanSu");
        }
    
        public virtual ObjectResult<SP_GetAllNhanSu_Result> SP_GetAllNhanSu()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_GetAllNhanSu_Result>("SP_GetAllNhanSu");
        }
    }
}
