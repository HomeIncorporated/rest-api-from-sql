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
    [Route("api/HumanResources/Employee_Temporal")]
    [ApiController]
    public class HumanResources_Employee_TemporalController : ControllerBase
    {
        private readonly ApplicationDbContext _db;

        public HumanResources_Employee_TemporalController(ApplicationDbContext db)
        {
            _db = db;
        }

		[HttpGet]
        [Route("", Name = "List_HumanResources_Employee_Temporal")]
        public async Task<ActionResult<IEnumerable<HumanResources.Employee_Temporal>>> ListEmployee_Temporal(int pageIndex, int pageSize)
        {
            return await _db.HumanResources_Employee_Temporal.OrderBy(x => x.BusinessEntityID).Skip((pageIndex - 1) * pageSize).Take(pageSize).ToListAsync();
        }

		[HttpGet]
        [Route("{businessEntityID}", Name = "GetById_HumanResources_Employee_Temporal")]
        public async Task<ActionResult<HumanResources.Employee_Temporal>> GetEmployee_Temporal(int businessEntityID)
        {
            var result = await _db.HumanResources_Employee_Temporal.FirstOrDefaultAsync(x => x.BusinessEntityID == businessEntityID);
            if (result == null)
            {
                return NotFound();
            }
            return result;
        }

		[HttpPost]
        [Route("", Name = "Create_HumanResources_Employee_Temporal")]
        public async Task<IActionResult> CreateEmployee_Temporal([FromBody] HumanResources.Employee_Temporal value)
        {
            _db.HumanResources_Employee_Temporal.Add(value);
            await _db.SaveChangesAsync();
            return Ok(value);
        }

		[HttpPut("{businessEntityID}", Name = "Edit_HumanResources_Employee_Temporal")]
        public async Task<IActionResult> EditEmployee_Temporal(int businessEntityID, [FromBody] HumanResources.Employee_Temporal value)
        {
            var existing = await _db.HumanResources_Employee_Temporal.FirstOrDefaultAsync(x => x.BusinessEntityID == businessEntityID);
            if (existing == null)
            {
                return NotFound();
            }

			existing.BusinessEntityID = value.BusinessEntityID;
			existing.NationalIDNumber = value.NationalIDNumber;
			existing.LoginID = value.LoginID;
			existing.OrganizationNode = value.OrganizationNode;
			existing.OrganizationLevel = value.OrganizationLevel;
			existing.JobTitle = value.JobTitle;
			existing.BirthDate = value.BirthDate;
			existing.MaritalStatus = value.MaritalStatus;
			existing.Gender = value.Gender;
			existing.HireDate = value.HireDate;
			existing.VacationHours = value.VacationHours;
			existing.SickLeaveHours = value.SickLeaveHours;
			existing.ValidFrom = value.ValidFrom;
			existing.ValidTo = value.ValidTo;

            _db.HumanResources_Employee_Temporal.Update(existing);
            await _db.SaveChangesAsync();
            return NoContent();
        }

		[HttpDelete("", Name = "Delete_HumanResources_Employee_Temporal")]
        public async Task<IActionResult> DeleteEmployee_Temporal(int businessEntityID)
        {
            var existing = await _db.HumanResources_Employee_Temporal.FirstOrDefaultAsync(x => x.BusinessEntityID == businessEntityID);
            if (existing == null)
            {
                return NotFound();
            }
            _db.HumanResources_Employee_Temporal.Remove(existing);
            await _db.SaveChangesAsync();
            return NoContent();
        }

		// No GetByUniqueKeyActions generated

		// No EditByUniqueKeyActions generated

		// No DeleteByUniqueKeyActions generated

	}
}