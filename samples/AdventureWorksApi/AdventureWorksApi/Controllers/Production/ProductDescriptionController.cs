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
    [Route("api/Production/ProductDescription")]
    [ApiController]
    public class Production_ProductDescriptionController : ControllerBase
    {
        private readonly ApplicationDbContext _db;

        public Production_ProductDescriptionController(ApplicationDbContext db)
        {
            _db = db;
        }

		[HttpGet]
        [Route("", Name = "List_Production_ProductDescription")]
        public async Task<ActionResult<IEnumerable<Production.ProductDescription>>> ListProductDescription(int pageIndex, int pageSize)
        {
            return await _db.Production_ProductDescription.OrderBy(x => x.ProductDescriptionID).Skip((pageIndex - 1) * pageSize).Take(pageSize).ToListAsync();
        }

		[HttpGet]
        [Route("{productDescriptionID}", Name = "GetById_Production_ProductDescription")]
        public async Task<ActionResult<Production.ProductDescription>> GetProductDescription(int productDescriptionID)
        {
            var result = await _db.Production_ProductDescription.FirstOrDefaultAsync(x => x.ProductDescriptionID == productDescriptionID);
            if (result == null)
            {
                return NotFound();
            }
            return result;
        }

		[HttpPost]
        [Route("", Name = "Create_Production_ProductDescription")]
        public async Task<IActionResult> CreateProductDescription([FromBody] Production.ProductDescription value)
        {
            _db.Production_ProductDescription.Add(value);
            await _db.SaveChangesAsync();
            return Ok(value);
        }

		[HttpPut("{productDescriptionID}", Name = "Edit_Production_ProductDescription")]
        public async Task<IActionResult> EditProductDescription(int productDescriptionID, [FromBody] Production.ProductDescription value)
        {
            var existing = await _db.Production_ProductDescription.FirstOrDefaultAsync(x => x.ProductDescriptionID == productDescriptionID);
            if (existing == null)
            {
                return NotFound();
            }

			existing.ProductDescriptionID = value.ProductDescriptionID;
			existing.Description = value.Description;
			existing.rowguid = value.rowguid;
			existing.ModifiedDate = value.ModifiedDate;

            _db.Production_ProductDescription.Update(existing);
            await _db.SaveChangesAsync();
            return NoContent();
        }

		[HttpDelete("", Name = "Delete_Production_ProductDescription")]
        public async Task<IActionResult> DeleteProductDescription(int productDescriptionID)
        {
            var existing = await _db.Production_ProductDescription.FirstOrDefaultAsync(x => x.ProductDescriptionID == productDescriptionID);
            if (existing == null)
            {
                return NotFound();
            }
            _db.Production_ProductDescription.Remove(existing);
            await _db.SaveChangesAsync();
            return NoContent();
        }

		// No GetByUniqueKeyActions generated

		// No EditByUniqueKeyActions generated

		// No DeleteByUniqueKeyActions generated

	}
}