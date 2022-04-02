using System.Web;
using System.Web.Mvc;

namespace THi_PIIT_DANGVANTIEN
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
