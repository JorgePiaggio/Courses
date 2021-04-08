using MVCTransportes.Data;
using MVCTransportes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTransportes.Controllers
{
    public class AutoController : Controller
    {
        // GET: Chofer
        public ActionResult Index()
        {
            List<Auto> autos = AdminAuto.GetAutos();
            return View(autos);
        }

        [ChildActionOnly]
        public ActionResult _AutoList(int number = 0)
        {
            List<Auto> autos = AdminAuto.GetAutos();
            return PartialView("_AutoList", autos);
        }

        public ActionResult Display(int id)
        {
            Auto auto = AdminAuto.GetAuto(id);
            if (auto != null)
                return View("Display", auto);
            return HttpNotFound();
        }

        public ActionResult Create()
        {
            return View("_AutoCreate");
        }

        [ChildActionOnly]
        public ActionResult _AutoCreate()
        {
            Auto auto = new Auto();
            return PartialView("_AutoList", auto);
        }

        [HttpPost]
        public ActionResult Create(Auto auto)
        {
            auto.Chofer = AdminChofer.GetChofer(auto.Chofer.ChoferID);
            if (!ModelState.IsValid)
            {
                return View("Create", auto);
            }
            else
            {
                AdminAuto.Create(auto);
                return RedirectToAction("Index");
            }
        }

        public ActionResult Update(int id)
        {
            Auto c = AdminAuto.GetAuto(id);
            return View("Update", c);
        }

        [HttpPost]
        public ActionResult Update(Auto auto)
        {
            if (!ModelState.IsValid)
            {
                return View("Update", auto);
            }
            else
            {
                AdminAuto.Update(auto);
                return RedirectToAction("Index");
            }
        }

        public ActionResult Delete(int id)
        {
            return DeleteConfirmed(id);
        }

        [HttpPost]
        public ActionResult DeleteConfirmed(int id)
        {
            AdminAuto.Delete(id);
            return RedirectToAction("Index");
        }
    }
}