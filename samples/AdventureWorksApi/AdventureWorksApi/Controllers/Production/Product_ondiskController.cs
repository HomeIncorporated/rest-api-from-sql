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
    [Route("api/Production/Product_ondisk")]
    [ApiController]
    public class Production_Product_ondiskController : ControllerBase
    {
        private readonly ApplicationDbContext _db;

        public Production_Product_ondiskController(ApplicationDbContext db)
        {
            _db = db;
        }

		[HttpGet]
        [Route("", Name = "List_Production_Product_ondisk")]
        public async Task<ActionResult<IEnumerable<Production.Product_ondisk>>> ListProduct_ondisk(int pageIndex, int pageSize)
        {
            return await _db.Production_Product_ondisk.OrderBy(x => x.ProductID).Skip((pageIndex - 1) * pageSize).Take(pageSize).ToListAsync();
        }

		[HttpGet]
        [Route("{productID}", Name = "GetById_Production_Product_ondisk")]
        public async Task<ActionResult<Production.Product_ondisk>> GetProduct_ondisk(int productID)
        {
            var result = await _db.Production_Product_ondisk.FirstOrDefaultAsync(x => x.ProductID == productID);
            if (result == null)
            {
                return NotFound();
            }
            return result;
        }

		[HttpPost]
        [Route("", Name = "Create_Production_Product_ondisk")]
        public async Task<IActionResult> CreateProduct_ondisk([FromBody] Production.Product_ondisk value)
        {
            _db.Production_Product_ondisk.Add(value);
            await _db.SaveChangesAsync();
            return Ok(value);
        }

		[HttpPut("{productID}", Name = "Edit_Production_Product_ondisk")]
        public async Task<IActionResult> EditProduct_ondisk(int productID, [FromBody] Production.Product_ondisk value)
        {
            var existing = await _db.Production_Product_ondisk.FirstOrDefaultAsync(x => x.ProductID == productID);
            if (existing == null)
            {
                return NotFound();
            }

			existing.ProductID = value.ProductID;
			existing.Name = value.Name;
			existing.ProductNumber = value.ProductNumber;
			existing.MakeFlag = value.MakeFlag;
			existing.FinishedGoodsFlag = value.FinishedGoodsFlag;
			existing.Color = value.Color;
			existing.SafetyStockLevel = value.SafetyStockLevel;
			existing.ReorderPoint = value.ReorderPoint;
			existing.StandardCost = value.StandardCost;
			existing.ListPrice = value.ListPrice;
			existing.Size = value.Size;
			existing.SizeUnitMeasureCode = value.SizeUnitMeasureCode;
			existing.WeightUnitMeasureCode = value.WeightUnitMeasureCode;
			existing.Weight = value.Weight;
			existing.DaysToManufacture = value.DaysToManufacture;
			existing.ProductLine = value.ProductLine;
			existing.Class = value.Class;
			existing.Style = value.Style;
			existing.ProductSubcategoryID = value.ProductSubcategoryID;
			existing.ProductModelID = value.ProductModelID;
			existing.SellStartDate = value.SellStartDate;
			existing.SellEndDate = value.SellEndDate;
			existing.DiscontinuedDate = value.DiscontinuedDate;
			existing.ModifiedDate = value.ModifiedDate;

            _db.Production_Product_ondisk.Update(existing);
            await _db.SaveChangesAsync();
            return NoContent();
        }

		[HttpDelete("", Name = "Delete_Production_Product_ondisk")]
        public async Task<IActionResult> DeleteProduct_ondisk(int productID)
        {
            var existing = await _db.Production_Product_ondisk.FirstOrDefaultAsync(x => x.ProductID == productID);
            if (existing == null)
            {
                return NotFound();
            }
            _db.Production_Product_ondisk.Remove(existing);
            await _db.SaveChangesAsync();
            return NoContent();
        }

		// No GetByUniqueKeyActions generated

		// No EditByUniqueKeyActions generated

		// No DeleteByUniqueKeyActions generated

	}
}