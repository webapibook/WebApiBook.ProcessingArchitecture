using System.Web;
using System.Web.Mvc;

namespace WebApiBook.ProcessingArchitecture.ProcessesApi.v1
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}