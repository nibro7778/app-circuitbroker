
using System.Web.Http;

namespace ExternalService.WebAPI.Controllers
{
    /// <summary>
    /// List of API with differnt "Hello World" functionality
    /// </summary>
    [RoutePrefix("HelloWorld/api/v1")]
    public class HelloWorldController : ApiController
    {
        /// <summary>
        /// This API simply retrun "Hello World" 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("Get")]        
        public IHttpActionResult GetHelloWorld()
        {
            return Ok("Hello World");
        }

        /// <summary>
        /// This API simply retrun "Hello World" + Requested string 
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [Route("Post")]
        public IHttpActionResult PostHelloWorld(string message)
        {
            return Ok("Hello World " + message);
        }
    }
}
