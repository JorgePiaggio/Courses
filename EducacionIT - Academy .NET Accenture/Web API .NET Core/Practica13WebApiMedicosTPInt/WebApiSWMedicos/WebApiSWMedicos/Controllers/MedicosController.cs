using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiSWMedicos.Data;
using WebApiSWMedicos.Models;

namespace WebApiSWMedicos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MedicosController : ControllerBase
    {

        private readonly MedicosDBContext _context;
        public MedicosController(MedicosDBContext context)
        {
            _context = context;
        }


        #region endpoints
        //    -- >     /api/medicos
        [HttpGet] 
        public IEnumerable<Medico> Get()
        {
            return _context.Medicos.ToList();
        }


        //    -- >     /api/medicos/pediatra
        [HttpGet("{especialidad}")]
        public IEnumerable<Medico> Get(string especialidad)
        {
            IEnumerable<Medico> medicos = _context.Medicos.Where(x => x.Especialidad == especialidad).ToList();

            if (medicos == null)
            {
                return (IEnumerable<Medico>)NotFound();
            }

            return medicos;
        }


        //    -- >     /api/medicos/pediatra/balcarce
        [HttpGet("{especialidad}/{ciudad}")]
        public IEnumerable<Medico> Get(string especialidad, string ciudad)
        {
            IEnumerable<Medico> medicos = _context.Medicos.Where(x => x.Especialidad == especialidad && x.Ciudad == ciudad).ToList();

            if (medicos == null)
            {
                return (IEnumerable<Medico>)NotFound();
            }

            return medicos;
        }


        [HttpPost]
        public ActionResult Post([FromBody] Medico medico)
        {
            _context.Medicos.Add(medico);
            _context.SaveChanges();

            return new CreatedAtRouteResult("Obtener Medico", new { id = medico.Id }, medico);
        }

        #endregion

    }
}
