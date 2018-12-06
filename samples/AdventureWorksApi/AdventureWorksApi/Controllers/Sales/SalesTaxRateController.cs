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
    [Route("api/Sales/SalesTaxRate")]
    [ApiController]
    public class Sales_SalesTaxRateController : ControllerBase
    {
        private readonly ApplicationDbContext _db;

        public Sales_SalesTaxRateController(ApplicationDbContext db)
        {
            _db = db;
        }

		[HttpGet]
        [Route("", Name = "List_Sales_SalesTaxRate")]
        public async Task<ActionResult<IEnumerable<Sales.SalesTaxRate>>> ListSalesTaxRate(int pageIndex, int pageSize)
        {
            return await _db.Sales_SalesTaxRate.OrderBy(x => x.SalesTaxRateID).Skip((pageIndex - 1) * pageSize).Take(pageSize).ToListAsync();
        }

		[HttpGet]
        [Route("{salesTaxRateID}", Name = "GetById_Sales_SalesTaxRate")]
        public async Task<ActionResult<Sales.SalesTaxRate>> GetSalesTaxRate(int salesTaxRateID)
        {
            var result = await _db.Sales_SalesTaxRate.FirstOrDefaultAsync(x => x.SalesTaxRateID == salesTaxRateID);
            if (result == null)
            {
                return NotFound();
            }
            return result;
        }

		[HttpPost]
        [Route("", Name = "Create_Sales_SalesTaxRate")]
        public async Task<IActionResult> CreateSalesTaxRate([FromBody] Sales.SalesTaxRate value)
        {
            _db.Sales_SalesTaxRate.Add(value);
            await _db.SaveChangesAsync();
            return Ok(value);
        }

		[HttpPut("{salesTaxRateID}", Name = "Edit_Sales_SalesTaxRate")]
        public async Task<IActionResult> EditSalesTaxRate(int salesTaxRateID, [FromBody] Sales.SalesTaxRate value)
        {
            var existing = await _db.Sales_SalesTaxRate.FirstOrDefaultAsync(x => x.SalesTaxRateID == salesTaxRateID);
            if (existing == null)
            {
                return NotFound();
            }

			existing.SalesTaxRateID = value.SalesTaxRateID;
			existing.StateProvinceID = value.StateProvinceID;
			existing.TaxType = value.TaxType;
			existing.TaxRate = value.TaxRate;
			existing.Name = value.Name;
			existing.rowguid = value.rowguid;
			existing.ModifiedDate = value.ModifiedDate;

            _db.Sales_SalesTaxRate.Update(existing);
            await _db.SaveChangesAsync();
            return NoContent();
        }

		[HttpDelete("", Name = "Delete_Sales_SalesTaxRate")]
        public async Task<IActionResult> DeleteSalesTaxRate(int salesTaxRateID)
        {
            var existing = await _db.Sales_SalesTaxRate.FirstOrDefaultAsync(x => x.SalesTaxRateID == salesTaxRateID);
            if (existing == null)
            {
                return NotFound();
            }
            _db.Sales_SalesTaxRate.Remove(existing);
            await _db.SaveChangesAsync();
            return NoContent();
        }

		// No GetByUniqueKeyActions generated

		// No EditByUniqueKeyActions generated

		// No DeleteByUniqueKeyActions generated

	}
}