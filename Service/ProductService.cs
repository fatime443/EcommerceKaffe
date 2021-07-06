using DataAccess;
using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class ProductService
    {
        private readonly ApplicationDbContext _context;
        public ProductService(ApplicationDbContext context)
        {
            _context = context;
        }
        public List<Header> GetHeaders()
        {
            return _context.Headers.ToList();
        }
        public List<Taste> GetTastes() 
        {
            return _context.Tastes.ToList();
        }
        public List<Menu> GetMenus() 
        {
            return _context.Menus.ToList();
        }
        public List<Brands> GetBrands()
        {
            return _context.Brands.ToList();
        }
        public List<Blog> GetBlogs()
        {
            return _context.Blogs.ToList();
        }
        public List<Photo> GetPhotos()
        {
            return _context.Photos.ToList();
        }
        public List<Product> GetProducts()
        {
            return _context.Products.Include("ProductPictures.Picture").OrderByDescending(x => x.Id).ToList();
        }

        public Product GetProductById(int id)
        {
            return _context.Products.Include("ProductPictures.Picture").FirstOrDefault(x => x.Id == id);
        }
        public List<Product> GetFeaturedProducts()
        {
            return _context.Products.Include("ProductPictures.Picture").Where(x =>x.IsFeatured).ToList();
        }
        public List<Product> GetSameCategoryProducts(int id)
        {
            return _context.Products.Include("ProductPictures.Picture").Where(x => x.CategoryId == id).ToList();
        }
        public List<Product> GetProductsByIds(List<int> ids)
        {
            return _context.Products.Where(x => ids.Contains(x.Id)).ToList();
        }
    }
}
