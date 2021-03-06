﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LLearningBuildingWebAPIsWithASPNETCore2.Models;
using System.Linq;
using System.Threading.Tasks;

namespace LLearningBuildingWebAPIsWithASPNETCore2.Controllers
{
    [Produces("application/json")]
    [Route("api/Orders")]
    public class OrderController : Controller
    {
        private readonly H_Plus_SportsContext _context;

        public OrderController(H_Plus_SportsContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetOrder()
        {
            return new ObjectResult(_context.Order);
        }

        [HttpGet("{id}", Name = "GetOrder")]
        public async Task<IActionResult> GetOrder([FromRoute] int id)
        {
            var order = await _context.Order.SingleOrDefaultAsync(m => m.OrderId == id);
            return Ok(order);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutOrder([FromRoute] int id, [FromBody]Order order)
        {
            _context.Entry(order).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return Ok(order);
        }

        [HttpPost]
        public async Task<IActionResult> PostOrder([FromBody] Order order)
        {
            _context.Order.Add(order);
            await _context.SaveChangesAsync();
            return CreatedAtAction("GetOrder", new { id = order.OrderId }, order);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOrder([FromRoute] int id)
        {
            var order = await _context.Order.SingleOrDefaultAsync(m => m.OrderId == id);
            _context.Order.Remove(order);
            await _context.SaveChangesAsync();
            return Ok(order);
        }
    }
}
