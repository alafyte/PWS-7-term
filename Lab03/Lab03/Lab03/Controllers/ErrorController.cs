using System;
using System.Net;
using System.Web.Http;
using System.Xml.Linq;

namespace WebApplication2.Controllers
{
    [RoutePrefix("api/error")]
    public class ErrorController : ApiController
    {
        [Route("{code:int}/{id:int}.{format}")]
        [HttpGet]
        public IHttpActionResult Error(int code, int id, string format)
        {
            if (format == "json")
            {
                switch (id)
                {
                    default:
                    case 1:
                        return Json(new { message = $"{code}/{id}. There's no entity by this id" });
                    case 2:
                        return Json(new { message = $"{code}/{id}. Unsupported format" });
                    case 3:
                        return Json(new { message = $"{code}/{id}. Enter correct data" });
                    case 4:
                        return Json(new { message = $"{code}/{id}. Fields limit, offset, minId, и maxId must be not negative" });
                    case 5:
                        return Json(new { message = $"{code}/{id}. minId must be less than maxId." });
                }
            }
            else
            {
                string message;
                switch (id)
                {
                    default:
                    case 1:
                        message = "Entity not found with the given id";
                        break;
                    case 2:
                        message = "Unsupported format";
                        break;
                    case 3:
                        message = "Invalid data provided";
                        break;
                    case 4:
                        message = "Fields limit, offset, minId, and maxId must be non-negative";
                        break;
                    case 5:
                        message = "minId must be less than maxId";
                        break;
                }

                return GenerateXmlErrorResponse(code, id, message);
            }
        }

        private IHttpActionResult GenerateXmlErrorResponse(int code, int id, string message)
        {
            var xmlResponse = new XElement("error",
                new XElement("code", code),
                new XElement("id", id),
                new XElement("message", message)
            );

            return Content(HttpStatusCode.OK, xmlResponse, Configuration.Formatters.XmlFormatter, "application/xml");
        }
    }
}
