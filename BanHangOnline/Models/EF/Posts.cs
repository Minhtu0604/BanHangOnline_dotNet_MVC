using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BanHangOnline.Models.EF
{
    [Table("tb_Posts")]
    public class Posts : CommonAbstract
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [StringLength(150)]
        public string Tiltle { get; set; }
        [StringLength(150)]
        public string Alias { get; set; }
        public string Description { get; set; }
        [AllowHtml]
        public string Detail { get; set; }
        [StringLength(250)]
        public string Image { get; set; }
        public int CategoryId { get; set; }
        [StringLength(250)]
        public string SeoTitle { set; get; }
        [StringLength(500)]
        public string SeoDescription { set; get; }
        [StringLength(250)]
        public string SeoKeywords { set; get; }
        public bool IsActive { get; set; }
        public virtual Category Category { get; set; }
    }
}