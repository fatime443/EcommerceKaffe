using DataAccess;
using Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Service;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Web.Models;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly CategoryService _categoryService;
        private readonly ProductService _productService;
        public HomeController(ILogger<HomeController> logger,ApplicationDbContext context)
        {
            _logger = logger;
            _categoryService = new CategoryService(context);
            _productService = new ProductService(context);
        }

        public IActionResult Index()
        {
            List<Header> headers = _productService.GetHeaders();
            List<Taste> tastes = _productService.GetTastes();
            List<Menu> menus = _productService.GetMenus();
            List<Brands> brands = _productService.GetBrands();
            List<Blog> blogs = _productService.GetBlogs();
            List<Photo> photos = _productService.GetPhotos();
            HomeVm vm = new HomeVm()
            {
                Headers = headers,
                Tastes = tastes,
                Menus = menus,
                Brands = brands,
                Blogs = blogs,
                Photos = photos
            };
            return View(vm);
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Shop()
        {
            HomeVm vm = new HomeVm();
            vm.Categories = _categoryService.GetCategories();
            vm.Products = _productService.GetProducts();
            return View(vm);
        }
        
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
