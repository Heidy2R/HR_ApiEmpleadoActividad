using System.Web;
using System.Web.Mvc;

namespace HR_ApiEmpleadoActividad
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
