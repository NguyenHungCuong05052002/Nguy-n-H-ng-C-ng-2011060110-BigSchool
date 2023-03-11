using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Nguyễn_Hùng_Cường_2011060110.Models
{
    public class Course
    {
        public int Id { get; set; }
        public ApplicationUser GiangVien { get; set; }

        public string LecturerID { get; set; }

        [Required]
        [StringLength(255)]
        public string Place { get; set; }

        public DateTime DateTime { get; set; }
        public Category Category { get; set; }
        [Required]
        public byte CategoryID { get; set; }
        

    }
}