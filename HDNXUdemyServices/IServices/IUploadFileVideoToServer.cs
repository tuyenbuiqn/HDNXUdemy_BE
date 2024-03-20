using HDNXUdemyModel.Model;
using HDNXUdemyModel.ResponModel;
using Microsoft.AspNetCore.Http;

namespace HDNXUdemyServices.IServices
{
    public interface IUploadFileVideoToServer
    {
        Task<ReturnUploadFile> UploadVideoFileToServer(IFormFile fileVideoUpload, string folderUpload, HttpRequest request);

        Task<bool> CreateFileSoftware(FileManagerModel model);

        Task<bool> UpdateStatusSoftware(Guid id, FileManagerModel model);

        Task<bool> UpdateInformationSoftware(Guid id, FileManagerModel model);

        Task<List<FileManagerModel>> GetListFileSoftware(HttpRequest request);

        Task<FileManagerModel> GetFileSoftware(Guid id);

        Task<ReturnUploadFile> UploadVideoMp4FileToServer(IFormFile fileVideoUpload, string folderUpload, HttpRequest request);
    }
}