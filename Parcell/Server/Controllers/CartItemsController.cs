using System;
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
    [Route("api/[controller]")]
    [ApiController]
    public class CartItemsController : ControllerBase
    {

        private readonly IUnitOfWork _unitOfWork;
        public CartItemsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;

        }



        // GET: api/CartItems
        [HttpGet]
        public async Task<IActionResult> GetCartItems()
        {
            var cartItems = await _unitOfWork.CartItems.GetAll();
            return Ok(cartItems);
        }



        // GET: api/CartItems/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCartItem(int id)
        {
            var cartItem = await _unitOfWork.CartItems.Get(q => q.Id == id);

            if (cartItem == null)
            {
                return NotFound();
            }

            return Ok(cartItem);
        }

        // PUT: api/CartItems/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCartItem(int id, CartItem cartItem)
        {
            if (id != cartItem.Id)
            {
                return BadRequest();
            }


            _unitOfWork.CartItems.Update(cartItem);
            try
            {

                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {

                if (!await CartItemExists(id))
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

        // POST: api/CartItems

        [HttpPost]
        public async Task<ActionResult<CartItem>> PostCartItem(CartItem cartItem)
        {

            await _unitOfWork.CartItems.Insert(cartItem);
            await _unitOfWork.Save(HttpContext);
            return CreatedAtAction("GetCartItem", new { id = cartItem.Id }, cartItem);
        }


        // DELETE: api/CartItems/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCartItem(int id)
        {
            var cartItem = await _unitOfWork.CartItems.Get(q => q.Id == id);
            if (cartItem == null)
            {
                return NotFound();
            }


            await _unitOfWork.CartItems.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }


        private async Task<bool> CartItemExists(int id)
        {

            var cartItem = await _unitOfWork.CartItems.Get(q => q.Id == id);
            return cartItem != null;
        }
    }
}
