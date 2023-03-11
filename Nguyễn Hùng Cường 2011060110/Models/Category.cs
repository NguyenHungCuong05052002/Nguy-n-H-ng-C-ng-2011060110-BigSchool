using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Nguyễn_Hùng_Cường_2011060110.Models
{
    public class Category
    {
        public byte ID { get; set; }
        [Required]
        [StringLength(255)]
        public String Name { get; set; }
    }
}