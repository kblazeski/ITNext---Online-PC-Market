using System.Web;
using System.Web.Mvc;

namespace ITNext___Online_PC_Market
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
