using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BanHangOnline.Models.EF
{
    [Table("tb_ProductCategory")]
    public class ProductCategory:CommonAbstract
    {
        public ProductCategory()
        {
            this.Products = new HashSet<Product>();
        }
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { set; get; }
        [Required]
        [StringLength(150)]
        public string Tiltle { set; get; }
        public string Description { set; get; }
        public string Icon { set; get; }
        public string SeoTitle { set; get; }
        public string SeoDescription { set; get; }
        public string SeoKeywords { set; get; }
        public int Position { set; get; }
        public ICollection<Product> Products { set; get; }
    }
}