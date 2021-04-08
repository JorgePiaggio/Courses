using MVCTransportes.Data;
using MVCTransportes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTransportes.Controllers
{
    public class CamionController : Controller
    {
        // GET: Chofer
        public ActionResult Index()
        {
            List<Camion> camiones = AdminCamion.GetCamiones();
            return View(camiones);
        }

        [ChildActionOnly]
        public ActionResult _CamionList(int number = 0)
        {
            List<Camion> camiones = AdminCamion.GetCamiones();
            return PartialView("_CamionList", camiones);
        }

        public ActionResult Display(int id)
        {
            Camion camion = AdminCamion.GetCamion(id);
            if (camion != null)
                return View("Display", camion);
            return HttpNotFound();
        }

        public ActionResult Create()
        {
            return View("_CamionCreate");
        }

        [ChildActionOnly]
        public ActionResult _CamionCreate()
        {
            Camion camion = new Camion();
            return PartialView("_CamionList", camion);
        }

        [HttpPost]
        public ActionResult Create(Camion camion)
        {
            if (!ModelState.IsValid)
            {
                return View("Create", camion);
            }
            else
            {
                AdminCamion.Create(camion);
                return RedirectToAction("Index");
            }
        }

        public ActionResult Update(int id)
        {
            Camion c = AdminCamion.GetCamion(id);
            return View("Update", c);
        }

        [HttpPost]
        public ActionResult Update(Camion camion)
        {
            if (!ModelState.IsValid)
            {
                return View("Update", camion);
            }
            else
            {
                AdminCamion.Update(camion);
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
            AdminCamion.Delete(id);
            return RedirectToAction("Index");
        }

    }
}