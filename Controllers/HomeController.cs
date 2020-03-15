using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using aspnet2.Models;

namespace aspnet2.Controllers
{
    public class HomeController : Controller
    {
        ApplicationContext db = new ApplicationContext();

        public ActionResult Index()
        {
            var products = db.Products.Include(p => p.Material);
            ViewBag.Products = products;

            var userId = Session["UserId"];
            if (userId != null)
            {
                Console.WriteLine(userId.ToString());
            }
            else
            {
                Console.WriteLine("UserId don`t exist");
            }

            return View();
        }
    }
}
