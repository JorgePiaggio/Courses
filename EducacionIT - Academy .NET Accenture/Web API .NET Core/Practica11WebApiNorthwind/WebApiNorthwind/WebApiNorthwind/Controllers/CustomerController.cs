using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiNorthwind.Models;

namespace WebApiNorthwind.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly NorthwindContext _context;
        public CustomerController(NorthwindContext context)
        {
            _context = context;
        }


        [HttpGet]
        public IEnumerable<Customers> Get()
        {
            return _context.Customers.ToList();
        }

        [HttpGet("{id}")]
        public ActionResult<Customers> Get(string id)
        {
            var customer = _context.Customers.FirstOrDefault(x => x.CustomerId.Equals( id));

            if (customer == null)
            {
                return NotFound();
            }
            return customer;
        }

        [HttpGet("city/{city}")]
        public IEnumerable<Customers> GetCustomerByCity(string city)
        {
            IEnumerable<Customers> customers = (from c in _context.Customers where c.City == city select c).ToList();

            if (customers == null)
             {
                 return (IEnumerable<Customers>)NotFound();
             }

            return customers;
        }


        [HttpPost]
        public ActionResult Post([FromBody] Customers customer)
        {
            _context.Customers.Add(customer);
            _context.SaveChanges();

            return new CreatedAtRouteResult("ObtenerCustomer", new { id = customer.CustomerId }, customer);
        }


        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Customers customer)
        {
            if( !id.Equals(customer.CustomerId) )
            {
                return BadRequest();
            }

            _context.Entry(customer).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();

            return Ok();
        }


        [HttpDelete("{id}")]
        public ActionResult<Customers> Delete (string id)
        {
            var customer = _context.Customers.Find(id);

            if(customer == null)
            {
                return NotFound();
            }

            _context.Customers.Remove(customer);
            _context.SaveChanges();

            return customer;

        }
    }
}
