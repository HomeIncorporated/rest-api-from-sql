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
    [Route("api/HumanResources/EmployeePayHistory")]
    [ApiController]
    public class HumanResources_EmployeePayHistoryController : ControllerBase
    {
        private readonly ApplicationDbContext _db;

        public HumanResources_EmployeePayHistoryController(ApplicationDbContext db)
        {
            _db = db;
        }

		[HttpGet]
        [Route("", Name = "List_HumanResources_EmployeePayHistory")]
        public async Task<ActionResult<IEnumerable<HumanResources.EmployeePayHistory>>> ListEmployeePayHistory(int pageIndex, int pageSize)
        {
            return await _db.HumanResources_EmployeePayHistory.OrderBy(x => x.BusinessEntityID).ThenBy(x => x.RateChangeDate).Skip((pageIndex - 1) * pageSize).Take(pageSize).ToListAsync();
        }

		[HttpGet]
        [Route("businessEntityID/{businessEntityID}/rateChangeDate/{rateChangeDate}", Name = "GetById_HumanResources_EmployeePayHistory")]
        public async Task<ActionResult<HumanResources.EmployeePayHistory>> GetEmployeePayHistory(int businessEntityID, DateTime rateChangeDate)
        {
            var result = await _db.HumanResources_EmployeePayHistory.FirstOrDefaultAsync(x => x.BusinessEntityID == businessEntityID && x.RateChangeDate == rateChangeDate);
            if (result == null)
            {
                return NotFound();
            }
            return result;
        }

		[HttpPost]
        [Route("", Name = "Create_HumanResources_EmployeePayHistory")]
        public async Task<IActionResult> CreateEmployeePayHistory([FromBody] HumanResources.EmployeePayHistory value)
        {
            _db.HumanResources_EmployeePayHistory.Add(value);
            await _db.SaveChangesAsync();
            return Ok(value);
        }

		[HttpPut("businessEntityID/{businessEntityID}/rateChangeDate/{rateChangeDate}", Name = "Edit_HumanResources_EmployeePayHistory")]
        public async Task<IActionResult> EditEmployeePayHistory(int businessEntityID, DateTime rateChangeDate, [FromBody] HumanResources.EmployeePayHistory value)
        {
            var existing = await _db.HumanResources_EmployeePayHistory.FirstOrDefaultAsync(x => x.BusinessEntityID == businessEntityID && x.RateChangeDate == rateChangeDate);
            if (existing == null)
            {
                return NotFound();
            }

			existing.BusinessEntityID = value.BusinessEntityID;
			existing.RateChangeDate = value.RateChangeDate;
			existing.Rate = value.Rate;
			existing.PayFrequency = value.PayFrequency;
			existing.ModifiedDate = value.ModifiedDate;

            _db.HumanResources_EmployeePayHistory.Update(existing);
            await _db.SaveChangesAsync();
            return NoContent();
        }

		[HttpDelete("", Name = "Delete_HumanResources_EmployeePayHistory")]
        public async Task<IActionResult> DeleteEmployeePayHistory(int businessEntityID, DateTime rateChangeDate)
        {
            var existing = await _db.HumanResources_EmployeePayHistory.FirstOrDefaultAsync(x => x.BusinessEntityID == businessEntityID && x.RateChangeDate == rateChangeDate);
            if (existing == null)
            {
                return NotFound();
            }
            _db.HumanResources_EmployeePayHistory.Remove(existing);
            await _db.SaveChangesAsync();
            return NoContent();
        }

		// No GetByUniqueKeyActions generated

		// No EditByUniqueKeyActions generated

		// No DeleteByUniqueKeyActions generated

	}
}