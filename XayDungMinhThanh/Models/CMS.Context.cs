﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace XayDungMinhThanh.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MinhThanhEntities : DbContext
    {
        public MinhThanhEntities()
            : base("name=MinhThanhEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AspNetRole> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; }
        public virtual DbSet<BacSi> BacSis { get; set; }
        public virtual DbSet<Banner> Banners { get; set; }
        public virtual DbSet<CategoryPost> CategoryPosts { get; set; }
        public virtual DbSet<Gallery> Galleries { get; set; }
        public virtual DbSet<Image> Images { get; set; }
        public virtual DbSet<InfoCompany> InfoCompanies { get; set; }
        public virtual DbSet<Post> Posts { get; set; }
        public virtual DbSet<Video> Videos { get; set; }
    }
}
