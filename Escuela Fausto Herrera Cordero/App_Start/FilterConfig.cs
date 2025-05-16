using System.Web;
using System.Web.Mvc;

namespace Escuela_Fausto_Herrera_Cordero
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
