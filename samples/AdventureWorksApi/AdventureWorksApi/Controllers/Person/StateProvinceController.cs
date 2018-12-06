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
    [Route("api/Person/StateProvince")]
    [ApiController]
    public class Person_StateProvinceController : ControllerBase
    {
        private readonly ApplicationDbContext _db;

        public Person_StateProvinceController(ApplicationDbContext db)
        {
            _db = db;
        }

		[HttpGet]
        [Route("", Name = "List_Person_StateProvince")]
        public async Task<ActionResult<IEnumerable<Person.StateProvince>>> ListStateProvince(int pageIndex, int pageSize)
        {
            return await _db.Person_StateProvince.OrderBy(x => x.StateProvinceID).Skip((pageIndex - 1) * pageSize).Take(pageSize).ToListAsync();
        }

		[HttpGet]
        [Route("{stateProvinceID}", Name = "GetById_Person_StateProvince")]
        public async Task<ActionResult<Person.StateProvince>> GetStateProvince(int stateProvinceID)
        {
            var result = await _db.Person_StateProvince.FirstOrDefaultAsync(x => x.StateProvinceID == stateProvinceID);
            if (result == null)
            {
                return NotFound();
            }
            return result;
        }

		[HttpPost]
        [Route("", Name = "Create_Person_StateProvince")]
        public async Task<IActionResult> CreateStateProvince([FromBody] Person.StateProvince value)
        {
            _db.Person_StateProvince.Add(value);
            await _db.SaveChangesAsync();
            return Ok(value);
        }

		[HttpPut("{stateProvinceID}", Name = "Edit_Person_StateProvince")]
        public async Task<IActionResult> EditStateProvince(int stateProvinceID, [FromBody] Person.StateProvince value)
        {
            var existing = await _db.Person_StateProvince.FirstOrDefaultAsync(x => x.StateProvinceID == stateProvinceID);
            if (existing == null)
            {
                return NotFound();
            }

			existing.StateProvinceID = value.StateProvinceID;
			existing.StateProvinceCode = value.StateProvinceCode;
			existing.CountryRegionCode = value.CountryRegionCode;
			existing.IsOnlyStateProvinceFlag = value.IsOnlyStateProvinceFlag;
			existing.Name = value.Name;
			existing.TerritoryID = value.TerritoryID;
			existing.rowguid = value.rowguid;
			existing.ModifiedDate = value.ModifiedDate;

            _db.Person_StateProvince.Update(existing);
            await _db.SaveChangesAsync();
            return NoContent();
        }

		[HttpDelete("", Name = "Delete_Person_StateProvince")]
        public async Task<IActionResult> DeleteStateProvince(int stateProvinceID)
        {
            var existing = await _db.Person_StateProvince.FirstOrDefaultAsync(x => x.StateProvinceID == stateProvinceID);
            if (existing == null)
            {
                return NotFound();
            }
            _db.Person_StateProvince.Remove(existing);
            await _db.SaveChangesAsync();
            return NoContent();
        }

		// No GetByUniqueKeyActions generated

		// No EditByUniqueKeyActions generated

		// No DeleteByUniqueKeyActions generated

	}
}