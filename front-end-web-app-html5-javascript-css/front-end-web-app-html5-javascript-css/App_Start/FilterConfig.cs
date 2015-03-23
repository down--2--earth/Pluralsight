using System.Web;
using System.Web.Mvc;

namespace front_end_web_app_html5_javascript_css
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
