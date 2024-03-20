using HDNXUdemyModel.Model;
using HDNXUdemyModel.ResponModel;
using Microsoft.AspNetCore.Http;

namespace HDNXUdemyServices.IServices
{
    public interface ICourseServices
    {
        Task<bool> CreateCourse(CourseModel model);

        Task<bool> UpdateStatusCourse(Guid id, int status, int processCourse);

        Task<bool> UpdateInformationCourse(Guid id, CourseModel model);

        Task<List<StudentProcessModel>> GetListStudentProcess();

        Task<StudentProcessModel> GetStudentProcess(Guid id);

        Task<bool> AddCommentOfStudentForCourse(CourseEvaluationModel model);

        Task<List<CourseEvaluationModel>> GetListCoursEvaluation(Guid idCourse);

        Task<bool> UpdateStatusCommentCourse(Guid id, CourseEvaluationModel model);

        Task<bool> UpdateInformationCommentCourse(Guid id, CourseEvaluationModel model);

        Task<CourseEvaluationModel> GetCommentCourse(Guid id);

        Task<bool> CreateContentCourse(ContentCourseModel model);

        Task<bool> UpdateStatusContentCourse(Guid id, ContentCourseModel model);

        Task<bool> UpdateInformationContentCourse(Guid id, ContentCourseModel model);

        Task<List<ListContentWithDetailCourse>> GetListContentCourse(Guid idCourse);

        Task<ContentCourseModel> GetContentCourse(Guid id);

        Task<bool> CreateContentCourseDetails(ContentCourseDetailModel model);

        Task<bool> UpdateStatusContentCourseDetails(Guid id, ContentCourseDetailModel model);

        Task<bool> UpdateInformationContentCourseDetails(Guid id, ContentCourseDetailModel model);

        Task<List<ContentCourseDetailModel>> GetListContentCourseDetails(Guid idContent);

        Task<ContentCourseDetailModel> GetContentCourseDetails(Guid id, HttpRequest request);

        Task<bool> CreateTheadQuestionCourse(TheadQuestionCourseModel model);

        Task<bool> UpdateStatusTheadQuestionCourse(Guid id, TheadQuestionCourseModel model);

        Task<bool> UpdateInformationTheadQuestionCourse(Guid id, TheadQuestionCourseModel model);

        Task<List<TheadQuestionCourseModel>> GetListTheadQuestionCourse(Guid idCourse);

        Task<TheadQuestionCourseModel> GetTheadQuestionCourse(Guid id);

        Task<List<CourseModel>> GetListCourseForAdmin();

        Task<GetCourseWithDetailsContent> GetDetailCourse(Guid id, bool isAdmin);

        Task<List<CourseModel>> GetListCourseAsCategory(Guid idCategory);

        Task<List<CourseModel>> GetListCourseOfStudent(Guid idStudent);

        Task<bool> LikeForCommentCourse(Guid id);

        Task<bool> DisLikeForCommentCourse(Guid id);

        Task<bool> CreateDetailsTheadQuestionCourse(DetailTheadQuestionCourseModel model);

        Task<bool> UpdateStatusDetailsTheadQuestionCourse(Guid id, DetailTheadQuestionCourseModel model);

        Task<bool> UpdateInformationDetailsTheadQuestionCourse(Guid id, DetailTheadQuestionCourseModel model);

        Task<List<DetailTheadQuestionCourseModel>> GetListDetailsTheadQuestionCourse(Guid idThear);
    }
}