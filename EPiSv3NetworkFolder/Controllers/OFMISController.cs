using EPiSv3NetworkFolder.Context;
using EPiSv3NetworkFolder.DataTransferModels.OFMIS;
using EPiSv3NetworkFolder.Helpers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EPiSv3NetworkFolder.Controllers
{
    [ApiController]
    [Route("api/OFMIS")]
    [Authorize]
    public class OFMISController : ControllerBase
    {
        private readonly OFMISContext context;
        private readonly IConfiguration configuration;

        public OFMISController(OFMISContext context , IConfiguration configuration)
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
            var empDto = employees.Select(x => new OFMISEmployees
            {
                Id = x.Id,
                FirstName = x.FirstName,
                MiddleName = x.MiddleName,
                LastName = x.LastName,
                ExtName = x.ExtName,
                Position = x.Position,
                Office = x.OffcAcr,
                ChiefId = x.Office.EmployeeId
            });
            return Ok(empDto);
        }

        [HttpGet]
        [Route("user/{username}")]
        public IActionResult GetUser(string username)
        {
            var authHeader = Request.Headers["Authorization"].FirstOrDefault();
            if (string.IsNullOrEmpty(authHeader) || !authHeader.StartsWith("Bearer ")) return BadRequest("Token is Required!");

            var token = authHeader.Substring("Bearer ".Length).Trim();
            var principal = JwtHelper.ValidateToken(token, configuration);
            if (principal == null) return Unauthorized("Invalid or expired token.");
            var user = context.Users.FirstOrDefault(x => x.UserName == username);
            var userDto = new OFMISUsers
            {
                Username = user.UserName,
                PasswordHash = user.PasswordHash,
                SecurityStamp = user.SecurityStamp
            };
            return Ok(userDto);
        }
    }
}
