using FileParser.Models;
using FileParser.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.IO;
using System.Threading.Tasks;

namespace FileParser.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BinParserController : ControllerBase
    {
        private readonly ILogger<BinParserController> _logger;
        private readonly IBinParserService _service;

        public BinParserController(ILogger<BinParserController> logger, IBinParserService service)
        {
            _logger = logger;
            _service = service;
        }

        [HttpPost("upload")]
        public async Task<IActionResult> UploadBinFile(IFormFile file)
        {
            if (file == null || file.Length == 0)
                return BadRequest("No file uploaded.");

            var extension = Path.GetExtension(file.FileName);
            if (!string.Equals(extension, ".bin", StringComparison.OrdinalIgnoreCase))
                return BadRequest("Only .bin files are allowed.");

            var messages = await _service.ParseBinFileAsync(file);
            return Ok(messages);
        }
    }
}