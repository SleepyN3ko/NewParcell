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
    //controller for balances
    [Route("api/[controller]")]
    [ApiController]
    public class BalancesController : ControllerBase
    {

        private readonly IUnitOfWork _unitOfWork;
        public BalancesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;

        }



        // GET: api/Balances
        [HttpGet]
        public async Task<IActionResult> GetBalances()
        {
            var balances = await _unitOfWork.Balances.GetAll();
            return Ok(balances);
        }



        // GET: api/Balances/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBalance(int id)
        {
            var balance = await _unitOfWork.Balances.Get(q => q.Id == id);

            if (balance == null)
            {
                return NotFound();
            }

            return Ok(balance);
        }

        // PUT: api/Balances/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBalance(int id, Balance balance)
        {
            if (id != balance.Id)
            {
                return BadRequest();
            }


            _unitOfWork.Balances.Update(balance);
            try
            {

                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {

                if (!await BalanceExists(id))
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

        // POST: api/Balances

        [HttpPost]
        public async Task<ActionResult<Balance>> PostBalance(Balance balance)
        {

            await _unitOfWork.Balances.Insert(balance);
            await _unitOfWork.Save(HttpContext);
            //customised API for returning location of balance that was just created
            return CreatedAtAction(nameof(GetBalance), new { id = balance.Id }, balance);
        }


        // DELETE: api/Balances/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBalance(int id)
        {
            var balance = await _unitOfWork.Balances.Get(q => q.Id == id);
            if (balance == null)
            {
                return NotFound();
            }


            await _unitOfWork.Balances.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }


        private async Task<bool> BalanceExists(int id)
        {

            var balance = await _unitOfWork.Balances.Get(q => q.Id == id);
            return balance != null;
        }
    }
}
