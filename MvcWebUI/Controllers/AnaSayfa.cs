using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MvcWebUI.Controllers
{
    public class AnaSayfa : Controller
    {
        private IHostingEnvironment _environment;
        public AnaSayfa(IHostingEnvironment environment)
        {
            _environment = environment;
        }
        [Route("~/")]
        [Route("~/AnaSayfa")]
        [Route("~/AnaSayfa/Index")]
        public IActionResult Index()
        {
            return View();
        }
        [Route("~/upload")]
        [HttpPost]
        public async Task<IActionResult> UploadFile(IFormFile file)
        {
            try
            {
                if (file.Length > 0)
                {
                    string folderRoot = Path.Combine(_environment.ContentRootPath, "Uploads");
                    string filePath = Guid.NewGuid() + Path.GetExtension(file.FileName);
                    filePath = Path.Combine(folderRoot, filePath);
                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        await file.CopyToAsync(stream);
                    }
                }
                return Ok(new { success = true, message = "File Uploaded" });
            }
            catch (Exception)
            {
                return BadRequest(new { success = false, message = "Error file failed to upload" });
            }
        }
    }
}
