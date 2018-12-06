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
    [Route("api/Person/CountryRegion")]
    [ApiController]
    public class Person_CountryRegionController : ControllerBase
    {
        private readonly ApplicationDbContext _db;

        public Person_CountryRegionController(ApplicationDbContext db)
        {
            _db = db;
        }

		[HttpGet]
        [Route("", Name = "List_Person_CountryRegion")]
        public async Task<ActionResult<IEnumerable<Person.CountryRegion>>> ListCountryRegion(int pageIndex, int pageSize)
        {
            return await _db.Person_CountryRegion.OrderBy(x => x.CountryRegionCode).Skip((pageIndex - 1) * pageSize).Take(pageSize).ToListAsync();
        }

		[HttpGet]
        [Route("{countryRegionCode}", Name = "GetById_Person_CountryRegion")]
        public async Task<ActionResult<Person.CountryRegion>> GetCountryRegion(string countryRegionCode)
        {
            var result = await _db.Person_CountryRegion.FirstOrDefaultAsync(x => x.CountryRegionCode == countryRegionCode);
            if (result == null)
            {
                return NotFound();
            }
            return result;
        }

		[HttpPost]
        [Route("", Name = "Create_Person_CountryRegion")]
        public async Task<IActionResult> CreateCountryRegion([FromBody] Person.CountryRegion value)
        {
            _db.Person_CountryRegion.Add(value);
            await _db.SaveChangesAsync();
            return Ok(value);
        }

		[HttpPut("{countryRegionCode}", Name = "Edit_Person_CountryRegion")]
        public async Task<IActionResult> EditCountryRegion(string countryRegionCode, [FromBody] Person.CountryRegion value)
        {
            var existing = await _db.Person_CountryRegion.FirstOrDefaultAsync(x => x.CountryRegionCode == countryRegionCode);
            if (existing == null)
            {
                return NotFound();
            }

			existing.CountryRegionCode = value.CountryRegionCode;
			existing.Name = value.Name;
			existing.ModifiedDate = value.ModifiedDate;

            _db.Person_CountryRegion.Update(existing);
            await _db.SaveChangesAsync();
            return NoContent();
        }

		[HttpDelete("", Name = "Delete_Person_CountryRegion")]
        public async Task<IActionResult> DeleteCountryRegion(string countryRegionCode)
        {
            var existing = await _db.Person_CountryRegion.FirstOrDefaultAsync(x => x.CountryRegionCode == countryRegionCode);
            if (existing == null)
            {
                return NotFound();
            }
            _db.Person_CountryRegion.Remove(existing);
            await _db.SaveChangesAsync();
            return NoContent();
        }

		// No GetByUniqueKeyActions generated

		// No EditByUniqueKeyActions generated

		// No DeleteByUniqueKeyActions generated

	}
}