using System.Web;
using System.Web.Mvc;
using CartmitMVC.Filters;
using log4net.Config;

namespace CartmitMVC
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new LogAttribute());
        }
    }
}
