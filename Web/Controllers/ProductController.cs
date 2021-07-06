using DataAccess;
using Microsoft.AspNetCore.Mvc;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Models;

namespace Web.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductService _productService;
        public ProductController(ApplicationDbContext context)
        {
            _productService = new ProductService(context);
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Details(int? id)
        {
            if (id == null) return NotFound();
            ProductVM vm = new();
            vm.Product = _productService.GetProductById(id.Value);
            if (vm.Product == null) return NotFound();
            return View(vm);
        }
    }
}
