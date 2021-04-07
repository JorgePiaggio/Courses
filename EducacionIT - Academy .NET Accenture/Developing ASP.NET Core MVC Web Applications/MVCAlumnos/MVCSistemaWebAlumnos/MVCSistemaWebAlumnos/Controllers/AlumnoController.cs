using MVCSistemaWebAlumnos.Data;
using MVCSistemaWebAlumnos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCSistemaWebAlumnos.Controllers
{
    public class AlumnoController : Controller
    {
        private AlumnoDBContext context = new AlumnoDBContext();


        // GET: Alumno
        public ActionResult Index()
        {
            List<Alumno> alumnos = context.Alumnos.ToList();
            return View(alumnos);
        }

        [ChildActionOnly]
        public ActionResult _AlumnoGallery(int number = 0)
        {
            List<Alumno> alumnos;
            if (number == 0)
            {
                alumnos = context.Alumnos.ToList();
            }
            else
            {
                alumnos = (from p in context.Alumnos orderby p.AlumnoID ascending select p).Take(number).ToList();
            }

            return PartialView("_AlumnoGallery", alumnos);
        }


        public ActionResult Display(int id)
        {
            Alumno alumno = context.Alumnos.Find(id);

            if (alumno == null)
            {
                return HttpNotFound();
            }
            return View("Display", alumno);
        }


        // GET: Alumno/Create
        public ActionResult Create()
        {
            Alumno nuevo = new Alumno();
            return View(nuevo);
        }

        // POST: Alumno/Create
        [HttpPost]
        public ActionResult Create(Alumno nuevo)
        {
            if (!ModelState.IsValid)
                return View("Create", nuevo);
            else
            {
                context.Alumnos.Add(nuevo);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
        }

        public ActionResult Delete(int id)
        {
            Alumno alumno = context.Alumnos.Find(id);

            if(alumno == null)
            {
                return HttpNotFound();
            }

            return View("Delete", alumno);
        }

        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteConfirmed(Alumno alumno)
        {
            Alumno a = context.Alumnos.Find(alumno.AlumnoID);
            context.Alumnos.Remove(a);
            context.SaveChanges();
            return RedirectToAction("Index");
        }


 
    }
}