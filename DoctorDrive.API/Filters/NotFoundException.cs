using System.Net;
using System.Web.Http;

namespace DoctorDrive.API.Filters
{
    public class NotFoundException : HttpResponseException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NotFoundException" /> class.
        /// </summary>
        public NotFoundException() : base(HttpStatusCode.NotFound) { }
    }
}