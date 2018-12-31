using LLearningBuildingWebAPIsWithASPNETCore2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace LLearningBuildingWebAPIsWithASPNETCore2.Controllers
{
    [Produces("application/json")]
    [Route("")]
    public class OrderItemsController : Controller
    {
        private readonly H_Plus_SportsContext _context;

        public OrderItemsController(H_Plus_SportsContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetOrderItem()
        {
            return new ObjectResult(_context.OrderItem);
        }

        [HttpGet("{id}", Name = "GetOrderItem")]
        public async Task<IActionResult> GetOrderItem([FromRoute] int id)
        {
            var orderItem = await _context.OrderItem.SingleOrDefaultAsync(m => m.OrderItemId == id);
            return Ok(orderItem);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutOrderItem([FromRoute] int id, [FromBody] OrderItem orderItem)
        {
            _context.Entry(orderItem).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return Ok(orderItem);
        }

        [HttpPost]
        public async Task<IActionResult> PostOrderItem([FromBody] OrderItem orderItem)
        {
            _context.OrderItem.Add(orderItem);
            await _context.SaveChangesAsync();
            return CreatedAtAction("GetOrderItem", new { id = orderItem.OrderItemId }, orderItem);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOrderItem([FromBody] int id)
        {
            var orderItem = await _context.OrderItem.SingleOrDefaultAsync(m => m.OrderItemId == id);
            _context.OrderItem.Remove(orderItem);
            await _context.SaveChangesAsync();
            return Ok(orderItem);
        }
    }
}
