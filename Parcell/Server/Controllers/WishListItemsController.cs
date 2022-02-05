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
    //controller for wishlistitems which are the items inside every user's wishlist
    [Route("api/[controller]")]
    [ApiController]
    public class WishListItemsController : ControllerBase
    {

        private readonly IUnitOfWork _unitOfWork;
        public WishListItemsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;

        }



        // GET: api/WishListItems
        [HttpGet]
        public async Task<IActionResult> GetWishListItems()
        {
            var wishListItems = await _unitOfWork.WishListItems.GetAll();
            return Ok(wishListItems);
        }



        // GET: api/WishListItems/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetWishListItem(int id)
        {
            var wishListItem = await _unitOfWork.WishListItems.Get(q => q.Id == id);

            if (wishListItem == null)
            {
                return NotFound();
            }

            return Ok(wishListItem);
        }

        // PUT: api/WishListItems/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutWishListItem(int id, WishListItem wishListItem)
        {
            if (id != wishListItem.Id)
            {
                return BadRequest();
            }


            _unitOfWork.WishListItems.Update(wishListItem);
            try
            {

                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {

                if (!await WishListItemExists(id))
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

        // POST: api/WishListItems

        [HttpPost]
        public async Task<ActionResult<WishListItem>> PostWishListItem(WishListItem wishListItem)
        {

            await _unitOfWork.WishListItems.Insert(wishListItem);
            await _unitOfWork.Save(HttpContext);
            return CreatedAtAction("GetWishListItem", new { id = wishListItem.Id }, wishListItem);
        }


        // DELETE: api/WishListItems/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteWishListItem(int id)
        {
            var wishListItem = await _unitOfWork.WishListItems.Get(q => q.Id == id);
            if (wishListItem == null)
            {
                return NotFound();
            }


            await _unitOfWork.WishListItems.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }


        private async Task<bool> WishListItemExists(int id)
        {

            var wishListItem = await _unitOfWork.WishListItems.Get(q => q.Id == id);
            return wishListItem != null;
        }
    }
}
