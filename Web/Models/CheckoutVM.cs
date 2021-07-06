using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Models
{
    public class CheckoutVM
    {
        public List<Product> Products { get; set; }
        public List<int> ProductIds { get; set; }
    }
}
