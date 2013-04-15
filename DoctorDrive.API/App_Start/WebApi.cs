﻿using System.Web.Http;
using DoctorDrive.API.Filters;

namespace DoctorDrive.API.App_Start
{
    public class WebApi
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
        }
    }
}