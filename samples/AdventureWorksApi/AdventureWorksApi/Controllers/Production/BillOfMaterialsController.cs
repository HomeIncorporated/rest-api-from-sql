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
    [Route("api/Production/BillOfMaterials")]
    [ApiController]
    public class Production_BillOfMaterialsController : ControllerBase
    {
        private readonly ApplicationDbContext _db;

        public Production_BillOfMaterialsController(ApplicationDbContext db)
        {
            _db = db;
        }

		[HttpGet]
        [Route("", Name = "List_Production_BillOfMaterials")]
        public async Task<ActionResult<IEnumerable<Production.BillOfMaterials>>> ListBillOfMaterials(int pageIndex, int pageSize)
        {
            return await _db.Production_BillOfMaterials.OrderBy(x => x.BillOfMaterialsID).Skip((pageIndex - 1) * pageSize).Take(pageSize).ToListAsync();
        }

		[HttpGet]
        [Route("{billOfMaterialsID}", Name = "GetById_Production_BillOfMaterials")]
        public async Task<ActionResult<Production.BillOfMaterials>> GetBillOfMaterials(int billOfMaterialsID)
        {
            var result = await _db.Production_BillOfMaterials.FirstOrDefaultAsync(x => x.BillOfMaterialsID == billOfMaterialsID);
            if (result == null)
            {
                return NotFound();
            }
            return result;
        }

		[HttpPost]
        [Route("", Name = "Create_Production_BillOfMaterials")]
        public async Task<IActionResult> CreateBillOfMaterials([FromBody] Production.BillOfMaterials value)
        {
            _db.Production_BillOfMaterials.Add(value);
            await _db.SaveChangesAsync();
            return Ok(value);
        }

		[HttpPut("{billOfMaterialsID}", Name = "Edit_Production_BillOfMaterials")]
        public async Task<IActionResult> EditBillOfMaterials(int billOfMaterialsID, [FromBody] Production.BillOfMaterials value)
        {
            var existing = await _db.Production_BillOfMaterials.FirstOrDefaultAsync(x => x.BillOfMaterialsID == billOfMaterialsID);
            if (existing == null)
            {
                return NotFound();
            }

			existing.BillOfMaterialsID = value.BillOfMaterialsID;
			existing.ProductAssemblyID = value.ProductAssemblyID;
			existing.ComponentID = value.ComponentID;
			existing.StartDate = value.StartDate;
			existing.EndDate = value.EndDate;
			existing.UnitMeasureCode = value.UnitMeasureCode;
			existing.BOMLevel = value.BOMLevel;
			existing.PerAssemblyQty = value.PerAssemblyQty;
			existing.ModifiedDate = value.ModifiedDate;

            _db.Production_BillOfMaterials.Update(existing);
            await _db.SaveChangesAsync();
            return NoContent();
        }

		[HttpDelete("", Name = "Delete_Production_BillOfMaterials")]
        public async Task<IActionResult> DeleteBillOfMaterials(int billOfMaterialsID)
        {
            var existing = await _db.Production_BillOfMaterials.FirstOrDefaultAsync(x => x.BillOfMaterialsID == billOfMaterialsID);
            if (existing == null)
            {
                return NotFound();
            }
            _db.Production_BillOfMaterials.Remove(existing);
            await _db.SaveChangesAsync();
            return NoContent();
        }

		// No GetByUniqueKeyActions generated

		// No EditByUniqueKeyActions generated

		// No DeleteByUniqueKeyActions generated

	}
}