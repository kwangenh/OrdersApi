using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OrdersApi.Contracts;
using OrdersApi.Models;

namespace OrdersApi.Controllers
{
    public class CustomersController : Controller
    {
        private readonly ICustomerRepository _customerRepository;
        private ILogger _logger;

        public CustomersController(ILogger logger, ICustomerRepository customerRepository)
        {
            _logger = logger;
            _customerRepository = customerRepository;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult CreateCustomer([FromBody] Customer customer)
        {
            try
            {
                if (customer == null)
                {
                    return BadRequest("Customer object is null");
                }

                if (!ModelState.IsValid)
                {
                    return BadRequest("Invalid model object");
                }

                _customerRepository.CreateCustomer(customer);

                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong in Customers.CreateCustomer action: {ex}");
                return StatusCode(500, "Internal Server Error");
            }

        }

       /* [HttpGet]
        public JsonResult GetCustomers()
        {
            string json = JsonSerializer.Serialize(_customerRepository.GetCustomers());
            //return JsonSerializer.Serialize(json);
        }
        */
    }
}