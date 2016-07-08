using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WAT.Admin.Data;

namespace WAT.Admin.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";
            ViewBag.Description = Open();
            return View();
        }

        private string Open()
        {
            var context = new WATContext();
            var pax = context.Paxes.FirstOrDefault();
            return pax != null ? pax.FirstName : "N/A";
            //context.Paxes.Add(new Entities.Pax { FirstName = "Test" });
            //context.SaveChanges();
        }
    }
}
