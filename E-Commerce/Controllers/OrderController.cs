using E_Commerce.BLL.Repositories;
using E_Commerce.BLL.Service.Order;
using E_Commerce.DAL.Entites;
using Microsoft.AspNetCore.Mvc;

namespace E_Commerce.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrderController : Controller
    {
        private readonly IGenaricRepository<Order> _orderRepo;
        // private readonly IOrderService _orderService;

        //, IOrderService orderService
        public OrderController(IGenaricRepository<Order> orderRepo )
        {
            _orderRepo = orderRepo;
          //  _orderService = orderService;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult<Order>> AddOrder(Order order)
        {
            try
            {
                var add = await _orderRepo.Add(order);
                return Ok(order);
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{OrderId}")]
        public async Task<ActionResult<Order>> GetOrder(int OrderId)
        {
            try
            {

                var order = await _orderRepo.GetByIdAsync(OrderId);
                return Ok(order);

            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public async Task<ActionResult<Order>> UpdateOrder(Order order)
        {
            try
            {

                var update = await _orderRepo.Update(order);
                return Ok(order);
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                return BadRequest(ex.Message);
            }
        }
    }
}
