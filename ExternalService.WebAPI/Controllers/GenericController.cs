
using System.Web.Http;

namespace ExternalService.WebAPI.Controllers
{
    [Route("Generic/api/v1/")]
    public class GenericController : ApiController
    {
        [HttpGet]
        [Route("GetString")]
        public IHttpActionResult GetString()
        {
            return Ok("Hello World");
        }
    }
}
