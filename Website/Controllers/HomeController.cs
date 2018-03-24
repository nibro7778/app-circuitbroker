using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Services;

namespace Website.Controllers
{
    public class HomeController : Controller
    {
        private readonly IService _service;

        public HomeController(IService service)
        {
            _service = service;
        }

        public async Task<ActionResult> Index()
        {
            var serviceResponse = await _service.GetHelloWorldAsync();
            //service response object contain response of external service
            return View();
        }
    }
}