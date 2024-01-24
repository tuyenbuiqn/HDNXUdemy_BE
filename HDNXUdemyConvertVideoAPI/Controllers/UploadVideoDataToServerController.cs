using Asp.Versioning;
using HDNXUdemyModel.Base;
using HDNXUdemyModel.Constant;
using HDNXUdemyModel.ResponModel;
using HDNXUdemyModel.SystemExceptions;
using HDNXUdemyServices.IServices;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace HDNXUdemyConvertVideoAPI.Controllers
{
    /// <summary>
    /// UploadVideoDataToServerController
    /// </summary>
    [ApiVersion(VersionApi.Version1)]
    [Route(RouterControllerName.UploadVideoToClound)]
    public class UploadVideoDataToServerController : BaseController
    {
        private readonly IUploadFileVideoToServer _uploadFileVideoToServer;
        private readonly IWebHostEnvironment _hostingEnvironment;

        /// <summary>
        /// UploadVideoDataToServerController
        /// </summary>
        /// <param name="uploadFileVideoToServer"></param>
        /// /// <param name="hostingEnvironment"></param>
        /// <exception cref="ProjectException"></exception>
        public UploadVideoDataToServerController(IUploadFileVideoToServer uploadFileVideoToServer, IWebHostEnvironment hostingEnvironment)
        {
            _uploadFileVideoToServer = uploadFileVideoToServer ?? throw new ProjectException(nameof(_uploadFileVideoToServer));
            _hostingEnvironment = hostingEnvironment ?? throw new ProjectException(nameof(_uploadFileVideoToServer));
        }

        /// <summary>
        /// UploadVideoToServer
        /// </summary>
        /// <param name="filePicture"></param>
        /// <returns></returns>
        [HttpPost("video-course")]
        public async Task<RepositoryModel<ReturnUploadFile>> UploadVideoToServer()
        {
            RepositoryModel<ReturnUploadFile> result = new()
            {
                PartnerCode = Messenger.SuccessFull,
                RetCode = ERetCode.Successfull,
                Data = new ReturnUploadFile(),
                SystemMessage = string.Empty,
                StatusCode = (int)HttpStatusCode.Created
            };
            var folderUpload = ProjectConfig.StorageMainVideo ?? string.Empty;
            var files = Request.Form.Files;
            result.Data = await _uploadFileVideoToServer.UploadVideoFileToServer(_hostingEnvironment, files[0], folderUpload, Request);
            return result;
        }

        /// <summary>
        /// UploadFileDocumentToServer
        /// </summary>
        /// <returns></returns>
        [HttpPost("file-document")]
        public async Task<RepositoryModel<ReturnUploadFile>> UploadFileDocumentToServer()
        {
            RepositoryModel<ReturnUploadFile> result = new()
            {
                PartnerCode = Messenger.SuccessFull,
                RetCode = ERetCode.Successfull,
                Data = new ReturnUploadFile(),
                SystemMessage = string.Empty,
                StatusCode = (int)HttpStatusCode.Created
            };
            var folderUpload = ProjectConfig.UploadSoftWareAndFile ?? string.Empty;
            var files = Request.Form.Files;
            result.Data = await _uploadFileVideoToServer.UploadVideoFileToServer(_hostingEnvironment, files[0], folderUpload, Request);
            return result;
        }
    }
}