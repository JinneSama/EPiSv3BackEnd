using EPiSv3NetworkFolder.Context;
using EPiSv3NetworkFolder.DataTransferModels.HRMIS;
using EPiSv3NetworkFolder.Helpers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EPiSv3NetworkFolder.Controllers
{
    [ApiController]
    [Route("api/HRMIS")]
    [Authorize]
    public class HRMISController : ControllerBase
    {
        private readonly HRMISContext context;
        private readonly IConfiguration configuration;

        public HRMISController(HRMISContext context, IConfiguration configuration)
        {
            this.context = context;
            this.configuration = configuration;
        }

        [HttpGet]
        [Route("employees")]
        public IActionResult GetEmployees()
        {
            var authHeader = Request.Headers["Authorization"].FirstOrDefault();
            if (string.IsNullOrEmpty(authHeader) || !authHeader.StartsWith("Bearer ")) return BadRequest("Token is Required!");

            var token = authHeader.Substring("Bearer ".Length).Trim();
            var principal = JwtHelper.ValidateToken(token, configuration);
            if (principal == null) return Unauthorized("Invalid or expired token.");

            var employees = context.Employees;
            var data = employees.Select(x => new HRMISEmployees
            {
                Id = x.FldEmpId,
                FirstName = x.FldFirstname,
                MiddleName = x.FldMiddleName,
                LastName = x.FldLastname,
                NameExt = x.FldNameExt,
                Detailed = x.Flddetailed,
                DetailedToOffice = x.FlddetailedTo,
                Office = x.FldOfficeId,
                DetailedToDivision = x.FlddetailedToDivision,
                Division = x.FldDivision,
                Position =  x.FldPosition,
                Username = x.FldUsername
            }).ToList();
            return Ok(data);
        }

        [HttpGet]
        [Route("office")]
        public IActionResult GetOffice()
        {
            var authHeader = Request.Headers["Authorization"].FirstOrDefault();
            if (string.IsNullOrEmpty(authHeader) || !authHeader.StartsWith("Bearer ")) return BadRequest("Token is Required!");

            var token = authHeader.Substring("Bearer ".Length).Trim();
            var principal = JwtHelper.ValidateToken(token, configuration);
            if (principal == null) return Unauthorized("Invalid or expired token.");

            var employees = context.Offices;
            var data = employees.Select(x => new HRMISOffice
            {
                Office = x.FldOfficeId,
                ChiefId = x.FldEmpId
            }).ToList();
            return Ok(data);
        }

        [HttpGet]
        [Route("division")]
        public IActionResult GetDivision()
        {
            var authHeader = Request.Headers["Authorization"].FirstOrDefault();
            if (string.IsNullOrEmpty(authHeader) || !authHeader.StartsWith("Bearer ")) return BadRequest("Token is Required!");

            var token = authHeader.Substring("Bearer ".Length).Trim();
            var principal = JwtHelper.ValidateToken(token, configuration);
            if (principal == null) return Unauthorized("Invalid or expired token.");

            var employees = context.Divisions;
            var data = employees.Select(x => new HRMISDivision
            {
                Office = x.FldOfficeId,
                Division = x.FldDivision,
                ChiefId = x.FldEmpId
            }).ToList();
            return Ok(data);
        }
    }
}
