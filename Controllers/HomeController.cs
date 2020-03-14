using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using aspnet2.Models;

namespace aspnet2.Controllers
{
    public class HomeController : Controller
    {
        //ApplicationContext db = new ApplicationContext();

        public ActionResult Index()
        {
            //IEnumerable<Material> materials = db.Materials;
            //ViewBag.Materials = materials;

            return View();
        }
    }
}
