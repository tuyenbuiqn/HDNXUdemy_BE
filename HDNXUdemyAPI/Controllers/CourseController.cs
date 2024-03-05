using Asp.Versioning;
using HDNXUdemyModel.Base;
using HDNXUdemyModel.Constant;
using HDNXUdemyModel.Model;
using HDNXUdemyModel.ResponModel;
using HDNXUdemyModel.SystemExceptions;
using HDNXUdemyServices.IServices;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace HDNXUdemyAPI.Controllers
{
    /// <summary>
    /// CourseController
    /// </summary>
    [ApiVersion(VersionApi.Version1)]
    [Route(RouterControllerName.Course)]
    public class CourseController : BaseController
    {
        private readonly ICourseServices _courseServices;
        private readonly IHttpContextAccessor _httpContextAccessor;

        /// <summary>
        /// CourseController
        /// </summary>
        /// <param name="courseServices"></param>
        /// <param name="httpContextAccessor"></param>
        /// <exception cref="ProjectException"></exception>
        public CourseController(ICourseServices courseServices, IHttpContextAccessor httpContextAccessor)
        {
            _courseServices = courseServices ?? throw new ProjectException(nameof(_courseServices));
            _httpContextAccessor = httpContextAccessor ?? throw new ProjectException(nameof(_httpContextAccessor));
        }

        /// <summary>
        /// CreateCourse
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost("course")]
        public async Task<RepositoryModel<bool>> CreateCourse(CourseModel model)
        {
            RepositoryModel<bool> result = new()
            {
                PartnerCode = Messenger.SuccessFull,
                RetCode = ERetCode.Successfull,
                Data = new bool(),
                SystemMessage = string.Empty,
                StatusCode = (int)HttpStatusCode.Created
            };

            result.Data = await _courseServices.CreateCourse(model);
            return result;
        }

        /// <summary>
        /// UpdateStatusCourse
        /// </summary>
        /// <param name="id"></param>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPut("course/status/{id}")]
        public async Task<RepositoryModel<bool>> UpdateStatusCourse(int id, CourseModel model)
        {
            RepositoryModel<bool> result = new()
            {
                PartnerCode = Messenger.SuccessFull,
                RetCode = ERetCode.Successfull,
                Data = new bool(),
                SystemMessage = string.Empty,
                StatusCode = (int)HttpStatusCode.Created
            };

            result.Data = await _courseServices.UpdateStatusCourse(id, model);
            return result;
        }

        /// <summary>
        /// UpdateInformationCourse
        /// </summary>
        /// <param name="id"></param>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPut("course/{id}")]
        public async Task<RepositoryModel<bool>> UpdateInformationCourse(int id, CourseModel model)
        {
            RepositoryModel<bool> result = new()
            {
                PartnerCode = Messenger.SuccessFull,
                RetCode = ERetCode.Successfull,
                Data = new bool(),
                SystemMessage = string.Empty,
                StatusCode = (int)HttpStatusCode.Created
            };

            result.Data = await _courseServices.UpdateInformationCourse(id, model);
            return result;
        }

        /// <summary>
        /// GetListAllCourse
        /// </summary>
        /// <returns></returns>
        [HttpGet("course")]
        public async Task<RepositoryModel<List<CourseModel>>> GetListAllCourse()
        {
            RepositoryModel<List<CourseModel>> result = new()
            {
                PartnerCode = Messenger.SuccessFull,
                RetCode = ERetCode.Successfull,
                Data = new List<CourseModel>(),
                SystemMessage = string.Empty,
                StatusCode = (int)HttpStatusCode.Created
            };

            result.Data = await _courseServices.GetListCourseForAdmin();
            return result;
        }

        /// <summary>
        /// GetCourses
        /// </summary>
        /// <param name="id"></param>
        /// <param name="isAdmin"></param>
        /// <returns></returns>
        [HttpGet("course/{id}/{isAdmin}")]
        public async Task<RepositoryModel<GetCourseWithDetailsContent>> GetCourses(int id, bool isAdmin)
        {
            RepositoryModel<GetCourseWithDetailsContent> result = new()
            {
                PartnerCode = Messenger.SuccessFull,
                RetCode = ERetCode.Successfull,
                Data = new GetCourseWithDetailsContent(),
                SystemMessage = string.Empty,
                StatusCode = (int)HttpStatusCode.Created
            };

            result.Data = await _courseServices.GetDetailCourse(id, isAdmin);
            return result;
        }

        /// <summary>
        /// GetListCourseAsCategory
        /// </summary>
        /// <param name="idCategory"></param>
        /// <returns></returns>
        [HttpGet("course/category/{idCategory}")]
        public async Task<RepositoryModel<List<CourseModel>>> GetListCourseAsCategory(int idCategory)
        {
            RepositoryModel<List<CourseModel>> result = new()
            {
                PartnerCode = Messenger.SuccessFull,
                RetCode = ERetCode.Successfull,
                Data = new List<CourseModel>(),
                SystemMessage = string.Empty,
                StatusCode = (int)HttpStatusCode.Created
            };

            result.Data = await _courseServices.GetListCourseAsCategory(idCategory);
            return result;
        }

        /// <summary>
        /// GetListStudentProcess
        /// </summary>
        /// <returns></returns>
        [HttpGet("course/student-process")]
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

            result.Data = await _courseServices.GetListStudentProcess();
            return result;
        }

        /// <summary>
        /// GetStudentProcess
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("course/student-process/{id}")]
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

            result.Data = await _courseServices.GetStudentProcess(id);
            return result;
        }

        /// <summary>
        /// CreateCommentCourse
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost("course-comment")]
        public async Task<RepositoryModel<bool>> CreateCommentCourse(CourseCommentModel model)
        {
            RepositoryModel<bool> result = new()
            {
                PartnerCode = Messenger.SuccessFull,
                RetCode = ERetCode.Successfull,
                Data = new bool(),
                SystemMessage = string.Empty,
                StatusCode = (int)HttpStatusCode.Created
            };

            result.Data = await _courseServices.CreateCommentCourse(model);
            return result;
        }

        /// <summary>
        /// UpdateStatusCommentCourse
        /// </summary>
        /// <param name="id"></param>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPut("course-comment/status/{id}")]
        public async Task<RepositoryModel<bool>> UpdateStatusCommentCourse(int id, CourseCommentModel model)
        {
            RepositoryModel<bool> result = new()
            {
                PartnerCode = Messenger.SuccessFull,
                RetCode = ERetCode.Successfull,
                Data = new bool(),
                SystemMessage = string.Empty,
                StatusCode = (int)HttpStatusCode.Created
            };

            result.Data = await _courseServices.UpdateStatusCommentCourse(id, model);
            return result;
        }

        /// <summary>
        /// UpdateInformationCommentCourse
        /// </summary>
        /// <param name="id"></param>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPut("course-comment/{id}")]
        public async Task<RepositoryModel<bool>> UpdateInformationCommentCourse(int id, CourseCommentModel model)
        {
            RepositoryModel<bool> result = new()
            {
                PartnerCode = Messenger.SuccessFull,
                RetCode = ERetCode.Successfull,
                Data = new bool(),
                SystemMessage = string.Empty,
                StatusCode = (int)HttpStatusCode.Created
            };

            result.Data = await _courseServices.UpdateInformationCommentCourse(id, model);
            return result;
        }

        /// <summary>
        /// GetListStudentProcess
        /// </summary>
        /// <returns></returns>
        [HttpGet("course-comment/course/{idCourse}")]
        public async Task<RepositoryModel<List<CourseCommentModel>>> GetListCommentCourse(int idCourse)
        {
            RepositoryModel<List<CourseCommentModel>> result = new()
            {
                PartnerCode = Messenger.SuccessFull,
                RetCode = ERetCode.Successfull,
                Data = new List<CourseCommentModel>(),
                SystemMessage = string.Empty,
                StatusCode = (int)HttpStatusCode.Created
            };

            result.Data = await _courseServices.GetListCommentCourse(idCourse);
            return result;
        }

        /// <summary>
        /// GetCommentCourse
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("course-comment/{id}")]
        public async Task<RepositoryModel<CourseCommentModel>> GetCommentCourse(int id)
        {
            RepositoryModel<CourseCommentModel> result = new()
            {
                PartnerCode = Messenger.SuccessFull,
                RetCode = ERetCode.Successfull,
                Data = new CourseCommentModel(),
                SystemMessage = string.Empty,
                StatusCode = (int)HttpStatusCode.Created
            };

            result.Data = await _courseServices.GetCommentCourse(id);
            return result;
        }

        /// <summary>
        /// CreateContentCourse
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost("course-content")]
        public async Task<RepositoryModel<bool>> CreateContentCourse(ContentCourseModel model)
        {
            RepositoryModel<bool> result = new()
            {
                PartnerCode = Messenger.SuccessFull,
                RetCode = ERetCode.Successfull,
                Data = new bool(),
                SystemMessage = string.Empty,
                StatusCode = (int)HttpStatusCode.Created
            };

            result.Data = await _courseServices.CreateContentCourse(model);
            return result;
        }

        /// <summary>
        /// UpdateStatusContentCourse
        /// </summary>
        /// <param name="id"></param>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPut("course-content/status/{id}")]
        public async Task<RepositoryModel<bool>> UpdateStatusContentCourse(int id, ContentCourseModel model)
        {
            RepositoryModel<bool> result = new()
            {
                PartnerCode = Messenger.SuccessFull,
                RetCode = ERetCode.Successfull,
                Data = new bool(),
                SystemMessage = string.Empty,
                StatusCode = (int)HttpStatusCode.Created
            };

            result.Data = await _courseServices.UpdateStatusContentCourse(id, model);
            return result;
        }

        /// <summary>
        /// UpdateInformationContentCourse
        /// </summary>
        /// <param name="id"></param>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPut("course-content/{id}")]
        public async Task<RepositoryModel<bool>> UpdateInformationContentCourse(int id, ContentCourseModel model)
        {
            RepositoryModel<bool> result = new()
            {
                PartnerCode = Messenger.SuccessFull,
                RetCode = ERetCode.Successfull,
                Data = new bool(),
                SystemMessage = string.Empty,
                StatusCode = (int)HttpStatusCode.Created
            };

            result.Data = await _courseServices.UpdateInformationContentCourse(id, model);
            return result;
        }

        /// <summary>
        /// GetListContentCourse
        /// </summary>
        /// <returns></returns>
        [HttpGet("course-content/course/{idCourse}")]
        public async Task<RepositoryModel<List<ListContentWithDetailCourse>>> GetListContentCourse(int idCourse)
        {
            RepositoryModel<List<ListContentWithDetailCourse>> result = new()
            {
                PartnerCode = Messenger.SuccessFull,
                RetCode = ERetCode.Successfull,
                Data = new List<ListContentWithDetailCourse>(),
                SystemMessage = string.Empty,
                StatusCode = (int)HttpStatusCode.Created
            };

            result.Data = await _courseServices.GetListContentCourse(idCourse);
            return result;
        }

        /// <summary>
        /// GetContentCourse
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("course-content/{id}")]
        public async Task<RepositoryModel<ContentCourseModel>> GetContentCourse(int id)
        {
            RepositoryModel<ContentCourseModel> result = new()
            {
                PartnerCode = Messenger.SuccessFull,
                RetCode = ERetCode.Successfull,
                Data = new ContentCourseModel(),
                SystemMessage = string.Empty,
                StatusCode = (int)HttpStatusCode.Created
            };

            result.Data = await _courseServices.GetContentCourse(id);
            return result;
        }

        /// <summary>
        /// CreateContentCourseDetails
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost("course-content-details")]
        public async Task<RepositoryModel<bool>> CreateContentCourseDetails(ContentCourseDetailModel model)
        {
            RepositoryModel<bool> result = new()
            {
                PartnerCode = Messenger.SuccessFull,
                RetCode = ERetCode.Successfull,
                Data = new bool(),
                SystemMessage = string.Empty,
                StatusCode = (int)HttpStatusCode.Created
            };

            result.Data = await _courseServices.CreateContentCourseDetails(model);
            return result;
        }

        /// <summary>
        /// UpdateStatusContentCourse
        /// </summary>
        /// <param name="id"></param>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPut("course-content-details/status/{id}")]
        public async Task<RepositoryModel<bool>> UpdateStatusContentCourseDetails(int id, ContentCourseDetailModel model)
        {
            RepositoryModel<bool> result = new()
            {
                PartnerCode = Messenger.SuccessFull,
                RetCode = ERetCode.Successfull,
                Data = new bool(),
                SystemMessage = string.Empty,
                StatusCode = (int)HttpStatusCode.Created
            };

            result.Data = await _courseServices.UpdateStatusContentCourseDetails(id, model);
            return result;
        }

        /// <summary>
        /// UpdateInformationContentCourse
        /// </summary>
        /// <param name="id"></param>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPut("course-content-details/{id}")]
        public async Task<RepositoryModel<bool>> UpdateInformationContentCourseDetails(int id, ContentCourseDetailModel model)
        {
            RepositoryModel<bool> result = new()
            {
                PartnerCode = Messenger.SuccessFull,
                RetCode = ERetCode.Successfull,
                Data = new bool(),
                SystemMessage = string.Empty,
                StatusCode = (int)HttpStatusCode.Created
            };

            result.Data = await _courseServices.UpdateInformationContentCourseDetails(id, model);
            return result;
        }

        /// <summary>
        /// GetListContentCourseDetails
        /// </summary>
        /// <returns></returns>
        [HttpGet("course-content-details/course/{idCourse}")]
        public async Task<RepositoryModel<List<ContentCourseDetailModel>>> GetListContentCourseDetails(int idCourse)
        {
            RepositoryModel<List<ContentCourseDetailModel>> result = new()
            {
                PartnerCode = Messenger.SuccessFull,
                RetCode = ERetCode.Successfull,
                Data = new List<ContentCourseDetailModel>(),
                SystemMessage = string.Empty,
                StatusCode = (int)HttpStatusCode.Created
            };

            result.Data = await _courseServices.GetListContentCourseDetails(idCourse);
            return result;
        }

        /// <summary>
        /// GetContentCourseDetails
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("course-content-details/{id}")]
        public async Task<RepositoryModel<ContentCourseDetailModel>> GetContentCourseDetails(int id)
        {
            RepositoryModel<ContentCourseDetailModel> result = new()
            {
                PartnerCode = Messenger.SuccessFull,
                RetCode = ERetCode.Successfull,
                Data = new ContentCourseDetailModel(),
                SystemMessage = string.Empty,
                StatusCode = (int)HttpStatusCode.Created
            };

            result.Data = await _courseServices.GetContentCourseDetails(id, Request);
            return result;
        }

        /// <summary>
        /// CreateCommentChapter
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost("course-comment-chapter")]
        public async Task<RepositoryModel<bool>> CreateCommentChapter(ChapterCommentModel model)
        {
            RepositoryModel<bool> result = new()
            {
                PartnerCode = Messenger.SuccessFull,
                RetCode = ERetCode.Successfull,
                Data = new bool(),
                SystemMessage = string.Empty,
                StatusCode = (int)HttpStatusCode.Created
            };

            result.Data = await _courseServices.CreateCommentChapter(model);
            return result;
        }

        /// <summary>
        /// UpdateStatusContentCourse
        /// </summary>
        /// <param name="id"></param>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPut("course-comment-chapter/status/{id}")]
        public async Task<RepositoryModel<bool>> UpdateStatusCommentChapter(int id, ChapterCommentModel model)
        {
            RepositoryModel<bool> result = new()
            {
                PartnerCode = Messenger.SuccessFull,
                RetCode = ERetCode.Successfull,
                Data = new bool(),
                SystemMessage = string.Empty,
                StatusCode = (int)HttpStatusCode.Created
            };

            result.Data = await _courseServices.UpdateStatusCommentChapter(id, model);
            return result;
        }

        /// <summary>
        /// UpdateInformationContentCourse
        /// </summary>
        /// <param name="id"></param>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPut("course-comment-chapter/{id}")]
        public async Task<RepositoryModel<bool>> UpdateInformationCommentChapter(int id, ChapterCommentModel model)
        {
            RepositoryModel<bool> result = new()
            {
                PartnerCode = Messenger.SuccessFull,
                RetCode = ERetCode.Successfull,
                Data = new bool(),
                SystemMessage = string.Empty,
                StatusCode = (int)HttpStatusCode.Created
            };

            result.Data = await _courseServices.UpdateInformationCommentChapter(id, model);
            return result;
        }

        /// <summary>
        /// GetListCommentChapter
        /// </summary>
        /// <returns></returns>
        [HttpGet("course-comment-chapter/course/{idCourse}")]
        public async Task<RepositoryModel<List<ChapterCommentModel>>> GetListCommentChapter(int idCourse)
        {
            RepositoryModel<List<ChapterCommentModel>> result = new()
            {
                PartnerCode = Messenger.SuccessFull,
                RetCode = ERetCode.Successfull,
                Data = new List<ChapterCommentModel>(),
                SystemMessage = string.Empty,
                StatusCode = (int)HttpStatusCode.Created
            };

            result.Data = await _courseServices.GetListCommentChapter(idCourse);
            return result;
        }

        /// <summary>
        /// GetCommentChapter
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("course-comment-chapter/{id}")]
        public async Task<RepositoryModel<ChapterCommentModel>> GetCommentChapter(int id)
        {
            RepositoryModel<ChapterCommentModel> result = new()
            {
                PartnerCode = Messenger.SuccessFull,
                RetCode = ERetCode.Successfull,
                Data = new ChapterCommentModel(),
                SystemMessage = string.Empty,
                StatusCode = (int)HttpStatusCode.Created
            };

            result.Data = await _courseServices.GetCommentChapter(id);
            return result;
        }
    }
}