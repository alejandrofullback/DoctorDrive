using System.Net;
using System.Net.Http;
using System.Web.Http.Filters;

namespace DoctorDrive.API.Filters
{
    public class UnhandledExceptionAttribute : ExceptionFilterAttribute
    {
        public override void OnException(HttpActionExecutedContext context)
        {
            context.Response = new HttpResponseMessage(HttpStatusCode.InternalServerError);
        }
    }
}