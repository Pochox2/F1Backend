using System;
using System.Net;

namespace Formula1Backend.Utils
{
    public class HttpError : Exception
    {
        public HttpStatusCode StatusCode { get; set; }

        public HttpError(string message, HttpStatusCode statusCode = HttpStatusCode.BadRequest) : base(message)
        {
            StatusCode = statusCode;
        }
    }
}
