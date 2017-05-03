using System.Web;
using System.Web.Mvc;

namespace MvcRequestLifeCycle
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new ActionFilter3()); // add filter on global level
        }
    }
}
