using Asp.Versioning;
using HDNXUdemyModel.Base;
using HDNXUdemyModel.Constant;
using HDNXUdemyModel.Model;
using HDNXUdemyModel.SystemExceptions;
using HDNXUdemyServices.IServices;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace HDNXUdemyAPI.Controllers
{
    /// <summary>
    /// StudentController
    /// </summary>
    [ApiVersion(VersionApi.Version1)]
    [Route(RouterControllerName.Student)]
    public class StudentController : BaseController
    {
        private readonly IStudentServices _studentServices;

        /// <summary>
        /// StudentController
        /// </summary>
        /// <param name="studentServices"></param>
        /// <exception cref="ProjectException"></exception>
        public StudentController(IStudentServices studentServices)
        {
            _studentServices = studentServices ?? throw new ProjectException(nameof(_studentServices));
        }

        /// <summary>
        /// CreateStudent
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<RepositoryModel<bool>> CreateStudent(UserModel model)
        {
            RepositoryModel<bool> result = new()
            {
                PartnerCode = Messenger.SuccessFull,
                RetCode = ERetCode.Successfull,
                Data = new bool(),
                SystemMessage = string.Empty,
                StatusCode = (int)HttpStatusCode.Created
            };

            result.Data = await _studentServices.CreateStudent(model);
            return result;
        }

        /// <summary>
        /// UpdateStatusStudent
        /// </summary>
        /// <param name="id"></param>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPut("status/{id}")]
        public async Task<RepositoryModel<bool>> UpdateStatusStudent(int id, UserModel model)
        {
            RepositoryModel<bool> result = new()
            {
                PartnerCode = Messenger.SuccessFull,
                RetCode = ERetCode.Successfull,
                Data = new bool(),
                SystemMessage = string.Empty,
                StatusCode = (int)HttpStatusCode.Created
            };

            result.Data = await _studentServices.UpdateStatusStudent(id, model);
            return result;
        }

        /// <summary>
        /// UpdateStudent
        /// </summary>
        /// <param name="id"></param>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPut("{id}")]
        public async Task<RepositoryModel<bool>> UpdateStudent(int id, UserModel model)
        {
            RepositoryModel<bool> result = new()
            {
                PartnerCode = Messenger.SuccessFull,
                RetCode = ERetCode.Successfull,
                Data = new bool(),
                SystemMessage = string.Empty,
                StatusCode = (int)HttpStatusCode.Created
            };

            result.Data = await _studentServices.UpdateStudent(id, model);
            return result;
        }

        /// <summary>
        /// GetListStudents
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<RepositoryModel<List<UserModel>>> GetListStudents()
        {
            RepositoryModel<List<UserModel>> result = new()
            {
                PartnerCode = Messenger.SuccessFull,
                RetCode = ERetCode.Successfull,
                Data = new List<UserModel>(),
                SystemMessage = string.Empty,
                StatusCode = (int)HttpStatusCode.Created
            };

            result.Data = await _studentServices.GetListStudents();
            return result;
        }

        /// <summary>
        /// GetStudent
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<RepositoryModel<UserModel>> GetStudent(int id)
        {
            RepositoryModel<UserModel> result = new()
            {
                PartnerCode = Messenger.SuccessFull,
                RetCode = ERetCode.Successfull,
                Data = new UserModel(),
                SystemMessage = string.Empty,
                StatusCode = (int)HttpStatusCode.Created
            };

            result.Data = await _studentServices.GetStudent(id);
            return result;
        }

        /// <summary>
        /// GetListUserManager
        /// </summary>
        /// <returns></returns>
        [HttpGet("account-user")]
        public async Task<RepositoryModel<List<UserModel>>> GetListUserManager()
        {
            RepositoryModel<List<UserModel>> result = new()
            {
                PartnerCode = Messenger.SuccessFull,
                RetCode = ERetCode.Successfull,
                Data = new List<UserModel>(),
                SystemMessage = string.Empty,
                StatusCode = (int)HttpStatusCode.Created
            };

            result.Data = await _studentServices.GetListUserManager();
            return result;
        }

        /// <summary>
        /// GetListTeachers
        /// </summary>
        /// <returns></returns>
        [HttpGet("account-teacher")]
        public async Task<RepositoryModel<List<UserModel>>> GetListTeachers()
        {
            RepositoryModel<List<UserModel>> result = new()
            {
                PartnerCode = Messenger.SuccessFull,
                RetCode = ERetCode.Successfull,
                Data = new List<UserModel>(),
                SystemMessage = string.Empty,
                StatusCode = (int)HttpStatusCode.Created
            };

            result.Data = await _studentServices.GetListTeachers();
            return result;
        }

        /// <summary>
        /// CreateStudentPromotions
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost("student-promotion")]
        public async Task<RepositoryModel<bool>> CreateStudentPromotions(StudentPromotionModel model)
        {
            RepositoryModel<bool> result = new()
            {
                PartnerCode = Messenger.SuccessFull,
                RetCode = ERetCode.Successfull,
                Data = new bool(),
                SystemMessage = string.Empty,
                StatusCode = (int)HttpStatusCode.Created
            };

            result.Data = await _studentServices.CreateStudentPromotions(model);
            return result;
        }

        /// <summary>
        /// UpdateStatusStudentPromotions
        /// </summary>
        /// <param name="id"></param>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPut("student-promotion/status/{id}")]
        public async Task<RepositoryModel<bool>> UpdateStatusStudentPromotions(int id, StudentPromotionModel model)
        {
            RepositoryModel<bool> result = new()
            {
                PartnerCode = Messenger.SuccessFull,
                RetCode = ERetCode.Successfull,
                Data = new bool(),
                SystemMessage = string.Empty,
                StatusCode = (int)HttpStatusCode.Created
            };

            result.Data = await _studentServices.UpdateStatusStudentPromotions(id, model);
            return result;
        }

        /// <summary>
        /// UpdateInformationStudentPromotions
        /// </summary>
        /// <param name="id"></param>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPut("student-promotion/{id}")]
        public async Task<RepositoryModel<bool>> UpdateInformationStudentPromotions(int id, StudentPromotionModel model)
        {
            RepositoryModel<bool> result = new()
            {
                PartnerCode = Messenger.SuccessFull,
                RetCode = ERetCode.Successfull,
                Data = new bool(),
                SystemMessage = string.Empty,
                StatusCode = (int)HttpStatusCode.Created
            };

            result.Data = await _studentServices.UpdateInformationStudentPromotions(id, model);
            return result;
        }

        /// <summary>
        /// GetListStudentPromotions
        /// </summary>
        /// <returns></returns>
        [HttpGet("student-promotion")]
        public async Task<RepositoryModel<List<StudentPromotionModel>>> GetListStudentPromotions()
        {
            RepositoryModel<List<StudentPromotionModel>> result = new()
            {
                PartnerCode = Messenger.SuccessFull,
                RetCode = ERetCode.Successfull,
                Data = new List<StudentPromotionModel>(),
                SystemMessage = string.Empty,
                StatusCode = (int)HttpStatusCode.Created
            };

            result.Data = await _studentServices.GetListStudentPromotions();
            return result;
        }

        /// <summary>
        /// GetStudentPromotions
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("student-promotion/{id}")]
        public async Task<RepositoryModel<StudentPromotionModel>> GetStudentPromotions(int id)
        {
            RepositoryModel<StudentPromotionModel> result = new()
            {
                PartnerCode = Messenger.SuccessFull,
                RetCode = ERetCode.Successfull,
                Data = new StudentPromotionModel(),
                SystemMessage = string.Empty,
                StatusCode = (int)HttpStatusCode.Created
            };

            result.Data = await _studentServices.GetStudentPromotions(id);
            return result;
        }

        /// <summary>
        /// CreateStudentProcess
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost("student-process")]
        public async Task<RepositoryModel<bool>> CreateStudentProcess(StudentProcessModel model)
        {
            RepositoryModel<bool> result = new()
            {
                PartnerCode = Messenger.SuccessFull,
                RetCode = ERetCode.Successfull,
                Data = new bool(),
                SystemMessage = string.Empty,
                StatusCode = (int)HttpStatusCode.Created
            };

            result.Data = await _studentServices.CreateStudentProcess(model);
            return result;
        }

        /// <summary>
        /// UpdateStatusStudentProcess
        /// </summary>
        /// <param name="id"></param>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPut("student-process/status/{id}")]
        public async Task<RepositoryModel<bool>> UpdateStatusStudentProcess(int id, StudentProcessModel model)
        {
            RepositoryModel<bool> result = new()
            {
                PartnerCode = Messenger.SuccessFull,
                RetCode = ERetCode.Successfull,
                Data = new bool(),
                SystemMessage = string.Empty,
                StatusCode = (int)HttpStatusCode.Created
            };

            result.Data = await _studentServices.UpdateStatusStudentProcess(id, model);
            return result;
        }

        /// <summary>
        /// UpdateInformationStudentProcess
        /// </summary>
        /// <param name="id"></param>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPut("student-process/{id}")]
        public async Task<RepositoryModel<bool>> UpdateInformationStudentProcess(int id, StudentProcessModel model)
        {
            RepositoryModel<bool> result = new()
            {
                PartnerCode = Messenger.SuccessFull,
                RetCode = ERetCode.Successfull,
                Data = new bool(),
                SystemMessage = string.Empty,
                StatusCode = (int)HttpStatusCode.Created
            };

            result.Data = await _studentServices.UpdateInformationStudentProcess(id, model);
            return result;
        }

        /// <summary>
        /// GetListStudentProcess
        /// </summary>
        /// <returns></returns>
        [HttpGet("student-process")]
        public async Task<RepositoryModel<List<StudentProcessModel>>> GetListStudentProcess()
        {
            RepositoryModel<List<StudentProcessModel>> result = new()
            {
                PartnerCode = Messenger.SuccessFull,
                RetCode = ERetCode.Successfull,
                Data = new List<StudentProcessModel>(),
                SystemMessage = string.Empty,
                StatusCode = (int)HttpStatusCode.Created
            };

            result.Data = await _studentServices.GetListStudentProcess();
            return result;
        }

        /// <summary>
        /// GetStudentProcess
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("student-process/{id}")]
        public async Task<RepositoryModel<StudentProcessModel>> GetStudentProcess(int id)
        {
            RepositoryModel<StudentProcessModel> result = new()
            {
                PartnerCode = Messenger.SuccessFull,
                RetCode = ERetCode.Successfull,
                Data = new StudentProcessModel(),
                SystemMessage = string.Empty,
                StatusCode = (int)HttpStatusCode.Created
            };

            result.Data = await _studentServices.GetStudentProcess(id);
            return result;
        }

        /// <summary>
        /// CreateBookmarkCourse
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost("bookmark-course")]
        public async Task<RepositoryModel<bool>> CreateBookmarkCourse(BookmarkCourseModel model)
        {
            RepositoryModel<bool> result = new()
            {
                PartnerCode = Messenger.SuccessFull,
                RetCode = ERetCode.Successfull,
                Data = new bool(),
                SystemMessage = string.Empty,
                StatusCode = (int)HttpStatusCode.Created
            };

            result.Data = await _studentServices.CreateStudentBookmarkCourse(model);
            return result;
        }

        /// <summary>
        /// UpdateStatusBookmarkCourse
        /// </summary>
        /// <param name="id"></param>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPut("bookmark-course/status/{id}")]
        public async Task<RepositoryModel<bool>> UpdateStatusBookmarkCourse(int id, BookmarkCourseModel model)
        {
            RepositoryModel<bool> result = new()
            {
                PartnerCode = Messenger.SuccessFull,
                RetCode = ERetCode.Successfull,
                Data = new bool(),
                SystemMessage = string.Empty,
                StatusCode = (int)HttpStatusCode.Created
            };

            result.Data = await _studentServices.UpdateStatusStudentBookmarkCourse(id, model);
            return result;
        }

        /// <summary>
        /// GetListBookmarkCourse
        /// </summary>
        /// <param name="idUser"></param>
        /// <returns></returns>
        [HttpGet("bookmark-course/{idUser}")]
        public async Task<RepositoryModel<List<BookmarkCourseModel>>> GetListBookmarkCourse(int idUser)
        {
            RepositoryModel<List<BookmarkCourseModel>> result = new()
            {
                PartnerCode = Messenger.SuccessFull,
                RetCode = ERetCode.Successfull,
                Data = new List<BookmarkCourseModel>(),
                SystemMessage = string.Empty,
                StatusCode = (int)HttpStatusCode.Created
            };

            result.Data = await _studentServices.GetListStudentBookmarkCourse(idUser);
            return result;
        }

        /// <summary>
        /// RemoveBookmarkCourse
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("bookmark-course/{id}")]
        public async Task<RepositoryModel<bool>> RemoveBookmarkCourse(int id)
        {
            RepositoryModel<bool> result = new()
            {
                PartnerCode = Messenger.SuccessFull,
                RetCode = ERetCode.Successfull,
                Data = new bool(),
                SystemMessage = string.Empty,
                StatusCode = (int)HttpStatusCode.Created
            };

            result.Data = await _studentServices.DeleteStudentBookmarkCourse(id);
            return result;
        }
    }
}