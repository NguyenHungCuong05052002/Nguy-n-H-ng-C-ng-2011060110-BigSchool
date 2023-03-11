using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Nguyễn_Hùng_Cường_2011060110.Models;

namespace Nguyễn_Hùng_Cường_2011060110.ViewModels
{
    public class CourseViewModel
    {
        public string DiaChi{ get; set; }
        public string Ngay { get; set; }
        public string Gio { get; set; }
        public IEnumerable < Category > Categories { get; set; }
        public DateTime GetDateTime()
        {
            return DateTime.Parse(string.Format("{0} {1}", Ngay,Gio));
        }
        
    }
}