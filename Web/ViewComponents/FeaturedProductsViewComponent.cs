using DataAccess;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.ViewComponents
{
    public class FeaturedProductsViewComponent:ViewComponent
    {
        private readonly ProductService _productService;
        public FeaturedProductsViewComponent(ApplicationDbContext context)
        {
            _productService = new ProductService(context);
        }

        public ViewViewComponentResult Invoke()
        {
            return View(_productService.GetFeaturedProducts());
        }
    }
}
