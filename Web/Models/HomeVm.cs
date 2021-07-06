using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Models
{
    public class HomeVm
    {
        public List<Category> Categories { get; set; }
        public List<Product> Products { get; set; }
        public List<Header> Headers { get; set; }
        public List<Taste> Tastes { get; set; }
        public List<Menu> Menus { get; set; }
        public List<Brands> Brands { get; set; }
        public List<Blog> Blogs { get; set; }
        public List<Photo> Photos { get; set; }
    }
}
