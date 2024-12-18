using Food1.Models;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;

namespace Food1.Controllers
{
    public class OrderController : ApiController
    {
        private readonly ApplicationDbContext _context;

        public OrderController()
        {
            _context = new ApplicationDbContext(); // Initialize your DB context
        }

        [HttpGet] 
        public IHttpActionResult GetOrder()
        {
            using (var db = new ApplicationDbContext())
            {
                var users = db.Orders.Select(u => new
                {
                    u.Id,
                    u.UserId,
                    u.OrderDate,
                }).ToList();

                return Ok(users);
            }
        }

        // POST: api/Order
        [HttpPost]
        public async Task<IHttpActionResult> PlaceOrder([FromBody] Order order)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Invalid order data.");
            }

            order.OrderDate = DateTime.UtcNow;

            _context.Orders.Add(order);
            await _context.SaveChangesAsync();

            return Ok(new { Message = "Order placed successfully", OrderId = order.Id });
        }
    }
}
