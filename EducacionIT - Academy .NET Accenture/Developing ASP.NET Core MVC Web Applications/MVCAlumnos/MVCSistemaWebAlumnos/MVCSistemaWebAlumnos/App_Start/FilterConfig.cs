using System.Web;
using System.Web.Mvc;

namespace MVCSistemaWebAlumnos
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
