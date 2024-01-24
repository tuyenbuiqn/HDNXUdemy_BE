using HDNXUdemyModel.Model;
using HDNXUdemyModel.ResponModel;
using Microsoft.AspNetCore.Http;

namespace HDNXUdemyServices.IServices
{
    public interface ICourseServices
    {
        Task<bool> CreateCourse(CourseModel model);

        Task<bool> UpdateStatusCourse(int id, CourseModel model);

        Task<bool> UpdateInformationCourse(int id, CourseModel model);

        Task<List<StudentProcessModel>> GetListStudentProcess();

        Task<StudentProcessModel> GetStudentProcess(int id);

        Task<bool> CreateCommentCourse(CourseCommentModel model);

        Task<bool> UpdateStatusCommentCourse(int id, CourseCommentModel model);

        Task<bool> UpdateInformationCommentCourse(int id, CourseCommentModel model);

        Task<List<CourseCommentModel>> GetListCommentCourse(int idCourse);

        Task<CourseCommentModel> GetCommentCourse(int id);

        Task<bool> CreateContentCourse(ContentCourseModel model);

        Task<bool> UpdateStatusContentCourse(int id, ContentCourseModel model);

        Task<bool> UpdateInformationContentCourse(int id, ContentCourseModel model);

        Task<List<ListContentWithDetailCourse>> GetListContentCourse(int idCourse);

        Task<ContentCourseModel> GetContentCourse(int id);

        Task<bool> CreateContentCourseDetails(ContentCourseDetailModel model);

        Task<bool> UpdateStatusContentCourseDetails(int id, ContentCourseDetailModel model);

        Task<bool> UpdateInformationContentCourseDetails(int id, ContentCourseDetailModel model);

        Task<List<ContentCourseDetailModel>> GetListContentCourseDetails(int idContent);

        Task<ContentCourseDetailModel> GetContentCourseDetails(int id, HttpRequest request);

        Task<bool> CreateCommentChapter(ChapterCommentModel model);

        Task<bool> UpdateStatusCommentChapter(int id, ChapterCommentModel model);

        Task<bool> UpdateInformationCommentChapter(int id, ChapterCommentModel model);

        Task<List<ChapterCommentModel>> GetListCommentChapter(int idCourse);

        Task<ChapterCommentModel> GetCommentChapter(int id);

        Task<List<CourseModel>> GetListCourseForAdmin();

        Task<GetCourseWithDetailsContent> GetDetailCourse(int id);

        Task<List<CourseModel>> GetListCourseAsCategory(int idCategory);
    }
}