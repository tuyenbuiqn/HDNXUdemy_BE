using Asp.Versioning;
using HDNXUdemyModel.Constant;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.FileProviders;
using System.IO;

namespace HDNXUdemyConvertVideoAPI.Controllers
{
    /// <summary>
    /// GetStreamFileController
    /// </summary>
    [ApiVersion(VersionApi.Version1)]
    [Route(RouterControllerName.GetVideoStreamFile)]
    public class GetStreamFileController : BaseController
    {
        private readonly IFileProvider _fileProvider;
        /// <summary>
        /// GetStreamFileController
        /// </summary>
        /// <param name="fileProvider"></param>
        public GetStreamFileController(IFileProvider fileProvider)
        {
            _fileProvider = fileProvider;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        [HttpGet("stream/{fileName}")]
        public IActionResult GetVideoStream(string fileName)
        {
            var filePath = _fileProvider.GetFileInfo($"StorageStreamVideo/{fileName}");

            if (!filePath.Exists)
            {
                return NotFound(); // File not found
            }

            var fileContent = System.IO.File.OpenRead(filePath.PhysicalPath ?? string.Empty);
            return File(fileContent, "application/octet-stream", enableRangeProcessing: true);
        }
    }
}
