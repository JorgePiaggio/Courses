using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiPubs.Models;

namespace WebApiPubs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PublisherController : ControllerBase
    {

        private readonly pubsContext _context;
        public PublisherController(pubsContext context)
        {
            _context = context;
        }


        #region endpoints
        // api/publisher
        [HttpGet]
        public IEnumerable<Publishers> Get()
        {
            return _context.Publishers.ToList();
        }

        // api/publisher/USA
        [HttpGet("{pais}")]
        public IEnumerable<Publishers> Get(string pais)
        {
            IEnumerable<Publishers> publishers = _context.Publishers.Where(x => x.Country == pais).ToList();

            if (publishers == null)
            {
                return (IEnumerable<Publishers>)NotFound();
            }

            return publishers;
        }

        // api/publisher/USA/Chicago
        [HttpGet("{pais}/{ciudad}")]
        public IEnumerable<Publishers> Get(string pais, string ciudad)
        {
            IEnumerable<Publishers> publishers = _context.Publishers.Where(x => x.Country == pais && x.City == ciudad).ToList();

            if (publishers == null)
            {
                return (IEnumerable<Publishers>)NotFound();
            }

            return publishers;
        }



        [HttpPost]
        public ActionResult Post([FromBody] Publishers publisher)
        {
            _context.Publishers.Add(publisher);
            _context.SaveChanges();

            return new CreatedAtRouteResult("Obtener Publisher", new { id = publisher.PubId }, publisher);
        }

        #endregion
    }
}
