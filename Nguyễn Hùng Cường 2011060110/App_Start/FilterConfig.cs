using System.Web;
using System.Web.Mvc;

namespace Nguyễn_Hùng_Cường_2011060110
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
