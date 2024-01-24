using HDNXUdemyModel.Model;
using HDNXUdemyModel.ResponModel;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace HDNXUdemyServices.IServices
{
    public interface IUploadFileVideoToServer
    {
        Task<ReturnUploadFile> UploadVideoFileToServer(IWebHostEnvironment _hostingEnvironment, IFormFile fileVideoUpload, string folderUpload, HttpRequest request);

        Task<bool> CreateFileSoftware(FileManagerModel model);

        Task<bool> UpdateStatusSoftware(int id, FileManagerModel model);

        Task<bool> UpdateInformationSoftware(int id, FileManagerModel model);

        Task<List<FileManagerModel>> GetListFileSoftware(HttpRequest request);

        Task<FileManagerModel> GetFileSoftware(int id);
    }
}