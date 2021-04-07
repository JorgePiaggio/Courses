using MVCTransportes.Data;
using MVCTransportes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTransportes.Controllers
{
    public class ChoferController : Controller
    {
        // GET: Chofer
        public ActionResult Index()
        {
            List<Chofer> choferes = AdminChofer.GetChoferes();
            return View(choferes);
        }

        [ChildActionOnly]
        public ActionResult _ChoferList(int number = 0)
        {
            List<Chofer> choferes = AdminChofer.GetChoferes();
            return PartialView("_ChoferList", choferes);
        }

        public ActionResult Display(int id)
        {
            Chofer chofer = AdminChofer.GetChofer(id);
            if(chofer != null)
                return View("Display", chofer);
            return HttpNotFound();
        }

        public ActionResult Create()
        {
            return View("_ChoferCreate");
        }

        [ChildActionOnly]
        public ActionResult _ChoferCreate()
        {
            Chofer nuevo = new Chofer();
            return PartialView("_ChoferList", nuevo);
        }

        [HttpPost]
        public ActionResult Create(Chofer chofer)
        {
            if (!ModelState.IsValid)
            {
                return View("Create", chofer);
            }
            else
            {
                AdminChofer.Create(chofer);
                return RedirectToAction("Index");
            }
        }

        public ActionResult Update(int id)
        {
            Chofer c = AdminChofer.GetChofer(id);
            return View("Update",c);
        }

        [HttpPost]
        public ActionResult Update(Chofer chofer)
        {
            if (!ModelState.IsValid)
            {
                return View("Update", chofer);
            }
            else
            {
                AdminChofer.Update(chofer);
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
                AdminChofer.Delete(id);
                return RedirectToAction("Index");
        }


    }
}