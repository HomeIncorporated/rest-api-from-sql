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
    [Route("api/Production/ProductProductPhoto")]
    [ApiController]
    public class Production_ProductProductPhotoController : ControllerBase
    {
        private readonly ApplicationDbContext _db;

        public Production_ProductProductPhotoController(ApplicationDbContext db)
        {
            _db = db;
        }

		[HttpGet]
        [Route("", Name = "List_Production_ProductProductPhoto")]
        public async Task<ActionResult<IEnumerable<Production.ProductProductPhoto>>> ListProductProductPhoto(int pageIndex, int pageSize)
        {
            return await _db.Production_ProductProductPhoto.OrderBy(x => x.ProductID).ThenBy(x => x.ProductPhotoID).Skip((pageIndex - 1) * pageSize).Take(pageSize).ToListAsync();
        }

		[HttpGet]
        [Route("productID/{productID}/productPhotoID/{productPhotoID}", Name = "GetById_Production_ProductProductPhoto")]
        public async Task<ActionResult<Production.ProductProductPhoto>> GetProductProductPhoto(int productID, int productPhotoID)
        {
            var result = await _db.Production_ProductProductPhoto.FirstOrDefaultAsync(x => x.ProductID == productID && x.ProductPhotoID == productPhotoID);
            if (result == null)
            {
                return NotFound();
            }
            return result;
        }

		[HttpPost]
        [Route("", Name = "Create_Production_ProductProductPhoto")]
        public async Task<IActionResult> CreateProductProductPhoto([FromBody] Production.ProductProductPhoto value)
        {
            _db.Production_ProductProductPhoto.Add(value);
            await _db.SaveChangesAsync();
            return Ok(value);
        }

		[HttpPut("productID/{productID}/productPhotoID/{productPhotoID}", Name = "Edit_Production_ProductProductPhoto")]
        public async Task<IActionResult> EditProductProductPhoto(int productID, int productPhotoID, [FromBody] Production.ProductProductPhoto value)
        {
            var existing = await _db.Production_ProductProductPhoto.FirstOrDefaultAsync(x => x.ProductID == productID && x.ProductPhotoID == productPhotoID);
            if (existing == null)
            {
                return NotFound();
            }

			existing.ProductID = value.ProductID;
			existing.ProductPhotoID = value.ProductPhotoID;
			existing.Primary = value.Primary;
			existing.ModifiedDate = value.ModifiedDate;

            _db.Production_ProductProductPhoto.Update(existing);
            await _db.SaveChangesAsync();
            return NoContent();
        }

		[HttpDelete("", Name = "Delete_Production_ProductProductPhoto")]
        public async Task<IActionResult> DeleteProductProductPhoto(int productID, int productPhotoID)
        {
            var existing = await _db.Production_ProductProductPhoto.FirstOrDefaultAsync(x => x.ProductID == productID && x.ProductPhotoID == productPhotoID);
            if (existing == null)
            {
                return NotFound();
            }
            _db.Production_ProductProductPhoto.Remove(existing);
            await _db.SaveChangesAsync();
            return NoContent();
        }

		// No GetByUniqueKeyActions generated

		// No EditByUniqueKeyActions generated

		// No DeleteByUniqueKeyActions generated

	}
}