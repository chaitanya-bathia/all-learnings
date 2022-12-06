using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace RepositoryPatternPractice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FileController : ControllerBase
    {
        [HttpPost]

        public async Task<IActionResult> Post(List<IFormFile> files)
        {
            var file = files.First();
            var fileName = string.Format("./Uploads/{0}", file.FileName);
            var fileStream = new FileStream(fileName,FileMode.Append);
            await file.CopyToAsync(fileStream);
            fileStream.Close();
            return Ok(file.FileName);
        }

        [HttpGet("{fileName}")]
        public async Task<IActionResult> Get(string fileName)
        {
            var filepath = string.Format("./Uploads/{0}", fileName);
            var fileStream = new FileStream(filepath, FileMode.Open);
            var bytes = await fileStream.ReadAllBytes();
            return File(bytes,"text/txt",fileName);

        }
    }

    public static class StreamExtensions
    {
        public async static Task<byte[]> ReadAllBytes(this Stream instream)
        {
            if(instream is MemoryStream)
            {
                return ((MemoryStream)instream).ToArray();
            }
            
            using (var memoryStream = new MemoryStream())
            {
                await instream.CopyToAsync(memoryStream);
                return memoryStream.ToArray();
            }
        }
    }
}
