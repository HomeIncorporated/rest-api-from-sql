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
    [Route("api/Person/ContactType")]
    [ApiController]
    public class Person_ContactTypeController : ControllerBase
    {
        private readonly ApplicationDbContext _db;

        public Person_ContactTypeController(ApplicationDbContext db)
        {
            _db = db;
        }

		[HttpGet]
        [Route("", Name = "List_Person_ContactType")]
        public async Task<ActionResult<IEnumerable<Person.ContactType>>> ListContactType(int pageIndex, int pageSize)
        {
            return await _db.Person_ContactType.OrderBy(x => x.ContactTypeID).Skip((pageIndex - 1) * pageSize).Take(pageSize).ToListAsync();
        }

		[HttpGet]
        [Route("{contactTypeID}", Name = "GetById_Person_ContactType")]
        public async Task<ActionResult<Person.ContactType>> GetContactType(int contactTypeID)
        {
            var result = await _db.Person_ContactType.FirstOrDefaultAsync(x => x.ContactTypeID == contactTypeID);
            if (result == null)
            {
                return NotFound();
            }
            return result;
        }

		[HttpPost]
        [Route("", Name = "Create_Person_ContactType")]
        public async Task<IActionResult> CreateContactType([FromBody] Person.ContactType value)
        {
            _db.Person_ContactType.Add(value);
            await _db.SaveChangesAsync();
            return Ok(value);
        }

		[HttpPut("{contactTypeID}", Name = "Edit_Person_ContactType")]
        public async Task<IActionResult> EditContactType(int contactTypeID, [FromBody] Person.ContactType value)
        {
            var existing = await _db.Person_ContactType.FirstOrDefaultAsync(x => x.ContactTypeID == contactTypeID);
            if (existing == null)
            {
                return NotFound();
            }

			existing.ContactTypeID = value.ContactTypeID;
			existing.Name = value.Name;
			existing.ModifiedDate = value.ModifiedDate;

            _db.Person_ContactType.Update(existing);
            await _db.SaveChangesAsync();
            return NoContent();
        }

		[HttpDelete("", Name = "Delete_Person_ContactType")]
        public async Task<IActionResult> DeleteContactType(int contactTypeID)
        {
            var existing = await _db.Person_ContactType.FirstOrDefaultAsync(x => x.ContactTypeID == contactTypeID);
            if (existing == null)
            {
                return NotFound();
            }
            _db.Person_ContactType.Remove(existing);
            await _db.SaveChangesAsync();
            return NoContent();
        }

		// No GetByUniqueKeyActions generated

		// No EditByUniqueKeyActions generated

		// No DeleteByUniqueKeyActions generated

	}
}