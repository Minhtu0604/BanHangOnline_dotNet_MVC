using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BanHangOnline.Models.EF
{
    public class SystemSetting : CommonAbstract
    {
        [Key]
        [StringLength(50)]
        public string SettingKey { set; get; }
        [StringLength(4000)]
        public string SettingValue { set; get; }
        [StringLength(4000)]
        public string SettingDescription { set; get; }
    }
}