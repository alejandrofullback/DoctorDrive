using System.Web.Http;
using System.Web.Http.Cors;
using DoctorDrive.API.Filters;

namespace DoctorDrive.API.App_Start
{
    public class WebApiConfig
    {
        /// <summary>
        /// Registers the specified configuration.
        /// </summary>
        /// <param name="configuration">The configuration.</param>
        public static void Register(HttpConfiguration configuration)
        {
            configuration.Routes.MapHttpRoute("Api", "api/{controller}/{id}",
                new { id = RouteParameter.Optional });

            configuration.Filters.Add(new UnhandledExceptionAttribute());
            configuration.EnableCors();
        }
    }
}