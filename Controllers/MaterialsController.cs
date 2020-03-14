using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using aspnet2.Models;

namespace aspnet2.Controllers
{
    public class MaterialsController : Controller
    {
        ApplicationContext db = new ApplicationContext();

        public ActionResult Index()
        {
            IEnumerable<Material> materials = db.Materials;
            ViewBag.Materials = materials;

            return View ();
        }

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            var material = db.Materials.Find(id);

            if (material == null)
            {
                return HttpNotFound();
            }

            ViewBag.Material = material;

            return View(material);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Material material)
        {
            try
            {
                db.Materials.Add(material);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return HttpNotFound();
            }
        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            var material = db.Materials.Find(id);

            if (material == null)
            {
                return HttpNotFound();
            }

            return View(material);
        }

        [HttpPost]
        public ActionResult Edit(Material material)
        {
            try
            { 
                db.Entry(material).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return HttpNotFound();
            }
        }

        public ActionResult Delete(int id)
        {
            try
            {
                var material = db.Materials.Find(id);
                db.Materials.Remove(material);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return HttpNotFound();
            }
        }
    }
}
