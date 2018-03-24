using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Services;

namespace Website.Controllers
{
    public class HomeController : Controller
    {
        private IService _service;

        public HomeController(IService service)
        {
            _service = service;
        }

        public ActionResult Index()
        {
            return View();
        }
    }
}