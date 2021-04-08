using SistemaWebClinica.Models;
using SistemaWebClinica.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SistemaWebClinica.Controllers
{
    public class MedicoController : Controller
    {

        #region list
        // GET: Medico
        public ActionResult Index()
        {
            List<Medico> medicos = AdminMedico.GetMedicos();
            return View("_Index",medicos);
        }


        public ActionResult GetMedicosEspecialidad(string especialidad)
        {
            List<Medico> medicos = AdminMedico.GetMedicos(especialidad);
            if(medicos == null)
            {
                return HttpNotFound();
            }
            return View("_Index", medicos);
        }

        public ActionResult GetMedicosEspecialidadCiudad(string especialidad, string ciudad)
        {
            List<Medico> medicos = AdminMedico.GetMedicos(especialidad, ciudad);
            if (medicos == null)
            {
                return HttpNotFound();
            }
            return View("_Index", medicos);
        }

        #endregion


        #region create

        public ActionResult Create()
        {
            Medico nuevo = new Medico();
            return View("_Create", nuevo);
        }

        [HttpPost]
        public ActionResult Create(Medico nuevo)
        {
            if (!ModelState.IsValid)
            {
                return View("_Create", nuevo);
            }
            else
            {
                AdminMedico.Create(nuevo);
                return RedirectToAction("Index");
            }
        }

        #endregion


        #region delete

        public ActionResult Delete(int id)
        {
            return View("_Delete", AdminMedico.GetMedico(id));
        }

        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            AdminMedico.Delete(id);
            return RedirectToAction("Index");
        }

        #endregion


        #region details
        public ActionResult Details(int id)
        {
            Medico medico = AdminMedico.GetMedico(id);
            if(medico == null)
            {
                return HttpNotFound();
            }
            return View("_Details", medico);
        }

        #endregion


     }
}