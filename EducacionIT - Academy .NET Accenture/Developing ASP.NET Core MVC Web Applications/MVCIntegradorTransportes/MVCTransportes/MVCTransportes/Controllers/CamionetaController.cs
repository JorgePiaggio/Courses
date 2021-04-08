using MVCTransportes.Data;
using MVCTransportes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTransportes.Controllers
{
    public class CamionetaController : Controller
    {
        // GET: Chofer
        public ActionResult Index()
        {
            List<Camioneta> camionetas = AdminCamioneta.GetCamionetas();
            return View(camionetas);
        }

        [ChildActionOnly]
        public ActionResult _ChoferList(int number = 0)
        {
            List<Camioneta> camionetas = AdminCamioneta.GetCamionetas();
            return PartialView("_CamionetaList", camionetas);
        }

        public ActionResult Display(int id)
        {
            Camioneta camioneta = AdminCamioneta.GetCamioneta(id);
            if (camioneta != null)
                return View("Display", camioneta);
            return HttpNotFound();
        }

        public ActionResult Create()
        {
            return View("_CamionetaCreate");
        }

        [ChildActionOnly]
        public ActionResult _CamionetaCreate()
        {
            Camioneta camioneta = new Camioneta();
            return PartialView("_CamionetaList", camioneta);
        }

        [HttpPost]
        public ActionResult Create(Camioneta camioneta)
        {
            if (!ModelState.IsValid)
            {
                return View("Create", camioneta);
            }
            else
            {
                AdminCamioneta.Create(camioneta);
                return RedirectToAction("Index");
            }
        }

        public ActionResult Update(int id)
        {
            Camioneta c = AdminCamioneta.GetCamioneta(id);
            return View("Update", c);
        }

        [HttpPost]
        public ActionResult Update(Camioneta camioneta)
        {
            if (!ModelState.IsValid)
            {
                return View("Update", camioneta);
            }
            else
            {
                AdminCamioneta.Update(camioneta);
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
            AdminCamioneta.Delete(id);
            return RedirectToAction("Index");
        }
    }
}