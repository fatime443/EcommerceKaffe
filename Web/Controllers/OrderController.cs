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
    public class OrderController : Controller
    {
        private readonly ProductService _productService;

        public OrderController(ApplicationDbContext context)
        {
            _productService = new ProductService(context);
        }
        [Route("/checkout")]
        public IActionResult Checkout()
        {
            var cookieValue = Request.Cookies["cartItem"];
            if (cookieValue !=null && cookieValue.Length > 0)
            {
                List<int> productIds = cookieValue.Split('-').Select(x => int.Parse(x)).ToList();
                var products = _productService.GetProductsByIds(productIds);
                CheckoutVM checkoutVM = new()
                {
                    Products = products,
                    ProductIds = productIds
                };
                return View(checkoutVM);
            }
            return View();
        }
    }
}
