using ResultFilter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ResultFilter.Controllers
{
    public class HomeController : Controller
    {
        PersonDBEntities db = new PersonDBEntities();
        // GET: Home
        [OutputCache(Duration =10, Location =System.Web.UI.OutputCacheLocation.Any)]
        public ActionResult Index()
        {
            ViewBag.Time = DateTime.Now.ToLongTimeString();
            return View();
        }
        public ActionResult GetData()
        {
            var data = db.people.ToList();
            return View(data);
        }
    }
}