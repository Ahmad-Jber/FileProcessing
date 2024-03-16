using FileProcessing.FileData.Dtos;
using FileProcessing.FileData.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FileProcessing.FileData.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FileController : ControllerBase
    {
        private IFileService _fileService;
        public FileController(IFileService fileService)
        {
            _fileService = fileService;
        }
        [HttpGet("all")]
        public async Task<ActionResult<List<GetAllFilesDto>>> GetAllFiles()
        {
            return Ok(await _fileService.GetAllFiles());
        }
        [HttpPost("add")]
        public async Task<ActionResult> InsertFile(InsertFileDto insertFileDto) 
        {
            await _fileService.InsertFile(insertFileDto);
            return Ok("Successful");
        }
    }
}
