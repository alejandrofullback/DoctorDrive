using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Ninject;

namespace DoctorDrive.API.Controllers
{
    public class BaseController : ApiController
    {
        [Inject]
        protected HttpResponseMessage CreatedHttpResponse(object newId, object createdItem)
        {
            var httpResponse = Request.CreateResponse(HttpStatusCode.Created, createdItem);
            string uri = Url.Link("DefaultApi", new { id = newId });
            httpResponse.Headers.Location = new Uri(uri);
            return httpResponse;
        }
    }
}