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
    //controller for swap products
    [Route("api/[controller]")]
    [ApiController]
    public class SwapsController : ControllerBase
    {

        private readonly IUnitOfWork _unitOfWork;
        public SwapsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;

        }



        // GET: api/Swaps
        [HttpGet]
        public async Task<IActionResult> GetSwaps()
        {
            var swaps = await _unitOfWork.Swaps.GetAll();
            return Ok(swaps);
        }



        // GET: api/Swaps/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetSwap(int id)
        {
            var swap = await _unitOfWork.Swaps.Get(q => q.Id == id);

            if (swap == null)
            {
                return NotFound();
            }

            return Ok(swap);
        }

        // PUT: api/Swaps/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSwap(int id, Swap swap)
        {
            if (id != swap.Id)
            {
                return BadRequest();
            }


            _unitOfWork.Swaps.Update(swap);
            try
            {

                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {

                if (!await SwapExists(id))
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

        // POST: api/Swaps

        [HttpPost]
        public async Task<ActionResult<Swap>> PostSwap(Swap swap)
        {

            await _unitOfWork.Swaps.Insert(swap);
            await _unitOfWork.Save(HttpContext);
            return CreatedAtAction("GetSwap", new { id = swap.Id }, swap);
        }


        // DELETE: api/Swaps/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSwap(int id)
        {
            var swap = await _unitOfWork.Swaps.Get(q => q.Id == id);
            if (swap == null)
            {
                return NotFound();
            }


            await _unitOfWork.Swaps.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }


        private async Task<bool> SwapExists(int id)
        {

            var swap = await _unitOfWork.Swaps.Get(q => q.Id == id);
            return swap != null;
        }
    }
}
