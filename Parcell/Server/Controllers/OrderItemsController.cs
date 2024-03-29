﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Parcell.Server.Data;
using Parcell.Server.IRepository;
using Parcell.Shared.Domain;

namespace Parcell.Server.Controllers
{
    //controller for orderitems
    [Route("api/[controller]")]
    [ApiController]
    public class OrderItemsController : ControllerBase
    {

        private readonly IUnitOfWork _unitOfWork;
        public OrderItemsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;

        }



        // GET: api/OrderItems
        [HttpGet]
        public async Task<IActionResult> GetOrderItems()
        {
            var orderItems = await _unitOfWork.OrderItems.GetAll();
            return Ok(orderItems);
        }



        // GET: api/OrderItems/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetOrderItem(int id)
        {
            var orderItem = await _unitOfWork.OrderItems.Get(q => q.Id == id);

            if (orderItem == null)
            {
                return NotFound();
            }

            return Ok(orderItem);
        }

        // PUT: api/OrderItems/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOrderItem(int id, OrderItem orderItem)
        {
            if (id != orderItem.Id)
            {
                return BadRequest();
            }


            _unitOfWork.OrderItems.Update(orderItem);
            try
            {

                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {

                if (!await OrderItemExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/OrderItems

        [HttpPost]
        public async Task<ActionResult<OrderItem>> PostOrderItem(OrderItem orderItem)
        {

            await _unitOfWork.OrderItems.Insert(orderItem);
            await _unitOfWork.Save(HttpContext);
            return CreatedAtAction(nameof(GetOrderItem), new { id = orderItem.Id }, orderItem);
        }


        // DELETE: api/OrderItems/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOrderItem(int id)
        {
            var orderItem = await _unitOfWork.OrderItems.Get(q => q.Id == id);
            if (orderItem == null)
            {
                return NotFound();
            }


            await _unitOfWork.OrderItems.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }


        private async Task<bool> OrderItemExists(int id)
        {

            var orderItem = await _unitOfWork.OrderItems.Get(q => q.Id == id);
            return orderItem != null;
        }
    }
}
