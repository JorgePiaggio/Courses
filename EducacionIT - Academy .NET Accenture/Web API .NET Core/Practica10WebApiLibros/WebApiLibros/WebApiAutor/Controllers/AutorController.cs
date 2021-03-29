using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiAutor.Data;
using WebApiAutor.Models;
using Microsoft.EntityFrameworkCore;

namespace WebApiAutor.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutorController : ControllerBase
    {
        private readonly BaseAutorContext _context;

        public AutorController(BaseAutorContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Autor> Get()
        {
            return _context.Autores.ToList();
        }


        [HttpGet("{id}")]
        public ActionResult<Autor> Get (int id)
        {
            // return _context.Autores.Find(id);

            var autor = _context.Autores.FirstOrDefault(x => x.AutorId == id);
            if(autor == null)
            {
                return NotFound();  // heredado de clase ControllerBase - StatusCodeResult // error 404
            }
            return autor;
        }


        [HttpPost]
        public ActionResult Post([FromBody] Autor autor)
        {
            _context.Autores.Add(autor);
            _context.SaveChanges();

            return new CreatedAtRouteResult("ObtenerAutor", new { id = autor.AutorId }, autor); // 201
        }


        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Autor autor)
        {

            if (id != autor.AutorId)
            {
                return BadRequest(); // 400
            }

            _context.Entry(autor).State = EntityState.Modified;
            _context.SaveChanges();

            return Ok(); // 200
        }


        [HttpDelete("{id}")]
        public ActionResult<Autor> Delete (int id)
        {
            var autor = _context.Autores.Find(id);
            
            if( autor == null)
            {
                return NotFound(); // 404
            }

            _context.Autores.Remove(autor);
            _context.SaveChanges();

            return autor;

        }



    }
}
