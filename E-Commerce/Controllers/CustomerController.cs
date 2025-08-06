using E_Commerce.BLL.Repositories;
using E_Commerce.BLL.Service.Customer;
using E_Commerce.DAL.Entites;
using Microsoft.AspNetCore.Mvc;

namespace E_Commerce.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : Controller
    {
        private readonly IGenaricRepository<Customer> _customerRepo;
        //private readonly ICustomerService _customerService;

        //, ICustomerService customerService
        public CustomerController(IGenaricRepository<Customer> customerRepo )
        {
            _customerRepo = customerRepo;
           // _customerService = customerService;

        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Customer>>> GetCustomers()
        {
            try
            {
                var customers = await _customerRepo.GetAllAsync();
                return Ok(customers);
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public async Task<ActionResult<Customer>> AddCustomer(Customer customer)
        {
            try
            {
                var add = await _customerRepo.Add(customer);
                return Ok(customer);
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{CustomerId}")]
        public async Task<ActionResult<Customer>> GetCustomer(int CustomerId)
        {
            try
            {

                var customer = await _customerRepo.GetByIdAsync(CustomerId);
                return Ok(customer);

            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                return BadRequest(ex.Message);
            }
        }

    }
}
