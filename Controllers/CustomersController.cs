using Customer_Api.Models;
using Customer_Api.Services.CustomerService;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace Customer_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController] 
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
            
        }

        [HttpGet]
        public async Task<ActionResult<List<Customer>>> getAllCustomer()
        {
            return await _customerService.getAllCustomer();
        }

        [HttpGet("{Id}")]
        public async Task<ActionResult<Customer>> getCustomerById(int Id)
        {
            var customer = await _customerService.getCustomerById(Id);
            if (customer is null)
                return NotFound("Sorry the customer doesn't exist");
            return Ok(customer);
        }

        [HttpPost]
        public async Task<ActionResult<List<Customer>>> addCustomer(Customer addCustomer)
        {
            var customer = await _customerService.addCustomer(addCustomer);
            return Ok(customer);

        }

        [HttpPut("{customerId}")]
        public async Task<ActionResult<List<Customer>>> updateCustomerById(int Id, Customer requestUpdate)
        {
            var customer = await _customerService.updateCustomerById(Id, requestUpdate);
            if (customer is null)
                return NotFound("Sorry the customer doesn't exist");
            return Ok(customer);
        }

        [HttpDelete("{customerId}")]
        public async Task<ActionResult<List<Customer>>> deleteCustomerById(int Id)
        {
            var customer = await (_customerService.deleteCustomerById(Id));
            if (customer is null)
                return NotFound("Sorry the customer doesn't exist");

            return Ok(customer);

        }
    }
}


