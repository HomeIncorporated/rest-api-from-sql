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
    [Route("api/Person/Person_Temporal")]
    [ApiController]
    public class Person_Person_TemporalController : ControllerBase
    {
        private readonly ApplicationDbContext _db;

        public Person_Person_TemporalController(ApplicationDbContext db)
        {
            _db = db;
        }

		[HttpGet]
        [Route("", Name = "List_Person_Person_Temporal")]
        public async Task<ActionResult<IEnumerable<Person.Person_Temporal>>> ListPerson_Temporal(int pageIndex, int pageSize)
        {
            return await _db.Person_Person_Temporal.OrderBy(x => x.BusinessEntityID).Skip((pageIndex - 1) * pageSize).Take(pageSize).ToListAsync();
        }

		[HttpGet]
        [Route("{businessEntityID}", Name = "GetById_Person_Person_Temporal")]
        public async Task<ActionResult<Person.Person_Temporal>> GetPerson_Temporal(int businessEntityID)
        {
            var result = await _db.Person_Person_Temporal.FirstOrDefaultAsync(x => x.BusinessEntityID == businessEntityID);
            if (result == null)
            {
                return NotFound();
            }
            return result;
        }

		[HttpPost]
        [Route("", Name = "Create_Person_Person_Temporal")]
        public async Task<IActionResult> CreatePerson_Temporal([FromBody] Person.Person_Temporal value)
        {
            _db.Person_Person_Temporal.Add(value);
            await _db.SaveChangesAsync();
            return Ok(value);
        }

		[HttpPut("{businessEntityID}", Name = "Edit_Person_Person_Temporal")]
        public async Task<IActionResult> EditPerson_Temporal(int businessEntityID, [FromBody] Person.Person_Temporal value)
        {
            var existing = await _db.Person_Person_Temporal.FirstOrDefaultAsync(x => x.BusinessEntityID == businessEntityID);
            if (existing == null)
            {
                return NotFound();
            }

			existing.BusinessEntityID = value.BusinessEntityID;
			existing.PersonType = value.PersonType;
			existing.NameStyle = value.NameStyle;
			existing.Title = value.Title;
			existing.FirstName = value.FirstName;
			existing.MiddleName = value.MiddleName;
			existing.LastName = value.LastName;
			existing.Suffix = value.Suffix;
			existing.EmailPromotion = value.EmailPromotion;
			existing.ValidFrom = value.ValidFrom;
			existing.ValidTo = value.ValidTo;

            _db.Person_Person_Temporal.Update(existing);
            await _db.SaveChangesAsync();
            return NoContent();
        }

		[HttpDelete("", Name = "Delete_Person_Person_Temporal")]
        public async Task<IActionResult> DeletePerson_Temporal(int businessEntityID)
        {
            var existing = await _db.Person_Person_Temporal.FirstOrDefaultAsync(x => x.BusinessEntityID == businessEntityID);
            if (existing == null)
            {
                return NotFound();
            }
            _db.Person_Person_Temporal.Remove(existing);
            await _db.SaveChangesAsync();
            return NoContent();
        }

		// No GetByUniqueKeyActions generated

		// No EditByUniqueKeyActions generated

		// No DeleteByUniqueKeyActions generated

	}
}