using Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Brands> Brands { get; set; }
        public DbSet<Header> Headers { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Photo> Photos { get; set; }
        public DbSet<Picture> Pictures { get; set; }
        public DbSet<Taste> Tastes { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ProductDetail> ProductDetails { get; set; }
        public DbSet<ProductPicture> ProductPictures { get; set; }
        public DbSet<Specification> Specifications { get; set; }
    }
}
