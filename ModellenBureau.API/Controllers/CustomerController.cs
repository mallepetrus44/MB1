using Microsoft.AspNetCore.Mvc;
using ModellenBureau.API.Models;
using ModellenBureau.Main.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModellenBureau.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : Controller
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerController(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        [HttpGet]
        public IActionResult GetAllCustomers()
        {
            return Ok(_customerRepository.GetAllCustomers());
        }

        [HttpGet("{id}")]
        public IActionResult GetCustomerById(int id)
        {
            return Ok(_customerRepository.GetCustomerById(id));
        }

        [HttpPost]
        public IActionResult CreateCustomer([FromBody] Customer customer)
        {
            if (customer == null)
                return BadRequest();

            if (customer.Voornaam == string.Empty || customer.Achternaam == string.Empty)
            {
                ModelState.AddModelError("Voornaam", "Voornaam is een verplicht veld");
            }

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var createdCustomer = _customerRepository.AddCustomer(customer);

            return Created("customer", createdCustomer);
        }

        [HttpPut]
        public IActionResult UpdateCustomer([FromBody] Customer customer)
        {
            if (customer == null)
                return BadRequest();

            if (customer.Voornaam == string.Empty || customer.Achternaam == string.Empty)
            {
                ModelState.AddModelError("Achternaam", "Achternaam is een verplicht veld");
            }

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var customerToUpdate = _customerRepository.GetCustomerById(customer.CustomerID);

            if (customerToUpdate == null)
                return NotFound();

            _customerRepository.UpdateCustomer(customer);

            return NoContent(); //success
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteCustomer(int id)
        {
            if (id == 0)
                return BadRequest();

            var customerToDelete = _customerRepository.GetCustomerById(id);
            if (customerToDelete == null)
                return NotFound();

            _customerRepository.DeleteCustomer(id);

            return NoContent();//success
        }
    }
}
