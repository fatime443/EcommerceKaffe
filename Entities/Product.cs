using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public string Description { get; set; }
        public decimal? Discount { get; set; }
        public int Count { get; set; }
        [Required]
        public bool IsSale { get; set; }
        public bool IsFeatured { get; set; }
        public string ImageUrl { get; set; }
        public virtual List<ProductPicture> ProductPictures { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public virtual List<ProductDetail> ProductDetails { get; set; }
    }
}
