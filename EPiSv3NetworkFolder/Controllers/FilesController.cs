using EPiSv3NetworkFolder.DataTransferModels;
using EPiSv3NetworkFolder.Helpers;
using EPiSv3NetworkFolder.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace EPiSv3NetworkFolder.Controllers
{
    [ApiController]
    [Route("api/files")]
    [Authorize]
    public class FilesController : ControllerBase
    {
        private readonly NetworkFolderService _networkFolderService;
        private readonly IConfiguration _configuration;

        public FilesController(NetworkFolderService networkFolderService, IConfiguration configuration)
        {
            _networkFolderService = networkFolderService;
            _configuration = configuration;
        }

        [HttpGet]
        [Route("download/{fileName}")]
        public IActionResult DownloadFile(string fileName)
        {
            var authHeader = Request.Headers["Authorization"].FirstOrDefault();
            if (string.IsNullOrEmpty(authHeader) || !authHeader.StartsWith("Bearer ")) return BadRequest("Token is Required!");

            var token = authHeader.Substring("Bearer ".Length).Trim();
            var principal = JwtHelper.ValidateToken(token, _configuration);
            if (principal == null) return Unauthorized("Invalid or expired token.");

            var file = _networkFolderService.GetFile(fileName);
            if (file == null) return NotFound("File not found.");

            return File(file.FileBytes, "application/octet-stream", file.FileName);
        }

        [HttpGet]
        [Route("list")]
        public IActionResult ListFiles()
        {
            try
            {
                var files = _networkFolderService.GetFileList();
                return Ok(files);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error: {ex.Message}");
            }
        }

        [HttpPost]
        [Route("upload")]
        public IActionResult UploadFile([FromForm] IFormFile file)
        {
            var authHeader = Request.Headers["Authorization"].FirstOrDefault();
            if (string.IsNullOrEmpty(authHeader) || !authHeader.StartsWith("Bearer ")) return BadRequest("Token is Required!");

            var token = authHeader.Substring("Bearer ".Length).Trim();
            var principal = JwtHelper.ValidateToken(token, _configuration);
            if (principal == null) return Unauthorized("Invalid or expired token.");

            if (file == null || file.Length == 0) return BadRequest("Invalid file.");

            _networkFolderService.UploadFile(file);
            return Ok("File uploaded successfully.");
        }

        [HttpDelete("{fileName}")]
        public IActionResult DeleteFile(string fileName)
        {
            var authHeader = Request.Headers["Authorization"].FirstOrDefault();
            if (string.IsNullOrEmpty(authHeader) || !authHeader.StartsWith("Bearer ")) return BadRequest("Token is Required!");

            var token = authHeader.Substring("Bearer ".Length).Trim();
            var principal = JwtHelper.ValidateToken(token, _configuration);
            if (principal == null) return Unauthorized("Invalid or expired token.");

            if (string.IsNullOrWhiteSpace(fileName))
            {
                return BadRequest("File name cannot be empty.");
            }

            var fullPath = Path.Combine(_networkFolderService.GetNetworkFolderPath(), fileName);

            if (!System.IO.File.Exists(fullPath))
            {
                return NotFound($"The file '{fileName}' does not exist.");
            }

            System.IO.File.Delete(fullPath);

            return Ok($"The file '{fileName}' has been deleted successfully.");
        }
    }
}
