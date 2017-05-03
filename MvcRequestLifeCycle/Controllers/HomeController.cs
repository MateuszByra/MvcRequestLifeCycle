using MvcRequestLifeCycle.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcRequestLifeCycle.Controllers
{
    [ActionFilter2]
    public class HomeController : Controller
    {
        [ActionFilter1]

        [AuthorizationFilter]
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [IsMobile]
        public JsonResult Register()
        {
            return Json("{Message: Display on Mobile Devices}");
        }
       
    }
}