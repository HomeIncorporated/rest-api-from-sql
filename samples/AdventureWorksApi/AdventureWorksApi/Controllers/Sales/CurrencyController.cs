// DISCLAIMER
// This file contains auto generated code.
// Changes to this file may be overwritten when the files are regenerated.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AutoGeneratedApi.Controllers
{
    [Route("api/Sales/Currency")]
    [ApiController]
    public class Sales_CurrencyController : ControllerBase
    {
        private readonly ApplicationDbContext _db;

        public Sales_CurrencyController(ApplicationDbContext db)
        {
            _db = db;
        }

		[HttpGet]
        [Route("", Name = "List_Sales_Currency")]
        public async Task<ActionResult<IEnumerable<Sales.Currency>>> ListCurrency(int pageIndex, int pageSize)
        {
            return await _db.Sales_Currency.OrderBy(x => x.CurrencyCode).Skip((pageIndex - 1) * pageSize).Take(pageSize).ToListAsync();
        }

		[HttpGet]
        [Route("{currencyCode}", Name = "GetById_Sales_Currency")]
        public async Task<ActionResult<Sales.Currency>> GetCurrency(string currencyCode)
        {
            var result = await _db.Sales_Currency.FirstOrDefaultAsync(x => x.CurrencyCode == currencyCode);
            if (result == null)
            {
                return NotFound();
            }
            return result;
        }

		[HttpPost]
        [Route("", Name = "Create_Sales_Currency")]
        public async Task<IActionResult> CreateCurrency([FromBody] Sales.Currency value)
        {
            _db.Sales_Currency.Add(value);
            await _db.SaveChangesAsync();
            return Ok(value);
        }

		[HttpPut("{currencyCode}", Name = "Edit_Sales_Currency")]
        public async Task<IActionResult> EditCurrency(string currencyCode, [FromBody] Sales.Currency value)
        {
            var existing = await _db.Sales_Currency.FirstOrDefaultAsync(x => x.CurrencyCode == currencyCode);
            if (existing == null)
            {
                return NotFound();
            }

			existing.CurrencyCode = value.CurrencyCode;
			existing.Name = value.Name;
			existing.ModifiedDate = value.ModifiedDate;

            _db.Sales_Currency.Update(existing);
            await _db.SaveChangesAsync();
            return NoContent();
        }

		[HttpDelete("", Name = "Delete_Sales_Currency")]
        public async Task<IActionResult> DeleteCurrency(string currencyCode)
        {
            var existing = await _db.Sales_Currency.FirstOrDefaultAsync(x => x.CurrencyCode == currencyCode);
            if (existing == null)
            {
                return NotFound();
            }
            _db.Sales_Currency.Remove(existing);
            await _db.SaveChangesAsync();
            return NoContent();
        }

		// No GetByUniqueKeyActions generated

		// No EditByUniqueKeyActions generated

		// No DeleteByUniqueKeyActions generated

	}
}