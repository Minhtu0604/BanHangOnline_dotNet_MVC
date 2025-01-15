using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BanHangOnline.Models.EF
{
    [Table("tb_Category")]
    public class Category : CommonAbstract
    {

        public Category() {
            this.News = new HashSet<News>();
        }
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public  int Id { set; get; }
        [Required(ErrorMessage ="Tên danh mục không được để trống")]
        [StringLength(150)]
        public string Tiltle { set; get; }
        public string Alias { set; get; }   
        public string Description { set; get; }
        [StringLength(150)]
        public string SeoTitle { set; get; }
        [StringLength(150)]
        public string SeoDescription { set; get; }
        [StringLength(150)]
        public string SeoKeywords { set; get; }
        public bool IsActive { get; set; }
        public int Position { set; get; }
        public ICollection<News> News { get; set; }
        public ICollection<Posts> Posts { get; set; }
    }
}