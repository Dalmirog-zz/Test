using OdeToFood.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OdeToFood.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }

        public ActionResult About()
        {
            var model = new AboutModel();
            model.Name = "Scott";
            model.Location = "Maryland, USA";
            model.Message = ConfigurationManager.AppSettings["MyMessage"];

            return View(model);
        }

        public ActionResult Contact()
        {
            var model = new AboutModel();
            model.Name = "Scott";
            model.Location = "Maryland, USA";

            return View();
        }
    }
}
