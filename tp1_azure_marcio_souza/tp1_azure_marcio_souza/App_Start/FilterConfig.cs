using System.Web;
using System.Web.Mvc;

namespace tp1_azure_marcio_souza
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
