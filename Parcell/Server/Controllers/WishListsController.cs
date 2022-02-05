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
    //controller for wishlists
    [Route("api/[controller]")]
    [ApiController]
    public class WishListsController : ControllerBase
    {

        private readonly IUnitOfWork _unitOfWork;
        public WishListsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;

        }



        // GET: api/WishLists
        [HttpGet]
        public async Task<IActionResult> GetWishLists()
        {
            var wishLists = await _unitOfWork.WishLists.GetAll();
            return Ok(wishLists);
        }



        // GET: api/WishLists/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetWishList(int id)
        {
            var wishList = await _unitOfWork.WishLists.Get(q => q.Id == id);

            if (wishList == null)
            {
                return NotFound();
            }

            return Ok(wishList);
        }

        // PUT: api/WishLists/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutWishList(int id, WishList wishList)
        {
            if (id != wishList.Id)
            {
                return BadRequest();
            }


            _unitOfWork.WishLists.Update(wishList);
            try
            {

                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {

                if (!await WishListExists(id))
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

        // POST: api/WishLists

        [HttpPost]
        public async Task<ActionResult<WishList>> PostWishList(WishList wishList)
        {

            await _unitOfWork.WishLists.Insert(wishList);
            await _unitOfWork.Save(HttpContext);
            //customised API for returning location of wishlist that was just created
            return CreatedAtAction(nameof(GetWishList), new { id = wishList.Id }, wishList);
        }


        // DELETE: api/WishLists/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteWishList(int id)
        {
            var wishList = await _unitOfWork.WishLists.Get(q => q.Id == id);
            if (wishList == null)
            {
                return NotFound();
            }


            await _unitOfWork.WishLists.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }


        private async Task<bool> WishListExists(int id)
        {

            var wishList = await _unitOfWork.WishLists.Get(q => q.Id == id);
            return wishList != null;
        }
    }
}
