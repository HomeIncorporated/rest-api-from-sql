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
    [Route("api/Sales/SalesOrderHeader_inmem")]
    [ApiController]
    public class Sales_SalesOrderHeader_inmemController : ControllerBase
    {
        private readonly ApplicationDbContext _db;

        public Sales_SalesOrderHeader_inmemController(ApplicationDbContext db)
        {
            _db = db;
        }

		[HttpGet]
        [Route("", Name = "List_Sales_SalesOrderHeader_inmem")]
        public async Task<ActionResult<IEnumerable<Sales.SalesOrderHeader_inmem>>> ListSalesOrderHeader_inmem(int pageIndex, int pageSize)
        {
            return await _db.Sales_SalesOrderHeader_inmem.OrderBy(x => x.SalesOrderID).Skip((pageIndex - 1) * pageSize).Take(pageSize).ToListAsync();
        }

		[HttpGet]
        [Route("{salesOrderID}", Name = "GetById_Sales_SalesOrderHeader_inmem")]
        public async Task<ActionResult<Sales.SalesOrderHeader_inmem>> GetSalesOrderHeader_inmem(int salesOrderID)
        {
            var result = await _db.Sales_SalesOrderHeader_inmem.FirstOrDefaultAsync(x => x.SalesOrderID == salesOrderID);
            if (result == null)
            {
                return NotFound();
            }
            return result;
        }

		[HttpPost]
        [Route("", Name = "Create_Sales_SalesOrderHeader_inmem")]
        public async Task<IActionResult> CreateSalesOrderHeader_inmem([FromBody] Sales.SalesOrderHeader_inmem value)
        {
            _db.Sales_SalesOrderHeader_inmem.Add(value);
            await _db.SaveChangesAsync();
            return Ok(value);
        }

		[HttpPut("{salesOrderID}", Name = "Edit_Sales_SalesOrderHeader_inmem")]
        public async Task<IActionResult> EditSalesOrderHeader_inmem(int salesOrderID, [FromBody] Sales.SalesOrderHeader_inmem value)
        {
            var existing = await _db.Sales_SalesOrderHeader_inmem.FirstOrDefaultAsync(x => x.SalesOrderID == salesOrderID);
            if (existing == null)
            {
                return NotFound();
            }

			existing.SalesOrderID = value.SalesOrderID;
			existing.RevisionNumber = value.RevisionNumber;
			existing.OrderDate = value.OrderDate;
			existing.DueDate = value.DueDate;
			existing.ShipDate = value.ShipDate;
			existing.Status = value.Status;
			existing.OnlineOrderFlag = value.OnlineOrderFlag;
			existing.PurchaseOrderNumber = value.PurchaseOrderNumber;
			existing.AccountNumber = value.AccountNumber;
			existing.CustomerID = value.CustomerID;
			existing.SalesPersonID = value.SalesPersonID;
			existing.TerritoryID = value.TerritoryID;
			existing.BillToAddressID = value.BillToAddressID;
			existing.ShipToAddressID = value.ShipToAddressID;
			existing.ShipMethodID = value.ShipMethodID;
			existing.CreditCardID = value.CreditCardID;
			existing.CreditCardApprovalCode = value.CreditCardApprovalCode;
			existing.CurrencyRateID = value.CurrencyRateID;
			existing.SubTotal = value.SubTotal;
			existing.TaxAmt = value.TaxAmt;
			existing.Freight = value.Freight;
			existing.Comment = value.Comment;
			existing.ModifiedDate = value.ModifiedDate;

            _db.Sales_SalesOrderHeader_inmem.Update(existing);
            await _db.SaveChangesAsync();
            return NoContent();
        }

		[HttpDelete("", Name = "Delete_Sales_SalesOrderHeader_inmem")]
        public async Task<IActionResult> DeleteSalesOrderHeader_inmem(int salesOrderID)
        {
            var existing = await _db.Sales_SalesOrderHeader_inmem.FirstOrDefaultAsync(x => x.SalesOrderID == salesOrderID);
            if (existing == null)
            {
                return NotFound();
            }
            _db.Sales_SalesOrderHeader_inmem.Remove(existing);
            await _db.SaveChangesAsync();
            return NoContent();
        }

		// No GetByUniqueKeyActions generated

		// No EditByUniqueKeyActions generated

		// No DeleteByUniqueKeyActions generated

	}
}